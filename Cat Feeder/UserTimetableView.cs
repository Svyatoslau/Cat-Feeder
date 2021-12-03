using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation;

namespace Cat_Feeder
{
    public partial class UserTimetableView : Form, ITimetableView
    {
        public UserTimetableView()
        {
            InitializeComponent();
        }

        public event Action ChooseTimetable;
        public event Action ExportTimetable;
        public event Action ImportTimetable;
        public event Action SaveTimetable;
        public event Action ChooseFeed;

        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer3_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Timetable_Load(object sender, EventArgs e)
        {
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // НЕ ЗНАЮ ЗАЧЕМ И ДЛЯ ЧЕГО                                             ЧЕРНЕЦКИЙ   ВЛАДИМИР
        }

        private void ExportTimetableButton_Click(object sender, EventArgs e)
        {

        }

        private void ImportTimetableButton_Click(object sender, EventArgs e)
        {

        }

        private void ChooseFeedButton_Click(object sender, EventArgs e)
        {

        }

        private void Timetable_Button1_Click(object sender, EventArgs e)
        {

        }

        private void Timetable_Button2_Click(object sender, EventArgs e)
        {

        }

        private void Timetable_Button3_Click(object sender, EventArgs e)
        {

        }

        private void Timetable_Button4_Click(object sender, EventArgs e)
        {

        }

        private void Timetable_Button5_Click(object sender, EventArgs e)
        {

        }

        private void Timetable_Button6_Click(object sender, EventArgs e)
        {

        }

        private void Timetable_Button7_Click(object sender, EventArgs e)
        {

        }

        private void Timetable_Button8_Click(object sender, EventArgs e)
        {

        }

        private void Timetable_Button9_Click(object sender, EventArgs e)
        {

        }

        private void SaveTametableButton_Click(object sender, EventArgs e)
        {

        }

        private void textBoxOfTimeTables_TextChanged(object sender, EventArgs e)
        {
            textBoxOfTimeTables.Text;
        }
    }
}
