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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculatrice
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

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            Button memoryButton = e.OriginalSource as Button;
            if (memoryButton is not null)
            {
                MessageBox.Show($"Operation Pressed : {memoryButton.Content} {sender.GetType().Name} {e.OriginalSource.GetType().Name}");
            }
        }

        private void MemoryButton_Click(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            Button memoryButton = e.OriginalSource as Button;
            if(memoryButton is not null)
            {
                MessageBox.Show($"Memory Pressed : {memoryButton.Content} {sender.GetType().Name} {e.OriginalSource.GetType().Name}");
            }            
        }

        private void NumericButton_Click(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            Button memoryButton = e.OriginalSource as Button;
            if (memoryButton is not null)
            {
                MessageBox.Show($"Numeric Pressed : {memoryButton.Content} {sender.GetType().Name} {e.OriginalSource.GetType().Name}");

                if (Screen.Text == "0")
                    Screen.Text = memoryButton.Content.ToString();
                else
                    Screen.Text += memoryButton.Content.ToString();
            }
        }
    }
}
