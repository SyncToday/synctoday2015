using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.activities.Appointments
{
    public sealed class GetLatestModificationAsWinner : CodeActivity
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public InArgument<Models.AdapterAppointmentDTO[]> adapterAppointments { get; set; }
        public OutArgument<Models.AdapterAppointmentDTO> winner { get; set; }
        protected override void Execute(CodeActivityContext context)
        {
            log.Debug(string.Format("Entered for '{0}'", adapterAppointments));
            try
            {
                var myAdapterAppointments = adapterAppointments.Get(context);
                Models.AdapterAppointmentDTO possibleWinner = null;
                DateTime lastModified = DateTime.MinValue;
                foreach (var adapterAppointment in myAdapterAppointments)
                {
                    if (adapterAppointment.LastModified > lastModified)
                    {
                        lastModified = adapterAppointment.LastModified;
                        possibleWinner = adapterAppointment;
                    }
                }
                winner.Set(context, possibleWinner);
            }
            catch (Exception ex)
            {
                log.Fatal("failed", ex);
                throw;
            }
        }

    }}
