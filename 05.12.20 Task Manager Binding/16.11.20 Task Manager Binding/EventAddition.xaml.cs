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
using System.Windows.Shapes;

namespace _16._11._20_Task_Manager_Binding
{
    /// <summary>
    /// Interaction logic for EventAddition.xaml
    /// </summary>
    public partial class EventAddition : Window
    {
        private static EventInfo _event = new EventInfo();
        public EventAddition()
        {
            InitializeComponent();
        }
        public EventAddition(string title)
        {
            InitializeComponent();

            Title = title;
        }

        public static EventInfo Event
        {
            get => _event;
        }


        private void addEvent_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (this.Title == "Event Addition")
                {
                    if (Convert.ToDateTime(((DateTime)datePicker1.SelectedDate.Value).ToShortDateString())
                                                < Convert.ToDateTime(DateTime.Now.ToShortDateString()))
                    {
                        throw new ArgumentException("Date must be bigger than today!");
                    }
                    EventInfo newEvent = new EventInfo();
                    newEvent.Name = nameTextBox.Text;
                    newEvent.Date = (DateTime)datePicker1.SelectedDate;
                    newEvent.Description = textTextBox.Text;
                    newEvent.Severity = (int)severitySlider.Value;

                    MainWindow.AddNewEvent(newEvent);

                }
                else
                {
                    if (Convert.ToDateTime(((DateTime)datePicker1.SelectedDate.Value).ToShortDateString())
                                                < Convert.ToDateTime(DateTime.Now.ToShortDateString()))
                    {
                        throw new ArgumentException("Date must be bigger than today!");
                    }
                    EventInfo newItem = new EventInfo();
                    EventInfo prevItem = new EventInfo();

                    foreach (var item in MainWindow.EventInfo)
                    {
                        if (item.Name.Equals(_event.Name)
                            && item.Severity.Equals(_event.Severity)
                          )//&& item.Description.Equals(_event.Description)
                        {
                            newItem.Name = nameTextBox.Text;
                            newItem.Severity = (int)severitySlider.Value;
                            newItem.Date = (DateTime)datePicker1.SelectedDate;
                            newItem.Description = textTextBox.Text;

                            prevItem = item;
                        }
                    }
                    MainWindow.EventInfo.Remove(prevItem);
                    MainWindow.AddNewEvent(newItem);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void deleteEvent_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void EventAddition_Loaded(object sender, RoutedEventArgs e)
        {
            deleteEvent.Focus();
        }

        void EventAddition_Closing(object sender, CancelEventArgs e)
        {
            MainWindow.OpenWindow = false;
        }
    }
}
