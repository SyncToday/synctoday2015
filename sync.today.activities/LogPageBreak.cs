using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.activities
{
    public sealed class LogPageBreak : CodeActivity
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        
        public InArgument<string> Description { get; set; }
        protected override void Execute(CodeActivityContext context)
        {
            var description = Description.Get(context);
            log.Debug(string.Format("*******************************************************************************************************************'{0}'", description));
        }

    }
}
