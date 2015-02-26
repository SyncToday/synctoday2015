using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.activities.ServiceAccounts
{
    public sealed class GetServiceAccounts : CodeActivity
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public OutArgument<Models.ServiceAccountDTO[]> result { get; set; }
        protected override void Execute(CodeActivityContext context)
        {
            log.Debug("Entered");
            try
            {
                var serviceAccounts = ServiceAccountRepository.ServiceAccounts();
                List<Models.ServiceAccountDTO> resultItems = new List<Models.ServiceAccountDTO>(serviceAccounts);
                result.Set(context, resultItems.ToArray());
            }
            catch (Exception ex)
            {
                log.Fatal("failed", ex);
                throw;
            }
        }

    }
}
