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
using Repositorio;

namespace Disc
{
   
    public partial class FormNovoTeste : MetroWindow
    {
        public Usuario usuario { get; set; }
        RepositorioResposta repositorio;

        

        public FormNovoTeste()
        {
            InitializeComponent();

            repositorio = new RepositorioResposta();
        }

        public FormNovoTeste(Usuario Usuario)
        {
            InitializeComponent();

            this.usuario = Usuario;

            repositorio = new RepositorioResposta();

        }

        
        private void btnVolta_Click(object sender, RoutedEventArgs e)
        {
            tab1.IsSelected = true;
        }

        private void btnIr_Click(object sender, RoutedEventArgs e)
        {
            if (boxResposta01.SelectedItem == null)
            {
                MessageBox.Show("Selecione alguma resposta do quadrante 1");
                return;
            }

        
           
            

            if (boxResposta2.SelectedItem ==null)
            {
                MessageBox.Show("Selecione alguma resposta do quadrante 2");
                return;
            }
         
               
            
            MessageBox.Show("Os n são");

            tab2.IsSelected = true;
        }

       
    }
    
    
}
