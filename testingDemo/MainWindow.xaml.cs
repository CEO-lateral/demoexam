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

namespace testingDemo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        testingDbEntities db;
        public MainWindow()
        {
            InitializeComponent();
            db = new testingDbEntities();
            ChangeDbSet(0);
        }

        private void ChangeDbSet(int type)
        {

            switch (type) {
                case 0:
                    box.SelectedIndex = 0;
                    grid.ItemsSource = db.ResidentialComplex.ToList();
                    break;
                case 1:
                    box.SelectedIndex = 1;
                    grid.ItemsSource = db.House.ToList();
                    break;
                case 2:
                    box.SelectedIndex = 2;
                    grid.ItemsSource = db.Apartment.ToList();
                    break;
            }
            
        }

        private void Box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ChangeDbSet(box.SelectedIndex);
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            //MainWindow mw = new MainWindow();
           this.Close();
        }
    }
}
