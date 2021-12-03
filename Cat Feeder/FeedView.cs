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
    public partial class FeedView : Form, IFeedVeiw
    {
        public string timetableName => throw new NotImplementedException();

        public string timetable => throw new NotImplementedException();

        public FeedView()
        {
            InitializeComponent();
        }

        public event Action SaveTimetable;
        public event Action ChooseExistTimetable;

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void splitContainer3_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FeedView_Load(object sender, EventArgs e)
        {

        }

        private void textBoxNameTimetable_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveTimetableButton_Click(object sender, EventArgs e)
        {

        }

        private void chooseExistTimetableButton_Click(object sender, EventArgs e)
        {

        }
    }
}
