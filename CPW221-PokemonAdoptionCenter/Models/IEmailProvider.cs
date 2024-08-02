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
                Subject = "Thank you so much for your application!",
                PlainTextContent = "We're thrilled that you want to give one of our Pokémon a new home in you!" +
                    "Once we've completed going through your application, we'll be sure to contact you again to let you know if you qualify!" +
                    "Hope we get to see you real soon!",
                HtmlContent = "<strong>-Yumi Smart (ICY Team)</strong>"
            };
            msg.AddTo(new EmailAddress(toEmail, "Adoption Candidate"));
            await client.SendEmailAsync(msg);
        }
    }
}
