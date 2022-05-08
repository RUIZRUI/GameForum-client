using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameForum
{
    public class ImageHelper
    {
        /// <summary>
        /// 生成圆形图片控件
        /// </summary>
        /// <param name="img"></param>
        /// <param name="rec"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static Image CutEllipse(Image img, Rectangle rec, Size size)
        {
            Bitmap bitmap = new Bitmap(size.Width, size.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                using (TextureBrush br = new TextureBrush(img, System.Drawing.Drawing2D.WrapMode.Clamp, rec))
                {
                    br.ScaleTransform(bitmap.Width / (float)rec.Width, bitmap.Height / (float)rec.Height);
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    g.FillEllipse(br, new Rectangle(Point.Empty, size));
                }
            }
            return bitmap;
        }


        public static Image SimpleCutEllipse(Image img)
        {
            return CutEllipse(img, new Rectangle(0, 0, img.Width, img.Height), new Size(img.Width, img.Height));
        }
    }
}
