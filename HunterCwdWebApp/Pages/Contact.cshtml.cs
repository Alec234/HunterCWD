using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MimeKit;

namespace HunterCwdWebApp.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public string fullName { get; set; }
        [BindProperty]
        public string email { get; set; }
        [BindProperty]
        public string subject { get; set; }
        [BindProperty]
        public string message { get; set; }
        public void OnGet()
        {
            //do something
            this.fullName = "";
            this.email = "";
            this.subject = "";
            this.message = "";

        }

        public void OnPost()
        {
            //call email service

           /* SmtpClient smtpClient = new("smtp.gmail.com", 587);
            //smtpClient.Host = "localhost";
            //what to do with the fullName... store as a known user? add them to a mailing list?
            //string fullName = this.fullName;
            string sender = this.email;
            string recipient = "symmondsalec@gmail.com";
            string subject = this.subject;
            string message = this.message;

            return smtpClient.SendMailAsync(sender, recipient, subject, message);*/

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(this.fullName, "HuntersCWD@outlook.com"));
            message.To.Add(new MailboxAddress("HunterCWD", "hutnerscwd@gmail.com"));
            message.Subject = this.subject;

            message.Body = new TextPart("plain")
            {
                Text = this.message
            };

            using (var client = new SmtpClient())
            {
                client.Connect("smtp-mail.outlook.com", 587, SecureSocketOptions.StartTls);

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate("HuntersCWD@outlook.com", "Fuck0ff!");

                client.Send(message);
                client.Disconnect(true);
            }

        }
    }
}
