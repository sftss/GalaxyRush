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

namespace GalaxyRush
{
    /// <summary>
    /// Logique d'interaction pour CommentJouer.xaml
    /// </summary>
    public partial class CommentJouer : Window
    {
        public CommentJouer()
        {
            InitializeComponent();
        }
        private void Retour_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}
