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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Random vel = new Random();
        public MainWindow()
        {
            InitializeComponent();
           

            for (int i = 0; i < 30; i++)
            {
                if (vel.Next(0, 2) == 0)
                {
                    Button gomb = new Button();
                    gomb.Click += LalaKattintott;
                    gomb.Content = "Szöveg";
                    gomb.Background = Brushes.Green;
                    lbGombok.Items.Add(gomb);
                }
                else
                {
                    Slider csuszka = new Slider();
                    csuszka.ValueChanged += LalaKattintott;
                    csuszka.Minimum = -100;
                    csuszka.Maximum = 100;
                    csuszka.Width = 200;
                    lbGombok.Items.Add(csuszka);
                }
            }
        }
        private void lbGombok_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //SButton ujgomb = new SButton($"neve [{vel.Next(1000, 10000)}]");
            if (rad1.IsChecked==true)
            {
                SButton ujgomb = new SButton($"kódja [{vel.Next(1000, 10000)}]");
                ujgomb.Click += LalaKattintott;
                lbGombok.Items.Add(ujgomb);
            }
            else if (rad2.IsChecked==true)
            {
                Slider ujslider = new Slider();
                ujslider.Minimum = -100;
                ujslider.Maximum = 100;
                ujslider.Width = 200;
                ujslider.ValueChanged += LalaKattintott;
                lbGombok.Items.Add(ujslider);
            }
            else if (rad3.IsChecked==true)
            {
                Label ujlabel = new Label();
                ujlabel.Content = "ez egy label.";
               // ujlabel.GotFocus += LalaKattintott;
                lbGombok.Items.Add(ujlabel);
            }
            else
            {
                TextBox ujtextbox = new TextBox();
                ujtextbox.Width = 100;
               // ujtextbox.GotFocus += LalaKattintott;
                lbGombok.Items.Add(ujtextbox);
            }
        }
        //  ujgomb.Click += (s, e) => { this.Title = (s as SButton).Content.ToString(); };
        private void LalaKattintott(object kuldo, RoutedEventArgs vmi)
        {
            Button vezerlo;
            

            if (kuldo is Button)
            {
                vezerlo = kuldo as Button;
                this.Title = vezerlo.Content.ToString();
            }
            else
            {
                //MessageBox.Show("Nem Button küldött ide!");
            }
            //< ListBox x: Name = "lbGombok" Margin = "5" Background = "LightGreen" MouseDoubleClick = "lbGombok_MouseDoubleClick" />
        }

    }
}
