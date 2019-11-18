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

namespace ControlDeUsuario
{
    /// <summary>
    /// Lógica de interacción para SelectorDirectorio.xaml
    /// </summary>
    public partial class SelectorDirectorio : UserControl
    {
        public SelectorDirectorio()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public string Titulo
        {
            get { return (string)GetValue(TituloProperty); }
            set { SetValue(TituloProperty, value); }
        }

        public string RutaDirectorio
        {
            get { return (string)GetValue(RutaDirectorioProperty); }
            set { SetValue(RutaDirectorioProperty, value); }
        }

        public static readonly DependencyProperty TituloProperty =
            DependencyProperty.Register("Titulo", typeof(string), typeof(SelectorDirectorio), new PropertyMetadata(""));
        public static readonly DependencyProperty RutaDirectorioProperty =
            DependencyProperty.Register("RutaDirectorio", typeof(string), typeof(SelectorDirectorio), new PropertyMetadata(""));


        private void SeleccionarDirectorioButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dialogo = new System.Windows.Forms.FolderBrowserDialog();

            //Mostramos el diálogo
            System.Windows.Forms.DialogResult resultado = dialogo.ShowDialog();

            //Comprobamos si el usuario ha pulsado el botón Aceptar
            if (resultado == System.Windows.Forms.DialogResult.OK)
            {
                //Accedemos a la ruta seleccionada por el usuario
                string ruta = dialogo.SelectedPath;
                RutaTextBox.Text = ruta;
                RutaDirectorio = ruta;
                
            }
        }
    }
}
