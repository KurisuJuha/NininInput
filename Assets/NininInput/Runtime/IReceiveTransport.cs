using System.Threading.Tasks;

namespace JuhaKurisu.PopoTools.Ninin
{
    public interface IReceiveTransport
    {
        public Task<bool> FetchConnect();
        public Task<bool> FetchJoin();
        public Task<bool> FetchInput();
        public Task<bool> SendInputs();
    }
}