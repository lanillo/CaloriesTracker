using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaloriesTracker.Data.Controllers;

namespace CaloriesTracker.Views
{
    public partial class FoodForm : Form
    {
        public FoodForm()
        {
            InitializeComponent();
        }

        private void FoodForm_Load(object sender, EventArgs e)
        {
            LoadFood();
        }

        private void LoadFood()
        {
            var food = SQLiteDataAccess.LoadFood();

            dgvFood.DataSource = food;
                   
        }
    }
}
