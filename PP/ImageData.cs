using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP
{
    class ImageData : IDisposable
    {
        public Bitmap SourceBitmap { get; private set; }
        public Bitmap TargetBitmap { get; private set; }
        private BitmapData bitmapData;
        
        private Dictionary<Color, Color> bestColorMatch;
        private HashSet<Color> uniqueColors;
        private List<Color> targetColors;

        public ImageData(string path, List<string> colors)
        {
            SourceBitmap = (Bitmap)Image.FromFile(path);
            TargetBitmap = new Bitmap(SourceBitmap.Width, SourceBitmap.Height, SourceBitmap.PixelFormat);
            targetColors = stringColorsToColors(colors);
        }

        public void ApplyChanges()
        {
            Rectangle rect = new Rectangle(0, 0, SourceBitmap.Width, SourceBitmap.Height);
            bitmapData = SourceBitmap.LockBits(rect, ImageLockMode.ReadWrite, SourceBitmap.PixelFormat);
            IntPtr ptr = bitmapData.Scan0;
            int bytes = Math.Abs(bitmapData.Stride) * bitmapData.Height;
            byte[] rgbValues = new byte[bytes];
            
            // bitmap -> array
            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

            // array -> bitmap
            // System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);
            TargetBitmap    .UnlockBits(bitmapData);
        }

        private void findUniqueColors()
        {

        }

        private void calculateEuclideanDistance()
        {

        }

        private List<Color> stringColorsToColors(List<string> colors)
        {
            List<Color> colorList = new List<Color>();
            foreach (string stringColor in colors)
            {
                colorList.Add(Color.FromArgb(Convert.ToInt32("FF" + stringColor, 16)));
            }
            return colorList;
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~ImageData() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion


    }
}
