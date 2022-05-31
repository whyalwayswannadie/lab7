using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
        public class GuestResponse
        {
            [Required(ErrorMessage = "Пожалуйста, введите свое имя")]
            public string Name { get; set; }

            [Required(ErrorMessage = "Пожалуйста, введите email")]
            [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Вы ввели некорректный email")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Пожалуйста, введите телефон")]
            public string Phone { get; set; }

            [Required(ErrorMessage = "Пожалуйста, укажите, примите ли участие в вечеринке")]
            public bool? WillAttend { get; set; }
        }
            public interface IEmailSender
            {
                void SendEmail();
            }
            public class MyEmailSender : IEmailSender
            {
                public void SendEmail() { }
            }

    public class PasswordResetHelper
    {
        private IEmailSender emailSender;
        public PasswordResetHelper(IEmailSender emailSenderParam)
        {
            emailSender = emailSenderParam;
        }

        public void ResetPassword()
        {
            // ...вызов методов интерфейса для конфигурировании настроек электронной почты... 
            emailSender.SendEmail();
        }
    }


}
