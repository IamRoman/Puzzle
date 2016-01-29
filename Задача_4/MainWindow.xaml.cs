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

namespace Задача_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BitmapImage BImage_1, BImage_2, BImage_3, BImage_4, BImage_5, BImage_6, BImage_7, BImage_8,
                    BImage_9, BImage_10, BImage_11, BImage_12, BImage_13, BImage_14, BImage_15, BImage_16;

        int count = 0;
        System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            InitializeImg();

            timer.Tick += new EventHandler(timerTick);
            timer.Interval = new TimeSpan(0, 0, 1);
        }

        private void timerTick(object sender, EventArgs e)
        {
            count++;
            MyTime.Text = "     " + count.ToString() + " sec";
            Win();
        }

        private void InitializeImg()
        {
            BImage_1 = new BitmapImage(new Uri("Res/01.jpg", UriKind.Relative));
            img_1.Source = BImage_1;
            img_1.IsEnabled = false;
            BImage_2 = new BitmapImage(new Uri("Res/02.jpg", UriKind.Relative));
            img_2.Source = BImage_2;
            img_2.IsEnabled = false;
            BImage_3 = new BitmapImage(new Uri("Res/03.jpg", UriKind.Relative));
            img_3.Source = BImage_3;
            img_3.IsEnabled = false;
            BImage_4 = new BitmapImage(new Uri("Res/04.jpg", UriKind.Relative));
            img_4.Source = BImage_4;
            img_4.IsEnabled = false;
            BImage_5 = new BitmapImage(new Uri("Res/05.jpg", UriKind.Relative));
            img_5.Source = BImage_5;
            img_5.IsEnabled = false;
            BImage_6 = new BitmapImage(new Uri("Res/06.jpg", UriKind.Relative));
            img_6.Source = BImage_6;
            img_6.IsEnabled = false;
            BImage_7 = new BitmapImage(new Uri("Res/07.jpg", UriKind.Relative));
            img_7.Source = BImage_7;
            img_7.IsEnabled = false;
            BImage_8 = new BitmapImage(new Uri("Res/08.jpg", UriKind.Relative));
            img_8.Source = BImage_8;
            img_8.IsEnabled = false;
            BImage_9 = new BitmapImage(new Uri("Res/09.jpg", UriKind.Relative));
            img_9.Source = BImage_9;
            img_9.IsEnabled = false;
            BImage_10 = new BitmapImage(new Uri("Res/10.jpg", UriKind.Relative));
            img_10.Source = BImage_10;
            img_10.IsEnabled = false;
            BImage_11 = new BitmapImage(new Uri("Res/11.jpg", UriKind.Relative));
            img_11.Source = BImage_11;
            img_11.IsEnabled = false;
            BImage_12 = new BitmapImage(new Uri("Res/12.jpg", UriKind.Relative));
            img_12.Source = BImage_12;
            img_12.IsEnabled = false;
            BImage_13 = new BitmapImage(new Uri("Res/13.jpg", UriKind.Relative));
            img_13.Source = BImage_13;
            img_13.IsEnabled = false;
            BImage_14 = new BitmapImage(new Uri("Res/14.jpg", UriKind.Relative));
            img_14.Source = BImage_14;
            img_14.IsEnabled = false;
            BImage_15 = new BitmapImage(new Uri("Res/15.jpg", UriKind.Relative));
            img_15.Source = BImage_15;
            img_15.IsEnabled = false;
            BImage_16 = null;//new BitmapImage(new Uri("Res/16.jpg", UriKind.Relative));
            img_16.Source = BImage_16;
            img_16.IsEnabled = false;
            MyRestart.IsEnabled = false;
        }

        private void MixingImg()
        {
            BitmapImage tmp = new BitmapImage();
            Random r = new Random();
            for (int i = 0; i < 1000; i++)
            {
                switch (r.Next(0, 7).ToString())
                {
                    case "0":
                        tmp = (BitmapImage)img_1.Source;
                        img_1.Source = img_16.Source;
                        img_16.Source = tmp;
                        break;
                    case "1":
                        tmp = (BitmapImage)img_8.Source;
                        img_8.Source = img_16.Source;
                        img_16.Source = tmp;
                        break;
                    case "2":
                        tmp = (BitmapImage)img_2.Source;
                        img_2.Source = img_14.Source;
                        img_14.Source = tmp;
                        break;
                    case "3":
                        tmp = (BitmapImage)img_7.Source;
                        img_7.Source = img_16.Source;
                        img_16.Source = tmp;
                        break;
                    case "4":
                        tmp = (BitmapImage)img_16.Source;
                        img_16.Source = img_9.Source;
                        img_9.Source = tmp;
                        break;
                    case "5":
                        tmp = (BitmapImage)img_11.Source;
                        img_11.Source = img_15.Source;
                        img_15.Source = tmp;
                        break;
                    case "6":
                        tmp = (BitmapImage)img_6.Source;
                        img_6.Source = img_7.Source;
                        img_7.Source = tmp;
                        break;
                    case "7":
                        tmp = (BitmapImage)img_16.Source;
                        img_16.Source = img_5.Source;
                        img_5.Source = tmp;
                        break;
                }
            }
        }

        private void img_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Image im = (Image)sender;

            switch ((string)im.Name)
            {
                case "img_1":
                    if (img_2.Source == null)
                    {
                        img_2.Source = img_1.Source;
                        img_1.Source = null;
                    }
                    else if (img_5.Source == null)
                    {
                        img_5.Source = img_1.Source;
                        img_1.Source = null;
                    }
                    break;
                case "img_2":
                    if (img_1.Source == null)
                    {
                        img_1.Source = img_2.Source;
                        img_2.Source = null;
                    }
                    else if (img_6.Source == null)
                    {
                        img_6.Source = img_2.Source;
                        img_2.Source = null;
                    }
                    else if (img_3.Source == null)
                    {
                        img_3.Source = img_2.Source;
                        img_2.Source = null;
                    }
                    break;
                case "img_3":
                    if (img_2.Source == null)
                    {
                        img_2.Source = img_3.Source;
                        img_3.Source = null;
                    }
                    else if (img_7.Source == null)
                    {
                        img_7.Source = img_3.Source;
                        img_3.Source = null;
                    }
                    else if (img_4.Source == null)
                    {
                        img_4.Source = img_3.Source;
                        img_3.Source = null;
                    }
                    break;
                case "img_4":
                    if (img_3.Source == null)
                    {
                        img_3.Source = img_4.Source;
                        img_4.Source = null;
                    }
                    else if (img_8.Source == null)
                    {
                        img_8.Source = img_4.Source;
                        img_4.Source = null;
                    }
                    break;
                case "img_5":
                    if (img_1.Source == null)
                    {
                        img_1.Source = img_5.Source;
                        img_5.Source = null;
                    }
                    else if (img_6.Source == null)
                    {
                        img_6.Source = img_5.Source;
                        img_5.Source = null;
                    }
                    else if (img_9.Source == null)
                    {
                        img_9.Source = img_5.Source;
                        img_5.Source = null;
                    }
                    break;
                case "img_6":
                    if (img_5.Source == null)
                    {
                        img_5.Source = img_6.Source;
                        img_6.Source = null;
                    }
                    else if (img_2.Source == null)
                    {
                        img_2.Source = img_6.Source;
                        img_6.Source = null;
                    }
                    else if (img_7.Source == null)
                    {
                        img_7.Source = img_6.Source;
                        img_6.Source = null;
                    }
                    else if (img_10.Source == null)
                    {
                        img_10.Source = img_6.Source;
                        img_6.Source = null;
                    }
                    break;
                case "img_7":
                    if (img_3.Source == null)
                    {
                        img_3.Source = img_7.Source;
                        img_7.Source = null;
                    }
                    else if (img_6.Source == null)
                    {
                        img_6.Source = img_7.Source;
                        img_7.Source = null;
                    }
                    else if (img_11.Source == null)
                    {
                        img_11.Source = img_7.Source;
                        img_7.Source = null;
                    }
                    else if (img_8.Source == null)
                    {
                        img_8.Source = img_7.Source;
                        img_7.Source = null;
                    }
                    break;
                case "img_8":
                    if (img_4.Source == null)
                    {
                        img_4.Source = img_8.Source;
                        img_8.Source = null;
                    }
                    else if (img_7.Source == null)
                    {
                        img_7.Source = img_8.Source;
                        img_8.Source = null;
                    }
                    else if (img_12.Source == null)
                    {
                        img_12.Source = img_8.Source;
                        img_8.Source = null;
                    }
                    break;
                case "img_9":
                    if (img_5.Source == null)
                    {
                        img_5.Source = img_9.Source;
                        img_9.Source = null;
                    }
                    else if (img_13.Source == null)
                    {
                        img_13.Source = img_9.Source;
                        img_9.Source = null;
                    }
                    else if (img_10.Source == null)
                    {
                        img_10.Source = img_9.Source;
                        img_9.Source = null;
                    }
                    break;
                case "img_10":
                    if (img_6.Source == null)
                    {
                        img_6.Source = img_10.Source;
                        img_10.Source = null;
                    }
                    else if (img_9.Source == null)
                    {
                        img_9.Source = img_10.Source;
                        img_10.Source = null;
                    }
                    else if (img_11.Source == null)
                    {
                        img_11.Source = img_10.Source;
                        img_10.Source = null;
                    }
                    else if (img_14.Source == null)
                    {
                        img_14.Source = img_10.Source;
                        img_10.Source = null;
                    }
                    break;
                case "img_11":
                    if (img_10.Source == null)
                    {
                        img_10.Source = img_11.Source;
                        img_11.Source = null;
                    }
                    else if (img_7.Source == null)
                    {
                        img_7.Source = img_11.Source;
                        img_11.Source = null;
                    }
                    else if (img_12.Source == null)
                    {
                        img_12.Source = img_11.Source;
                        img_11.Source = null;
                    }
                    else if (img_15.Source == null)
                    {
                        img_15.Source = img_11.Source;
                        img_11.Source = null;
                    }
                    break;
                case "img_12":
                    if (img_8.Source == null)
                    {
                        img_8.Source = img_12.Source;
                        img_12.Source = null;
                    }
                    else if (img_11.Source == null)
                    {
                        img_11.Source = img_12.Source;
                        img_12.Source = null;
                    }
                    else if (img_16.Source == null)
                    {
                        img_16.Source = img_12.Source;
                        img_12.Source = null;
                    }
                    break;
                case "img_13":
                    if (img_9.Source == null)
                    {
                        img_9.Source = img_13.Source;
                        img_13.Source = null;
                    }
                    else if (img_14.Source == null)
                    {
                        img_14.Source = img_13.Source;
                        img_13.Source = null;
                    }
                    break;
                case "img_14":
                    if (img_10.Source == null)
                    {
                        img_10.Source = img_14.Source;
                        img_14.Source = null;
                    }
                    else if (img_13.Source == null)
                    {
                        img_13.Source = img_14.Source;
                        img_14.Source = null;
                    }
                    else if (img_15.Source == null)
                    {
                        img_15.Source = img_14.Source;
                        img_14.Source = null;
                    }
                    break;
                case "img_15":
                    if (img_16.Source == null)
                    {
                        //BitmapImage tmp = new BitmapImage();
                        //tmp = (BitmapImage)img_15.Source;
                        img_16.Source = img_15.Source;
                        img_15.Source = null;
                    }

                    else if (img_14.Source == null)
                    {
                        img_14.Source = img_15.Source;
                        img_15.Source = null;
                    }
                    else if (img_11.Source == null)
                    {
                        img_11.Source = img_15.Source;
                        img_15.Source = null;
                    }
                    break;
                case "img_16":
                    if (img_12.Source == null)
                    {
                        img_12.Source = img_16.Source;
                        img_16.Source = null;
                    }
                    else if (img_15.Source == null)
                    {
                        img_15.Source = img_16.Source;
                        img_16.Source = null;
                    }
                    break;
            }
        }

        private void MyStart_Click(object sender, RoutedEventArgs e)
        {
            timer.Start(); MyTime.Text = "     " + count.ToString() + " sec";
            MixingImg();
            img_1.IsEnabled = true; img_2.IsEnabled = true; img_3.IsEnabled = true; img_4.IsEnabled = true;
            img_5.IsEnabled = true; img_6.IsEnabled = true; img_7.IsEnabled = true; img_8.IsEnabled = true;
            img_9.IsEnabled = true; img_10.IsEnabled = true; img_11.IsEnabled = true; img_12.IsEnabled = true;
            img_13.IsEnabled = true; img_14.IsEnabled = true; img_15.IsEnabled = true; img_16.IsEnabled = true;
            MyStart.IsEnabled = false;
            MyRestart.IsEnabled = true;
        }

        private void MyRestart_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop(); count = 0; MyTime.Text = "     " + count.ToString() + " sec";
            MyStart.IsEnabled = true;
            MyRestart.IsEnabled = false;
            InitializeImg();
        }

        private void Win()
        {
            if (img_1.Source == BImage_1 && img_2.Source == BImage_2 && img_3.Source == BImage_3 &&
                img_4.Source == BImage_4 && img_5.Source == BImage_5 && img_6.Source == BImage_6 &&
                img_7.Source == BImage_7 && img_8.Source == BImage_8 && img_9.Source == BImage_9 &&
                img_10.Source == BImage_10 && img_11.Source == BImage_11 && img_12.Source == BImage_12 &&
                img_13.Source == BImage_13 && img_14.Source == BImage_14 && img_15.Source == BImage_15 && img_16.Source == null)
            {
                MessageBox.Show("Вы выиграли ПОЗДРАВЛЯЕМ!!!");
                timer.Stop(); count = 0; MyTime.Text = "     " + count.ToString() + " sec";
                MyStart.IsEnabled = true;
                MyRestart.IsEnabled = false;
                InitializeImg();
            }
        }
    }
}
