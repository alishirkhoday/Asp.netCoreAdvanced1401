using SmsProvider.SmsServices;

namespace SmsProvider.Costracts
{
    public class SmsProviderManager
    {
        public ISmsSender SmsSender(string smsProvider)
        {
            switch (smsProvider.ToLower())
            {
                case "kavenegar":
                    return new KavenegarSmsService();
                case "mohsennegar":
                    return new MohsenNegarSmsService();
            }
            return null;
        }
    }
}
