using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaloriesTracker.Data.Enums;

namespace CaloriesTracker.Data.Models
{
    public class FoodModel
    {
        public int pkID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public UnitTypes fkIDUnitType { get; set; }
        public int Calories { get; set; }
    }
}
