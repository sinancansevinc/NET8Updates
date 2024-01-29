using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoogleMapPoint = (string, double);

namespace NET8Updates
{
    public class City
    {
        public City(int id, string name, GoogleMapPoint point)
        {
            Id = id;
            Name = name;
            Point = point;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public GoogleMapPoint Point { get; set; }
    }
}
