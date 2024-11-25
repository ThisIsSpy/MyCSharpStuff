using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimatePatternKT.Task5
{
    public class RealService : IService
    {
        public ProxyService ProxyService;

        public string GetData()
        {
            if (ProxyService.CachedData == null)
            {
                Task.Delay(1000).Wait();
                ProxyService.CachedData = "data";
                return "data";
            }
            else
            {
                return ProxyService.GetData();
            }
        }
        public void Construct(ProxyService proxyService)
        {
            ProxyService = proxyService;
        }
    }
}
