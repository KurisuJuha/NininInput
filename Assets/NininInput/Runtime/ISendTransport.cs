using System.Threading.Tasks;

namespace JuhaKurisu.PopoTools.Ninin
{
    public interface ISendTransport
    {
        public Task<bool> Connect();
    }
}