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

namespace krestiki_noliki
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml za pobedu
    /// </summary>
    public partial class MainWindow : Window

    { public static int kk = 0;
        public static int hh;
        public static int dd = 1;
         static Button[] кнопки = new Button[9];

        public static int[] genacid = new int[9];
        public MainWindow()


        {
            InitializeComponent();
            hh = 1;
            кнопки[0] = _1;
            кнопки[1] = _2;
            кнопки[2] = _3;
            кнопки[3] = _4;
            кнопки[4] = _5;
            кнопки[5] = _6;
            кнопки[6] = _7;
            кнопки[7] = _8;
            кнопки[8] = _9;
            for (int i = 0; i < кнопки.Length; i++)
            {

                кнопки[i].IsEnabled = false;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(hh == 1)
            {
                sender.GetType().GetProperty("Content").SetValue(sender, "x");
                info.Content = "нули";
                kk += 1;
                
                hh = 0;
            }
            else if (hh == 0)
            {
                sender.GetType().GetProperty("Content").SetValue(sender, "0");
                info.Content = "кресты";
                kk += 1;
                hh = 1; 
            }
            sender.GetType().GetProperty("IsEnabled").SetValue(sender, false);
            zapobedu();
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < кнопки.Length; i++)
            {
                кнопки[i].Content = "";
                кнопки[i].IsEnabled = true;

            }
            if(dd== 1)
            {
                hh = 1; info.Content = "кресты";
            }
            else if (dd ==0)
            {
                hh = 0; info.Content = "нули";
            }
            kk = 0; 
        }
        public  void zapobedu()
        {
            if ((кнопки[0].Content == "x" && кнопки[1].Content == "x" && кнопки[2].Content == "x") || (кнопки[3].Content == "x" && кнопки[4].Content == "x" && кнопки[5].Content == "x") || (кнопки[6].Content == "x" && кнопки[7].Content == "x" && кнопки[8].Content == "x"))
            {
                info.Content = "pobeda krestov";
                dd = 0;
                for (int i = 0; i < кнопки.Length; i++)
                {

                    кнопки[i].IsEnabled = false;

                }
            }
            else if ((кнопки[0].Content == "x" && кнопки[3].Content == "x" && кнопки[6].Content == "x") || (кнопки[1].Content == "x" && кнопки[4].Content == "x" && кнопки[7].Content == "x") || (кнопки[2].Content == "x" && кнопки[5].Content == "x" && кнопки[8].Content == "x"))
            {
                info.Content = "pobeda krestov";
                dd = 0;
                for (int i = 0; i < кнопки.Length; i++)
                {

                    кнопки[i].IsEnabled = false;

                }
            }
            else if ((кнопки[0].Content == "x" && кнопки[4].Content == "x" && кнопки[8].Content == "x") || (кнопки[2].Content == "x" && кнопки[4].Content == "x" && кнопки[6].Content == "x"))
            {
                info.Content = "pobeda krestov";
                dd = 0;
                for (int i = 0; i < кнопки.Length; i++)
                {

                    кнопки[i].IsEnabled = false;

                }
            }
            else if ((кнопки[0].Content == "0" && кнопки[1].Content == "0" && кнопки[2].Content == "0") || (кнопки[3].Content == "0" && кнопки[4].Content == "0" && кнопки[5].Content == "0") || (кнопки[6].Content == "0" && кнопки[7].Content == "0" && кнопки[8].Content == "0"))
            {
                info.Content = "pobeda nuley";
                dd = 1;
                for (int i = 0; i < кнопки.Length; i++)
                {

                    кнопки[i].IsEnabled = false;

                }
            }
            else if ((кнопки[0].Content == "0" && кнопки[3].Content == "0" && кнопки[6].Content == "0") || (кнопки[1].Content == "0" && кнопки[4].Content == "0" && кнопки[7].Content == "0") || (кнопки[2].Content == "0" && кнопки[5].Content == "0" && кнопки[8].Content == "0"))
            {
                info.Content = "pobeda nuley";
                dd = 1;
                for (int i = 0; i < кнопки.Length; i++)
                {

                    кнопки[i].IsEnabled = false;

                }
            }
            else if ((кнопки[0].Content == "0" && кнопки[4].Content == "0" && кнопки[8].Content == "0") || (кнопки[2].Content == "0" && кнопки[4].Content == "0" && кнопки[6].Content == "0"))
            {
                info.Content = "pobeda nuley";
                dd = 1;
                for (int i = 0; i < кнопки.Length; i++)
                {

                    кнопки[i].IsEnabled = false;

                }
            }
            else if(kk== 9)
            {
                if ((кнопки[0].Content == "x" && кнопки[1].Content == "x" && кнопки[2].Content == "x") || (кнопки[3].Content == "x" && кнопки[4].Content == "x" && кнопки[5].Content == "x") || (кнопки[6].Content == "x" && кнопки[7].Content == "x" && кнопки[8].Content == "x"))
                {
                    info.Content = "pobeda krestov";
                    dd = 0;
                    for (int i = 0; i < кнопки.Length; i++)
                    {

                        кнопки[i].IsEnabled = false;

                    }
                }
                else if ((кнопки[0].Content == "x" && кнопки[3].Content == "x" && кнопки[6].Content == "x") || (кнопки[1].Content == "x" && кнопки[4].Content == "x" && кнопки[7].Content == "x") || (кнопки[2].Content == "x" && кнопки[5].Content == "x" && кнопки[8].Content == "x"))
                {
                    info.Content = "pobeda krestov";
                    dd = 0;
                    for (int i = 0; i < кнопки.Length; i++)
                    {

                        кнопки[i].IsEnabled = false;

                    }
                }
                else if ((кнопки[0].Content == "x" && кнопки[4].Content == "x" && кнопки[8].Content == "x") || (кнопки[2].Content == "x" && кнопки[4].Content == "x" && кнопки[6].Content == "x"))
                {
                    info.Content = "pobeda krestov";
                    dd = 0;
                    for (int i = 0; i < кнопки.Length; i++)
                    {

                        кнопки[i].IsEnabled = false;

                    }
                }
                else if ((кнопки[0].Content == "0" && кнопки[1].Content == "0" && кнопки[2].Content == "0") || (кнопки[3].Content == "0" && кнопки[4].Content == "0" && кнопки[5].Content == "0") || (кнопки[6].Content == "0" && кнопки[7].Content == "0" && кнопки[8].Content == "0"))
                {
                    info.Content = "pobeda nuley";
                    dd = 1;
                    for (int i = 0; i < кнопки.Length; i++)
                    {

                        кнопки[i].IsEnabled = false;

                    }
                }
                else if ((кнопки[0].Content == "0" && кнопки[3].Content == "0" && кнопки[6].Content == "0") || (кнопки[1].Content == "0" && кнопки[4].Content == "0" && кнопки[7].Content == "0") || (кнопки[2].Content == "0" && кнопки[5].Content == "0" && кнопки[8].Content == "0"))
                {
                    info.Content = "pobeda nuley";
                    dd = 1;
                    for (int i = 0; i < кнопки.Length; i++)
                    {

                        кнопки[i].IsEnabled = false;

                    }
                }
                else if ((кнопки[0].Content == "0" && кнопки[4].Content == "0" && кнопки[8].Content == "0") || (кнопки[2].Content == "0" && кнопки[4].Content == "0" && кнопки[6].Content == "0"))
                {
                    info.Content = "pobeda nuley";
                    dd = 1;
                    for (int i = 0; i < кнопки.Length; i++)
                    {

                        кнопки[i].IsEnabled = false;

                    }
                }
                else
                {
                    info.Content = "nichya";
                }
                
            }


        }

    }

}
