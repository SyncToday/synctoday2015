using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.activities.Appointments.Adapter
{
    public sealed class CopyAdapterAppointmentToAppointment : CodeActivity
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public InArgument<Models.AdapterAppointmentDTO> adapterAppointment { get; set; }
        public OutArgument<Models.AppointmentDTO> appointment { get; set; }
        protected override void Execute(CodeActivityContext context)
        {
            log.Debug(string.Format("Entered for '{0}' and '{1}'", appointment, adapterAppointment));
            try
            {
                var myAppointment = appointment.Get(context);
                var myAdapterAppointment = adapterAppointment.Get(context);
                log.Debug(string.Format("would call for '{0}' and '{1}'", myAppointment, myAdapterAppointment));

                myAppointment.Category = myAdapterAppointment.Category;
                myAppointment.Content = myAdapterAppointment.Content;
                myAppointment.DateFrom = myAdapterAppointment.DateFrom ;
                myAppointment.DateTo = myAdapterAppointment.DateTo;
                myAppointment.IsPrivate = myAdapterAppointment.IsPrivate;
                myAppointment.Location = myAdapterAppointment.Location;
                myAdapterAppointment.Notification = myAdapterAppointment.Notification;
                myAdapterAppointment.Priority = myAdapterAppointment.Priority;
                myAdapterAppointment.Reminder = myAdapterAppointment.Reminder;
                myAdapterAppointment.Title = myAdapterAppointment.Title;
            }
            catch (Exception ex)
            {
                log.Fatal("failed", ex);
                throw;
            }
        }

    }
}
