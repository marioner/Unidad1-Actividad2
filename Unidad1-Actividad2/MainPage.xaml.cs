using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Unidad1_Actividad2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        float total,cuenta;
        int comensales;

       /* private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void monto_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
        */
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (masDeCinco.IsSelected == true)
            {
                texto2.Text = "Ingresa el número de personas:";
                textBox1.Visibility = Visibility.Visible;
   
            }
            else
            {              
                texto2.Text = "";
                textBox1.Visibility = Visibility.Collapsed;
                comensales = personas.SelectedIndex;
                comensales = comensales + 1;
            }

            
        }//cierre combo box

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            var aux = (TextBox)sender;
            var aux2 = aux.Text.ToString();
            comensales = Convert.ToInt32(aux2);
        }

        private void calcular_Click(object sender, RoutedEventArgs e)
        {
            cuenta = Convert.ToInt32(monto.Text);

            if (sinPropina.IsChecked == true)
            {
                total = cuenta / comensales;
                texto4.Visibility = Visibility.Visible;
                resultado.Text = Convert.ToString(total);
            }
            else if (propina10.IsChecked == true)
            {
                total = (float)(cuenta * 1.1) / comensales;
                texto4.Visibility = Visibility.Visible;
                resultado.Text = Convert.ToString(total);
            }
            else {
                total = (float)(cuenta * 1.5) / comensales;
                texto4.Visibility = Visibility.Visible;
                resultado.Text = Convert.ToString(total);
            }
                

        }
    }
}
