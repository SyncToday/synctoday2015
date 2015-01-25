using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Activities;

namespace ActivityLibrary1
{
    public sealed class LastSync : CodeActivity
    {
        public OutArgument<DateTime> result { get; set; }
        protected override void Execute(CodeActivityContext context)
        {
            result.Set(context, DateTime.Now.AddHours(-1.0));
        }

    }
}
