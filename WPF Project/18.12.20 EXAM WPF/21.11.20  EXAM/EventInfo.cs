using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _21._11._20__EXAM
{
    public class EventInfo
    {
        private DateTime _date = new DateTime();
        private string _name;
        private int _severity;
        private string _description;

        public EventInfo() { }
        public EventInfo(DateTime date, string name, int severity)
        {
            _date = date;
            _name = name;
            _severity = severity;

        }
        public DateTime Date
        {
            get => _date;
            set
            {
                try
                {
                    if (value == null)
                    {
                        throw new ArgumentNullException("Value cannot be null!");
                    }
                    _date = value;
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }
        public string Name
        {
            get => _name;
            set
            {
                try
                {
                    if (value == null)
                    {
                        throw new ArgumentNullException("Value cannot be null!");
                    }
                    _name = value;
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                try
                {
                    if (value == null)
                    {
                        throw new ArgumentNullException("Value cannot be null!");
                    }
                    _description = value;
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        public int Severity
        {
            get => _severity;
            set
            {
                try
                {
                    if (value < 0 || value > 30)
                    {
                        throw new ArgumentException("Severity cannot be smaller than 0!");
                    }
                    _severity = value;
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }
        public override string ToString()
        {
            return $"Name: {Name}; Severity: {Severity}; Date: {Date.ToShortDateString()}";
        }
    }
}
