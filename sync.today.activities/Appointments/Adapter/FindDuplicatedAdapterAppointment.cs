using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.activities.Appointments.Adapter
{
    public sealed class FindDuplicatedAdapterAppointment : CodeActivity
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public InArgument<Models.AdapterAppointmentDTO> SourceAdapterAppointment { get; set; }
        public InArgument<Models.AdapterAppointmentDTO> DuplicatedAdapterAppointment { get; set; }
        public OutArgument<bool> result { get; set; }
        protected override void Execute(CodeActivityContext context)
        {
            log.Debug(string.Format("Entered for '{0}' and '{1}'", SourceAdapterAppointment, DuplicatedAdapterAppointment));
            try
            {
                var sourceAdapterAppointment = SourceAdapterAppointment.Get(context);
                log.Debug(string.Format("would call for '{0}'", sourceAdapterAppointment));
                try
                {
                    var duplicatedAdapterAppointment = AdapterAppointmentRepository.FindDuplicatedAdapterAppointment(sourceAdapterAppointment).Value;
                    DuplicatedAdapterAppointment.Set(context, duplicatedAdapterAppointment);
                }
                catch (NullReferenceException)
                {
                    DuplicatedAdapterAppointment.Set(context, null);
                }
            }
            catch (Exception ex)
            {
                log.Fatal("failed", ex);
                throw;
            }
        }

    }}
