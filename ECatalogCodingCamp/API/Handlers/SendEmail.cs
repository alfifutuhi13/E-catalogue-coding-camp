using API.Context;
using API.Models;
using System;
using System.Collections.Generic;
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
    }
}
