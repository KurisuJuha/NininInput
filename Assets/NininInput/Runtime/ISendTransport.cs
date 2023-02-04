using System;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace JuhaKurisu.PopoTools.Ninin
{
    public interface ISendTransport
    {
        public Task<bool> Connect();
        public Task<(Guid clientId, Guid clientKey)> Join();
        public Task<bool> SendInput(NininInput client);
        public Task<bool> FetchInputs(out ReadOnlyCollection<NininInput> inputs);
    }
}