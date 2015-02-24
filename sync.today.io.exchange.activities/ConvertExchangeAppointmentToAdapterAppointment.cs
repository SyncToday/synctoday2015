using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.io.exchange.activities
{
    public sealed class ConvertExchangeAppointmentToAdapterAppointment : CodeActivity
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public InArgument<Models.ExchangeAppointmentDTO> ExchangeAppointment { get; set; }
        public InArgument<int> AdapterId { get; set; }
        public OutArgument<Models.AdapterAppointmentDTO> AdapterAppointment { get; set; }
        protected override void Execute(CodeActivityContext context)
        {
            try
            {
                log.Debug(string.Format("Called on '{0}'and  '{1}'", ExchangeAppointment, AdapterId));
                var myExchangeAppointment = ExchangeAppointment.Get(context);
                var myAdapterId = AdapterId.Get(context);
                log.Debug(string.Format("Got '{0}' and  '{1}'", myExchangeAppointment, myAdapterId));
                var dto = ExchangeRepository.ConvertToDTO(myExchangeAppointment, myAdapterId);
                AdapterAppointment.Set(context, dto);
            }
            catch (Exception ex)
            {
                log.Fatal("failed", ex);
                throw;
            }
        }

    }}
