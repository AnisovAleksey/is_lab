using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Collections.Generic;
using System.Drawing;

namespace FaceDetection
{
    class HaarFaceDetector : IFaceDetector
    {
        private string _cascadeFilename;

        public HaarFaceDetector(string filename)
        {
            _cascadeFilename = filename;
        }

        public Bitmap ResolveImage(string filename)
        {
            var image = new Mat(filename, LoadImageType.Color);

            var faces = DetectFaces(image, _cascadeFilename);

            foreach (Rectangle face in faces)
            {
                CvInvoke.Rectangle(image, face, new Bgr(Color.Red).MCvScalar, 2);
            }

            return image.Bitmap;
        }


        private List<Rectangle> DetectFaces(Mat image, string faceFileName)
        {
            var result = new List<Rectangle>();

            //Read the HaarCascade object
            using (CascadeClassifier face = new CascadeClassifier(faceFileName))
            using (UMat ugray = new UMat())
            {

                CvInvoke.CvtColor(image, ugray, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);

                // normalizes brightness and increases contrast of the image
                CvInvoke.EqualizeHist(ugray, ugray);

                //Detect the faces from the gray scale image and store the locations as rectangle
                //The first dimensional is the channel
                //The second dimension is the index of the rectangle in the specific channel
                Rectangle[] facesDetected = face.DetectMultiScale(
                   ugray,
                   1.3,
                   10,
                   new Size(20, 20));

                result.AddRange(facesDetected);
            }

            return result;
        }
    }
}
