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

namespace _13._11._20_Controls
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

        private void CheckA2Button_Click(object sender, RoutedEventArgs e)
        {
            uint markA2 = 0;

            if (this.secondFouthWill.IsChecked == true)
            {
                markA2 += 10;
            }
            if (this.secondFouthMade.IsChecked == true)
            {
                markA2 += 10;
            }
            if (this.thirdFouthHost.IsChecked == true)
            {
                markA2 += 10;
            }
            if (this.firstA2.Text == "is" || this.firstA2.Text == "Is")
            {
                markA2 += 10;
            }
            if (this.secondA2.Text == "does" || this.secondA2.Text == "Does")
            {
                markA2 += 10;
            }
            if (this.thirdA2.Text == "were" || this.thirdA2.Text == "Were")
            {
                markA2 += 10;
            }
            if (this.fifthA2.Text == "on" || this.firstA2.Text == "On")
            {
                markA2 += 10;
            }
            if (this.seventhA2.Text == "does" || this.seventhA2.Text == "Does")
            {
                markA2 += 10;
            }
            if (this.ninthA2.Text == "shoot" || this.ninthA2.Text == "Shoot")
            {
                markA2 += 10;
            }
            if (this.tenthA2.Text == "like" || this.tenthA2.Text == "Like")
            {
                markA2 += 10;
            }

            this.markLabelA2.Content = $"Mark: {markA2}/100";
        }

        private void CheckB1Button_Click(object sender, RoutedEventArgs e)
        {
            uint markB1 = 0;

            if (this.secondFouthWithPleasure.IsChecked == true)
            {
                markB1 += 10;
            }
            if (this.secondSixthOn.IsChecked == true)
            {
                markB1 += 10;
            }
            if (this.firstEighthSomething.IsChecked == true)
            {
                markB1 += 10;
            }
            if (this.firstB1.Text == "I have visited Spain and Hungary")
            {
                markB1 += 10;
            }
            if (this.secondB1.Text == "They are 10")
            {
                markB1 += 10;
            }
            if (this.thirdB1.Text == "They are a fur hat, boots and a coat")
            {
                markB1 += 10;
            }
            if (this.fifthB1.Text == "to" || this.fifthB1.Text == "To")
            {
                markB1 += 10;
            }
            if (this.seventhB1.Text == "busy" || this.seventhB1.Text == "Busy")
            {
                markB1 += 10;
            }
            if (this.ninthB1.Text == "The children are flying kites")
            {
                markB1 += 10;
            }
            if (this.tenthB1.Text == "Sentence" || this.tenthB1.Text == "sentence")
            {
                markB1 += 10;
            }


            this.markLabelB1.Content = $"Mark: {markB1}/100";
        }
    }
}
