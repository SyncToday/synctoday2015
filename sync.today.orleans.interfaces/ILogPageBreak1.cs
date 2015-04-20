using Orleans;
using System.Threading.Tasks;

namespace sync.today.orleans.interfaces
{
    public interface ILogPageBreak : Orleans.IGrainWithIntegerKey
    {
        Task Log();
    }
}
