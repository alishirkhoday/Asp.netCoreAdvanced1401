namespace SmsProvider.Costracts
{
    public interface ISmsSender
    {
        void SendSms(string receptor, string message);
    }
}
