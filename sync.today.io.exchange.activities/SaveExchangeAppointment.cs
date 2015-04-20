using sync.today.activities;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.io.exchange.activities
{
    public sealed class SaveExchangeAppointment : BaseCodeActivity
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public InArgument<Models.ExchangeAppointmentDTO> ExchangeAppointment { get; set; }
        protected override void DoExecute(CodeActivityContext context)
        {
            devlog.Debug(string.Format("Called on '{0}'", ExchangeAppointment));
            var myExchangeAppointment = ExchangeAppointment.Get(context);
            devlog.Debug(string.Format("myExchangeAppointment:'{0}'", myExchangeAppointment));
            ExchangeRepository.insertOrUpdate(myExchangeAppointment);
        }

    }
}

