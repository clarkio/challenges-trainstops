using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainStopsChallenge
{
    public class StopLocation
    {
        public string Name { get; set; }
        public Dictionary<string, int> AdjacentLocations { get; set; }
    }
}
