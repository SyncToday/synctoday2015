using sync.today.activities;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.io.activities
{
    public abstract class BaseConvertIOAppointmentToAdapterAppointment : BaseCodeActivity
    {
        public InArgument<int> AdapterId { get; set; }
        public OutArgument<Models.AdapterAppointmentDTO> AdapterAppointment { get; set; }
    }
}
