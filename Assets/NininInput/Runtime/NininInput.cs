using System.Collections.Generic;
using System.Threading.Tasks;

namespace JuhaKurisu.PopoTools.Ninin
{
    public class NininInput
    {
        readonly List<NininInputClient> clients = new List<NininInputClient>();
        readonly ISendTransport sendTransport;
        readonly IReceiveTransport receiveTransport;

        NininInput(ISendTransport sendTransport, IReceiveTransport receiveTransport)
        {
            this.sendTransport = sendTransport;
            this.receiveTransport = receiveTransport;
        }

        public static NininInput Create(ISendTransport sendTransport, IReceiveTransport receiveTransport) => new NininInput(sendTransport, receiveTransport);
        public static NininInput Create<T>(T transport) where T : ISendTransport, IReceiveTransport => new NininInput(transport, transport);

        public Task<bool> Connect() => sendTransport.Connect();
    }
}