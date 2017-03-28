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


        List<int> D = new List<int>();
        List<int> I = new List<int>();
        List<int> S = new List<int>();
        List<int> C = new List<int>();



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


        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            switch (boxResposta1.SelectedIndex)
            {
                case 0:
                    D.Add(boxResposta1.SelectedIndex);
                    break;
                case 1:
                    I.Add(boxResposta1.SelectedIndex);
                    break;
                case 2:
                    S.Add(boxResposta1.SelectedIndex);
                    break;
                case 3:
                    C.Add(boxResposta1.SelectedIndex);
                    break;
                default:
                    MessageBox.Show("Por favor preencher o primeiro quadrante");
                    D.Clear();
                    I.Clear();
                    S.Clear();
                    C.Clear();
                    return;
            }

            switch (boxResposta2.SelectedIndex)
            {
                case 0:
                    D.Add(boxResposta2.SelectedIndex);
                    break;
                case 1:
                    I.Add(boxResposta2.SelectedIndex);
                    break;
                case 2:
                    S.Add(boxResposta2.SelectedIndex);
                    break;
                case 3:
                    C.Add(boxResposta2.SelectedIndex);
                    break;
                default:
                    MessageBox.Show("Por favor preencher o segundo quadrante");
                    D.Clear();
                    I.Clear();
                    S.Clear();
                    C.Clear();
                    return;
            }

            switch (boxResposta3.SelectedIndex)
            {
                case 0:
                    D.Add(boxResposta3.SelectedIndex);
                    break;
                case 1:
                    I.Add(boxResposta3.SelectedIndex);
                    break;
                case 2:
                    S.Add(boxResposta3.SelectedIndex);
                    break;
                case 3:
                    C.Add(boxResposta3.SelectedIndex);
                    break;
                default:
                    MessageBox.Show("Por favor preencher o Terceiro quadrante");
                    D.Clear();
                    I.Clear();
                    S.Clear();
                    C.Clear();
                    return;
            }

            switch (boxResposta4.SelectedIndex)
            {
                case 0:
                    D.Add(boxResposta4.SelectedIndex);
                    break;
                case 1:
                    I.Add(boxResposta4.SelectedIndex);
                    break;
                case 2:
                    S.Add(boxResposta4.SelectedIndex);
                    break;
                case 3:
                    C.Add(boxResposta4.SelectedIndex);
                    break;
                default:
                    MessageBox.Show("Por favor preencher o quarto quadrante");
                    D.Clear();
                    I.Clear();
                    S.Clear();
                    C.Clear();
                    return;
            }

            switch (boxResposta5.SelectedIndex)
            {
                case 0:
                    D.Add(boxResposta5.SelectedIndex);
                    break;
                case 1:
                    I.Add(boxResposta5.SelectedIndex);
                    break;
                case 2:
                    S.Add(boxResposta5.SelectedIndex);
                    break;
                case 3:
                    C.Add(boxResposta5.SelectedIndex);
                    break;
                default:
                    MessageBox.Show("Por favor preencher o quinto quadrante");
                    D.Clear();
                    I.Clear();
                    S.Clear();
                    C.Clear();
                    return;
            }

            switch (boxResposta6.SelectedIndex)
            {
                case 0:
                    D.Add(boxResposta6.SelectedIndex);
                    break;
                case 1:
                    I.Add(boxResposta6.SelectedIndex);
                    break;
                case 2:
                    S.Add(boxResposta6.SelectedIndex);
                    break;
                case 3:
                    C.Add(boxResposta6.SelectedIndex);
                    break;
                default:
                    MessageBox.Show("Por favor preencher o sexto quadrante");
                    D.Clear();
                    I.Clear();
                    S.Clear();
                    C.Clear();
                    return;
            }

            switch (boxResposta7.SelectedIndex)
            {
                case 0:
                    D.Add(boxResposta7.SelectedIndex);
                    break;
                case 1:
                    I.Add(boxResposta7.SelectedIndex);
                    break;
                case 2:
                    S.Add(boxResposta7.SelectedIndex);
                    break;
                case 3:
                    C.Add(boxResposta7.SelectedIndex);
                    break;
                default:
                    MessageBox.Show("Por favor preencher o sétimo quadrante");
                    D.Clear();
                    I.Clear();
                    S.Clear();
                    C.Clear();
                    return;
            }

            switch (boxResposta8.SelectedIndex)
            {
                case 0:
                    D.Add(boxResposta8.SelectedIndex);
                    break;
                case 1:
                    I.Add(boxResposta8.SelectedIndex);
                    break;
                case 2:
                    S.Add(boxResposta8.SelectedIndex);
                    break;
                case 3:
                    C.Add(boxResposta8.SelectedIndex);
                    break;
                default:
                    MessageBox.Show("Por favor preencher o oitavo quadrante");
                    D.Clear();
                    I.Clear();
                    S.Clear();
                    C.Clear();
                    return;
            }

            switch (boxResposta9.SelectedIndex)
            {
                case 0:
                    D.Add(boxResposta9.SelectedIndex);
                    break;
                case 1:
                    I.Add(boxResposta9.SelectedIndex);
                    break;
                case 2:
                    S.Add(boxResposta9.SelectedIndex);
                    break;
                case 3:
                    C.Add(boxResposta9.SelectedIndex);
                    break;
                default:
                    MessageBox.Show("Por favor preencher o nono quadrante");
                    D.Clear();
                    I.Clear();
                    S.Clear();
                    C.Clear();
                    return;
            }

            switch (boxResposta10.SelectedIndex)
            {
                case 0:
                    D.Add(boxResposta10.SelectedIndex);
                    break;
                case 1:
                    I.Add(boxResposta10.SelectedIndex);
                    break;
                case 2:
                    S.Add(boxResposta10.SelectedIndex);
                    break;
                case 3:
                    C.Add(boxResposta10.SelectedIndex);
                    break;
                default:
                    MessageBox.Show("Por favor preencher o décimo quadrante");
                    D.Clear();
                    I.Clear();
                    S.Clear();
                    C.Clear();
                    return;
            }

            switch (boxResposta11.SelectedIndex)
            {
                case 0:
                    D.Add(boxResposta11.SelectedIndex);
                    break;
                case 1:
                    I.Add(boxResposta11.SelectedIndex);
                    break;
                case 2:
                    S.Add(boxResposta11.SelectedIndex);
                    break;
                case 3:
                    C.Add(boxResposta11.SelectedIndex);
                    break;
                default:
                    MessageBox.Show("Por favor preencher o décimo primeiro quadrante");
                    D.Clear();
                    I.Clear();
                    S.Clear();
                    C.Clear();
                    return;
            }

            switch (boxResposta12.SelectedIndex)
            {
                case 0:
                    D.Add(boxResposta12.SelectedIndex);
                    break;
                case 1:
                    I.Add(boxResposta12.SelectedIndex);
                    break;
                case 2:
                    S.Add(boxResposta12.SelectedIndex);
                    break;
                case 3:
                    C.Add(boxResposta12.SelectedIndex);
                    break;
                default:
                    MessageBox.Show("Por favor preencher o décimo segundo quadrante");
                    D.Clear();
                    I.Clear();
                    S.Clear();
                    C.Clear();
                    return;
            }

            switch (boxResposta13.SelectedIndex)
            {
                case 0:
                    D.Add(boxResposta13.SelectedIndex);
                    break;
                case 1:
                    I.Add(boxResposta13.SelectedIndex);
                    break;
                case 2:
                    S.Add(boxResposta13.SelectedIndex);
                    break;
                case 3:
                    C.Add(boxResposta13.SelectedIndex);
                    break;
                default:
                    MessageBox.Show("Por favor preencher o décimo terceiro quadrante");
                    D.Clear();
                    I.Clear();
                    S.Clear();
                    C.Clear();
                    return;
            }

            switch (boxResposta14.SelectedIndex)
            {
                case 0:
                    D.Add(boxResposta14.SelectedIndex);
                    break;
                case 1:
                    I.Add(boxResposta14.SelectedIndex);
                    break;
                case 2:
                    S.Add(boxResposta14.SelectedIndex);
                    break;
                case 3:
                    C.Add(boxResposta14.SelectedIndex);
                    break;
                default:
                    MessageBox.Show("Por favor preencher o décimo quarto quadrante");
                    D.Clear();
                    I.Clear();
                    S.Clear();
                    C.Clear();
                    return;
            }

            switch (boxResposta15.SelectedIndex)
            {
                case 0:
                    D.Add(boxResposta15.SelectedIndex);
                    break;
                case 1:
                    I.Add(boxResposta15.SelectedIndex);
                    break;
                case 2:
                    S.Add(boxResposta15.SelectedIndex);
                    break;
                case 3:
                    C.Add(boxResposta15.SelectedIndex);
                    break;
                default:
                    MessageBox.Show("Por favor preencher o décimo quinto quadrante");
                    D.Clear();
                    I.Clear();
                    S.Clear();
                    C.Clear();
                    return;
            }

            switch (boxResposta16.SelectedIndex)
            {
                case 0:
                    D.Add(boxResposta16.SelectedIndex);
                    break;
                case 1:
                    I.Add(boxResposta16.SelectedIndex);
                    break;
                case 2:
                    S.Add(boxResposta16.SelectedIndex);
                    break;
                case 3:
                    C.Add(boxResposta16.SelectedIndex);
                    break;
                default:
                    MessageBox.Show("Por favor preencher o décimo sexto quadrante");
                    D.Clear();
                    I.Clear();
                    S.Clear();
                    C.Clear();
                    return;
            }

            switch (boxResposta17.SelectedIndex)
            {
                case 0:
                    D.Add(boxResposta17.SelectedIndex);
                    break;
                case 1:
                    I.Add(boxResposta17.SelectedIndex);
                    break;
                case 2:
                    S.Add(boxResposta17.SelectedIndex);
                    break;
                case 3:
                    C.Add(boxResposta17.SelectedIndex);
                    break;
                default:
                    MessageBox.Show("Por favor preencher o décimo sétimo quadrante");
                    D.Clear();
                    I.Clear();
                    S.Clear();
                    C.Clear();
                    return;
            }

            switch (boxResposta18.SelectedIndex)
            {
                case 0:
                    D.Add(boxResposta18.SelectedIndex);
                    break;
                case 1:
                    I.Add(boxResposta18.SelectedIndex);
                    break;
                case 2:
                    S.Add(boxResposta18.SelectedIndex);
                    break;
                case 3:
                    C.Add(boxResposta18.SelectedIndex);
                    break;
                default:
                    MessageBox.Show("Por favor preencher o décimo oitavo quadrante");
                    D.Clear();
                    I.Clear();
                    S.Clear();
                    C.Clear();
                    return;
            }

            switch (boxResposta19.SelectedIndex)
            {
                case 0:
                    D.Add(boxResposta19.SelectedIndex);
                    break;
                case 1:
                    I.Add(boxResposta19.SelectedIndex);
                    break;
                case 2:
                    S.Add(boxResposta19.SelectedIndex);
                    break;
                case 3:
                    C.Add(boxResposta19.SelectedIndex);
                    break;
                default:
                    MessageBox.Show("Por favor preencher o décimo nono quadrante");
                    D.Clear();
                    I.Clear();
                    S.Clear();
                    C.Clear();
                    return;
            }

            switch (boxResposta20.SelectedIndex)
            {
                case 0:
                    D.Add(boxResposta20.SelectedIndex);
                    break;
                case 1:
                    I.Add(boxResposta20.SelectedIndex);
                    break;
                case 2:
                    S.Add(boxResposta20.SelectedIndex);
                    break;
                case 3:
                    C.Add(boxResposta20.SelectedIndex);
                    break;
                default:
                    MessageBox.Show("Por favor preencher o vigésimo quadrante");
                    D.Clear();
                    I.Clear();
                    S.Clear();
                    C.Clear();
                    return;
            }

            switch (boxResposta21.SelectedIndex)
            {
                case 0:
                    D.Add(boxResposta21.SelectedIndex);
                    break;
                case 1:
                    I.Add(boxResposta21.SelectedIndex);
                    break;
                case 2:
                    S.Add(boxResposta21.SelectedIndex);
                    break;
                case 3:
                    C.Add(boxResposta21.SelectedIndex);
                    break;
                default:
                    MessageBox.Show("Por favor preencher o vigésimo primeiro quadrante");
                    D.Clear();
                    I.Clear();
                    S.Clear();
                    C.Clear();
                    return;
            }

            switch (boxResposta22.SelectedIndex)
            {
                case 0:
                    D.Add(boxResposta22.SelectedIndex);
                    break;
                case 1:
                    I.Add(boxResposta22.SelectedIndex);
                    break;
                case 2:
                    S.Add(boxResposta22.SelectedIndex);
                    break;
                case 3:
                    C.Add(boxResposta22.SelectedIndex);
                    break;
                default:
                    MessageBox.Show("Por favor preencher o vigésimo segundo quadrante");
                    D.Clear();
                    I.Clear();
                    S.Clear();
                    C.Clear();
                    return;
            }

            switch (boxResposta23.SelectedIndex)
            {
                case 0:
                    D.Add(boxResposta23.SelectedIndex);
                    break;
                case 1:
                    I.Add(boxResposta23.SelectedIndex);
                    break;
                case 2:
                    S.Add(boxResposta23.SelectedIndex);
                    break;
                case 3:
                    C.Add(boxResposta23.SelectedIndex);
                    break;
                default:
                    MessageBox.Show("Por favor preencher o vigésimo terceiro quadrante");
                    D.Clear();
                    I.Clear();
                    S.Clear();
                    C.Clear();
                    return;
            }

            switch (boxResposta24.SelectedIndex)
            {
                case 0:
                    D.Add(boxResposta24.SelectedIndex);
                    break;
                case 1:
                    I.Add(boxResposta24.SelectedIndex);
                    break;
                case 2:
                    S.Add(boxResposta24.SelectedIndex);
                    break;
                case 3:
                    C.Add(boxResposta24.SelectedIndex);
                    break;
                default:
                    MessageBox.Show("Por favor preencher o vigésimo quarto quadrante");
                    D.Clear();
                    I.Clear();
                    S.Clear();
                    C.Clear();
                    return;
            }

            switch (boxResposta25.SelectedIndex)
            {
                case 0:
                    D.Add(boxResposta25.SelectedIndex);
                    break;
                case 1:
                    I.Add(boxResposta25.SelectedIndex);
                    break;
                case 2:
                    S.Add(boxResposta25.SelectedIndex);
                    break;
                case 3:
                    C.Add(boxResposta25.SelectedIndex);
                    break;
                default:
                    MessageBox.Show("Por favor preencher o vigésimo quinto quadrante");
                    D.Clear();
                    I.Clear();
                    S.Clear();
                    C.Clear();
                    return;
            }

            switch (boxResposta26.SelectedIndex)
            {
                case 0:
                    D.Add(boxResposta26.SelectedIndex);
                    break;
                case 1:
                    I.Add(boxResposta26.SelectedIndex);
                    break;
                case 2:
                    S.Add(boxResposta26.SelectedIndex);
                    break;
                case 3:
                    C.Add(boxResposta26.SelectedIndex);
                    break;
                default:
                    MessageBox.Show("Por favor preencher o décimo quarto quadrante");
                    D.Clear();
                    I.Clear();
                    S.Clear();
                    C.Clear();
                    return;
            }

            switch (boxResposta27.SelectedIndex)
            {
                case 0:
                    D.Add(boxResposta27.SelectedIndex);
                    break;
                case 1:
                    I.Add(boxResposta27.SelectedIndex);
                    break;
                case 2:
                    S.Add(boxResposta27.SelectedIndex);
                    break;
                case 3:
                    C.Add(boxResposta27.SelectedIndex);
                    break;
                default:
                    MessageBox.Show("Por favor preencher o vigésimo sétimo quadrante");
                    D.Clear();
                    I.Clear();
                    S.Clear();
                    C.Clear();
                    return;
            }

            switch (boxResposta28.SelectedIndex)
            {
                case 0:
                    D.Add(boxResposta28.SelectedIndex);
                    break;
                case 1:
                    I.Add(boxResposta28.SelectedIndex);
                    break;
                case 2:
                    S.Add(boxResposta28.SelectedIndex);
                    break;
                case 3:
                    C.Add(boxResposta28.SelectedIndex);
                    break;
                default:
                    MessageBox.Show("Por favor preencher o vigésimo sétimo quadrante");
                    D.Clear();
                    I.Clear();
                    S.Clear();
                    C.Clear();
                    return;
            }

            MessageBox.Show("Valor D " + D.Count().ToString());
            MessageBox.Show("Valor I " + I.Count().ToString());
            MessageBox.Show("Valor S " + S.Count().ToString());
            MessageBox.Show("Valor C " + C.Count().ToString());


            D.Clear();
            I.Clear();
            S.Clear();
            C.Clear();
        }
    }


}
