using AndersonNotificationData;
using AndersonNotificationEntity;
using AndersonNotificationModel;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Net.Mail;
using System.Net;
using System.Configuration;

namespace AndersonNotificationFunction
{
    public class FEmailNotification : IFEmailNotification
    {
        private IDEmailNotification _iDEmailNotification;

        public FEmailNotification(IDEmailNotification iDEmailNotifications) 
        {
            _iDEmailNotification = iDEmailNotifications;
        }

        public FEmailNotification()
        {
            _iDEmailNotification = new DEmailNotification();

        }

        #region Create
        public EmailNotification Create(int createdBy, EmailNotification emailNotification)
        {   
            var eEmailNotification = EEmailNotification(emailNotification);
            eEmailNotification.CreatedDate = DateTime.Now;
            eEmailNotification.CreatedBy = createdBy;
            eEmailNotification = _iDEmailNotification.Insert(eEmailNotification);
           
            return EmailNotification(eEmailNotification);
        }
        #endregion
        

        #region Read
        public EmailNotification Read(int emailNotificationId)
        {
            var eEmailNotification = _iDEmailNotification.Read<EEmalNotification>(a => a.EmailNotificationId == emailNotificationId);
            return EmailNotification(eEmailNotification);
        }

        public List<EmailNotification> Read(string sortBy)
        {
            var eEmailNotifications = _iDEmailNotification.Read<EEmalNotification>(a => true, sortBy);
            return EmailNotifications(eEmailNotifications);
        }
        #endregion

        #region Update
        public EmailNotification Update(int updatedBy, EmailNotification emailNotification)
        {
            var eEmailNotification = EEmailNotification(emailNotification);
            eEmailNotification.UpdatedDate = DateTime.Now;
            eEmailNotification.UpdatedBy = updatedBy;
            eEmailNotification = _iDEmailNotification.Update(eEmailNotification);
            return EmailNotification(eEmailNotification);
        }
        #endregion

        #region Delete
        public void Delete(int emailNotificationId)
        {
            _iDEmailNotification.Delete<EEmalNotification>(a => a.EmailNotificationId == emailNotificationId);
        }
        #endregion

        #region Other Function
        public EmailNotification Send(int createdBy, EmailNotification emailNotification)
        {
            EmailNotification emailNotificationWithDefaultValues = SetDefaultValues(emailNotification);
            MailMessage email = new MailMessage();
            email.IsBodyHtml = emailNotificationWithDefaultValues.IsBodyHtml.Value;
            email.Body = emailNotificationWithDefaultValues.Body;
            if (!string.IsNullOrEmpty(emailNotificationWithDefaultValues.Bcc))
                email.Bcc.Add(emailNotificationWithDefaultValues.Bcc);
            if (!string.IsNullOrEmpty(emailNotificationWithDefaultValues.CC))
                email.CC.Add(emailNotificationWithDefaultValues.CC);
            email.From = new MailAddress(emailNotificationWithDefaultValues.From);
            email.Subject = emailNotificationWithDefaultValues.Subject;
            email.To.Add(emailNotificationWithDefaultValues.To);

            SmtpClient smtp = new SmtpClient();
            smtp.Host = emailNotificationWithDefaultValues.Host;
            smtp.Credentials = new NetworkCredential(emailNotificationWithDefaultValues.Username, emailNotificationWithDefaultValues.Password);
            smtp.EnableSsl = emailNotificationWithDefaultValues.EnableSsl.Value;
            smtp.Port = emailNotificationWithDefaultValues.Port.Value;
            smtp.Send(email);

            var recordedEmailNotification = Create(createdBy, emailNotificationWithDefaultValues);
            //prevent the code on returning the default values
            emailNotification.CreatedDate = recordedEmailNotification.CreatedDate;
            emailNotification.UpdatedDate = recordedEmailNotification.UpdatedDate;
            emailNotification.CreatedBy = recordedEmailNotification.CreatedBy;
            emailNotification.EmailNotificationId = recordedEmailNotification.EmailNotificationId;
            emailNotification.UpdatedBy = recordedEmailNotification.UpdatedBy;
            return emailNotification;
        }

