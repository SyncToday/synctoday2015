using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.io.exchange.activities
{
    public sealed class GetNewExchangeAppointments : CodeActivity
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public InArgument<Models.ExchangeAppointmentDTO[]> AlsoIncludedAppointments { get; set; }
        public OutArgument<Models.ExchangeAppointmentDTO[]> NewAppointments { get; set; }
        protected override void Execute(CodeActivityContext context)
        {
            try
            {
                var alsoIncluded = AlsoIncludedAppointments.Get(context);
                log.DebugFormat("alsoIncluded.Length:'{0}'", alsoIncluded.Length);
                var newAppsList = new List<Models.ExchangeAppointmentDTO>(ExchangeRepository.New());
                log.DebugFormat("newAppsList.Count:'{0}'", newAppsList.Count);
                newAppsList.AddRange(alsoIncluded);
                var newApps = newAppsList.ToArray();
                log.DebugFormat("newApps.Length:'{0}'", newApps.Length);
                NewAppointments.Set(context, newApps);
            }
            catch (Exception ex)
            {
                log.Fatal("failed", ex);
                throw;
            }
        }

    }
}
