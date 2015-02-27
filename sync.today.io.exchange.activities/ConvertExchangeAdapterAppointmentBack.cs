using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.io.exchange.activities
{
    public sealed class ConvertExchangeAdapterAppointmentBack : CodeActivity
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public InArgument<Models.AdapterAppointmentDTO> AdapterAppointment { get; set; }
        public InArgument<int> ServiceAccountId { get; set; }
        public InArgument<Models.ExchangeAppointmentDTO> OriginalExchangeAppointment { get; set; }
        public OutArgument<Models.ExchangeAppointmentDTO> ExchangeAppointment { get; set; }
        protected override void Execute(CodeActivityContext context)
        {
            try
            {
                log.Debug(string.Format("Called on '{0}'and  '{1}'", AdapterAppointment, ServiceAccountId));
                var myAdapterAppointment = AdapterAppointment.Get(context);
                var myServiceAccountId = ServiceAccountId.Get(context);
                var myOriginalExchangeAppointment = OriginalExchangeAppointment.Get(context);
                log.Debug(string.Format("Got '{0}' and  '{1}' and '{2}'", myAdapterAppointment, myServiceAccountId, myOriginalExchangeAppointment));
                var exchangeAppointment = ExchangeRepository.ConvertFromDTO(myAdapterAppointment, myServiceAccountId, myOriginalExchangeAppointment);
                ExchangeAppointment.Set(context, exchangeAppointment);
            }
            catch (Exception ex)
            {
                log.Fatal("failed", ex);
                throw;
            }
        }

    }}
