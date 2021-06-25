using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using WpfMed.Model;
using Wpfprobnic.Model;


namespace WpfMed
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {




        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;
            Globals.dataProvider = new LocalDataProvider();
            BookList = Globals.dataProvider.GetYear();
            YearAList = Globals.dataProvider.GetYearA().ToList();
            YearAList.Insert(0, new Book { Title = "Все Диагнозы" });


        }



        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        public event PropertyChangedEventHandler PropertyChanged;


        private void Invalidate()
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs("BookList"));
        }



        public List<Book> YearAList { get; set; }

        public string SelectedBreed { get; set; } = "Все Года";



        private IEnumerable<Book> _BookList = null;
        public IEnumerable<Book> BookList
        {
            get
            {
                var res = _BookList
                    .Where(c => (SelectedBreed == "Все года" || c.Year == SelectedBreed));
                if (SearchFilter != "")
                    res = res.Where(c => c.Year.IndexOf(SearchFilter, StringComparison.OrdinalIgnoreCase) >= 0);


                if (SortAsc) res = res.OrderBy(c => c.Year);
                else res = res.OrderByDescending(c => c.Year);
                return res;
            }
            set
            {
                _BookList = value;
            }
        }
        private void NameFilterComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedBreed = (NameFilterComboBox.SelectedItem as YearA).Title;
            Invalidate();
        }


        private string SearchFilter = "";

        private void SearchFilter_KeyUp(object sender, KeyEventArgs e)
        {
            SearchFilter = SearchFilterTextBox.Text;
            Invalidate();

        }

        private void SearchFilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            SearchFilter = SearchFilterTextBox.Text;
            Invalidate();
        }
        private bool SortAsc = true;
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            SortAsc = (sender as RadioButton).Tag.ToString() == "1";
            Invalidate();
        }
    }
}