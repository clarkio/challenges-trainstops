using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainStopsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stop Location Name, [ Adjacent Stop Name, Distance ]
            var routingData = new List<StopLocation>();
            var dataList = new List<string>();
            var currentStopName = string.Empty;
            StopLocation currentStopLocation = null;

            var data = File.ReadAllText(@".\SampleData\Data.txt");

            if (!string.IsNullOrEmpty(data))
            {
                dataList = data.Replace(" ", "").Split(',').ToList();
                var groups = dataList.GroupBy(i => i.Substring(0, 1));
                foreach (var group in groups)
                {
                    currentStopLocation = new StopLocation { Name = group.Key };
                    currentStopLocation.AdjacentLocations = group.ToDictionary(g => g.Substring(1, 1),
                                                                    g => Convert.ToInt32(g.Substring(2, 1)));
                    routingData.Add(currentStopLocation);
                }

                foreach (var route in routingData)
                {
                    Console.WriteLine(route.Name + ": " + route.AdjacentLocations.Count);
                }
            }

            Console.ReadLine();
        }

        public static int GetRouteDistance(string route)
        {
            var stops = route.Split('-');
            return 0;
        }

        public static string GetShortestRoute(string firstStop, string secondStop)
        {
            return string.Empty;
        }

        public static List<string> GetUniqueRoutes(string firstStop, string secondStop)
        {
            return new List<string>();
        }
    }
}
