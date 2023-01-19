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

namespace PickACardUI
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
            string[] pickedCards = CardPicker.PickSomeCards((int)numberOfCards.Value);  /*The int casting operator is used to cast the numberOfCards.Value to an int, 
                                                                                         * if numberOfCards.Value is not already an int, this could cause an exception.*/
            listOfCards.Items.Clear();  //clear the items in the ListBox
            foreach (string card in pickedCards)
            {
                listOfCards.Items.Add(card);  //add the ites in the ListBox
            }
        }
    }
}
