using System.Timers;

namespace YilanOyunu
{
    public partial class Form1 : Form
    {
        List<Point> yilan;
        int sutunAdet, satirAdet, hucreGen, hucreYuk, yonX, yonY, skor;
        Random rnd = new Random();
        Point yem;
        bool yonDegisti = false;

        private void tmrOyun_Tick(object sender, EventArgs e)
        {
            yonDegisti = false;
            Point yeniBas = new Point(yilan[0].X + yonX, yilan[0].Y + yonY);

            // oyunun sonlandırılması
            if (yeniBas.X >= sutunAdet || yeniBas.X < 0 || yeniBas.Y < 0 || yeniBas.Y >= satirAdet || (yilan.Any(bogum => bogum == yeniBas) && yeniBas != yilan[yilan.Count - 1]))
            {
                tmrOyun.Stop();
                MessageBox.Show("Oyun Bitti!");
                OyunuHazirla();
                pnlOyun.Refresh();
                return;
            }

            yilan.Insert(0, yeniBas);

            if (yeniBas == yem)
            {
                skor++;
                lblSkor.Text = skor.ToString("000");
                YemUret();
            }
            else
            {
                yilan.RemoveAt(yilan.Count - 1);
            }

            pnlOyun.Refresh();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (yonDegisti)
                return base.ProcessCmdKey(ref msg, keyData);

            if (keyData == Keys.Up || keyData == Keys.Down || keyData == Keys.Left || keyData == Keys.Right)
                tmrOyun.Start();

            int x = 0, y = 0;
            if (keyData == Keys.Up)
                y = -1;
            else if (keyData == Keys.Down)
                y = 1;
            else if (keyData == Keys.Right)
                x = 1;
            else if (keyData == Keys.Left)
                x = -1;

            // hatalı yön kontrolü
            if (yonX != -x && yonY != -y)
            {
                yonX = x;
                yonY = y;
                yonDegisti = true;
            }


            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void pnlOyun_Paint(object sender, PaintEventArgs e)
        {
            bool basMi = true;
            foreach (Point bogum in yilan)
            {
                HucreBoya(e.Graphics, bogum, basMi ? Brushes.LawnGreen : Brushes.Green);
                basMi = false;
            }

            HucreBoya(e.Graphics, yem, Brushes.Red);
        }

        private void HucreBoya(Graphics graphics, Point bogum, Brush firca)
        {
            int x = bogum.X * hucreGen;
            int y = bogum.Y * hucreYuk;
            graphics.FillRectangle(firca, x, y, hucreGen, hucreYuk);
            graphics.DrawRectangle(Pens.Black, x, y, hucreGen, hucreYuk);
        }

        public Form1()
        {
            InitializeComponent();
            OyunuHazirla();
        }

        private void OyunuHazirla()
        {
            skor = 0;
            lblSkor.Text = skor.ToString("000");
            sutunAdet = 8;
            satirAdet = 8;
            hucreGen = pnlOyun.Width / sutunAdet;
            hucreYuk = pnlOyun.Height / satirAdet;

            int basX = sutunAdet / 2;
            int basY = satirAdet / 2;
            yilan = new List<Point>()
            {
                new Point(basX, basY),
                new Point(basX - 1, basY),
                new Point(basX - 2, basY)
            };
            yonX = +1;
            yonY = 0;
            YemUret();
        }

        private void YemUret()
        {
            do
            {
                yem = new Point(rnd.Next(sutunAdet), rnd.Next(satirAdet));
            } while (yilan.Any(bogum => bogum.X == yem.X && bogum.Y == yem.Y));
        }
    }
}