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
using System.IO;
using Microsoft.Win32;

namespace Language
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        ЛангуагеEntities db;
        List<Client> bruh;
        List<Client> bruh2;
        int i;
        int kolvo1;
        string kolvo = "";
        public MainWindow()
        {
            InitializeComponent();
            db = new ЛангуагеEntities();
            bruh = db.Client.ToList();
            //DataGridClient.ItemsSource = bruh.TakeWhile(b => b.ID <= 150);
            bruh2 = db.Client.ToList();
            string[] items = { "10", "50", "200", "Все" };
            kolvoBox.ItemsSource = items;
            kolvoBox.SelectedIndex = 3;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            i = 0;
            bruh2.Clear();
            
            kolvo = kolvoBox.SelectedValue.ToString();
            if (kolvo == "Все")
            {
                DataGridClient.ItemsSource = bruh;
            }
            else if (kolvo != "")
            {
                kolvo1 = Convert.ToInt32(kolvo);
                if (kolvo1 >= db.Client.Count())
                {
                    DataGridClient.ItemsSource = bruh;
                }
                else
                {
                    foreach (var clients in db.Client)
                    {
                        if (i < kolvo1)
                        {
                            bruh2.Add(clients);
                            i++;
                        }
                        else
                        {
                            break;
                        }

                    }
                    DataGridClient.ItemsSource = new List<Client>();
                    DataGridClient.ItemsSource = bruh2;
                }
                
            }
            

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            int j = 0;
            bruh2.Clear();
            if (kolvo != "Все" && !(kolvo1 >= bruh.Count()))
            {
                foreach (var clients in db.Client)
                {
                    if ( j >= i-kolvo1*2 && j<kolvo1+(i - kolvo1 * 2))
                    {
                        bruh2.Add(clients);
                        j++;
                    }
                    else
                    {
                       j++;
                    }
                }
                i = i - kolvo1;
                DataGridClient.ItemsSource = new List<Client>();
                DataGridClient.ItemsSource = bruh2;
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            int j = 0;
            bruh2.Clear();
            if (kolvo != "Все" && !(kolvo1 >= bruh.Count()) && !(i >= bruh.Count()))
              {
                foreach (var clients in db.Client)
                {
                    if (j < kolvo1+i && j >= i)
                    {
                        bruh2.Add(clients);
                        j++;
                    }
                    else
                    {
                        j++;
                    }
                }
                i = kolvo1 + i ;
                DataGridClient.ItemsSource = new List<Client>();
                DataGridClient.ItemsSource = bruh2;
            }
        }

        private void AddPhoto_Click(object sender, RoutedEventArgs e)
        {
            PhotoWindow photoWindow = new PhotoWindow();
            photoWindow.ShowDialog();
        }
    }
}
