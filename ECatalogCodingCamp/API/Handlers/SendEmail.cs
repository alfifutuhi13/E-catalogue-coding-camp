using API.Context;
using API.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace API.Handlers
{
    public class SendEmail
    {
        private readonly MyContext context;
        public SendEmail(MyContext context)
        {
            this.context = context;
        }

        public void SendForgotPassword(string url, string token, User user)
        {
            var parameter = context.Parameters.Find(1);
            var time24 = DateTime.Now.ToString("HH:mm:ss");

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(parameter.Name, parameter.Value);

            MailMessage message = new MailMessage();
            message.From = new MailAddress(parameter.Name);
            message.To.Add(new MailAddress(user.Email));
            message.Subject = "Reset Password " + time24;
            message.IsBodyHtml = false;
            message.Body = "Hi\nThis is your reset link for your account. \nReset link: "+ url + token ;
            smtp.Send(message);
        }

        public void SendInterviewRequest(string aCandidateEmail, string aClientName, string aCandidateName, string aMessage)
        {
            var parameter = context.Parameters.Find(1);

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(parameter.Name, parameter.Value);

            MailMessage message = new MailMessage();
            message.From = new MailAddress(parameter.Name);
            message.To.Add(new MailAddress(aCandidateEmail));
            message.Subject = "INTERVIEW INVITATIONAL";
            message.IsBodyHtml = true;
            message.Body = CreateInterviewRequestBody(aClientName, aCandidateName, aMessage);
            smtp.Send(message);
        }

        private string CreateInterviewRequestBody(string aClientName, string aCandidateName, string aMessage)
        {
            string body = string.Empty;
            using (StreamReader reader = new StreamReader("Handlers/EmailInterviewRequest.html"))
            {
                body = reader.ReadToEnd();
            }

            body = body.Replace("{CandidateName}", aCandidateName);
            body = body.Replace("{ClientName}", aClientName);
            body = body.Replace("{Message}", aMessage);
            return body;
        }

        public void SendRejected(string aCandidateEmail, string aClientName, string aCandidateName, string aMessage)
        {
            var parameter = context.Parameters.Find(1);

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(parameter.Name, parameter.Value);

            MailMessage message = new MailMessage();
            message.From = new MailAddress(parameter.Name);
            message.To.Add(new MailAddress(aCandidateEmail));
            message.Subject = "THANK YOU FOR YOUR TIME, INTERVIEW REJECTED";
            message.IsBodyHtml = true;
            message.Body = CreateRejectedBody(aClientName, aCandidateName, aMessage);
            smtp.Send(message);
        }

        private string CreateRejectedBody(string aClientName, string aCandidateName, string aMessage)
        {
            string body = string.Empty;
            using (StreamReader reader = new StreamReader("Handlers/EmailRejected.html"))
            {
                body = reader.ReadToEnd();
            }

            body = body.Replace("{CandidateName}", aCandidateName);
            body = body.Replace("{ClientName}", aClientName);
            body = body.Replace("{Message}", aMessage);
            return body;
        }

        public void SendAccepted(string aCandidateEmail, string aClientName, string aCandidateName, string aMessage)
        {
            var parameter = context.Parameters.Find(1);

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(parameter.Name, parameter.Value);

            MailMessage message = new MailMessage();
            message.From = new MailAddress(parameter.Name);
            message.To.Add(new MailAddress(aCandidateEmail));
            message.Subject = "CONGRATULATIONS, YOU GOT A NEW JOB";
            message.IsBodyHtml = true;
            message.Body = CreateAcceptedBody(aClientName, aCandidateName, aMessage);
            smtp.Send(message);
        }

        private string CreateAcceptedBody(string aClientName, string aCandidateName, string aMessage)
        {
            string body = string.Empty;
            using (StreamReader reader = new StreamReader("Handlers/EmailAccepted.html"))
            {
                body = reader.ReadToEnd();
            }

            body = body.Replace("{CandidateName}", aCandidateName);
            body = body.Replace("{ClientName}", aClientName);
            body = body.Replace("{Message}", aMessage);
            return body;
        }
    }
}
