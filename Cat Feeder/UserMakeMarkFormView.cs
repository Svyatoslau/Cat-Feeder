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
    public partial class UserMakeMarkFormView : Form, IUserMakeMarkFormView
    {
        public string Note => throw new NotImplementedException();

        public UserMakeMarkFormView()
        {
            InitializeComponent();
        }

        public event Action ChoiseFeeder;
        public event Action MakeNoteToFeeder;
        public event Action MakeNoteByHand;

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InfoKarmushkaField_Click(object sender, EventArgs e)
        {

        }

        private void MakeMarkForm_Load(object sender, EventArgs e)
        {

        }
    }
}
