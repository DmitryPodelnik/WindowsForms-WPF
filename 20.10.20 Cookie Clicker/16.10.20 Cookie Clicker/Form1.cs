using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16._10._20_Cookie_Clicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int _power = 1;
        private string _scoreString;
        private string _levelString;
        private string _timeString;
        private int _edge = 10;
        private int _time = 0;

        private int _result = 0;

        private int _cursorPrice = 15;
        private int _grandMotherPrice = 100;
        private int _farmPrice = 1100;
        private int _minePrice = 12000;
        private int _factoryPrice = 130000;
        private int _bankPrice = 1400000;

        private int _countCursors = 0;
        private int _countGrandMothers = 0;
        private int _countFarms = 0;
        private int _countMines = 0;
        private int _countFactories = 0;
        private int _countBanks = 0;
        private int _countCookies = 1;
       

        private void button1_Click(object sender, EventArgs e)
        {
            _scoreString = "Cookies: " + _countCookies;
            _levelString = "Level: " + _power;
            _timeString = "Time: " + _time;
            _countCookies += _power;
            label1.Text = _scoreString;
            label2.Text = _levelString;
            label3.Text = _timeString;

            if (_countCookies >= _edge)
            {
                _power++;
                _edge *= _power;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _time++;
            _result = (1 * _countCursors) + (5 * _countGrandMothers) + (35 * _countFarms) + (100 * _countMines) + (500 * _countFactories) + (5000 * _countBanks);
            _countCookies += _result;
            _scoreString = "Cookies: " + _countCookies;
            _levelString = "Level: " + _power;
            _timeString = "Time: " + _time;
            label1.Text = _scoreString;
            label2.Text = _levelString;
            label3.Text = _timeString;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_countCursors < 24 && _countCookies >= _cursorPrice)
            {
                _countCookies -= _cursorPrice;
                _cursorPrice += ((_cursorPrice * 15) / 100);

                _countCursors++;

                _result = (1 * _countCursors);

                label10.Text = "Cursor: " + _cursorPrice;
                label4.Text = _countCursors + "/24 | per second: " + _result;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_countFactories < 22 && _countCookies >= _factoryPrice)
            {
                _countCookies -= _factoryPrice;
                _factoryPrice += ((_factoryPrice * 15) / 100);

                _countFactories++;

                _result = (500 * _countFactories);

                label14.Text = "Factory: " + _factoryPrice;
                label8.Text = _countFactories + "/22 | per second: " + _result;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_countGrandMothers < 42 && _countCookies >= _grandMotherPrice)
            {
                _countCookies -= _grandMotherPrice;
                _grandMotherPrice += ((_grandMotherPrice * 15) / 100);

                _countGrandMothers++;

                _result = (5 * _countGrandMothers);

                label11.Text = "GrandMother: " + _grandMotherPrice;
                label5.Text = _countGrandMothers + "/42 | per second: " + _result;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_countFarms < 22 && _countCookies >= _farmPrice)
            {
                _countCookies -= _farmPrice;
                _farmPrice += ((_farmPrice * 15) / 100);

                _countFarms++;

                _result = (35 * _countFarms);

                label12.Text = "Farm: " + _farmPrice;
                label6.Text = _countFarms + "/22 | per second: " + _result;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_countMines < 22 && _countCookies >= _minePrice)
            {
                _countCookies -= _minePrice;
                _minePrice += ((_minePrice * 15) / 100);

                _countMines++;

                _result = (100 * _countMines);

                label13.Text = "Mine: " + _minePrice;
                label7.Text = _countMines + "/22 | per second: " + _result;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_countBanks < 22 && _countCookies >= _bankPrice)
            {
                _countCookies -= _bankPrice;
                _bankPrice += ((_bankPrice * 15) / 100);

                _countBanks++;

                _result = (5000 * _countBanks);

                label15.Text = "Bank: " + _bankPrice;
                label9.Text = _countBanks + "/22 | per second: " + _result;

            }
        }
    }
}
