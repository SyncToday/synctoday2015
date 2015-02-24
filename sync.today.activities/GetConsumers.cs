using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.activities
{
    public sealed class GetConsumers : CodeActivity
    {
        public OutArgument<Models.ConsumerDTO[]> result { get; set; }
        protected override void Execute(CodeActivityContext context)
        {
            var journalItems = JournalRepository.Journals();
            List<Models.JournalDTO> resultItems = new List<Models.JournalDTO>(journalItems);
            result.Set(context, resultItems);
        }
    }
}
