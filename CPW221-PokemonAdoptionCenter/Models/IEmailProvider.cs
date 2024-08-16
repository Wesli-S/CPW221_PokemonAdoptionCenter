using SendGrid;
using SendGrid.Helpers.Mail;

namespace CPW221_PokemonAdoptionCenter.Models
{
    public interface IEmailProvider
    {
        Task SendEmailAsync(string toEmail, string fromEmail, string subject, string body, string htmlContent, string page);
    }

    public class EmailProviderSendGrid : IEmailProvider
    {
        private readonly IConfiguration _config;

        public EmailProviderSendGrid(IConfiguration config)
        {
            _config = config;
        }

        public async Task SendEmailAsync(string toEmail, string fromEmail, string subject, string body, string htmlContent, string page)
        {
            var apiKey = _config.GetSection("SENDGRID_KEY").Value;
            var client = new SendGridClient(apiKey);

            string htmlTemplate = string.Empty;
            string emailSubject = string.Empty;

            switch (page)
            {
                case "Views/Poke/TYForSubmitting":
                    htmlTemplate = File.ReadAllText("Views/Poke/IcyTyEmailTemplate.html");
                    emailSubject = "Thank you so much for your application!";
                    break;
                case "Views/Home/VolunteerTY":
                    htmlTemplate = File.ReadAllText("Views/Home/VolunteerTYEmailTemplate.html");
                    emailSubject = "Thank you for volunteering!";
                    break;
                default:
                    throw new ArgumentException("Invalid page specified");
            }

            var msg = new SendGridMessage()
            {
                From = new EmailAddress(fromEmail, "ICY Team"),
                Subject = emailSubject,
                HtmlContent = htmlTemplate
            };
            msg.AddTo(new EmailAddress(toEmail, "Adoption Candidate"));
            await client.SendEmailAsync(msg);
        }
    }
}
