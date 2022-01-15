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
using System.Linq;

namespace ClientContractWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public void Client_Search_ReadOnly(bool isTrue)
        {
            if (isTrue)
            {
                Client_Org_Search.IsReadOnly = true;
                Client_Address_Search.IsReadOnly = true;
                Client_Cheff_Search.IsReadOnly = true;
                Client_Org_Search.Background = new SolidColorBrush(Color.FromRgb(171, 173, 179));
                Client_Address_Search.Background = new SolidColorBrush(Color.FromRgb(171, 173, 179));
                Client_Cheff_Search.Background = new SolidColorBrush(Color.FromRgb(171, 173, 179));
            }
            else
            {
                Client_Org_Search.IsReadOnly = false;
                Client_Address_Search.IsReadOnly = false;
                Client_Cheff_Search.IsReadOnly = false;
                Client_Org_Search.Background = Brushes.White;
                Client_Address_Search.Background = Brushes.White;
                Client_Cheff_Search.Background = Brushes.White;
            }
        }
        public void Client_Edit_ReadOnly(bool isTrue)
        {
            if (isTrue)
            {
                Client_Org_Edit.IsReadOnly = true;
                Client_Address_Edit.IsReadOnly = true;
                Client_Cheff_Edit.IsReadOnly = true;
                Client_Org_Edit.Background = new SolidColorBrush(Color.FromRgb(171, 173, 179));
                Client_Address_Edit.Background = new SolidColorBrush(Color.FromRgb(171, 173, 179));
                Client_Cheff_Edit.Background = new SolidColorBrush(Color.FromRgb(171, 173, 179));
            }
            else
            {
                Client_Org_Edit.IsReadOnly = false;
                Client_Address_Edit.IsReadOnly = false;
                Client_Cheff_Edit.IsReadOnly = false;
                Client_Org_Edit.Background = Brushes.White;
                Client_Address_Edit.Background = Brushes.White;
                Client_Cheff_Edit.Background = Brushes.White;
            }
        }
        public void Contract_Search_ReadOnly(bool isTrue)
        {
            if (isTrue)
            {
                Contract_Date_Search.IsHitTestVisible = false;
                Contract_Date_Search.Focusable = false;
                Contract_Hour_Search.IsEditable = false;
                Contract_Hour_Search.IsHitTestVisible = false;
                Contract_Hour_Search.Focusable = false;
                Contract_Minute_Search.IsEditable = false;
                Contract_Minute_Search.IsHitTestVisible = false;
                Contract_Minute_Search.Focusable = false;
                Contract_Sum_Search.IsReadOnly = true;
                Contract_Date_Search.Background = new SolidColorBrush(Color.FromRgb(171, 173, 179));
                Contract_Sum_Search.Background = new SolidColorBrush(Color.FromRgb(171, 173, 179));
            }
            else
            {
                Contract_Date_Search.IsHitTestVisible = true;
                Contract_Date_Search.Focusable = true;
                Contract_Hour_Search.IsEditable = true;
                Contract_Hour_Search.IsHitTestVisible = true;
                Contract_Hour_Search.Focusable = true;
                Contract_Minute_Search.IsEditable = true;
                Contract_Minute_Search.IsHitTestVisible = true;
                Contract_Minute_Search.Focusable = true;
                Contract_Sum_Search.IsReadOnly = false;
                Contract_Date_Search.Background = Brushes.White;
                Contract_Sum_Search.Background = Brushes.White;
            }
        }
        public void Contract_Edit_ReadOnly(bool isTrue)
        {
            if (isTrue)
            {
                Contract_Date_Edit.IsHitTestVisible = false;
                Contract_Date_Edit.Focusable = false;
                Contract_Hour_Edit.IsEditable = false;
                Contract_Hour_Edit.IsHitTestVisible = false;
                Contract_Hour_Edit.Focusable = false;
                Contract_Minute_Edit.IsEditable = false;
                Contract_Minute_Edit.IsHitTestVisible = false;
                Contract_Minute_Edit.Focusable = false;
                Contract_Sum_Edit.IsReadOnly = true;
                Contract_Date_Edit.Background = new SolidColorBrush(Color.FromRgb(171, 173, 179));
                Contract_Sum_Edit.Background = new SolidColorBrush(Color.FromRgb(171, 173, 179));
            }
            else
            {
                Contract_Date_Edit.IsHitTestVisible = true;
                Contract_Date_Edit.Focusable = true;
                Contract_Hour_Edit.IsEditable = true;
                Contract_Hour_Edit.IsHitTestVisible = true;
                Contract_Hour_Edit.Focusable = true;
                Contract_Minute_Edit.IsEditable = true;
                Contract_Minute_Edit.IsHitTestVisible = true;
                Contract_Minute_Edit.Focusable = true;
                Contract_Sum_Edit.IsReadOnly = false;
                Contract_Date_Edit.Background = Brushes.White;
                Contract_Sum_Edit.Background = Brushes.White;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            using (AppContext db = new AppContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
                Client_Grid.ItemsSource = db.Clients.ToList<Client>();
                Contract_Grid.ItemsSource = db.Contracts.ToList<Contract>();
            }
            Contract_Hour_Search.IsReadOnly = true;
            Contract_Hour_Edit.IsReadOnly = true;
            Contract_Minute_Search.IsReadOnly = true;
            Contract_Minute_Edit.IsReadOnly = true;
            Client_Search_ReadOnly(true);
            Client_Edit_ReadOnly(true);
            Contract_Search_ReadOnly(true);
            Contract_Edit_ReadOnly(true);
            for (int i = 0; i < 24; i++)
            {
                Contract_Hour_Edit.Items.Insert(i, i);
                Contract_Hour_Search.Items.Insert(i, i);
            }
            for (int i = 0; i < 61; i++)
            {
                Contract_Minute_Edit.Items.Insert(i, i);
                Contract_Minute_Search.Items.Insert(i, i);
            }
            Contract_Hour_Edit.SelectedIndex = 0;
            Contract_Hour_Search.SelectedIndex = 0;
            Contract_Minute_Edit.SelectedIndex = 0;
            Contract_Minute_Search.SelectedIndex = 0;
        }

        private void Client_Search_radio_Checked(object sender, RoutedEventArgs e)
        {
            Client_Search_ReadOnly(false);
            Contract_Search_ReadOnly(true);

        }

        private void Contract_Search_radio_Checked(object sender, RoutedEventArgs e)
        {
            Client_Search_ReadOnly(true);
            Contract_Search_ReadOnly(false);
        }

        private void Client_Edit_radio_Checked(object sender, RoutedEventArgs e)
        {
            Client_Edit_ReadOnly(false);
            Contract_Edit_ReadOnly(true);
        }

        private void Contract_Edit_radio_Checked(object sender, RoutedEventArgs e)
        {
            Client_Edit_ReadOnly(true);
            Contract_Edit_ReadOnly(false);
        }



        private void Client_Org_Search_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }

        private void Client_Org_Search_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsLetter(e.Text, 0));
        }

        private void Client_Address_Search_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }

        private void Client_Address_Search_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsLetter(e.Text, 0));
        }

        private void Client_Cheff_Search_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }

        private void Client_Cheff_Search_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsLetter(e.Text, 0));
        }

        private void Contract_Sum_Search_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }

        private void Contract_Sum_Search_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }

        private void Client_Org_Edit_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }

        private void Client_Org_Edit_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsLetter(e.Text, 0));
        }

        private void Client_Address_Edit_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }

        private void Client_Address_Edit_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsLetter(e.Text, 0));
        }

        private void Client_Cheff_Edit_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }

        private void Client_Cheff_Edit_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsLetter(e.Text, 0));
        }

        private void Contract_Sum_Edit_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }

        private void Contract_Sum_Edit_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }

        private void Client_Search_Click(object sender, RoutedEventArgs e)
        {
            if (Client_Search_radio.IsChecked == true)
            {

            }
            else if (Contract_Search_radio.IsChecked == true)
            {

            }
            else
                MessageBox.Show("Выберите что нужно найти!");
        }

        private void DB_Add_Click(object sender, RoutedEventArgs e)
        {
            if (Client_Edit_radio.IsChecked == true)
            {
                using (AppContext db = new AppContext())
                {
                    Client client = new Client { orgName = Client_Org_Edit.Text, adress = Client_Address_Edit.Text, cheff = Client_Cheff_Edit.Text };
                    db.Clients.Add(client);
                    db.SaveChanges();
                    Client_Grid.ItemsSource = db.Clients.ToList<Client>();
                }
            }
            else if (Contract_Edit_radio.IsChecked == true)
            {
                //DateTime dateTime = Convert.ToDateTime(Contract_Date_Edit.SelectedDate.Value.Date.ToShortDateString());
                //int hour = (int)Contract_Hour_Edit.SelectedItem;
                //int minute = (int)Contract_Minute_Edit.SelectedItem;
                //dateTime = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, hour, minute, 0);
                int selectedColumn = Client_Grid.CurrentCell.Column.DisplayIndex;
                var selectedCell = Client_Grid.SelectedCells[selectedColumn];
                var cellContent = selectedCell.Column.GetCellContent(selectedCell.Item);
                if (cellContent is TextBlock)
                {
                    MessageBox.Show((cellContent as TextBlock).Text);
                }
                //using (AppContext db = new AppContext())
                //{
                //    Contract contract = new Contract { date = dateTime, sum = int.Parse(Contract_Sum_Edit.Text), clientId =  }
                //}
            }
            else
                MessageBox.Show("Выберите что нужно добавить!");
        }

        private void DB_Edit_Click(object sender, RoutedEventArgs e)
        {
            if (Client_Edit_radio.IsChecked == true)
            {
                
            }
            else if (Contract_Edit_radio.IsChecked == true)
            {

            }
            else
                MessageBox.Show("Выберите что нужно отредактировать!");
        }
    }
}
