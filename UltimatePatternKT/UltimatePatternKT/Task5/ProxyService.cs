using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimatePatternKT.Task5
{
    public class ProxyService : IService
    {
        public RealService RealService;
        public string CachedData;

        public string GetData()
        {
            if (CachedData == null)
            {
                CachedData = RealService.GetData();
            }
            return CachedData;
        }
        public void Construct(RealService realService)
        {
            RealService = realService;
        }
    }
}
