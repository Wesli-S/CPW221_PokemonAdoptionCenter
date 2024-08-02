using SendGrid;
using SendGrid.Helpers.Mail;

namespace CPW221_PokemonAdoptionCenter.Models
{
    public interface IEmailProvider
    {
        Task SendEmailAsync(string toEmail, string fromEmail, string subject, string body, string htmlContent);
    }

    public class EmailProviderSendGrid : IEmailProvider
    {
        private readonly IConfiguration _config;

        public EmailProviderSendGrid(IConfiguration config)//Gives us access to the configuration settings
        {
            _config = config;
        }
        public async Task SendEmailAsync(string toEmail, string fromEmail, string subject, string body, string htmlContent)
        {
            var apiKey = _config.GetSection("SENDGRID_KEY").Value;
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress("silvergurlsmart@gmail.com", "ICY Team"),
                Subject = "Wanna subscribe to our newsletter?",
                PlainTextContent = "We know you do~! Sign up to get notified about events at our center!",
                HtmlContent = "<strong> We know you do~! Sign up to get notified about events at our center!\"</strong>"
            };
            msg.AddTo(new EmailAddress(toEmail, "Adoption Candidate"));
            await client.SendEmailAsync(msg);
        }
    }
}
