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

namespace Logik_IT1A
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Brush barva1;
        Brush barva2;
        Brush barva3;
        Brush barva4;

        public MainWindow()
        {
            InitializeComponent();
            Prvnikolo();
            GenerujBarvy();
        }
        private Brush GenerujBarvu()
        {
            Random random = new Random();
            int cislo = random.Next(1, 7);
            if(cislo == 1)
            {
                return  Brushes.Red;
            }
            else if(cislo == 2)
            {
                return Brushes.Green;
            }
            else if(cislo == 3)
            {
                return Brushes.Blue;
            }
            else if(cislo == 4)
            {
                return Brushes.Yellow;
            }
            else if(cislo == 5)
            {
                return Brushes.Orange;
            }
            else if(cislo == 6)
            {
                return Brushes.Purple;
            }
            return Brushes.Red;

           
        }

        private void GenerujBarvy()
        {
            barva1 = GenerujBarvu();
            barva2 = GenerujBarvu();
            barva3 = GenerujBarvu();
            barva4 = GenerujBarvu();
        }


        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)

        {
            Ellipse ellipse = (Ellipse)sender;//přetypování na Ellipse
            if (ellipse.Fill.ToString() == "#FFF7F7F7")
            {
                ellipse.Fill = Brushes.Red;
            }
            else if (ellipse.Fill.ToString() == Brushes.Red.ToString())
            {
                ellipse.Fill = Brushes.Green;
            }
            else if (ellipse.Fill.ToString() == Brushes.Green.ToString())
            {
                ellipse.Fill = Brushes.Blue;
            }
            else if (ellipse.Fill.ToString() == Brushes.Blue.ToString())
            {
                ellipse.Fill = Brushes.Yellow;
            }
            else if (ellipse.Fill.ToString() == Brushes.Yellow.ToString())
            {
                ellipse.Fill = Brushes.Orange;
            }
            else if (ellipse.Fill.ToString() == Brushes.Orange.ToString())
            {
                ellipse.Fill = Brushes.Purple;
            }
            else
            {
                ellipse.Fill = Brushes.Red;


            }
        }
       


        private void NastavKoloDisabled(Ellipse ellipse)
        {
            ellipse.IsEnabled = false;
            ellipse.Stroke = Brushes.Gray;
            ellipse.Fill = Brushes.White;

        }




        private void Prvnikolo()
        {
            Kruh_0_0.IsEnabled = true;
            Kruh_0_1.IsEnabled = true;
            Kruh_0_2.IsEnabled = true;
            Kruh_0_3.IsEnabled = true;


            NastavKoloDisabled(Kruh_1_0);
            NastavKoloDisabled(Kruh_1_1);
            NastavKoloDisabled(Kruh_1_2);
            NastavKoloDisabled(Kruh_1_3);


            NastavKoloDisabled(Kruh_2_0);
            NastavKoloDisabled(Kruh_2_1);
            NastavKoloDisabled(Kruh_2_2);
            NastavKoloDisabled(Kruh_2_3);


            NastavKoloDisabled(Kruh_3_0);
            NastavKoloDisabled(Kruh_3_1);
            NastavKoloDisabled(Kruh_3_2);
            NastavKoloDisabled(Kruh_3_3);



            NastavKoloDisabled(Kruh_4_0);
            NastavKoloDisabled(Kruh_4_1);
            NastavKoloDisabled(Kruh_4_2);
            NastavKoloDisabled(Kruh_4_3);


            NastavKoloDisabled(Kruh_5_0);
            NastavKoloDisabled(Kruh_5_1);
            NastavKoloDisabled(Kruh_5_2);
            NastavKoloDisabled(Kruh_5_3);


            NastavKoloDisabled(Kruh_6_0);
            NastavKoloDisabled(Kruh_6_1);
            NastavKoloDisabled(Kruh_6_2);
            NastavKoloDisabled(Kruh_6_3);


            NastavKoloDisabled(Kruh_7_0);
            NastavKoloDisabled(Kruh_7_1);
            NastavKoloDisabled(Kruh_7_2);
            NastavKoloDisabled(Kruh_7_3);


            NastavKoloDisabled(Kruh_8_0);
            NastavKoloDisabled(Kruh_8_1);
            NastavKoloDisabled(Kruh_8_2);
            NastavKoloDisabled(Kruh_8_3);








        }
       

        

        private void BtnVyhodnotit_Click(object sender, RoutedEventArgs e)
        {

            int cerna = 0;
            if(barva1 == Kruh_0_0.Fill)
            {
                cerna = 1;
            }
            else if(barva2 == Kruh_0_0.Fill)|
            {
                bila++;
            }
            if (barva2 == Kruh_0_1.Fill)
            {
                cerna++;
            }
            if (barva3 == Kruh_0_2.Fill)
            {
                cerna++;
            }
            if (barva4 == Kruh_0_3.Fill)
            {
                cerna++;
            }





        }

        private void NovaHra_Click(object sender, RoutedEventArgs e)
        {

        }
    }
      
    }

