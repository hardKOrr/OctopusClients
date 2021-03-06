using System;
using Octopus.Client.Model;

namespace Octopus.Client.Repositories
{
    public interface IProxyRepository : IGet<ProxyResource>, ICreate<ProxyResource>, IModify<ProxyResource>, IDelete<ProxyResource>, IFindByName<ProxyResource>
    {
    }
    
    class ProxyRepository : BasicRepository<ProxyResource>, IProxyRepository
    {
        public ProxyRepository(IOctopusClient client)
            : base(client, "Proxies")
        {

        }
    }
}