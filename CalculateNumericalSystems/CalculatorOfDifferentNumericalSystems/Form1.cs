using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorOfDifferentNumericalSystems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int counter = default;
        readonly char[] setSymbols = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'A', 'B', 'C', 'D', 'E', 'F', '-' };
        bool verifySymbols = false;
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            int selectedSystemNumericalFrom = Convert.ToInt32(comboBox1.SelectedItem.ToString());
            int selectedSystemNumericalTo = Convert.ToInt32(comboBox2.SelectedItem.ToString());

            string numericNumber = textBox1.Text;
            var hash = new HashSet<char>(setSymbols);

            for (int i = 0; i < numericNumber.Length; i++)
            {
                if (hash.Contains(numericNumber[i]))
                {
                    counter++;
                }
                if (numericNumber[i] == '-' && i != 0)
                {
                    break;
                }
            }

            if (counter == numericNumber.Length)
            {
                verifySymbols = true;
            }
            if (verifySymbols)
            {
                try
                {
                    label4.Text = Convert.ToString(Convert.ToInt32(numericNumber, selectedSystemNumericalFrom), selectedSystemNumericalTo);
                }
                catch { }
            }
            else
            {
                label4.Text = "Невірно введені дані";
            }
        }
    }
}
