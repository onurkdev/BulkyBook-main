using System;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace BulkyBook.Utility
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            //We generated this class to bypass DP at app constructor since we dont need email verification for this kinda project
            return Task.CompletedTask;
        }
    }


}

