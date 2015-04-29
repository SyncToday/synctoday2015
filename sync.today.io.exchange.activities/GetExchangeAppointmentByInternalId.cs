using sync.today.activities;
using sync.today.io.activities;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.io.exchange.activities
{
    public sealed class GetExchangeAppointmentByInternalId : BaseGetIOAppointmentByInternalId
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public OutArgument<Models.ExchangeAppointmentDTO> ExchangeAppointment { get; set; }
        protected override void DoExecute(CodeActivityContext context)
        {
            var internalId = InternalId.Get(context);
            devlog.DebugFormat("Entered for '{0}'", internalId);
            var found = ExchangeRepository.ExchangeAppointmentByInternalId(internalId);
            try
            {
                ExchangeAppointment.Set(context, found.Value);
                devlog.DebugFormat("found '{0}'", found.Value);
            }
            catch (NullReferenceException)
            {
                ExchangeAppointment.Set(context, null);
                devlog.DebugFormat("found nothing");
            }
        }

    }
}
