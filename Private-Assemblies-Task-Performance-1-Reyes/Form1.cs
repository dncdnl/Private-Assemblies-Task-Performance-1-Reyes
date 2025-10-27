using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Private_Assemblies_Task_Performance_1_Reyes
{
    public partial class frmBasicCalculator : Form
    {
        public frmBasicCalculator()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            // Calling the methods from the BasicComputation class in the CalculatorPrivateAssembly
            float num1 = float.Parse(tbNum1.Text);
            float num2 = float.Parse(tbNum2.Text);
            float total = 0;

            switch(cbOperations.SelectedItem.ToString())
            {
                case "+":
                    total = CalculatorPrivateAssembly.BasicComputation.Add(num1, num2);
                    break;
                case "-":
                    total = CalculatorPrivateAssembly.BasicComputation.Subtract(num1, num2);
                    break;
                case "*":
                    total = CalculatorPrivateAssembly.BasicComputation.Multiply(num1, num2);
                    break;
                case "/":
                    total = CalculatorPrivateAssembly.BasicComputation.Divide(num1, num2);
                    break;
                
            }
        }
    }
}
