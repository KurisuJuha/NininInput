using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace JuhaKurisu.PopoTools.Ninin
{
    public interface ISendTransport
    {
        public Task<bool> Connect();
        public Task<bool> Join();
        public Task<bool> SendInput(INininInput client);
        public Task<bool> FetchInputs(out ReadOnlyCollection<INininInput> inputs);
    }
}