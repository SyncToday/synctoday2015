using sync.today.activities;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.io.exchange.activities
{
    public sealed class ConvertExchangeAppointmentToAdapterAppointment : BaseCodeActivity
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public InArgument<Models.ExchangeAppointmentDTO> ExchangeAppointment { get; set; }
        public InArgument<int> AdapterId { get; set; }
        public OutArgument<Models.AdapterAppointmentDTO> AdapterAppointment { get; set; }
        protected override void DoExecute(CodeActivityContext context)
        {
            devlog.Debug(string.Format("Called on '{0}'and  '{1}'", ExchangeAppointment, AdapterId));
            var myExchangeAppointment = ExchangeAppointment.Get(context);
            var myAdapterId = AdapterId.Get(context);
            devlog.Debug(string.Format("Got '{0}' and  '{1}'", myExchangeAppointment, myAdapterId));
            var dto = ExchangeRepository.ConvertToDTO(myExchangeAppointment, myAdapterId);
            AdapterAppointment.Set(context, dto);
        }

    }
}
