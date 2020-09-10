using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MailKit;
using BusinessLayer.BussinessLogic;


namespace BusinessLayer.Interface
{
    public interface IEmailSender
    {
        void SendEmail(Message message);
        Task SendEmailAsync(Message message);
    }
}
