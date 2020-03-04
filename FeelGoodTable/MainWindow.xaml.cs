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
using System.Windows.Threading;

namespace FeelGoodTable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<EmpInsert> empInserts = new List<EmpInsert>();

        public MainWindow()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;

            //VIGTIGSTE KODE I MANDS MINDE!!!!!!
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int i = 0;
            i++;
            if (i == 1)
            {
                i = 0;
                AddControls();
                InsertControlValue();
            }
        }
        //DET SLUTTER HER

        public void AddControls()
        {
            empInserts.Add(new EmpInsert(textblock1, img1, mood1));
            empInserts.Add(new EmpInsert(textblock2, img2, mood2));
            empInserts.Add(new EmpInsert(textblock3, img3, mood3));
            empInserts.Add(new EmpInsert(textblock4, img4, mood4));
            empInserts.Add(new EmpInsert(textblock5, img5, mood5));
            empInserts.Add(new EmpInsert(textblock6, img6, mood6));
            empInserts.Add(new EmpInsert(textblock7, img7, mood7));
            empInserts.Add(new EmpInsert(textblock8, img8, mood8));
            empInserts.Add(new EmpInsert(textblock9, img9, mood9));
            empInserts.Add(new EmpInsert(textblock10, img10, mood10));
            empInserts.Add(new EmpInsert(textblock11, img11, mood11));
            empInserts.Add(new EmpInsert(textblock12, img12, mood12));
            empInserts.Add(new EmpInsert(textblock13, img13, mood13));
            empInserts.Add(new EmpInsert(textblock14, img14, mood14));
            empInserts.Add(new EmpInsert(textblock15, img15, mood15));
            empInserts.Add(new EmpInsert(textblock16, img16, mood16));
            empInserts.Add(new EmpInsert(textblock17, img17, mood17));
            empInserts.Add(new EmpInsert(textblock18, img18, mood18));
            empInserts.Add(new EmpInsert(textblock19, img19, mood19));
            empInserts.Add(new EmpInsert(textblock20, img20, mood20));
            empInserts.Add(new EmpInsert(textblock21, img21, mood21));
            empInserts.Add(new EmpInsert(textblock22, img22, mood22));
            empInserts.Add(new EmpInsert(textblock23, img23, mood23));
            empInserts.Add(new EmpInsert(textblock24, img24, mood24));
            empInserts.Add(new EmpInsert(textblock25, img25, mood25));
            empInserts.Add(new EmpInsert(textblock26, img26, mood26));
            empInserts.Add(new EmpInsert(textblock27, img27, mood27));
            empInserts.Add(new EmpInsert(textblock28, img28, mood28));
            empInserts.Add(new EmpInsert(textblock29, img29, mood29));
            empInserts.Add(new EmpInsert(textblock30, img30, mood30));
            empInserts.Add(new EmpInsert(textblock31, img31, mood31));
            empInserts.Add(new EmpInsert(textblock32, img32, mood32));
            empInserts.Add(new EmpInsert(textblock33, img33, mood33));
            empInserts.Add(new EmpInsert(textblock34, img34, mood34));
            empInserts.Add(new EmpInsert(textblock35, img35, mood35));
            empInserts.Add(new EmpInsert(textblock36, img36, mood36));
            empInserts.Add(new EmpInsert(textblock37, img37, mood37));
            empInserts.Add(new EmpInsert(textblock38, img38, mood38));
            empInserts.Add(new EmpInsert(textblock39, img39, mood39));
            empInserts.Add(new EmpInsert(textblock40, img40, mood40));
            empInserts.Add(new EmpInsert(textblock41, img41, mood41));
            empInserts.Add(new EmpInsert(textblock42, img42, mood42));
            empInserts.Add(new EmpInsert(textblock43, img43, mood43));
            empInserts.Add(new EmpInsert(textblock44, img44, mood44));
            empInserts.Add(new EmpInsert(textblock45, img45, mood45));
            empInserts.Add(new EmpInsert(textblock46, img46, mood46));
            empInserts.Add(new EmpInsert(textblock47, img47, mood47));
            empInserts.Add(new EmpInsert(textblock48, img48, mood48));
            empInserts.Add(new EmpInsert(textblock49, img49, mood49));
            empInserts.Add(new EmpInsert(textblock50, img50, mood50));
            empInserts.Add(new EmpInsert(textblock51, img51, mood51));
            empInserts.Add(new EmpInsert(textblock52, img52, mood52));
            empInserts.Add(new EmpInsert(textblock53, img53, mood53));
        }

        public void InsertControlValue()
        {
            EmployeeRepo repo = new EmployeeRepo();
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
