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
    public partial class LogsFormView : Form, ILogsFormView
    {
        public LogsFormView()
        {
            InitializeComponent();
        }

        public event Action<string> ShowAllLogs;
        public event Action<string> ExportLogs;
        public event Action<string> ChooseLog;

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void LogsFormView_Load(object sender, EventArgs e)
        {

        }
    }
}
