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
using FeelGoodTable.Domain_Layer;

namespace FeelGoodTable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public EmployeeRepo repo = new EmployeeRepo();
        public List<EmpInsert> empInserts = new List<EmpInsert>();
        public MainWindow()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
            AddControls();
            InsertControlValue();
        }

        public void AddControls()
        {
            empInserts.Add(new EmpInsert(textblock1, img1, mood1));
            empInserts.Add(new EmpInsert(textblock2, img2, mood2));
        }

        public void InsertControlValue()
        {
            int count = 0;
            foreach (Employee employee in repo.employees)
            {
                empInserts[count].Name.Text = employee.Name;
                empInserts[count].Mood.Source = new BitmapImage(new Uri("Assets/" + repo.employees[count].Mood, UriKind.Relative));
                count++;
            }
        }
    }
}
