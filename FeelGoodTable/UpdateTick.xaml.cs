﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FeelGoodTable
{
    /// <summary>
    /// Interaction logic for UpdateTick.xaml
    /// </summary>
    public partial class UpdateTick : Window
    {
        public UpdateTick()
        {
            InitializeComponent();
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
