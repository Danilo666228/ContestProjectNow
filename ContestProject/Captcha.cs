using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContestProject
{
    public class Captcha
    {
        public class MakeCaptcha
        {
            public static Bitmap CreateImage(int width, int height, out string captcha)
            {
                Random rand = new Random();
                Bitmap result = new Bitmap(width, height);
                Brush[] colors =
                {
                Brushes.Black,
                Brushes.Red,
                Brushes.RoyalBlue,
                Brushes.Green
            };
                Graphics g = Graphics.FromImage((Image)result);
                g.Clear(Color.Gray);
                char symbol;
                string alphabet = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
                captcha = "";
                int h = 30;
                for (int i = 0; i < 5; i++)
                {
                    int size = rand.Next(10, h);
                    symbol = alphabet[rand.Next(alphabet.Length)];
                    captcha += symbol;
                    int Ypos = rand.Next(height - size - 20);
                    int Xpos = rand.Next(i * h, (i + 1) * h - size);
                    g.DrawString(symbol.ToString(),
                        new Font("Arial", size),
                        colors[rand.Next(colors.Length)],
                        new PointF(Xpos, Ypos));
                    Pen skyBluePen = new Pen(colors[rand.Next(colors.Length)]);
                    skyBluePen.Width = rand.Next(2, 5);
                    if (i % 2 == 0)
                        g.DrawLine(skyBluePen,
                            new Point(Xpos + 5, Ypos + 5),
                            new Point(Xpos + size + 5, Ypos + size + 5));
                }
                for (int i = 0; i < width; ++i)
                    for (int j = 0; j < height; ++j)
                        if (rand.Next() % 20 == 0)
                            result.SetPixel(i, j, Color.White);
                return result;
            }
        }
    }
}
