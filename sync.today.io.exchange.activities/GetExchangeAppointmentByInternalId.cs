using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.io.exchange.activities
{
    public sealed class GetExchangeAppointmentByInternalId : CodeActivity
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public InArgument<Guid> InternalId { get; set; }
        public OutArgument<Models.ExchangeAppointmentDTO> ExchangeAppointment { get; set; }
        protected override void Execute(CodeActivityContext context)
        {
            try
            {
                var internalId = InternalId.Get(context);
                log.DebugFormat("Entered for '{0}'", internalId);
                var found = ExchangeRepository.ExchangeAppointmentByInternalId(internalId);                
                try
                {
                    ExchangeAppointment.Set(context, found.Value);
                    log.DebugFormat("found '{0}'", found.Value);
                }
                catch (NullReferenceException)
                {
                    ExchangeAppointment.Set(context, null);
                    log.DebugFormat("found nothing");
                }
            }
            catch (Exception ex)
            {
                log.Fatal("failed", ex);
                throw;
            }
        }

    }
}
