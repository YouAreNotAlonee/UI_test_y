using System;
using System.Drawing;
using System.Windows.Forms;
//using System.IO;

using System.Runtime.InteropServices;
using DirectShowLib;
//using OpenCvSharp;
//using Microsoft.DirectX.AudioVideoPlayback;
namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        /*direct X test*/
        Microsoft.DirectX.AudioVideoPlayback.Video vid;
        public void init()
        {
            OpenFileDialog of = new OpenFileDialog();
            if(of.ShowDialog()==DialogResult.OK)
            {
                vid = new Microsoft.DirectX.AudioVideoPlayback.Video(of.FileName);
                vid.Owner = this.panel1;
                //vid.Size = this.panel1.Size;
            }
        }
        //IGraphBuilder pGraphBuilder = null;
        //IMediaControl pMediaControl = null;

        //IMediaEvent pMediaEvent = null;
        //EventCode eventCode;
        
        //IVideoWindow pVideoWindow = null;
        private void Video_Stop()
        {
            /*Marshal.ReleaseComObject(pGraphBuilder);
            pGraphBuilder = null;
            Marshal.ReleaseComObject(pMediaControl);
            pMediaControl = null;
            Marshal.ReleaseComObject(pMediaEvent);
            pMediaEvent = null;
            Marshal.ReleaseComObject(pVideoWindow);
            pVideoWindow = null;*/
        }

        private void Video_Play()
        {
            /*pGraphBuilder = (IGraphBuilder)new FilterGraph();

            pMediaControl = (IMediaControl)pGraphBuilder;

            pMediaEvent = (IMediaEvent)pGraphBuilder;

            pVideoWindow = (IVideoWindow)pGraphBuilder;

            pMediaControl.RenderFile("test.wmv");

            pVideoWindow.put_Owner(video_panel.Handle);
            pVideoWindow.put_WindowStyle(WindowStyle.Child | WindowStyle.ClipSiblings);
            Rectangle rect = video_panel.ClientRectangle;
            pVideoWindow.SetWindowPosition(0, 0, rect.Right, rect.Bottom);

            pMediaControl.Run();
            */
        }
        /*video test*/
        //Microsoft.DirectX.AudioVideoPlayback.Video video;
        public MainForm()
        {
            //VideoCapture cap1("2.mp4");
            
            InitializeComponent();
            
            this.BackColor = Color.White;
            /*make mainform's background to white*/

            audio_play.BackColor = Color.Transparent;
            audio_step_back.BackColor = Color.Transparent;
            audio_step_forward.BackColor = Color.Transparent;
            audio_stop.BackColor = Color.Transparent;
            /*make button's background transparent*/

            audio_play.ForeColor = Color.Transparent;
            audio_step_back.ForeColor = Color.Transparent;
            audio_step_forward.ForeColor = Color.Transparent;
            audio_stop.ForeColor = Color.Transparent;
            Speed_tbox.Text = "018";
            /*make button's line transparent*/
            
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.listView.View = View.Details;
            this.listView.Columns.Add("날짜", 100, HorizontalAlignment.Center);
            this.listView.Columns.Add("시", 60, HorizontalAlignment.Center);
            this.listView.Columns.Add("분 초", 60, HorizontalAlignment.Center);
            this.listView.Columns.Add("녹화타입", 80, HorizontalAlignment.Center);
            this.time_tbox.Text = "00:10 / 00:18";
            /*init listview*/
            //imagetest();
            insert_listviewitem();//listview test
            //init();
        }
        /*listview test*/
        private void insert_listviewitem()
        {
            ListViewItem item;
            String[] itemStr = new string[4];
            itemStr.SetValue("20161230", 0);
            itemStr.SetValue("6시", 1);
            itemStr.SetValue("46분", 2);
            itemStr.SetValue("상시", 3);
            //itemStr.SetValue("s", 0);
            item = new ListViewItem(itemStr);
            this.listView.Items.Add(item);
        }
        /*test end*/

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

        private void audio_step_forward_Click(object sender, EventArgs e)
        {
            //vid.
        }

        private void audio_pause_Click(object sender, EventArgs e)
        {
            vid.Pause();
            
        }

        private void audio_stop_Click(object sender, EventArgs e)
        {
            //Video_Stop();
            vid.Stop();
        }

        private void audio_play_Click(object sender, EventArgs e)
        {
            vid.Play();
            //Video_Play();
        }

        private void audio_step_back_Click(object sender, EventArgs e)
        {
            //audio_step_back.
        }

        private void zero_dot_two_btn_Click(object sender, EventArgs e)
        {

        }

        private void zero_dot_five_btn_Click(object sender, EventArgs e)
        {

        }

        private void one_dot_zero_btn_Click(object sender, EventArgs e)
        {

        }

        private void one_dot_five_btn_Click(object sender, EventArgs e)
        {

        }

        private void two_dot_zero_btn_Click(object sender, EventArgs e)
        {

        }

        private void Marker_Click(object sender, EventArgs e)
        {

        }

        private void folder_open_Click(object sender, EventArgs e)
        {

        }

        private void Camera_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {

        }

        private void Dirve_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (Dirve_btn.Checked)
                MessageBox.Show("drive checked");
            else if (!Dirve_btn.Checked)
                MessageBox.Show("drive unchecked");
            else
                MessageBox.Show("drive button error");
        }

        private void Event_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (Event_btn.Checked)
                MessageBox.Show("Event checked");
            else if (!Event_btn.Checked)
                MessageBox.Show("Event unchecked");
            else
                MessageBox.Show("drive button error");
        }

        private void Parking_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (Parking_btn.Checked)
                MessageBox.Show("Parking checked");
            else if (!Parking_btn.Checked)
                MessageBox.Show("parking uncheked");
            else
                MessageBox.Show("drive button error");
        }

        private void Camera_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (Camera_btn.Checked)
                MessageBox.Show("camera checked");
            else if (!Camera_btn.Checked)
                MessageBox.Show("camera unchecked");
            else
                MessageBox.Show("camera button error");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            init();
        }

        
        /*
void imagetest()//test images by opencv
{
Mat src = new Mat("C:/Users/Seyeong/Documents/Visual Studio 2017/Projects/WindowsFormsApp1/lena.jpg", ImreadModes.GrayScale);//temp
Mat dst = new Mat();

Cv2.Canny(src, dst, 50, 200);
using (new Window("src image", src))
using (new Window("dst image", dst))
{
Cv2.WaitKey();
}
}
*/


    }
}
