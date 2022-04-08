using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes
{
    public partial class Area_of_a_Circle : Form
    {
        public Area_of_a_Circle()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            double radius = int.Parse(txtRadius.Text);
            double area = Math.PI * Math.Pow(radius, 2);
            Answer.Text = area.ToString();
        }
    }
}
