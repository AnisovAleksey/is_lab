using System;
using System.Drawing;
using System.Windows.Forms;

namespace FaceDetection
{
    public partial class MainForm : Form
    {
        private IFaceDetector _faceDetector;
        private string _lastImageFilename;

        public MainForm()
        {
            InitializeComponent();
        }

        private void InvalidatePickImageButton()
        {
            PickImageButton.Enabled = _faceDetector != null;
        }

        #region UI Events

        private void OnFormResized(object sender, EventArgs e)
        {
            PickImageButton.Location = new Point(ClientSize.Width - 15 - PickImageButton.Size.Width, ClientSize.Height - 15 - PickImageButton.Size.Height);
            PickCascadeButton.Location = new Point(15, ClientSize.Height - 15 - PickCascadeButton.Size.Height);
            SelectedCascadeLabel.Location = new Point(PickCascadeButton.Location.X + PickCascadeButton.Size.Width + 15, PickCascadeButton.Location.Y);
            var cascadeButtonTrailing = PickCascadeButton.Location.X + PickCascadeButton.Size.Width;
            var imageButtonLeading = PickImageButton.Location.X;
            SelectedCascadeLabel.MaximumSize = new Size(imageButtonLeading - cascadeButtonTrailing - 30, 15);

            panel1.Size = new Size(ClientSize.Width - 15, PickImageButton.Location.Y - 15);
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            OpenImage();
        }

        private void OnPanelDoubleClick(object sender, EventArgs e)
        {
            OpenImage();
        }

        private void OnPictureBoxDoubleClick(object sender, EventArgs e)
        {
            OpenImage();
        }

        private void OnPickCascadeButtonClick(object sender, EventArgs e)
        {
            OpenHaarCascade();
        }

        #endregion

        #region File handlers

        private void HandleImageFile(string filename)
        {
            try
            {
                _lastImageFilename = filename;
                pictureBox1.Image = new Bitmap(_faceDetector.ResolveImage(filename));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            }
        }

        private void HandleHaarCascade(string filename)
        {
            _faceDetector = new HaarFaceDetector(filename);
            InvalidatePickImageButton();

            var substringFrom = Math.Max(0, filename.LastIndexOf('\\') + 1);
            
            SelectedCascadeLabel.Text = String.Format("Выбран каскад: {0}", filename.Substring(substringFrom));

            if (_lastImageFilename != null)
            {
                HandleImageFile(_lastImageFilename);
            }
        }

        #endregion

        #region OpenFile Utility

        private void OpenImage()
        {
            OpenFile("Image files (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp", HandleImageFile);
        }

        private void OpenHaarCascade()
        {
            OpenFile("XML files (*.xml)|*.xml", HandleHaarCascade);
        }

        private void OpenFile(string filter, Action<String> handler)
        {
            var openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = "c:\\",
                Filter = filter,
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            handler(openFileDialog.FileName);
        }
        #endregion
    }

}
