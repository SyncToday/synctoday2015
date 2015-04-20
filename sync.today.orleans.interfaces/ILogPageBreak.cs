using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.orleans.interfaces
{
    public interface ILogPageBreak : Orleans.IGrainWithIntegerKey
    {
        void Log();
    }
}
