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
    public partial class Square : Form
    {
        public Square()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int width = int.Parse(txtWidth.Text);
            int height = int.Parse(txtHeight.Text);
            int area = width * height;
            Answer.Text = area.ToString();
        }
    }
}
