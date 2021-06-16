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
using System.Windows.Threading;

namespace Task_6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();

            timer.Interval = new TimeSpan(0, 0, 1); ;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        private byte blink = 1;
        private bool show = false;

        private void timer_Tick(object sender, EventArgs e)
        {
            if (show)
            {
                Title = "Enter button `OK!`";
                show = false;
            }
            else
            {
                Title = "";
                show = true;
            }
            ++blink;
            if (blink <= 16)
                return;
            timer.Stop();
            show = false;
        }
        private static readonly Random random = new Random();
        private void button1_Move(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Canvas.SetLeft(button, random.Next(100, 300));
            Canvas.SetTop(button, random.Next(100, 250));
            button.Width -= 3;
            button.Height -= 3;

            if (button1.Height <= 0)
            {
                Title = "The `OK` button cannot be pressed";
                timer.Stop();
                this.show = false;
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
