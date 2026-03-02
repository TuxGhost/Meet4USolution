using Microsoft.AspNetCore.Identity.UI.Services;
using Org.BouncyCastle.Tls;
using System.Net;
using System.Net.Mail;
using System.Net.Security;

namespace DIT.MVC.Services;

public class EmailSenderService : IEmailSender
{
    private readonly IConfiguration _config;
    private SmtpClient _smtpClient = null!;
    private readonly ILogger<EmailSenderService> _logger;
    public EmailSenderService(IConfiguration configuration, ILogger<EmailSenderService> logger)
    {
        _config = configuration;
        _logger = logger;
        _logger.LogInformation("e-mail constructor");
    }
    public void SendEmail(string email, string subject, string htmlMessage)
    {
        if (_config == null)
        {
            _logger.LogError("No configuration available");
            return;
        }
        if (_smtpClient == null)
        {
            int port = int.Parse(_config.GetValue<string>("smtp:port"));
            string host = _config.GetValue<string>("smtp:host");
            string user = _config.GetValue<string>("smtp:user");
            string password = _config.GetValue<string>("smtp:Password");
            string enableSsl = _config.GetValue<string>("smtp:ssl", "true");
            _smtpClient = new SmtpClient
            {
                UseDefaultCredentials = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                EnableSsl = enableSsl.CompareTo("false") == 0 ? false : true,
                Host = host,
                Port = port,
                Credentials = new NetworkCredential(user, password)
            };
        }
        if (_smtpClient != null)
        {
            MailMessage mailMessage = new MailMessage("test", "peter_kuda@hotmail.com")
            {
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true
            };
        }
    }
    public Task SendEmailAsync(string email, string subject, string htmlMessage)
    {
        //throw new Exception("Forced error");
        if (_config == null)
        {
            _logger.LogError("No configuration available");
            return Task.FromException(new Exception("No configuration available"));
        }
        if (_smtpClient == null)
        {
            ServicePointManager.ServerCertificateValidationCallback = (sender, Certificate, chain, SslPolicyErrors) => true;

            int port = int.Parse(_config.GetValue<string>("smtp:port"));
            string host = _config.GetValue<string>("smtp:host");
            string user = _config.GetValue<string>("smtp:user");
            string password = _config.GetValue<string>("smtp:Password");
            string enableSsl = _config.GetValue<string>("smtp:ssl", "true");

            if (user != null && password != null)
            {
                _smtpClient = new SmtpClient
                {
                    UseDefaultCredentials = false,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    EnableSsl = enableSsl.CompareTo("false") == 0 ? false : true,
                    Host = host,
                    Port = port,
                    Credentials = new NetworkCredential(user, password)
                };
            }
            else
            {
                _smtpClient = new SmtpClient
                {
                    UseDefaultCredentials = false,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    EnableSsl = false,
                    Host = host,
                    Port = port,
                   
                };
            }
            _logger.LogInformation($"Host={host} Port={port} SSL={enableSsl}");
        }        
        if (_smtpClient != null) {
            //MailMessage mailMessage = new MailMessage("noreply@peterkuda.be", email)
            MailMessage mailMessage = new MailMessage("noreply@localhost", email)
            {
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true
            };
            try
            {
                
                _smtpClient.Send(mailMessage);
                _logger.LogInformation("Email was sent");
            }
            catch(SmtpException ex)
            {
                _logger.LogError(ex, "SMTP Exception :" + ex.Message);
                return Task.FromException(ex);
            }
            catch (IOException ex)
            {
                _logger.LogError(ex, "IO Exception : " + ex.Message);
                return Task.FromException(ex);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "General exception: " + ex.Message);
                return Task.FromException(ex);
            }            
            _logger.LogInformation("Email was sent");
        }
        return Task.CompletedTask;
    }
}
