using SmsProvider.Costracts;

namespace SmsProvider.SmsServices
{
    public class KavenegarSmsService : ISmsSender
    {
        public void SendSms(string receptor, string message)
        {
            Console.WriteLine("Kavenegar");
        }
    }
}
