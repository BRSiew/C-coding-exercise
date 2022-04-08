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
    public partial class Shapes : Form
    {
        public Shapes()
        {
            InitializeComponent();
        }

        private void txtSqr_Click(object sender, EventArgs e)
        {
            new Square().Show();
            
        }

        private void txtCirc_Click(object sender, EventArgs e)
        {
            new Area_of_a_Circle().Show();
        }

        private void txtTri_Click(object sender, EventArgs e)
        {
            new Area_of_a_Triangle().Show();
        }
    }
}
