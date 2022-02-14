namespace SupposedlySecureApplication.Services
{
    public class Secrets
    {
        public string SmtpEmail { get; set; }
        public string SmtpPassword { get; set; }
        public string RecaptchaSiteKey { get; set; }
        public string RecaptchaSecretKey { get; set; }
    }
}