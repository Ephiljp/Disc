using Model;
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
      
        public FormCadastroDeUsuario()
        {
            InitializeComponent();
            this.DataContext = new Usuario();
        }

        public FormCadastroDeUsuario(Usuario usuario)
        {
            InitializeComponent();

            this.DataContext = usuario;

        }

      
    }
}
