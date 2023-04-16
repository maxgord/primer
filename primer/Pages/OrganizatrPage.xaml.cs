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

namespace primer.Pages
{
    /// <summary>
    /// Логика взаимодействия для OrganizatrPage.xaml
    /// </summary>
    public partial class OrganizatrPage : Page
    {
        public OrganizatrPage(Polzovateli s = null)
        {
            InitializeComponent();
            DataContext = this;
            Info = s;

            if (s != null)
            {
                FIO.Content = s.FIO;
            }

        }
        public Polzovateli Info { get; set; }
    }
}
