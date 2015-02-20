using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.activities.Appointments.Adapter
{
    public sealed class SaveAppointmentAndAdapterAppointments : CodeActivity
      {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public InArgument<Models.AppointmentDTO> appointment { get; set; }
        public InArgument<Models.AdapterAppointmentDTO[]> adapterAppointments { get; set; }
        protected override void Execute(CodeActivityContext context)
        {
            log.Debug(string.Format("Entered for '{0}'", appointment));
            try
            {
                var myAppointment = appointment.Get<Models.AppointmentDTO>(context);
                log.Debug(string.Format("would call for '{0}'", myAppointment));
                var myAdapterAppointments = adapterAppointments.Get(context);
                foreach (var adapterAppointment in myAdapterAppointments)
                {
                    adapterAppointment.Category = myAppointment.Category;
                    adapterAppointment.Content = myAppointment.Content;
                    adapterAppointment.DateFrom = myAppointment.DateFrom;
                    adapterAppointment.DateTo = myAppointment.DateTo;
                    adapterAppointment.IsPrivate = myAppointment.IsPrivate;
                    adapterAppointment.Location = myAppointment.Location;
                    adapterAppointment.Notification = myAppointment.Notification;
                    adapterAppointment.Priority = myAppointment.Priority;
                    adapterAppointment.Reminder = myAppointment.Reminder;
                    adapterAppointment.Title = adapterAppointment.Title;

                    AdapterAppointmentRepository.InsertOrUpdate(adapterAppointment);
                }
                AppointmentRepository.InsertOrUpdate(myAppointment);
            }
            catch (Exception ex)
            {
                log.Fatal("failed", ex);
                throw;
            }
        }

    }}
