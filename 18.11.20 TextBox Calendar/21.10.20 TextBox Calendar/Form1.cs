using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Linq.Expressions;
using System.IO;
using System.Xml;

namespace _21._10._20_TextBox_Calendar
{
    public partial class Form1 : Form
    {
        private List<EventInfo> _eventsInfo = new List<EventInfo>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
                        if (xnode.Name == "event")
                        {
                            monthCalendar1.AddBoldedDate(newEvent.Date);
                            _eventsInfo.Add(new EventInfo(newEvent.Date, newEvent.Name, Condition.EVENT));
                        }
                        else if (xnode.Name == "birthdate")
                        {
                            monthCalendar1.AddAnnuallyBoldedDate(newEvent.Date);
                            _eventsInfo.Add(new EventInfo(newEvent.Date, newEvent.Name, Condition.BIRTHDATE));
                        }
                    }
                }
                monthCalendar1.UpdateBoldedDates();
                textBox2.Text = (new DateTime(monthCalendar1.SelectionRange.Start.Year,
                                       monthCalendar1.SelectionRange.Start.Month,
                                       monthCalendar1.SelectionRange.Start.Day).ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Console.WriteLine(ex.Message);
            }
        }
        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
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
                    if (ev.Condition.Equals(Condition.EVENT))
                    {
                        eventElem = xDoc.CreateElement("event");
                    }
                    else
                    {
                        eventElem = xDoc.CreateElement("birthdate");
                    }
                    // создаем атрибут name
                    XmlAttribute nameAttr = xDoc.CreateAttribute("name");
                    // создаем элементы year, genre и date
                    XmlElement dateElem = xDoc.CreateElement("date");
                    // создаем текстовые значения для элементов и атрибута
                    XmlText nameText = xDoc.CreateTextNode(ev.Name);
                    XmlText dateText = xDoc.CreateTextNode(ev.Date.ToShortDateString());

                    //добавляем узлы
                    nameAttr.AppendChild(nameText);
                    dateElem.AppendChild(dateText);
                    eventElem.Attributes.Append(nameAttr);
                    eventElem.AppendChild(dateElem);
                    xRoot.AppendChild(eventElem);
                }
                xDoc.Save("events.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            groupBox1.Enabled = Enabled;
            textBox2.ReadOnly = false;
            textBox1.ReadOnly = false;
            textBox2.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            textBox2.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you want to delete the event?", "Message",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    DateTime t1 = new DateTime();
                    t1 = Convert.ToDateTime(textBox2.Text);

                    int i = 0;
                    foreach (var item in _eventsInfo)
                    {
                        if (t1.ToShortDateString() == item.Date.ToShortDateString())
                        {
                            _eventsInfo.RemoveAt(i);
                            listBox1.Items.Remove(item.Name);
                            if (item.Condition.Equals(Condition.EVENT))
                            {
                                monthCalendar1.RemoveBoldedDate(t1);
                            }
                            else
                            {
                                monthCalendar1.RemoveAnnuallyBoldedDate(t1);
                            }
                            break;
                        }
                        i++;
                    }
                }
                textBox1.Text = "";
                monthCalendar1.UpdateBoldedDates();
                listBox1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            try
            {
                button1.Enabled = true;
                button3.Enabled = false;
                button2.Enabled = false;
                groupBox1.Enabled = false;
                textBox1.Text = "";
                textBox2.Text = (new DateTime(monthCalendar1.SelectionRange.Start.Year,
                                           monthCalendar1.SelectionRange.Start.Month,
                                           monthCalendar1.SelectionRange.Start.Day).ToString());

                DateTime t1 = new DateTime(monthCalendar1.SelectionRange.Start.Year,
                                           monthCalendar1.SelectionRange.Start.Month,
                                           monthCalendar1.SelectionRange.Start.Day);

                listBox1.Items.Clear();

                foreach (var item in _eventsInfo)
                {
                    if (t1.ToShortDateString() == item.Date.ToShortDateString())
                    {
                        listBox1.Items.Add(item.Name);
                        button3.Enabled = true;
                        button2.Enabled = true;
                        textBox1.ReadOnly = true;
                        groupBox1.Enabled = true;
                        textBox1.Text = item.Name;
                        textBox2.ReadOnly = true;
                        textBox2.Text = item.Date.ToString();
                        if (item.Condition.Equals(Condition.EVENT))
                        {
                            radioButton1.Checked = true;
                        }
                        else if (item.Condition.Equals(Condition.BIRTHDATE))
                        {
                            radioButton2.Checked = true;
                        }
                    }
                }
                listBox1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime t1 = Convert.ToDateTime(textBox2.Text);
                if (t1 < DateTime.Now)
                {
                    throw new ArgumentException("Date must be bigger than today!");
                }

                bool temp = false;
                bool checkDateTime = false;

                //string eventName;
                int i = 0;
                foreach (var item in _eventsInfo)
                {
                    if (t1.ToShortDateString() == item.Date.ToShortDateString()
                        && t1.ToShortTimeString() == item.Date.ToShortTimeString())
                    {
                        checkDateTime = true;
                        temp = true;
                        break;
                    }
                    i++;
                }

                if (checkDateTime == true)
                {
                    throw new ArgumentException("An event is already added on this date.");
                }

                if (temp == false)
                {
                    if (radioButton1.Checked)
                    {
                        monthCalendar1.AddBoldedDate(t1);
                        _eventsInfo.Add(new EventInfo(t1, textBox1.Text, Condition.EVENT));
                    }
                    else if (radioButton2.Checked)
                    {
                        monthCalendar1.AddAnnuallyBoldedDate(t1);
                        _eventsInfo.Add(new EventInfo(t1, textBox1.Text, Condition.BIRTHDATE));
                    }
                    listBox1.Items.Add(textBox1.Text);
                    monthCalendar1.UpdateBoldedDates();
                }
                else
                {
                    _eventsInfo[i].Name = textBox1.Text;
                    _eventsInfo[i].Condition = radioButton1.Checked ? Condition.EVENT : Condition.BIRTHDATE;
                }
                listBox1.Refresh();
                textBox1.Text = "";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                foreach (var item in _eventsInfo)
                {
                    if (DateTime.Now.ToShortTimeString() == item.Date.ToShortTimeString())
                    {
                        MessageBox.Show($"Event {item.Name} is started!", "Message");
                        if (_eventsInfo[i].Condition == Condition.EVENT)
                        {
                            _eventsInfo.RemoveAt(i);
                            listBox1.Items.Remove(item.Name);
                            monthCalendar1.RemoveBoldedDate(item.Date);
                        }

                        break;
                    }
                    i++;
                }
                listBox1.Refresh();
                monthCalendar1.UpdateBoldedDates();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                button2.Enabled = true;
                button3.Enabled = true;
                string selectedSession = listBox1.SelectedItem.ToString();
                foreach (var item in _eventsInfo)
                {
                    if (selectedSession == item.Name)
                    {
                        textBox2.Text = item.Date.ToString();
                        break;

                    }
                }
                textBox1.Text = selectedSession;
            }
            catch (NullReferenceException ex)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
