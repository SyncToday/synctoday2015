using sync.today.io.activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.io.caldav.activities
{
    public sealed class Download : BaseDownload
    {
        protected override void DoExecute(System.Activities.CodeActivityContext context)
        {
            devlog.Debug(string.Format("Entered for '{0}'", ServiceAccount));
            var myServiceAccount = ServiceAccount.Get(context);
            devlog.Debug(string.Format("Got for '{0}'", myServiceAccount));
            Repository.Download(myServiceAccount);
        }
    }
}
