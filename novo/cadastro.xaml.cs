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
using System.Windows.Shapes;

namespace novo
{
    /// <summary>
    /// Lógica interna para cadastro.xaml
    /// </summary>
    public partial class cadastro : Window
    {
        public cadastro()
        {
            InitializeComponent();
        }

        private void Salvar_Click(object sender, RoutedEventArgs e)
        {
            curso curs = new curso();
            curs.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            curso c = new curso();
            c.Show();
        }
    }
}
