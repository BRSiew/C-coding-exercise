using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using CalcLibrary;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace CalcHttpClient
{
    public partial class Calc : Form 
    {

        private static HttpClient _httpClient = new HttpClient();
        CalculatorEntities OE = new CalculatorEntities();
        

        public Calc()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int firstNumber = int.Parse(txtStart.Text);
            int secondNumber = int.Parse(txtBy.Text);

            int sum = firstNumber + secondNumber;
            Answer.Text = sum.ToString();
        }
        public async Task CreateResource()
        {
            var valueToCreate = new CalculatorEntities();
            {
                int FirstNumber = int.Parse(txtStart.Text);
                int SecondNumber = int.Parse(txtBy.Text);
                int Sum = FirstNumber + SecondNumber;
            }
            var serializedValueToCreate = JsonSerializtion.Ser
        }
    }
}
