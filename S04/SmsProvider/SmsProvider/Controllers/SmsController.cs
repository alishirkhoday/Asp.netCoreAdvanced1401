using Microsoft.AspNetCore.Mvc;
using SmsProvider.Costracts;

namespace SmsProvider.Controllers
{
    [Route("/api/v1/Sms/Send")]
    [ApiController]
    public class SmsController : ControllerBase
    {
        private SmsProviderManager _smsProviderManager;

        public SmsController(SmsProviderManager smsProviderManager)
        {
            _smsProviderManager = smsProviderManager;
        }

        [HttpPost]
        public IActionResult Send([FromBody] string sender)
        {
            var smsSender = _smsProviderManager.SmsSender(sender);
            if (smsSender == null)
            {
                return BadRequest();
            }
            smsSender.SendSms("09308336840", "Hello");
            return Ok();
        }
    }
}
