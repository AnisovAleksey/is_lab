using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Collections.Generic;
using System.Drawing;

namespace FaceDetection
{
    class HaarFaceDetector : IFaceDetector
    {
        public Bitmap ResolveImage(string filename)
        {
            var image = new Mat(filename, LoadImageType.Color);
            var faces = new List<Rectangle>();
            var eyes = new List<Rectangle>();

            long detectionTime;

            DetectFace.Detect(image,
                "haarcascade_frontalface_default.xml",
                "haarcascade_eye.xml",
                faces,
                eyes,
                false,
                out detectionTime);

            foreach (Rectangle face in faces)
            {
                CvInvoke.Rectangle(image, face, new Bgr(Color.Red).MCvScalar, 2);
            }

            foreach (Rectangle eye in eyes)
            {
                CvInvoke.Rectangle(image, eye, new Bgr(Color.Blue).MCvScalar, 2);
            }

            return image.Bitmap;
        }
    }
}
