﻿using System;
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

namespace Disc
{
   
    public partial class MainWindow 
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            flyMenu.IsOpen = true;
            
        }

        private void btnNovoTeste_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTestesFeitos_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            var formCadastro = new FormCadastroDeUsuario();
            formCadastro.ShowDialog();

           

        }

       

    }




}