using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YB_MutluArdaBetülRezervasyonApp.DataAccessLayer.ConfigurationModelBuilder
{
    public class Helper
    {
        public static Guid GenerateGuid()
        {
            return Guid.NewGuid();
        }

        public static List<Guid> GenerateGuids(int count)
        {
            return Enumerable.Range(0, count).Select(x => Guid.NewGuid()).ToList();
        }
    }
}
