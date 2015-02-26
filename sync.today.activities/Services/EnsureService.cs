using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.activities.Services
{
    public sealed class EnsureService : CodeActivity
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public InArgument<string> Key { get; set; }
        public InArgument<string> Name { get; set; }
        public OutArgument<Models.ServiceDTO> Service { get; set; }
        protected override void Execute(CodeActivityContext context)
        {
            log.Debug("Entered");
            try
            {
                var key = Key.Get(context);
                var name = Name.Get(context);
                log.Debug(string.Format("Got '{0}' and '{1}'", key, name));
                var service = ServiceRepository.EnsureService(key, name);
                Service.Set(context, service);
            }
            catch (Exception ex)
            {
                log.Fatal("failed", ex);
                throw;
            }
        }

    }

}
