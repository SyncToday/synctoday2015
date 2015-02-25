using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.io.exchange.activities
{
    public sealed class Download : CodeActivity
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public InArgument<Models.ServiceAccountDTO> ServiceAccount { get; set; }
        protected override void Execute(CodeActivityContext context)
        {
            try
            {
                log.Debug(string.Format("Entered for '{0}'", ServiceAccount));
                var myServiceAccount = ServiceAccount.Get(context);
                log.Debug(string.Format("Got for '{0}'", myServiceAccount));
                ExchangeRepository.Download(myServiceAccount);
            }
            catch (Exception ex)
            {
                log.Fatal("failed", ex);
                throw;
            }
        }

    }
}
