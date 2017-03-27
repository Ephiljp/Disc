using MahApps.Metro.Controls.Dialogs;
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
    /// <summary>
    /// Interaction logic for FormCadastroDeUsuario.xaml
    /// </summary>
    public partial class FormCadastroDeUsuario 
    {
        public Usuario Usuario { get; set; }
        public FormCadastroDeUsuario()
        {
            InitializeComponent();
            this.DataContext = new Usuario();
        }

        public FormCadastroDeUsuario(Usuario usuario)
        {
            InitializeComponent();

            this.DataContext = usuario;
            txtNome.IsEnabled = false;

        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            var usuario = (Usuario)this.DataContext;

            var repositorio = new RepositorioUsuario();


            if (usuario.Codigo == 0)
            {
                if (txtSenha.Password != txtConfSenha.Password)
                {
                    MessageBox.Show("As senhas devem ser iguais");
                    return;
                }

                if (string.IsNullOrEmpty(txtSenha.Password) || string.IsNullOrEmpty(txtConfSenha.Password))
                {
                    MessageBox.Show("A senha deve ser informada");
                    return;
                }
                usuario.Senha = txtSenha.Password;

            }


            if (usuario.Codigo == 0)
            {
                foreach (var item in repositorio.Liste())
                {
                    if (item.Nome == usuario.Nome)
                    {
                        MessageBox.Show("Usuario já existe");
                        return;
                    }
                }
                repositorio.Adicione(usuario);                //Cadastrar no banco de dados!!
            }
            else if (txtSenha.Password != txtConfSenha.Password)
            {
                MessageBox.Show("As senhas devem ser iguais");
                return;
            }
            else
            {
                MessageBox.Show("Senha alterada com sucesso");
                usuario.Senha = txtSenha.Password;
                //Editando
                repositorio.Atualize(usuario);   //Atualizar no banco de dados!! 
            }
            
               
            this.Close();
            
        }
    }
}
