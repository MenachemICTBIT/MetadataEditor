using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace MetadataEditor
{
    public partial class Form1 : Form
    {
        FolderBrowserDialog folderDlg;
        String photoDirectory;
        String flightDataDirectory;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.folderDlg = new FolderBrowserDialog();

        }

        private void PhotoUploadButton_Click(object sender, EventArgs e)
        {
            if (folderDlg.ShowDialog() == DialogResult.OK)
            {
                this.photoDirectory = folderDlg.SelectedPath;
                Console.WriteLine("Path selected" + this.photoDirectory);
                this.photoDirLocationLabel.Text = this.photoDirectory;
            }
        }

        private void FlightDataUploadButton_Click(object sender, EventArgs e)
        {
            if (folderDlg.ShowDialog() == DialogResult.OK)
            {
                this.flightDataDirectory = folderDlg.SelectedPath;
                Console.WriteLine("Path selected" + this.flightDataDirectory);
                this.flightDataDirLocationLabel.Text = this.flightDataDirectory;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var dirInfo = new DirectoryInfo(this.photoDirectory);
                Console.WriteLine("testing");
                
                Image image = Image.FromFile(@"C:\Users\Mendel\Downloads\testPhotos\second.jpg");

                PropertyItem item = image.PropertyItems[0];
                item.Id = 0x0001; // 0x0001 is supposed to be the EXIF tag for GPSLatitudeRef (Takes N, S, E, W as an argument).
                item.Type = 2;
                item.Value = System.Text.Encoding.UTF8.GetBytes("S\0");
                item.Len = item.Value.Length;
                image.SetPropertyItem(item);
                string newFilename = "HelloWorld.jpg";
                image.Save(newFilename, ImageFormat.Jpeg);
                

                Console.WriteLine(item);
                Console.WriteLine(item.Value);


                // foreach (FileInfo file in dirInfo.GetFiles())
                // { }
                
              

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show("There was an error." +
                    "Make sure the paths are valid and that only images are located in the photo directory.");
            }
        }

        private void SetProperty(ref System.Drawing.Imaging.PropertyItem prop, int iId, string sTxt)
        {
            int iLen = sTxt.Length + 1;
            byte[] bTxt = new Byte[iLen];
            for (int i = 0; i < iLen - 1; i++)
                bTxt[i] = (byte)sTxt[i];
            bTxt[iLen - 1] = 0x00;
            prop.Id = iId;
            prop.Type = 2;
            prop.Value = bTxt;
            prop.Len = iLen;
        }
    }
}
