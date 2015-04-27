using sync.today.activities;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.io.activities
{
    public abstract class BaseUpload : BaseCodeActivity
    {
        public InArgument<Models.ServiceAccountDTO> ServiceAccount { get; set; }
        public InArgument<bool> Ignore { get; set; }

        protected abstract void RepositoryUpload( Models.ServiceAccountDTO myServiceAccount);

        protected override void DoExecute(CodeActivityContext context)
        {
            devlog.Debug(string.Format("Entered for '{0}' and '{1}'", ServiceAccount, Ignore));
            var myServiceAccount = ServiceAccount.Get(context);
            var myIgnore = Ignore.Get(context);
            devlog.Debug(string.Format("Got for '{0}' and '{1}'", myServiceAccount, myIgnore));
            if (!myIgnore)
                RepositoryUpload(myServiceAccount);
        }

    }
}
