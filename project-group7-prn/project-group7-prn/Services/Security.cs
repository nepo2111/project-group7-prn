using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace project_group7_prn.Services
{
    public class Security
    {
        //Role system
        //1 is Customer
        public static readonly int ROLE_CUSTOMER = 1;
        //2 is Admin
        public static readonly int ROLE_ADMIN = 2;

        //Default avatar user
        public static readonly string AVATAR_DEFAULT = "~/Individual/User/Images/default-user-icon-13.jpg";


        public void SendMail(string to, string name)
        {
            //string to = "toaddress@gmail.com"; //To address    
            string from = "hieunvhe153769@fpt.edu.vn"; //From address    
            MailMessage message = new MailMessage(from, to);

            string mailbody = $"Dear {name},\nPlease click the link below to verify your email address." +
                $"<a href='#'>VERIFY</a> , regards\nAdministrator.";
            message.Subject = "VERIFY";
            message.Body = mailbody;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential("hieunvhe153769@fpt.edu.vn", "Skynet.com");
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = basicCredential1;
            try
            {
                client.Send(message);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
