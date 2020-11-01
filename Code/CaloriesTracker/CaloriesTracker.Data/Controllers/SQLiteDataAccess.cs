using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaloriesTracker.Data.Models;
using Dapper;

namespace CaloriesTracker.Data.Controllers
{
    public class SQLiteDataAccess
    {
        public static List<FoodModel> LoadFood() 
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString())) 
            {
                return connection.Query<FoodModel>("SELECT * FROM Food", new DynamicParameters()).ToList();
            }
        }

        public static void SaveFood(FoodModel food)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("INSERT INTO Food (Name, Quantity, fkIDUnitType, Calories) VALUES (@Name, @Quantity, @UnitType, @Calories)", food);
            }
        }

        private static string LoadConnectionString(string id = "Default") 
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
