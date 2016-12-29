using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            audio_play.BackColor = Color.Transparent;
            audio_step_back.BackColor = Color.Transparent;
            audio_step_forward.BackColor = Color.Transparent;
            audio_stop.BackColor = Color.Transparent;

            audio_play.ForeColor = Color.Transparent;
            audio_step_back.ForeColor = Color.Transparent;
            audio_step_forward.ForeColor = Color.Transparent;
            audio_stop.ForeColor = Color.Transparent;
            Speed_tbox.Text = "018";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            audio_play.BackColor = Color.Transparent;
            */
            this.listView.View = View.Details;
            this.listView.Columns.Add("날짜", 100, HorizontalAlignment.Center);
            this.listView.Columns.Add("시", 60, HorizontalAlignment.Center);
            this.listView.Columns.Add("분 초", 60, HorizontalAlignment.Center);
            this.listView.Columns.Add("녹화타입", 80, HorizontalAlignment.Center);
            this.time_tbox.Text = "00:10 / 00:18";
            //audio_play.BackColor =

        }

        private void audio_step_back_Click(object sender, EventArgs e)
        {
            //audio_step_back.
            
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("setting menu clicked!");
        }

        private void LeftRight_Scroll(object sender, EventArgs e)
        {
            if (LeftRight.Value == 0)
                MessageBox.Show("front");
            else if (LeftRight.Value == 1)
                MessageBox.Show("back");
            else
                MessageBox.Show("error");
        }

        private void UpDown_Scroll(object sender, EventArgs e)
        {
            if (UpDown.Value == 0)
                MessageBox.Show("UP");
            else if (UpDown.Value == 1)
                MessageBox.Show("Down");
            else
                MessageBox.Show("Error");
        }
    }
}
