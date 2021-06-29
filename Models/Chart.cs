using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gestion_ordre_mission.Models
{
    public class Chart
    {
        public int[] labels { get; set; }
        public List<Datasets> datasets { get; set; }
    }
    public class Datasets
    {
        public string Label { get; set; }
        public String[] backgroundColor { get; set; }
        public String[] borderColor { get; set; }
        public String borderWidth { get; set; }
        public int[] data { get; set; }
    }
}
