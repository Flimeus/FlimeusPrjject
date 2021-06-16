using System;
using System.IO;
using System.Windows;
using System.Windows.Input;

namespace Task_7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string basePath = @"C:\Folder\Folder";
       
        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show($"Your path: {basePath}");
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                DirectoryInfo dir = new DirectoryInfo(basePath);
                basePath = @"C:\Folder\Folder" + i.ToString();
                if (!dir.Exists)
                {
                    dir.Create();
                }
            }
            basePath = @"C:\Folder\Folder";
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                DirectoryInfo dir = new DirectoryInfo(basePath);
                basePath = @"C:\Folder\Folder" + i.ToString();
                if (dir.Exists)
                {
                    dir.Delete();
                }
            }
            basePath = @"C:\Folder\Folder";
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 4674; i++)
            {
                DirectoryInfo dir = new DirectoryInfo(basePath);
                basePath += @"\Folder";
                if (!dir.Exists)
                {
                    dir.Create();
                }
            }
            MessageBox.Show($"Max of created folders = 4675");
            basePath = @"C:\Folder\Folder";
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            foreach (string folder in Directory.GetDirectories(basePath))
            {
                Directory.Delete(folder, true);
            }
            DirectoryInfo dir = new DirectoryInfo(basePath);
            dir.Delete();
        }
        static string path2 = @"";
        private void btn_5_Click(object sender, RoutedEventArgs e)
        {
            if (tb_1.Text != null)
            {
                path2 += tb_1.Text;
            }
            FindFiles(new DirectoryInfo(path2));
        }
        void FindFiles(DirectoryInfo path)
        {
            if (path is null)
            {
                throw new ArgumentNullException(nameof(path));
            }
            else
            {
                foreach (FileInfo f in path.GetFiles("*.txt"))
                    lstb_1.Items.Add(f.FullName);
            }

                
            

            foreach (DirectoryInfo dir in path.GetDirectories())
            {
                FindFiles(dir);
            }
        }
        private void lstb_1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (tb_1.Text != null)
            {
                path2 += tb_1.Text;
            }
            ReadFiles(new DirectoryInfo(path2));
        }
        static string nextPath = @"C:\Folder";
        void ReadFiles(DirectoryInfo path)
        {
            lstb_1.Items.Clear();
            using (FileStream fstream = File.OpenRead($"{nextPath}\\Folder.txt"))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                lstb_1.Items.Add(textFromFile);
            }
        }
    }
}
