using Model;
using Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using MahApps.Metro.Controls;

namespace Disc
{

    public partial class Login : MetroWindow
    {

        public Login()
        {
            InitializeComponent();


        }



        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();

            lblCarregando.Visibility = Visibility.Visible;
            lblUsuario.Visibility = Visibility.Hidden;
            lblSenha.Visibility = Visibility.Hidden;
            btnLogin.Visibility = Visibility.Hidden;
            btnRegistrar.Visibility = Visibility.Hidden;
            btnSair.Visibility = Visibility.Hidden;
            cmbUsuarios.Visibility = Visibility.Hidden;
            txtPassword.Visibility = Visibility.Hidden;
            btnRecarregar.Visibility = Visibility.Hidden;

            worker.DoWork += (o, ea) =>
            {
                var repoUsuario = new RepositorioUsuario();

                var listaUsuarios = repoUsuario.Liste();



                //no direct interaction with the UI is allowed from this method
                for (int i = 0; i < 2; i++)
                {
                    System.Threading.Thread.Sleep(50);
                }
            };

            worker.RunWorkerCompleted += (o, ea) =>
            {
                //work has completed. you can now interact with the UI
                progress.Visibility = Visibility.Hidden;

                lblUsuario.Visibility = Visibility.Visible;
                lblSenha.Visibility = Visibility.Visible;
                btnLogin.Visibility = Visibility.Visible;
                btnRegistrar.Visibility = Visibility.Visible;
                btnSair.Visibility = Visibility.Visible;
                cmbUsuarios.Visibility = Visibility.Visible;
                txtPassword.Visibility = Visibility.Visible;
                btnRecarregar.Visibility = Visibility.Visible;
                lblCarregando.Visibility = Visibility.Hidden;


                var repoUsuario = new RepositorioUsuario();

                var listaUsuarios = repoUsuario.Liste();

                cmbUsuarios.DataContext = listaUsuarios;

            };



            worker.RunWorkerAsync();
        }

       

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            var usuario = (Usuario)cmbUsuarios.SelectedItem;
            var formPrincipal = new MainWindow(usuario);
            formPrincipal.ShowDialog();

            this.Close();
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {

            var formRegistrar = new FormCadastroDeUsuario();
            formRegistrar.ShowDialog();


        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnRecarregar_Click(object sender, RoutedEventArgs e)
        {
            var repoUsuario = new RepositorioUsuario();
            cmbUsuarios.DataContext = repoUsuario.Liste();
        }
    }
}
