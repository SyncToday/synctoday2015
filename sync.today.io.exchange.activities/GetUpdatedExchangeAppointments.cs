using sync.today.activities;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.io.exchange.activities
{
    public sealed class GetUpdatedExchangeAppointments : BaseCodeActivity
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public OutArgument<Models.ExchangeAppointmentDTO[]> UpdatedAppointments { get; set; }
        protected override void DoExecute(CodeActivityContext context)
        {
            devlog.Debug("Entered");
            var result = ExchangeRepository.Updated();
            var updatedApps = new List<Models.ExchangeAppointmentDTO>(result).ToArray();
            devlog.DebugFormat("updatedApps.Length:'{0}'", updatedApps.Length);
            UpdatedAppointments.Set(context, updatedApps);
        }

    }
}
