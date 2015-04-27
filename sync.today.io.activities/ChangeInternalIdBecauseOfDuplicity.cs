using sync.today.activities;
using sync.today.Models;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.io.activities
{
    public abstract class BaseChangeInternalIdBecauseOfDuplicity : BaseCodeActivity
    {
        public InArgument<AdapterAppointmentDTO> FoundDuplicity { get; set; }
    }
}
