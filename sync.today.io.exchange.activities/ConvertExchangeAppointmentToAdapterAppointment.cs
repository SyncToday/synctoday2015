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
        public OutArgument<Models.AdapterAppointmentDTO> AdapterAppointment { get; set; }
        protected override void Execute(CodeActivityContext context)
        {
            try
            {
                log.Debug(string.Format("Called on '{0}'", ExchangeAppointment));
                var myExchangeAppointment = ExchangeAppointment.Get(context);
                log.Debug(string.Format("Got '{0}'", myExchangeAppointment));
                var dto = ExchangeRepository.ConvertToDTO(myExchangeAppointment);
                AdapterAppointment.Set(context, dto);
            }
            catch (Exception ex)
            {
                log.Fatal("failed", ex);
                throw;
            }
        }

    }}
