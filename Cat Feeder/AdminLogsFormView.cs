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
    public partial class AdminLogsFormView : Form, IAdminLogsFormView
    {
        public string textLog;

        public event Action ChooseUser;
        public event Action ChooseLog;
        public event Action PrintAllLogs;
        public event Action ExportLogs;

        public AdminLogsFormView()
        {
            InitializeComponent();
        }

        

        private void ShowAllLogsButton_Click(object sender, EventArgs e)
        {
            
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            ExportLogs.Invoke();
        }

        private void ShowLogButton_Click(object sender, EventArgs e)
        {
            textLog = ShowLogButton.Text;
            //MessageBox.Show(textLog);
          
        }

        private void AdminLogsFormView_Load(object sender, EventArgs e)
        {

        }
    }
}
