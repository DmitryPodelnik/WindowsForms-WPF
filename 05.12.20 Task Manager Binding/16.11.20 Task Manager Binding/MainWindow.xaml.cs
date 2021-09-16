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
using System.Xml;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace _16._11._20_Task_Manager_Binding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static ObservableCollection<EventInfo> _eventsInfo = new ObservableCollection<EventInfo>();
        private static ObservableCollection<EventInfo> _exactEventsInfo = new ObservableCollection<EventInfo>();

        public static ObservableCollection<EventInfo> EventsInfo
        {
            get => _eventsInfo;
        }

        public static bool OpenWindow { get; set; }
        public string SelecDate
        {
            get { return (string)GetValue(SelecDateProperty); }
            set { SetValue(SelecDateProperty, value); }
        }

        public static readonly DependencyProperty SelecDateProperty = DependencyProperty.Register("SelecDate", typeof(string), typeof(MainWindow), new UIPropertyMetadata(null));


        public static void AddNewEvent(EventInfo nEvent)
        {
            _eventsInfo.Add(nEvent);
            _exactEventsInfo.Add(nEvent);
        }
        public static ObservableCollection<EventInfo> EventInfo
        {
            get => _eventsInfo;
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load("events.xml");

                // получаем корневой элемент
                XmlElement xRoot = xDoc.DocumentElement;

                // обход всех узлов в корневом элементе
                foreach (XmlNode xnode in xRoot)
                {
                    EventInfo newEvent = new EventInfo();

                    // получаем атрибут name
                    if (xnode.Attributes.Count > 0)
                    {
                        XmlNode attr = xnode.Attributes.GetNamedItem("name");
                        if (attr != null)
                        {
                            newEvent.Name = attr.Value;
                        }
                    }
                    // обходим все дочерние узлы элемента event
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        // если узел - date
                        if (childnode.Name == "date")
                        {
                            newEvent.Date = Convert.ToDateTime(childnode.InnerText);
                        }
                        if (childnode.Name == "severity")
                        {
                            newEvent.Severity = Int32.Parse(childnode.InnerText);
                        }
                        if (childnode.Name == "description")
                        {
                            newEvent.Description = childnode.InnerText;
                        }                      
                        
                        
                    }
                    _eventsInfo.Add(new EventInfo(newEvent.Date, newEvent.Name, newEvent.Severity));

                    foreach (var item in _eventsInfo)
                    {
                        if (mainCalendar.DisplayDate.ToShortDateString().Equals(newEvent.Date.ToShortDateString()))
                        {
                            //string listItem = $"Name:{newEvent.Name} Severity: {newEvent.Severity}";
                            _exactEventsInfo.Add(new EventInfo(newEvent.Date, newEvent.Name, newEvent.Severity));
                        }
                    }
                }
                deleteEvent.IsEnabled = false;
                mainListBox.ItemsSource = _exactEventsInfo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        void MainWindow_Closing(object sender, CancelEventArgs e)
        {
            try
            {
                DeleteAllXmlNodes();

                XmlDocument xDoc = new XmlDocument();
                xDoc.Load("events.xml");
                XmlElement xRoot = xDoc.DocumentElement;

                foreach (var ev in _eventsInfo)
                {
                    XmlElement eventElem;
                    // создаем новый элемент event
                    eventElem = xDoc.CreateElement("event");
                    // создаем атрибут name
                    XmlAttribute nameAttr = xDoc.CreateAttribute("name");
                    // создаем атрибус severity
                    XmlAttribute severityAttr = xDoc.CreateAttribute("severity");
                    // создаем элемент description
                    XmlElement descriptionElem = xDoc.CreateElement("description");
                    // создаем элемент date
                    XmlElement dateElem = xDoc.CreateElement("date");
                    // создаем текстовые значения для элементов и атрибута
                    XmlText nameText = xDoc.CreateTextNode(ev.Name);
                    XmlText severityText = xDoc.CreateTextNode(ev.Severity.ToString());
                    XmlText dateText = xDoc.CreateTextNode(ev.Date.ToShortDateString());
                    XmlText descriptionText = xDoc.CreateTextNode(ev.Description);

                    //добавляем узлы
                    nameAttr.AppendChild(nameText);
                    severityAttr.AppendChild(severityText);
                    descriptionElem.AppendChild(descriptionText);
                    dateElem.AppendChild(dateText);
                    eventElem.Attributes.Append(nameAttr);
                    eventElem.Attributes.Append(severityAttr);
                    eventElem.AppendChild(dateElem);
                    eventElem.AppendChild(descriptionElem);
                    xRoot.AppendChild(eventElem);
                }
                xDoc.Save("events.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void DeleteAllXmlNodes()
        {
            try
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load("events.xml");

                // получаем корневой элемент
                XmlElement xRoot = xDoc.DocumentElement;

                xRoot.RemoveAll();
                xDoc.Save("events.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (OpenWindow == true)
                {
                    return;
                }
                if (Convert.ToDateTime(((DateTime)mainCalendar.SelectedDate.Value).ToShortDateString()) 
                                                < Convert.ToDateTime(DateTime.Now.ToShortDateString()))
                {
                    throw new ArgumentException("Date must be bigger than today!");
                }

                EventAddition eventAddition = new EventAddition();
                eventAddition.DataContext = this;
                eventAddition.Owner = this;
                eventAddition.Show();
                OpenWindow = true;
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

        private void ListBoxItem_MouseDoubleClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (this.mainListBox.SelectedItem == null)
                {
                    return;
                }
                if (OpenWindow == true)
                {
                    return;
                }
                if (Convert.ToDateTime(((DateTime)mainCalendar.SelectedDate.Value).ToShortDateString())
                                                < Convert.ToDateTime(DateTime.Now.ToShortDateString()))
                {
                    throw new ArgumentException("Date must be bigger than today!");
                }

                EventAddition editWindow = new EventAddition("Event Edition");
                editWindow.DataContext = this;
                editWindow.Owner = this;
                editWindow.Show();
                OpenWindow = true;

                if (editWindow.datePicker1.SelectedDate == null)
                {
                    editWindow.datePicker1.SelectedDate = mainCalendar.DisplayDate;
                }

                string selectedItem = mainListBox.SelectedItem.ToString();

                foreach (var item in _eventsInfo)
                {
                    if (item.Date == editWindow.datePicker1.SelectedDate && selectedItem.Contains(item.Name)
                                                         && selectedItem.Contains(item.Severity.ToString()))
                    {
                        editWindow.nameTextBox.Text = item.Name;
                        editWindow.textTextBox.Text = item.Description;
                        editWindow.severitySlider.Value = item.Severity;

                        if (editWindow.Title == "Event Edition")
                        {
                            EventAddition.Event.Name = editWindow.nameTextBox.Text;
                            EventAddition.Event.Severity = (int)editWindow.severitySlider.Value;
                            EventAddition.Event.Description = editWindow.textTextBox.Text;
                            EventAddition.Event.Date = (DateTime)editWindow.datePicker1.SelectedDate;
                        }

                        break;
                    }
                }
                editWindow.Show();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch(ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            deleteEvent.IsEnabled = true;

            if (mainListBox.SelectedItem == null)
            {
                deleteEvent.IsEnabled = false;
            }
        }

        private void deleteEvent_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string selectedItem = mainListBox.SelectedItem.ToString();

                foreach (var item in _eventsInfo)
                {
                    if (mainListBox.SelectedItem.ToString().Contains(item.Name)
                        && mainListBox.SelectedItem.ToString().Contains(item.Severity.ToString()))
                    {
                        _eventsInfo.Remove(item);
                        break;
                    }
                }

                foreach (var item in _exactEventsInfo)
                {
                    if (mainListBox.SelectedItem.ToString().Contains(item.Name)
                        && mainListBox.SelectedItem.ToString().Contains(item.Severity.ToString()))
                    {
                        _exactEventsInfo.Remove(item);
                        break;
                    }
                }
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

        private void MainCalendar_SelectedDatesChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            try
            {

                _exactEventsInfo.Clear();
                //mainListBox.Items.Clear();

                DateTime tempDate = (DateTime)mainCalendar.SelectedDate;

                foreach (var item in _eventsInfo)
                {
                    if (tempDate.ToShortDateString().Equals(item.Date.ToShortDateString()))
                    {
                        // string listItem = $"Name:{item.Name} Severity: {item.Severity}";
                        // mainListBox.Items.Add(listItem);
                        _exactEventsInfo.Add(new EventInfo(item.Date, item.Name, item.Severity));
                    }
                }
                mainListBox.ItemsSource = _exactEventsInfo;
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (ArgumentException ex)
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
