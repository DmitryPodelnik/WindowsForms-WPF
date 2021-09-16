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

namespace _21._11._20__EXAM
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
                MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
          
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
                    if (mainWindow.mainCalendar.SelectedDate.Value.ToShortDateString() != datePicker1.SelectedDate.Value.ToShortDateString()
                        || mainWindow.mainCalendar.Visibility == Visibility.Hidden)
                    { 
                        MainWindow.ExactEventInfo.Remove(newEvent);
                    }
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
                    int index = 0;

                    foreach (var item in MainWindow.EventsInfo)
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

                            foreach (var it in MainWindow.ExactEventInfo)
                            {
                                if (item.Date == it.Date && item.Name == it.Name && item.Severity == it.Severity)
                                {
                                    break;
                                }
                                index++;
                            }

                            break;
                        }
                    }
                    MainWindow.EventsInfo.Remove(prevItem);
                    MainWindow.ExactEventInfo.RemoveAt(index);
                    MainWindow.AddNewEvent(newItem);
                    if (mainWindow.mainCalendar.SelectedDate.Value.ToShortDateString() != datePicker1.SelectedDate.Value.ToShortDateString())
                    {
                        MainWindow.ExactEventInfo.Remove(newItem);
                    }
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

            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;

            //deleteEvent.IsEnabled = true;

            if (mainWindow.mainListBox.SelectedItem != null && MainWindow.AddTaskOpen == false)
            {
                deleteButt.IsEnabled = true;
            }
            if (MainWindow.AddTaskOpen == true)
            {
                deleteButt.IsEnabled = false;
            }
        }

        void EventAddition_Closing(object sender, CancelEventArgs e)
        {
            MainWindow.OpenWindow = false;
            MainWindow.AddTaskOpen = false;
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;

                MessageBoxResult result = MessageBox.Show("Are you sure to delete the event?", "Delete confirmation", MessageBoxButton.YesNo);

                if (result == MessageBoxResult.Yes)
                {
                    string selectedItem = mainWindow.mainListBox.SelectedItem.ToString();

                    foreach (var item in MainWindow.EventsInfo)
                    {
                        if (mainWindow.mainListBox.SelectedItem.ToString().Contains(item.Name)
                            && mainWindow.mainListBox.SelectedItem.ToString().Contains(item.Severity.ToString()))
                        {
                            MainWindow.EventsInfo.Remove(item);
                            break;
                        }
                    }

                    foreach (var item in MainWindow.ExactEventInfo)
                    {
                        if (mainWindow.mainListBox.SelectedItem.ToString().Contains(item.Name)
                            && mainWindow.mainListBox.SelectedItem.ToString().Contains(item.Severity.ToString()))
                        {
                            MainWindow.ExactEventInfo.Remove(item);
                            break;
                        }
                    }
                }
                this.Close();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
