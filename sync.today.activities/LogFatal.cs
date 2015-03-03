using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.activities
{
    public sealed class LogFatal : CodeActivity
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        
        public InArgument<string> Description { get; set; }
        public InArgument<Exception> ExceptionCaught { get; set; }
        protected override void Execute(CodeActivityContext context)
        {
            log.Debug(string.Format("Entered '{0}' and '{1}'", Description, ExceptionCaught));
            var description = Description.Get(context);
            var exception = ExceptionCaught.Get(context);
            log.Debug(string.Format("Got '{0}' and '{1}'", description, exception));
            log.Fatal(description, exception);
        }

    }
}