        private EmailNotification SetDefaultValues(EmailNotification emailNotification)
        {
            return new EmailNotification
            {
                EnableSsl = (emailNotification.EnableSsl ?? Convert.ToBoolean(ConfigurationManager.AppSettings["EmailNotificationEnableSsl"])),
                IsBodyHtml = emailNotification.IsBodyHtml ?? Convert.ToBoolean(ConfigurationManager.AppSettings["EmailNotificationIsBodyHtml"]),

                CreatedDate = emailNotification.CreatedDate,
                UpdatedDate = emailNotification.UpdatedDate,

                CreatedBy = emailNotification.CreatedBy,
                EmailNotificationId = emailNotification.EmailNotificationId,
                Port = emailNotification.Port ?? Convert.ToInt32(ConfigurationManager.AppSettings["EmailNotificationPort"]),
                UpdatedBy = emailNotification.UpdatedBy,

                Body = emailNotification.Body,
                Bcc = (!string.IsNullOrEmpty(emailNotification.Bcc)) ? emailNotification.Bcc : ConfigurationManager.AppSettings["EmailNotificationBcc"],
                CC = (!string.IsNullOrEmpty(emailNotification.CC)) ? emailNotification.CC : ConfigurationManager.AppSettings["EmailNotificationCC"],
                Host = (!string.IsNullOrEmpty(emailNotification.Host)) ? emailNotification.Host : ConfigurationManager.AppSettings["EmailNotificationHost"],
                From = (!string.IsNullOrEmpty(emailNotification.From)) ? emailNotification.From : ConfigurationManager.AppSettings["EmailNotificationFrom"],
                Password = (!string.IsNullOrEmpty(emailNotification.Password)) ? emailNotification.Password : ConfigurationManager.AppSettings["EmailNotificationPassword"],
                Subject = (!string.IsNullOrEmpty(emailNotification.Subject)) ? emailNotification.Subject : ConfigurationManager.AppSettings["EmailNotificationSubject"],
                To = (!string.IsNullOrEmpty(emailNotification.To)) ? emailNotification.To : ConfigurationManager.AppSettings["EmailNotificationTo"],
                Username = (!string.IsNullOrEmpty(emailNotification.Username)) ? emailNotification.Username : ConfigurationManager.AppSettings["EmailNotificationUsername"],
            };
        }

        private EEmalNotification EEmailNotification(EmailNotification emailNotification)
        {
            return new EEmalNotification
            {
                EnableSsl = emailNotification.EnableSsl.Value,
                IsBodyHtml = emailNotification.IsBodyHtml.Value,

                CreatedDate = emailNotification.CreatedDate,
                UpdatedDate = emailNotification.UpdatedDate,

                CreatedBy = emailNotification.CreatedBy,
                EmailNotificationId = emailNotification.EmailNotificationId,
                Port = emailNotification.Port.Value,
                UpdatedBy = emailNotification.UpdatedBy,

                Body = emailNotification.Body,
                Bcc = emailNotification.Bcc,
                CC = emailNotification.CC,
                Host = emailNotification.Host,
                From = emailNotification.From,
                Subject = emailNotification.Subject,
                To = emailNotification.To,
                Username = emailNotification.Username,
            };
        }

        private EmailNotification EmailNotification(EEmalNotification eEmailNotification)
        {
            return new EmailNotification
            {
                EnableSsl = eEmailNotification.EnableSsl,
                IsBodyHtml = eEmailNotification.IsBodyHtml,

                CreatedDate = eEmailNotification.CreatedDate,
                UpdatedDate = eEmailNotification.UpdatedDate,

                CreatedBy = eEmailNotification.CreatedBy,
                EmailNotificationId = eEmailNotification.EmailNotificationId,
                Port = eEmailNotification.Port,
                UpdatedBy = eEmailNotification.UpdatedBy,

                Body = eEmailNotification.Body,
                Bcc = eEmailNotification.Bcc,
                CC = eEmailNotification.CC,
                Host = eEmailNotification.Host,
                From = eEmailNotification.From,
                Subject = eEmailNotification.Subject,
                To = eEmailNotification.To,
                Username = eEmailNotification.Username,
            };
        }
        private List<EmailNotification> EmailNotifications(List<EEmalNotification> eEmailNotifications)
        {
            return eEmailNotifications.Select(a => new EmailNotification
            {
                EnableSsl = a.EnableSsl,
                IsBodyHtml = a.IsBodyHtml,

                CreatedDate = a.CreatedDate,
                UpdatedDate = a.UpdatedDate,

                CreatedBy = a.CreatedBy,
                EmailNotificationId = a.EmailNotificationId,
                Port = a.Port,
                UpdatedBy = a.UpdatedBy,

                Body = a.Body,
                Bcc = a.Bcc,
                CC = a.CC,
                Host = a.Host,
                From = a.From,
                Subject = a.Subject,
                To = a.To,
                Username = a.Username,
            }).ToList();
        }
        #endregion

    }
}