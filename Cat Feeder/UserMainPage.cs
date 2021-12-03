﻿using System;
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
    public partial class UserMainPage : Form, IUserMainPageVeiw
    {
        public UserMainPage()
        {

            InitializeComponent();
            
        }

        
        public new void Show()
        {
            
            base.Show();
        }

        public event Action ShowMakeMarkFormView;
        public event Action ShowLogsFormView;
        public event Action ShowTimetableView;
        public event Action ShowFeedVeiw;



        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

  

        private void UserMainPage_Load(object sender, EventArgs e)
        {

        }

        
        private void createNoteButton_Click(object sender, EventArgs e)
        {
            ShowFeedVeiw?.Invoke();
        }

        private void note1_Click(object sender, EventArgs e)
        {

        }

        private void note2_Click(object sender, EventArgs e)
        {

        }

        private void logButton_Click(object sender, EventArgs e)
        {

        }

        private void timetableButton_Click(object sender, EventArgs e)
        {

        }

        private void feeder2_Click(object sender, EventArgs e)
        {

        }

        private void feeder4_Click(object sender, EventArgs e)
        {

        }

        private void feeder3_Click(object sender, EventArgs e)
        {

        }
    }
}
