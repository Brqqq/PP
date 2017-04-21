using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP
{
    public partial class Form1 : Form
    {
        BindingList<string> colors;
        Image loadedImage;
        Bitmap imageBitmap;
        Size originalSize;
        Dictionary<Color, Color> bestColorMatch;
        HashSet<Color> uniqueColors;
        public Form1()
        {
            colors = new BindingList<string>()
            {
                "FFFFFF",
                "e50000",
                "ffa7d1",
                "888888",
                "242424",
                "e59500",
                "e5d900",
                "94e044",
                "02be01",
                "00d3dd",
                "0083c7",
                "0000ea",
                "820080"
            };

            InitializeComponent();
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            listBoxColors.DataSource = colors;
            originalSize = this.Size;
           
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result != DialogResult.OK) return;

            cleanup();

            textPath.Text = openFileDialog1.FileName;
            pictureInput.Load(openFileDialog1.FileName);
            loadedImage = Image.FromFile(openFileDialog1.FileName);
            

            //this.Size = new Size(originalSize.Width + pictureInput.Location.X + loadedImage.Width, originalSize.Height + pictureInput.Location.Y + loadedImage.Height);
        }

        private void buttonAddColor_Click(object sender, EventArgs e)
        {
            try
            {
                if (colors.Contains(textBoxColor.Text) ||
                    textBoxColor.Text.Length != 6 ||
                    Convert.ToInt32(textBoxColor.Text, 16) != null) return;
            } catch(FormatException)
            {
                return;
            }

            colors.Add(textBoxColor.Text);
            textBoxColor.Clear();
            
        }

        private void buttonRemoveColor_Click(object sender, EventArgs e)
        {
            var selected = listBoxColors.SelectedItem;
            if(selected != null)
            {
                colors.Remove(selected.ToString());
            }
        }

        private void listBoxColors_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBoxColors.SelectedValue == null) return;

            textBoxColor.Text = listBoxColors.SelectedValue.ToString();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            bestColorMatch = new Dictionary<Color, Color>();
            uniqueColors = new HashSet<Color>();

            imageBitmap = new Bitmap(loadedImage);

            cacheAllUniqueColors();
            euclideanDistance();
            applyChanges();
            pictureInput.Image = imageBitmap;
        }

        private void cacheAllUniqueColors()
        {
            for(int x = 0; x < loadedImage.Width; x++)
            {
                for(int y = 0; y < loadedImage.Height; y++)
                {
                    uniqueColors.Add(imageBitmap.GetPixel(x, y));
                }
            }
        }

        private void applyChanges()
        {
            for(int x = 0; x < loadedImage.Width; x++)
            {
                for(int y = 0; y < loadedImage.Height; y++)
                {
                    Color value = default(Color);
                    bestColorMatch.TryGetValue(imageBitmap.GetPixel(x, y), out value);
                    imageBitmap.SetPixel(x, y, value);
                }
            }
        }

        private void euclideanDistance()
        {
            var colorList = stringColorsToColors();
            foreach(Color uniqueColor in uniqueColors)
            {
                Color bestMatchingColor = default(Color);
                double bestMatchingColorDistance = double.MaxValue;
                foreach(Color targetPaletteColor in colorList)
                {
                    double distance = getEuclideanDistance(uniqueColor, targetPaletteColor);
                    if(distance < bestMatchingColorDistance)
                    {
                        bestMatchingColorDistance = distance;
                        bestMatchingColor = targetPaletteColor;
                    }
                }
                bestColorMatch[uniqueColor] = bestMatchingColor;
            }
        }

        private List<Color> stringColorsToColors()
        {
            List<Color> colorList = new List<Color>();
            foreach(string stringColor in this.colors)
            {
                colorList.Add(Color.FromArgb(Convert.ToInt32("FF" + stringColor, 16)));
            }
            return colorList;
        }

        private double getEuclideanDistance(Color color1, Color color2)
        {
            return Math.Sqrt(
                (subtractedSquared(color2.R, color1.R)) + 
                (subtractedSquared(color2.G, color1.G)) + 
                (subtractedSquared(color2.B, color1.B))
                );
        }

        private int subtractedSquared(byte r1, byte r2)
        {
            int r1Int = r1;
            int r2Int = r2;
            return (r2Int - r1Int) * (r2Int - r1Int);
        }

        private static string HexConverter(System.Drawing.Color c)
        {
            return c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }
        

        private Color getNearestColour(Color input)
        {
            Color result;
            bestColorMatch.TryGetValue(input, out result);
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cleanup();

        }

        private void cleanup()
        {
            imageBitmap?.Dispose();
            loadedImage?.Dispose();
            bestColorMatch?.Clear();
            uniqueColors?.Clear();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

    }
}
