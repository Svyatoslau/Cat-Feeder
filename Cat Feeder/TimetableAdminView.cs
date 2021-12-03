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
    public partial class TimetableAdminView : Form, ITimetableAdminView
    {
        public TimetableAdminView()
        {
            InitializeComponent();
        }

        public event Action TimetableСhoose;
        public event Action TimetableExportAdmin;
        public event Action TimetableImportAdmin;
        public event Action<string> TimetableText;

        private void TimetableAdmin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Это заголовок текста  Timetables Admin над списком расписаний НЕ ЗНАЮ КТО СДЕЛАЛ НА НЕГО ДЕЙСТВИЕ И ЗАЧЕМ????????????
        }

        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ExportTimetableAdmin_Button_Click(object sender, EventArgs e)
        {

        }

        private void ImportTimetableAdmin_Button_Click(object sender, EventArgs e)
        {

        }

        private void TimetableAdmin_Button1_Click(object sender, EventArgs e)
        {

        }

        private void TimetableAdmin_Button2_Click(object sender, EventArgs e)
        {

        }

        private void TimetableAdmin_Button3_Click(object sender, EventArgs e)
        {

        }

        private void TimetableAdmin_Button4_Click(object sender, EventArgs e)
        {

        }

        private void TimetableAdmin_Button5_Click(object sender, EventArgs e)
        {

        }

        private void TimetableAdmin_Button6_Click(object sender, EventArgs e)
        {

        }

        private void TimetableAdmin_Button7_Click(object sender, EventArgs e)
        {

        }

        private void TimetableAdmin_Button8_Click(object sender, EventArgs e)
        {

        }

        private void TimetableAdmin_Button9_Click(object sender, EventArgs e)
        {

        }

        private void TimetableAdmin_Button10_Click(object sender, EventArgs e)
        {

        }

        private void TimetableAdmin_Button11_Click(object sender, EventArgs e)
        {

        }
    }
}
