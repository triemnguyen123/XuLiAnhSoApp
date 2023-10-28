using DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;
using System.Drawing;
using System.Drawing.Drawing2D;
using ChartArea = DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ChartArea;
using Timer = System.Windows.Forms.Timer;

namespace XuLiAnhSo1
{

    public partial class Form1 : Form
    {

        
        private bool isDragging = false;

        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_addPicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Hình ảnh|*.jpg;*.png;*.gif;*.bmp;*.jpeg";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;

                    Bitmap newOriginalBitmap = new Bitmap(imagePath); // Tạo một bản sao mới cho originalBitmap

                    // Sử dụng Task.Run để chạy mã trong một luồng riêng biệt
                    await Task.Run(() =>
                    {
                        Image originalImage = Image.FromFile(imagePath);
                        Image scaledImage = ScaleImage(originalImage, pictureBox1.Size);

                        // Hiển thị hình ảnh trong PictureBox
                        this.Invoke(new Action(() =>
                        {
                            pictureBox1.Image = scaledImage;
                        }));

                        originalBitmap = newOriginalBitmap; // Gán bản sao mới
                        balancedBitmap = new Bitmap(originalBitmap);
                        UpdateHistogram(originalBitmap);
                    });
                }

            }
        }


        private Image ScaleImage(Image image, Size targetSize)
        {
            Bitmap newImage = new Bitmap(targetSize.Width, targetSize.Height);

            using (Graphics graphics = Graphics.FromImage(newImage))
            {
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(image, 0, 0, targetSize.Width, targetSize.Height);
            }

            return newImage;
        }

        private void btnShowHistogram_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap bitmap = new Bitmap(pictureBox1.Image);
                int[] histogram = CalculateHistogram(bitmap);

                // Định nghĩa mảng màu sắc cho biểu đồ
                Color[] colors = new Color[256]; // 256 màu sắc tương ứng với 256 giá trị mức xám
                for (int i = 0; i < 256; i++)
                {
                    colors[i] = Color.FromArgb(i, i, i); // Sử dụng màu xám với các giá trị R, G, B giống nhau.
                                                         // Nếu bạn muốn sử dụng màu khác, bạn có thể thay đổi giá trị R, G, B ở đây.
                }

                // Gọi phương thức DrawHistogram và truyền mảng màu sắc
                DrawHistogram(histogram, pictureBoxHistogram, bitmap, colors);
            }
            else
            {
                MessageBox.Show("Vui lòng tải ảnh trước khi hiển thị biểu đồ histogram.");
            }
        }

        private double numberTrack = 0.5;
        private double numberTrack1= 0.5;

        private double numberTrack2 = 0.5;

        private Bitmap balancedBitmap;
        private Bitmap originalBitmap;
        public int[] CalculateHistogram(Bitmap bitmap)
        {
            int[] histogram = new int[256]; // 256 giá trị mức xám (0-255)            
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color pixelColor = bitmap.GetPixel(x, y);
                    int grayValue = (int)(pixelColor.R * numberTrack + pixelColor.G * numberTrack1 + pixelColor.B * numberTrack2);

                    // Đảm bảo grayValue nằm trong khoảng từ 0 đến 255
                    if (grayValue >= 0 && grayValue <= 255)
                    {
                        histogram[grayValue]++;
                    }
                }
            }

            return histogram;
        }



        private void DrawHistogram(int[] histogram, PictureBox pictureBox, Bitmap originalImage, Color[] colors)
        {
            int maxCount = histogram.Max();

            // Tính toán tỷ lệ chiều rộng và chiều cao của PictureBox
            float widthRatio = (float)pictureBox.Width / originalImage.Width;
            float heightRatio = (float)pictureBox.Height / originalImage.Height;

            int scale = 1; // Điều chỉnh tỷ lệ để biểu đồ vẽ lớn hơn hoặc nhỏ hơn

            Bitmap chart = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics g = Graphics.FromImage(chart);
            

            for (int i = 0; i < histogram.Length; i++)
            {
                int barHeight = (int)(pictureBox.Height * ((float)histogram[i] / maxCount) / scale);
                Color barColor = colors[i]; // Lấy màu sắc tương ứng với giá trị


                using (Pen pen = new Pen(barColor)) // Sử dụng màu sắc tương ứng với giá trị
                {
                    g.DrawLine(pen, i * widthRatio, pictureBox.Height, i * widthRatio, pictureBox.Height - barHeight);
                }

            }

            pictureBox.Image = chart;
        }

        private bool isValueChanged = false;

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lock (imageLock)
            {
                // Cập nhật giá trị số và gọi UpdateBalancedImage()
                numberTrack = (double)trackBar1.Value / trackBar1.Maximum;
                UpdateBalancedImage();
            }

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
              //  numberTrack1 = (double)trackBar2.Value / trackBar2.Maximum;
            lock (imageLock)
            {
                // Cập nhật giá trị số và gọi UpdateBalancedImage()
                numberTrack1 = (double)trackBar2.Value / trackBar2.Maximum;
                UpdateBalancedImage();
            }

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
               // numberTrack2 = (double)trackBar3.Value / trackBar3.Maximum;
            lock (imageLock)
            {
                // Cập nhật giá trị số và gọi UpdateBalancedImage()
                numberTrack2 = (double)trackBar3.Value / trackBar3.Maximum;
                UpdateBalancedImage();
            }
        }
        private void UpdateHistogram(Bitmap bitmap)
        {
            if (pictureBox1.Image != null)
            {
                int[] histogram = CalculateHistogram(bitmap);

                // Định nghĩa mảng màu sắc cho biểu đồ
                Color[] colors = new Color[256]; // 256 màu sắc tương ứng với 256 giá trị mức xám
                for (int i = 0; i < 256; i++)
                {
                    colors[i] = Color.FromArgb(i, i, i); // Sử dụng màu xám với các giá trị R, G, B giống nhau.
                                                         // Nếu bạn muốn sử dụng màu khác, bạn có thể thay đổi giá trị R, G, B ở đây.
                }

                // Gọi phương thức DrawHistogram và truyền mảng màu sắc
                DrawHistogram(histogram, pictureBoxHistogram, bitmap, colors);
            }
            else
            {
                MessageBox.Show("Vui lòng tải ảnh trước khi hiển thị biểu đồ histogram.");
            }
        }
        private object imageLock = new object(); // Khóa đồng bộ hóa cho balancedBitmap
        private void UpdateBalancedImage()
        {
            lock (imageLock)
            {
                if (isValueChanged)
                {

                    if (originalBitmap != null)
                    {
                        Bitmap newBalancedBitmap = BalanceHistogram(originalBitmap, numberTrack, numberTrack1, numberTrack2);
                        pictureBox1.Image = newBalancedBitmap; // Hiển thị bức hình cân bằng
                        UpdateHistogram(newBalancedBitmap); // Tính toán và vẽ biểu đồ histogram cho bức hình cân bằng
                    }

                }
            }
        }
        public Bitmap BalanceHistogram(Bitmap bitmap, double numberTrack, double numberTrack1, double numberTrack2)
        {
            Bitmap balancedBitmap = new Bitmap(bitmap.Width, bitmap.Height);

            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color pixelColor = bitmap.GetPixel(x, y);
                    int grayValue = (int)(pixelColor.R * numberTrack + pixelColor.G * numberTrack1 + pixelColor.B * numberTrack2);

                    // Dkien vong lap grayValue không qua maximum
                    grayValue = Math.Max(0, Math.Min(255, grayValue));

                    Color newColor = Color.FromArgb(grayValue, grayValue, grayValue);
                    balancedBitmap.SetPixel(x, y, newColor);
                }
            }

            return balancedBitmap;
        }


        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            
            UpdateBalancedImage();
        }
        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
           
            UpdateBalancedImage();
        }

        private void trackBar2_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            
            UpdateBalancedImage();
        }

        private void trackBar3_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            
            UpdateBalancedImage();
        }
    }
}