using Model;
using Repositorio;
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

namespace Disc
{
    
    public partial class Login 
    {
      
        public Login()
        {
            InitializeComponent();
           
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var repoUsuario = new RepositorioUsuario();

            var listaUsuarios = repoUsuario.Liste();
            cmbUsuarios.DataContext = listaUsuarios;
             

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            var formPrincipal = new MainWindow();
            formPrincipal.ShowDialog();
            this.Close();
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            var formRegistrar = new FormCadastroDeUsuario();
            formRegistrar.ShowDialog();
            this.Close();
        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
