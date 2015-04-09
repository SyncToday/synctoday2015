using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.activities.Appointments
{
    public sealed class GetAppointmentsModifiedThroughAdapter : BaseCodeActivity
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public InArgument<DateTime> LastModification { get; set; }
        public InArgument<Models.ConsumerDTO> Consumer { get; set; }
        public OutArgument<Models.AppointmentDTO[]> Result { get; set; }
        protected override void DoExecute(CodeActivityContext context)
        {
            devlog.Debug(string.Format("Entered for '{0}' and '{1}' and '{2}'", Consumer, Result, LastModification));
            var myConsumer = Consumer.Get(context);
            var lastModification = LastModification.Get(context);
            devlog.Debug(string.Format("Got '{0}' and '{1}'", myConsumer, lastModification));
            var modifiedItems = AppointmentRepository.ModifiedThroughAdapter(myConsumer, lastModification);
            List<Models.AppointmentDTO> resultItems = new List<Models.AppointmentDTO>(modifiedItems);
            devlog.DebugFormat("resultItems:'{0}'", resultItems.Count);
            Result.Set(context, resultItems.ToArray());
        }

    }
}
