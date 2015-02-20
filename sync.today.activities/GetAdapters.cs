using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.activities
{
    public sealed class GetAdapters : CodeActivity
    {
        public OutArgument<List<Models.AdapterDTO>> result { get; set; }
        protected override void Execute(CodeActivityContext context)
        {
            var journalItems = AdapterRepository.Adapters();
            List<Models.AdapterDTO> resultItems = new List<Models.AdapterDTO>(journalItems);
            result.Set(context, resultItems);
        }

    }
}
