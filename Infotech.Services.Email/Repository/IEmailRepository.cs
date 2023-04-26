using Infotech.Services.Email.Messages;

namespace Infotech.Services.Email.Repository
{
    public interface IEmailRepository
    {
        //Task SendAndLogEmail(UpdatePaymentResultMessage message);
        void SendAndLogEmail(UpdatePaymentResultMessage message);
    }
}
