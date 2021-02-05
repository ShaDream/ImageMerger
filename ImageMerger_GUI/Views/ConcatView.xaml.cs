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
using ImageMerger;
using ImageMerger.ViewModels;

namespace ImageMerger_GUI.Views
{
    /// <summary>
    /// Логика взаимодействия для ConcatView.xaml
    /// </summary>
    public partial class ConcatView : Page
    {
        public ConcatView(StartSettings settings)
        {
            InitializeComponent();
            DataContext = new ConcatViewModel(settings);
        }
    }
}
