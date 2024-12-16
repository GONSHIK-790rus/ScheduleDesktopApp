using System.Drawing;

namespace ScheduleApp.Captcha {
    internal class Captcha {
        private string captcha;
        private Bitmap btm;
        public Bitmap _btm { get { return btm; } }

        public Captcha(Size bitmapSize) {
            if (bitmapSize == null) 
                throw new ArgumentNullException();
            btm = new Bitmap(bitmapSize.Width, bitmapSize.Height);
            Next();
        }

        private string RandomCaptchaGeneration() {
            string ret = "";
            Random rnd = new Random();
            int buf = 0;

            for (int i = 0; i < 5; i++) {
                buf = rnd.Next(0, 63);

                if (buf >= 0 && buf <= 9)
                    ret += buf;

                if (buf >= 10 && buf < 36)
                    ret += (char)(buf + 55);

                if (buf >= 37 && buf < 63)
                    ret += (char)(buf + 60);
            }

            return ret;
        }

        private void BitmapPaint() {
            btm = new Bitmap(btm.Width, btm.Height);
            Random r = new Random();

            using (Graphics g = Graphics.FromImage(btm)) {
                g.DrawString(captcha, new Font("Arial", 28), new SolidBrush(Color.Black), 0, 0, new StringFormat());

                Point start = new Point(0, r.Next(btm.Height));
                Point end = new Point(btm.Width - 1, r.Next(btm.Height));

                Color lineColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
                using (Pen pen = new Pen(lineColor, 2)) {
                    g.DrawLine(pen, start, end);
                }
            }



            for (int i = 0; i < btm.Width; i += r.Next(2, 4)) {
                for (int j = 0; j < btm.Height; j += r.Next(1, 3)) {
                    int num = r.Next(0, 255);
                    btm.SetPixel(i, j, Color.FromArgb(255, num, num, num));
                }
            }
        }

        public void Next() {
            captcha = RandomCaptchaGeneration();
            BitmapPaint();
        }

        public bool CheackCaptch(string captcha) {
            return captcha == this.captcha;
        }
    }
}
