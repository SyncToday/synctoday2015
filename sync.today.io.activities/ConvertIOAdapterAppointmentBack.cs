using sync.today.activities;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.io.activities
{
    public abstract class BaseConvertIOAdapterAppointmentBack : BaseCodeActivity
    {
        public InArgument<Models.AdapterAppointmentDTO> AdapterAppointment { get; set; }
        public InArgument<int> ServiceAccountId { get; set; }

    }
}
