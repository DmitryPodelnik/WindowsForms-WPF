using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21._10._20_TextBox_Calendar
{
    enum Condition
    {
        EVENT = 1,
        BIRTHDATE
    };
    class EventInfo
    {
        private DateTime _date = new DateTime();
        private string _name;
        private Condition _condition;

        public EventInfo() { }
        public EventInfo(DateTime date, string name, Condition condition = Condition.EVENT)
        {
            _date = date;
            _name = name;
            _condition = condition;
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
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public Condition Condition
        {
            get => _condition;
            set
            {
                try
                {
                    if (value != Condition.EVENT && value != Condition.BIRTHDATE)
                    {
                        throw new ArgumentException("Incorrect value!");
                    }
                    _condition = value;
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
