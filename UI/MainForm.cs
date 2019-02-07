using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Model;

namespace UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private List<MonthModel> Months;

        private int weekday;

        private int MonthDay;

        private List<string> TodayList = new List<string>();

        private List<string> TomorrowList = new List<string>();
        private void MonthReset()
        {
            Months = new MonthOpr().GetMonth();
            foreach (var item in Months)
            {
                if (item.MonthDay == MonthDay.ToString())
                {
                    TodayList.Add(item.Title);
                }
                if (item.MonthDay == (MonthDay + 1).ToString())
                {
                    TomorrowList.Add(item.Title);
                }
            }
        }

        private void Reset()
        {
            MonthReset();

            listBoxToday.DataSource = TodayList;
            listBoxTomorrow.DataSource = TomorrowList;
        }

        private int GetWeekDayNumber(string input)
        {
            if (input == "Monday")
            {
                return 1;
            }
            else if (input == "Tuesday")
            {
                return 2;
            }
            else if (input == "Wednesday")
            {
                return 3;
            }
            else if (input == "Thursday")
            {
                return 4;
            }
            else if (input == "Friday")
            {
                return 5;
            }
            else if (input == "Saturday")
            {
                return 6;
            }
            else
            {
                return 7;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MonthDay = DateTime.Now.Day;
            weekday = GetWeekDayNumber(DateTime.Now.DayOfWeek.ToString());

            Reset();
        }

        private void 插入新报告ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
