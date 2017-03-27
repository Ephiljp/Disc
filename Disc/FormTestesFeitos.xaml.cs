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
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using Model;

namespace Disc
{
   
    public partial class FormTestesFeitos : MetroWindow
    {
        public Usuario usuario { get; set; }
        public FormTestesFeitos()
        {
            InitializeComponent();
        }


        public FormTestesFeitos(Usuario Usuario)
        {
            InitializeComponent();

            this.usuario = Usuario;
        }

        private void btnNovoTeste_Click(object sender, RoutedEventArgs e)
        {
            var formNovoteste =new  FormNovoTeste();
            formNovoteste.ShowDialog();

        }
    }
}
