using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace App_Desk3
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

        private void b_ordenar_Click(object sender, RoutedEventArgs e)
        {
            b_ordenar.IsEnabled = false;
            b_cancelar.IsEnabled = false;
            

 

            if (ck_01.IsChecked == false && ck_02.IsChecked == false
            && ck_03.IsChecked == false && ck_04.IsChecked == false
            && ck_05.IsChecked == false)
            {

                l_precio.Content = "DEBE SELECCIONAR UNA PIZZA CON LA ORDEN";

            } else
            {
                double total = 0.0;

                //Seleccion de pizzas
                if (ck_01.IsChecked == true) total += 350.00;
                if (ck_02.IsChecked == true) total += 450.00;
                if (ck_03.IsChecked == true) total += 500.00;
                if (ck_04.IsChecked == true) total += 650.00;
                if (ck_05.IsChecked == true) total += 700.00;
                //Seleccion de bebidas
                if (rb_01.IsChecked == true) total += 100.00;
                if (rb_02.IsChecked == true) total += 80.00;
                if (rb_03.IsChecked == true) total += 75.00;
                if (rb_04.IsChecked == true) total += 40.00;
                if (rb_05.IsChecked == true) total += 35.00;
                if (rb_06.IsChecked == true) total += 60.00;
                if (rb_07.IsChecked == true) total += 75.00;

                l_precio.Content = $"{total}.00$RD";
            }
        }

        private void b_cancelar_Click(object sender, RoutedEventArgs e)
        {

            //Checkbox de pizzas
            ck_01.IsChecked = false;
            ck_02.IsChecked = false;
            ck_03.IsChecked = false;
            ck_04.IsChecked = false;
            ck_05.IsChecked = false;
            //Radiobutton de bebidas
            rb_01.IsChecked = false;
            rb_02.IsChecked = false; 
            rb_03.IsChecked = false;
            rb_04.IsChecked = false;
            rb_05.IsChecked = false;
            rb_06.IsChecked = false;
            rb_07.IsChecked = false;

            l_precio.Content = "0.00$RD";

            if(b_cancelar.IsEnabled == true)
            {
                b_ordenar.IsEnabled = true;
            }

        }

        private void b_volver_ordenar_Click(object sender, RoutedEventArgs e)
        {
            b_ordenar.IsEnabled = true;
            b_cancelar.IsEnabled = true;
            l_precio.Content = $"0.00$RD";
        }

        private void b_clear_Click(object sender, RoutedEventArgs e)
        {

            l_precio.Content = $"0.00$RD";

            //Checkbox de pizzas
            ck_01.IsChecked = false;
            ck_02.IsChecked = false;
            ck_03.IsChecked = false;
            ck_04.IsChecked = false;
            ck_05.IsChecked = false;
            //Radiobutton de bebidas
            rb_01.IsChecked = false;
            rb_02.IsChecked = false;
            rb_03.IsChecked = false;
            rb_04.IsChecked = false;
            rb_05.IsChecked = false;
            rb_06.IsChecked = false;
            rb_07.IsChecked = false;

        }

        private void b_exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}