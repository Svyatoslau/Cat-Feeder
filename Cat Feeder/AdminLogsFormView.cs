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
    public partial class AdminLogsFormView : Form, ILogsFormView
    {
        public string textLog;
        public AdminLogsFormView()
        {
            InitializeComponent();
        }

        public event Action ShowAllLogs;
        public event Action ExportLogs;
        public event Action<string> ChooseLog;

        private void ShowAllLogsButton_Click(object sender, EventArgs e)
        {
            ShowAllLogs.Invoke();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            ExportLogs.Invoke();
        }

        private void ShowLogButton_Click(object sender, EventArgs e)
        {
            textLog = ShowLogButton.Text;
            //MessageBox.Show(textLog);
            ChooseLog.Invoke(textLog);
        }
    }
}
