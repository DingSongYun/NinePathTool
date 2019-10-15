using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace NinePatch
{
    class NinePatchConfig
    {
        public int left;
        public int right;
        public int top;
        public int bottom;

        public override String ToString()
        {
            return "left: " + left + ", " + 
                "right: " + right + ", " +
                "top: " + top + ", " + 
                "bottom: " + bottom
                ;
        }
    };

    class NinePatchCreator
    {
        private String mOutputPath;
        private Bitmap mInputImage;
        private Bitmap mOutputImage;
        public NinePatchCreator(String inputImagePath, String outputPath)
        {
            mInputImage = new Bitmap(inputImagePath);
            //mInputImage = new ImageFactory().Load(inputImagePath);
            mOutputPath = outputPath;
        }

        public void Create(NinePatchConfig Config)
        {
            // 扩展2px用来画黑线
            int width = mInputImage.Width + 2;
            int height = mInputImage.Height + 2;
            mOutputImage = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(mOutputImage);
            graphics.DrawImage(mInputImage, 1, 1);

            // Common Pen
            Pen pen = new Pen(Color.Black);
            
            // Drwa Top Line
            int leftPoint = Math.Max(1 + Config.left, 1);
            int rightPoint = Math.Min(Math.Max(leftPoint, width - 1 - Config.right), width);
            graphics.DrawLine(pen, new Point(leftPoint, 0), new Point(rightPoint, 0));
            // Drwa Left Line
            int topPoint = Math.Max(1, 1 + Config.top);
            int bottomPoint = Math.Min(Math.Max(topPoint, height - 1 - Config.bottom), height);
            graphics.DrawLine(pen, new Point(0, topPoint), new Point(0, bottomPoint));

            graphics.Flush();
            SaveImage();
        }

        private void SaveImage()
        {
            if (!String.IsNullOrEmpty(mOutputPath))
            {
                String Folder = Path.GetDirectoryName(mOutputPath);
                if (!Directory.Exists(Folder))
                {
                    Directory.CreateDirectory(Folder);
                }
                mOutputImage.Save(mOutputPath, ImageFormat.Png);
            }
        }
    }
}
