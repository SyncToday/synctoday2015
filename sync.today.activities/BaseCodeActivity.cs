using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.activities
{
    public abstract class BaseCodeActivity : CodeActivity
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        protected log4net.ILog devlog = log4net.LogManager.GetLogger("DevLog");
        protected abstract void DoExecute(CodeActivityContext context);
        protected override void Execute(CodeActivityContext context)
        {
            try
            {
                devlog.Debug(String.Format("'{0}' Entered", GetType()));
                DoExecute(context);
                devlog.Debug(String.Format("'{0}' Successfully Done", GetType()));
            }
            catch (Exception ex)
            {
                log.Fatal(String.Format("'{0}' failed", GetType()), ex);
                throw;
            }
        }
   }
}
