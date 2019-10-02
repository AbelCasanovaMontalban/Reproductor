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

namespace Reproductor
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Trailer2RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            ReproductorMediaElement.Source= new Uri(@"C:\Users\alumno\source\repos\Reproductor\Reproductor\trailer2.mp4");
            ReproductorMediaElement.Play();
        }

        private void Trailer1RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            ReproductorMediaElement.Source = new Uri(@"C:\Users\alumno\source\repos\Reproductor\Reproductor\trailer1.mp4");
            ReproductorMediaElement.Play();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button boton = sender as Button;
            if (boton.Name=="PlayButton")
            {
                ReproductorMediaElement.Play();
            }
            else if (boton.Name=="PauseButton")
            {
                ReproductorMediaElement.Pause();
            }
            else
            {
                ReproductorMediaElement.Stop();
            }

        }

        private void SilenciarCheckBox_CheckedOrNot(object sender, RoutedEventArgs e)
        {
            CheckBox silenciar = sender as CheckBox;
            if (silenciar.IsChecked==true)
            {
                ReproductorMediaElement.IsMuted = true;
            }
            else
            {
                ReproductorMediaElement.IsMuted = false;
            }
            
        }
    }
}
