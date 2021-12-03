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
    public partial class AdminMonitorFeedView : Form, IAdminMonitorFeedView
    {
        public string name => throw new NotImplementedException();

        public string typeOfFeeder => throw new NotImplementedException();

        public AdminMonitorFeedView()
        {
            InitializeComponent();
        }

        public event Action ChoiseFeeder;
        public event Action ChoiseUser;

        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer3_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer10_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer12_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MonitorFeedAdminView_Load(object sender, EventArgs e)
        {

        }
    }
}
