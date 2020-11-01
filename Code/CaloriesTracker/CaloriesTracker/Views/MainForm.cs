using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaloriesTracker.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void foodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var foodForm = new FoodForm();
            foodForm.ShowDialog();
        }
    }
}
