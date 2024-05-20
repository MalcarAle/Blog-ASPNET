using MailKit.Net.Smtp;
using MimeKit;

namespace Blog.Sevices
{
    public class EmailService
    {
        private readonly IConfiguration _config;
        public EmailService(IConfiguration config)
        {
            _config = config;
        }
        public async Task<bool> Send(
            string toName,
            string toEmail,
            string subject,
            string body,
            string fromName = "Equipe malcar",
            string fromEmail = "estudos.alexandre.prog@gmail.com")
        {

            var message = new MimeMessage();

            message.From.Add(new MailboxAddress(fromName, fromEmail));
            message.To.Add(new MailboxAddress(toName, toEmail));
            message.Subject = subject;

            var bodyBuilder = new BodyBuilder
            {
                HtmlBody = body
            };

            message.Body = bodyBuilder.ToMessageBody();

            using var smtp = new SmtpClient();
            try
            {
                await smtp.ConnectAsync("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                await smtp.AuthenticateAsync(_config.GetSection("SenderName").Value, _config.GetSection("Password").Value);
                await smtp.SendAsync(message);
                await smtp.DisconnectAsync(true);

                return true;

            }
            catch
            {

                return false;
            }

        }
    }

}
