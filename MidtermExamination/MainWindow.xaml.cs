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

namespace MidtermExamination
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calculate_price_Click(object sender, RoutedEventArgs e)
        {
            output.Items.Clear();

            output.Items.Add("JOE'S FRUIT STAND");
            double Banana = 0.19;
            double Oranges = 3.99;
            double Apple = 2.40;
            double total = 0;
            double Delivery = 0;


            Banana = double.Parse(tb_banana.Text) * Banana; ;
            Oranges = double.Parse(tb_Oranges.Text) * Oranges; ;
            Apple = double.Parse(tb_Apple.Text) * Apple;
            total = Apple + Oranges + Banana + Delivery;
            if (total < 25)
            { Delivery = 10; };


            output.Items.Add("The quantity of apple is"+" "+" "+" "+tb_Apple.Text+" "+ ","+"The Price of apple $" + " " + Apple);
           output.Items.Add("The quantity of Banana is" + " " + " "+ tb_banana.Text+" "+","+ "The price of banana $" + " " + Banana);
             output.Items.Add("The quantity of Orange is" + " " +" "+ tb_Oranges.Text+" "+","+ "The price of oranges $" + " " + " " + Oranges); 
            output.Items.Add(  "Your Delivery fee is $" + " " + Delivery);
            output.Items.Add("Your Total price $" + " " + total + " " + Delivery);







        }

        private void save_Click(object sender, RoutedEventArgs e)
        {

            const string sPath = "C:\\Users\\soibifaa\\Desktop\\visualstudio\\TotalPrice.txt";

            if (output.Items.IsEmpty)
            {
                MessageBox.Show("Cannot save empty Document", "Please enter a Valid number");
            }

            else
            {
                System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
                foreach (var item in output.Items)

                {

                    SaveFile.WriteLine(item);
                }
                SaveFile.Close();
            }

            if (output.Items.Count >= 1)
                MessageBox.Show("Your file has been saved", "file saved");


        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            tb_Oranges.Clear();
            tb_banana.Clear();
            tb_Apple.Clear();
            output.Items.Clear();
        }
    }
    }

        
 


