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
using static System.Math;

namespace PR_1_task_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TbAnswerP.Clear();
            TbAnswerS.Clear();
            if (!double.TryParse(TbX1.Text, out double x1))
            {
                MessageBox.Show("Поле X1 только число");
            }
            if (!double.TryParse(TbY1.Text, out double y1))
            {
                MessageBox.Show("Поле Y1 только число");
            }
            if (!double.TryParse(TbX2.Text, out double x2))
            {
                MessageBox.Show("Поле X2 только число");
            }
            if (!double.TryParse(TbY2.Text, out double y2))
            {
                MessageBox.Show("Поле Y2 только число");
            }
            if (!double.TryParse(TbX3.Text, out double x3))
            {
                MessageBox.Show("Поле X3 только число");
            }
            if (!double.TryParse(TbY3.Text, out double y3))
            {
                MessageBox.Show("Поле Y3 только число");
            }
            double P, S, p, a, b, c;
            a = Sqrt(Pow((x2 - x1), 2) + Pow((y2 - y1), 2));
            b = Sqrt(Pow((x3 - x2), 2) + Pow((y3 - y2), 2));
            c = Sqrt(Pow((x3 - x1), 2) + Pow((y3 - y1), 2));
            p = (a + b + c) / 2;
            P = a + b + c;
            S = Sqrt(p * (p - a) * (p - b) * (p - c));
            TbAnswerP.Text += P;
            TbAnswerS.Text += S;
        }
    }
}
