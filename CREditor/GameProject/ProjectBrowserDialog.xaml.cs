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

namespace CREditor.GameProject
{
    /// <summary>
    /// Lógica de interacción para ProjectBrowserDialog.xaml
    /// </summary>
    public partial class ProjectBrowserDialog : Window
    {
        public ProjectBrowserDialog()
        {
            InitializeComponent();
        }

        private void OnToggleButton_Click(object sender, RoutedEventArgs e)
        {
            if(sender == openProjectButton)
            {
                if(createProjectButton.IsChecked == true)
                {
                    createProjectButton.IsChecked = false;
                    browserContent.Margin = new Thickness(0);
                }
                openProjectButton.IsChecked = true;
            }
            else
            {
                if (openProjectButton.IsChecked == true)
                {
                    openProjectButton.IsChecked = false;
                    browserContent.Margin = new Thickness(-800,0,0,0);
                }
                createProjectButton.IsChecked = true;
            }
        }
    }
}
