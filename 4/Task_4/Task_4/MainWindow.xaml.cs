using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long num1 = 0;
        long num2 = 0;
        string operations = "";
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "")
            {
                num1 = (num1 * 10) + 1;
                textNum.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 1;
                textNum.Text = num2.ToString();
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "")
            {
                num1 = (num1 * 10) + 2;
                textNum.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 2;
                textNum.Text = num2.ToString();
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "")
            {
                num1 = (num1 * 10) + 3;
                textNum.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 3;
                textNum.Text = num2.ToString();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "")
            {
                num1 = (num1 * 10) + 4;
                textNum.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 4;
                textNum.Text = num2.ToString();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "")
            {
                num1 = (num1 * 10) + 5;
                textNum.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 5;
                textNum.Text = num2.ToString();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "")
            {
                num1 = (num1 * 10) + 6;
                textNum.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 6;
                textNum.Text = num2.ToString();
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "")
            {
                num1 = (num1 * 10) + 7;
                textNum.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) +7;
                textNum.Text = num2.ToString();
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "")
            {
                num1 = (num1 * 10) + 8;
                textNum.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 8;
                textNum.Text = num2.ToString();
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "")
            {
                num1 = (num1 * 10) + 9;
                textNum.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 9;
                textNum.Text = num2.ToString();
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "")
            {
                num1 = (num1 * 10);
                textNum.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10);
                textNum.Text = num2.ToString();
            }
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            operations = "÷";
            textNum.Text = "0";
        }

        private void btnMultyple_Click(object sender, RoutedEventArgs e)
        {
            operations = "x";
            textNum.Text = "0";
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            operations = "-";
            textNum.Text = "0";
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            operations = "+";
            textNum.Text = "0";
        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            switch (operations)
            {
                case "+":
                    textNum.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    textNum.Text = (num1 - num2).ToString();
                    break;
                case "x":
                    textNum.Text = (num1 * num2).ToString();
                    break;
                case "÷":
                    textNum.Text = (num1 / num2).ToString();
                    break;
                default: textNum.Text = "0";
                    break;
            }
        }

        private void btnCe_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "")
            {
                num1 = 0;
            }
            else
                num2 = 0;
            textNum.Text = "0";
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            num1 = 0;
            num2 = 0;
            operations = "";
            textNum.Text = "0";
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "")
            {
                num1 = (num1 / 10);
                textNum.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 / 10);
                textNum.Text = num2.ToString();
            }
        }

        private void btnPlusOrMinus_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "")
            {
                num1 *= -1;
                textNum.Text = num1.ToString();
            }
            else
            {
                num2 *= -1;
                textNum.Text = num2.ToString();
            }
        }
    }
}
