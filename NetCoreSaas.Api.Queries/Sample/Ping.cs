using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace NetCoreSaas.Api.Queries.Sample
{
    public class Ping : IRequest<string>
    {
        public class PingHandler : IRequestHandler<Ping, string>
        {
            public Task<string> Handle(Ping request, CancellationToken cancellationToken)
            {
                return Task.FromResult("Pong");
            }
        }
    }
}
