using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace ScreenCaptureMagic.Util
{
    class ImageHelpers
    {
        public static void saveBitmapToJpg(Bitmap bmp, string filename)
        {
            var qualityEncoder = System.Drawing.Imaging.Encoder.Quality;
            var quality = (long)65;
            var ratio = new EncoderParameter(qualityEncoder, quality);
            var codecParams = new EncoderParameters(1);
            codecParams.Param[0] = ratio;
            var jpegCodecInfo = GetEncoder(ImageFormat.Jpeg);
            bmp.Save(filename, jpegCodecInfo, codecParams); // Save to JPG            
        }

        public static ImageCodecInfo GetEncoder(ImageFormat format)
        {

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();

            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }
    }
}
