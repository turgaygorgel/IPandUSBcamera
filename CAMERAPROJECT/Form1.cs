using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using AForge.Video;
using AForge.Video.DirectShow;


namespace CAMERAPROJECT
{
    public partial class Form1 : Form
    {
        MJPEGStream streamvideo;//FOR IP CAME1
        MJPEGStream streamvideo2;//FOR IP CAME2

        public int islemdurumu = 0; //CAMERA STATUS
        FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        VideoCaptureDevice videoSource = null;
        public static int durdur = 0;
        public static int gondermesayisi = 0;
        public int kamerabaslat = 0;
        public int selected = 0;
        public string camera1 = "http://92.110.122.229:8080/mjpg/video.mjpg";
        public string camera2 = "http://64.90.159.118:8888/?action=stream";
        public Form1()
        {
            InitializeComponent();
      
            streamvideo = new MJPEGStream(camera1);
            streamvideo.NewFrame += GetNewframe;            
           
            streamvideo2 = new MJPEGStream(camera2);
            streamvideo2.NewFrame += GetNewframe2;
        }

        private void GetNewframe2(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
            pictureBox2.Image = bmp;
        }

        private void GetNewframe(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bmp;
        }

        private void START_Click(object sender, EventArgs e)
        {
            selected = comboBox1.SelectedIndex;

            if (islemdurumu == 0)
            {


                if (kamerabaslat > 0) return;
                try
                {
                    videoSource = new VideoCaptureDevice(videoDevices[selected].MonikerString);
                    videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame); 
                    videoSource.Start(); kamerabaslat = 1; //CAMERA STARTRED
                     
                }
                catch
                {
                    MessageBox.Show("RESTART THE PROGRAM");

                    if (!(videoSource == null))
                        if (videoSource.IsRunning)
                        {
                            videoSource.SignalToStop();
                            videoSource = null;
                        }
                }//catch
            }
        }////

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap img = (Bitmap)eventArgs.Frame.Clone();
            imgVideo.Image = img; 
        }

        private void RESET_Click(object sender, EventArgs e)
        {
            if (!(videoSource == null))
                if (videoSource.IsRunning)
                {
                    videoSource.SignalToStop();
                    videoSource = null;
                }
             
            kamerabaslat = 0;
            imgVideo.Image = null;

            label1.Text = "CAMERA TURN OFF";
        }

        private void CAPTURE_Click(object sender, EventArgs e)
        {

            
                if (imgVideo != null) { imgCapture.Image = imgVideo.Image; }
             
        }

        private void PAUSE_Click(object sender, EventArgs e)
        {
           
                if (!(videoSource == null))
                    if (videoSource.IsRunning)
                    {
                        videoSource.SignalToStop();
                        videoSource = null;
                    }

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
         

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.label1.Text = "";
                //Enumerate all video input devices
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (videoDevices.Count == 0)
                {
                    label1.Text = "No local capture devices";
                }
                foreach (FilterInfo device in videoDevices)
                {
                    int i = 1;
                    comboBox1.Items.Add(device.Name);
                    label1.Text = ("camera initialization completed..." + "\n");
                    i++;
                }
                comboBox1.SelectedIndex = 0;
            }
            catch (ApplicationException)
            {
                this.label1.Text = "No local capture devices";
                videoDevices = null;
            }
            try
            {
              

            }
            catch { }
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            try
            {
                videoSource.SignalToStop();
                videoSource = null;
                if (!(videoSource == null))
                {
                    videoSource.Stop();
                    videoSource = null;
                }
            }
            catch { }
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            { 
               // videoSource.SignalToStop();
                videoSource = null;
                if (!(videoSource == null))
                {
                    videoSource.Stop();
                    videoSource = null;
                }
            }
            catch { }
            Application.Exit();
            streamvideo.Stop();
            streamvideo2.Stop();

        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            try
            {
                imgCapture.Image = imgVideo.Image;
            }
            catch { }
            /* kaydet butonu  bntSave_Click*/
            try
            { 

                imgCapture.Image.Save(@"resim.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
              
                 label1.Text = "IMAGE SAVED";
               
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            streamvideo.Start();
        }

        private void STOP_Click(object sender, EventArgs e)
        {
            streamvideo.Stop();
        }

        private void WATCH_US_CAMERA_2_Click(object sender, EventArgs e)
        {
            streamvideo2.Start();
        }

        private void STOP_US_CAMERA_2_Click(object sender, EventArgs e)
        {
            streamvideo2.Stop();
        }

        ///
    }
}
