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

namespace Formula1Pilots
{
    //class created for F1 pilots
    class F1Pilot
    {
        public string name;
        public int wins;
        public int entries;
        public string country;

        public F1Pilot(string row)
        {
            string[] fileRow = row.Split(';');
            name = fileRow[0];
            wins = Convert.ToInt32(fileRow[1]);
            entries = Convert.ToInt32(fileRow[2]);
            country = fileRow[3];
        }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<F1Pilot> f1Pilots;
        public MainWindow()
        {
            InitializeComponent();
            string[] file = File.ReadAllLines("results.txt");
            f1Pilots = new List<F1Pilot>();
            foreach(var i in file)
            {
                f1Pilots.Add(new F1Pilot(i));
            }
            foreach (var a in f1Pilots)
            {
                lbNames.Items.Add(a.name);
            }
            foreach (var b in f1Pilots)
            {
                cbDriverStats.Items.Add(b.name);
            }

            //Setting the default value for the combo box
            cbDriverStats.SelectedIndex = 0;
        }

        public void dataWrite (string driverStat)
        {
            for (int i = 0; i < f1Pilots.Count; i++)
            {
                if (f1Pilots[i].name == driverStat)
                {
                    break;
                }
                lbStats.Content = f1Pilots[i].name;
            }
        }
        

        // Most wins button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string maxName = "";
            int max = f1Pilots[0].wins;
            foreach(var i in f1Pilots)
            {
                if(i.wins > max)
                {
                    max = i.wins;
                    maxName = i.name;
                }
            }
            MessageBox.Show("The drive with the most wins: " + maxName + ". Number of wins: " + max + ".");
        }

        //Least entries button
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string leastName = "";
            int least = f1Pilots[0].entries;
            foreach(var i in f1Pilots)
            {
                if(i.entries < least)
                {
                    least = i.entries;
                    leastName = i.name;
                }
            }
            MessageBox.Show("The driver with the least amount of entries: " + leastName + ". Number of entries: " + least + ".");
        }

        private void cbDriverStats_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (var i in f1Pilots)
            {
                if (i.name == cbDriverStats.SelectedValue)
                {
                    lbStats.Content = "Name: " + i.name + "\nWins: " + i.wins + "\nEntries: " + i.entries + "\nNationality: " + i.country;
                    break;
                }
            }
        }

        private void btBetween_Click(object sender, RoutedEventArgs e)
        {
            string betweenWins = "";            
            foreach (var i in f1Pilots)
            {
                if ((i.wins >= 40) && (i.wins <= 90))
                {
                    betweenWins += i.name + ": " + i.wins + " victories\n";
                }
            }
            MessageBox.Show(betweenWins);
        }

        private void bt98_Click(object sender, RoutedEventArgs e)
        {
            foreach (var i in f1Pilots)
            {
                if (i.wins == 98)
                {
                    MessageBox.Show(i.name + " has 98 wins.");
                    break;
                }
            }
        }

        private void btWinOrder_Click(object sender, RoutedEventArgs e)
        {
            List<F1Pilot> f1wins;
            F1Pilot c;
            int max;
            lbNames.Items.Clear();

            for (int i = f1Pilots.Count - 1; i >= 0; i --)
            {
                max = i;
                for (int j = 0; j <=  i; j++)
                {
                    if (f1Pilots[j].wins > f1Pilots[max].wins)
                    {
                        max = j;                       
                    }
                }
                c = f1Pilots[i];
                f1Pilots[i] = f1Pilots[max];
                f1Pilots[max] = c;
            }
            foreach (var k in f1Pilots)
            {
                lbNames.Items.Add(k.name);
            }
        }
    }
}
