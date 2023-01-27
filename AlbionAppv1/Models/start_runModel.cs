using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbionAppv1.Models
{
    public class start_runModel
    {
        public int id { get; set; }
        public int tier { get; set; }
        public int current_silver { get; set; }
        public int current_item_value { get; set; }
        public int map_cost { get; set; }
        public string zone { get; set; }
        public int solo_duo { get; set; }

        public DateTime start_time { get; set; }



    }
}
