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

namespace First_WPF_09._02._2021
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ApplyButtom_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(DescriptionText.Text))
                MessageBox.Show("Поле Description пустое");
            else
                MessageBox.Show($"This DescriptionTextBox text is : {DescriptionText.Text}");
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            WeldCheckBox.IsChecked = AssemblyCheckBox.IsChecked = PlasmaCheckBox.IsChecked = LaserCheckBox.IsChecked =
                PurchaseCheckBox.IsChecked = LatheCheckBox.IsChecked = DrillCheckBox.IsChecked = FoldCheckBox.IsChecked =
                RollCheckBox.IsChecked = SawCheckBox.IsChecked = false;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            LengthTextBox.Text += $"{((CheckBox)sender).Content}, ";
        }

        private void FinishSelected_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (NoteText == null)
                return;
         
            
             var combo = (ComboBox)sender;
             var value = (ComboBoxItem)combo.SelectedValue;
             NoteText.Text = (string)value.Content;
          
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FinishSelected_SelectionChanged(this.FinishDropDown, null);   
        }

        private void SupplierNameText_TextChanged(object sender, TextChangedEventArgs e)
        {
            MassText.Text = SupplierNameText.Text;
        }
    }
}
