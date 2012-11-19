using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;
using KinectTester.Properties;
using Microsoft.Research.Kinect.Nui;
using System.Runtime.InteropServices;

namespace KinectTester
{
  public partial class KinectTesterForm : Form
  {
    private Runtime _nui;

    public KinectTesterForm()
    {
      InitializeComponent();
    }

    private void buttonStart_Click(object sender, EventArgs e)
    {
      _nui = Runtime.Kinects.FirstOrDefault();
      if (_nui != null)
      {
        if (buttonStart.Text == Resources.Form1_buttonStart_Click_Start)
        {
          buttonStart.Text = Resources.Form1_buttonStart_Click_Stop;

          _nui.Initialize(RuntimeOptions.UseColor);
          _nui.VideoStream.Open(ImageStreamType.Video, 2, ImageResolution.Resolution640x480, ImageType.Color);

          _nui.VideoFrameReady += FrameReady;
        }
        else if (buttonStart.Text == Resources.Form1_buttonStart_Click_Stop)
        {
          buttonStart.Text = Resources.Form1_buttonStart_Click_Start;
          _nui.Uninitialize();
        }
      }
      else
      {
        var dr = MessageBox.Show(Resources.Form1_buttonStart_Click_Please_connect_a_Microsoft_Kinect_to_the_computer,
                                 Resources.Form1_buttonStart_Click_Error, MessageBoxButtons.RetryCancel);
        if (dr == DialogResult.Retry)
        {
          buttonStart_Click(sender, e);
        }
      }
    }

    private void FrameReady(object sender, ImageFrameReadyEventArgs e)
    {
      var pImage = e.ImageFrame.Image;
      var bmap = PImageToBitmap(pImage);
      pictureBoxVideo.Image = bmap;
    }
    
    private static Bitmap PImageToBitmap(PlanarImage pImage)
    {
      var bmap = new Bitmap(pImage.Width, pImage.Height, PixelFormat.Format32bppRgb);
      var bmapdata = bmap.LockBits(new Rectangle(0, 0, pImage.Width, pImage.Height), ImageLockMode.WriteOnly,
                                   bmap.PixelFormat);
      var ptr = bmapdata.Scan0;
      Marshal.Copy(pImage.Bits, 0, ptr, pImage.Width * pImage.BytesPerPixel * pImage.Height);
      
      bmap.UnlockBits(bmapdata);
      return bmap;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      //
    }

    private void pictureBoxVideo_Click(object sender, EventArgs e)
    {

    }

    private void button(object sender, EventArgs e)
    {
      var vector = new Vector();
    }
  }
}
