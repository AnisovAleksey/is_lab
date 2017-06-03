using System.Drawing;

namespace FaceDetection
{
    public interface IFaceDetector
    {
        Bitmap ResolveImage(string filename);
    }
}
