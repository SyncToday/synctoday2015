using sync.today.io.activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.io.caldav.activities
{
    public sealed class Upload : BaseUpload
    {
        protected override void RepositoryUpload(sync.today.Models.ServiceAccountDTO myServiceAccount)
        {
            Repository.Upload(myServiceAccount);
        }
    }
}
