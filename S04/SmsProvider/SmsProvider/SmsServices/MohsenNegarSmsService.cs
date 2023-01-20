using SmsProvider.Costracts;

namespace SmsProvider.SmsServices
{
    public class MohsenNegarSmsService : ISmsSender
    {
        public void SendSms(string receptor, string message)
        {
            Console.WriteLine("MohsenNegar");
        }
    }
}
