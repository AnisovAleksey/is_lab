using System;
using System.Windows.Forms;

namespace FaceDetection
{
    public partial class MainForm : Form
    {
        private IFaceDetector _faceDetector;

        public MainForm()
        {
            _faceDetector = new HaarFaceDetector();
            InitializeComponent();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = "c:\\",
                Filter = "image files (*.jpg)|*.jpg",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            
            try
            {
                panAndZoomPictureBox1.Image = _faceDetector.ResolveImage(openFileDialog.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            }
        }
    }
}
