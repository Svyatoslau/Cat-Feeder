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
    public partial class TimetableView : Form, ITimetableView
    {
        public TimetableView()
        {
            InitializeComponent();
        }

        public event Action<string> ChooseTimetable;
        public event Action<string> ExportTimetable;
        public event Action<string> ImportTimetable;
        public event Action<string> SaveTimetable;
        public event Action<string> ChooseFeed;

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

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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
    }
}
