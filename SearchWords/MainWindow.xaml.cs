using System;
using System.Collections.Generic;
using System.Windows;

namespace SearchWords
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text.Length > 1 || textBox1.Text.Length < 1)
            {
                MessageBox.Show("Вы ввели не букву!");
            }
            else
            {
                string[] str1 = textBox2.Text.Split(' ');
                label1.Content = "";

                for (int i = 0; i < str1.Length; i++)
                {
                    if (Convert.ToString(str1[i][0]).Contains(textBox1.Text))
                        label1.Content += str1[i] + " ";
                }
            }
        }
    }
}
