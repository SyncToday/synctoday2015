using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Activities;

namespace ActivityLibrary1
{
    // http://www.codeproject.com/Tips/640802/Create-SendEmail-Workflow-Custom-Activity
    public sealed class SendEmailActivity : CodeActivity
    {
        public InArgument<string> from { get; set; }
        public InArgument<string> host { get; set; }
        public InArgument<string> userName { get; set; }
        public InArgument<string> password { get; set; }
        public InArgument<string> to { get; set; }
        public InArgument<string> subject { get; set; }
        public InArgument<string> body { get; set; }
        public OutArgument<string> result { get; set; }
        protected override void Execute(CodeActivityContext context)
        {
            var mailMessage = new System.Net.Mail.MailMessage();
            mailMessage.To.Add(to.Get(context).ToString());
            mailMessage.Subject = subject.Get(context).ToString();
            mailMessage.Body = body.Get(context);
            mailMessage.From =
            new System.Net.Mail.MailAddress(from.Get(context));
            var smtp = new System.Net.Mail.SmtpClient();
            smtp.Host = host.Get(context);
            smtp.Credentials =
            new System.Net.NetworkCredential(
            userName.Get(context), password.Get(context));
            smtp.EnableSsl = true;
            smtp.Send(mailMessage);
            result.Set(context, "Sent Email Successfully!");
        }
    }
}
