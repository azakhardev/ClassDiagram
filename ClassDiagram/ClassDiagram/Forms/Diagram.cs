using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ClassDiagram.Tables;

namespace ClassDiagram
{
    public partial class Diagram : Form
    {
        public Application Application { get; set; }
        public DatabaseContext Context { get; set; } = new DatabaseContext();

        public Bitmap Bitmap { get; set; }
        private double Scale { get; set; } = 1;
        private Point MouseCenter { get; set; }

        public Diagram()
        {
            InitializeComponent();

            this.Application = new Application() { Sizes = new Point(this.Diagram_PictureBox.Width, this.Diagram_PictureBox.Height) };
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Diagram_PictureBox.Refresh();
        }

        private void Diagram_PictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.ScaleTransform(1, 1);
            e.Graphics.DrawString($"Scale:{Math.Round(this.Scale, 2)}", new Font("Arial", 12), Brushes.Black, 0, 0);

            e.Graphics.TranslateTransform(this.MouseCenter.X, this.MouseCenter.Y);
            e.Graphics.ScaleTransform((float)Scale, (float)Scale);
            e.Graphics.TranslateTransform(-this.MouseCenter.X, -this.MouseCenter.Y);

            this.Application.Painter.DrawClass(e.Graphics);
            this.Application.Painter.DrawPoint(e.Graphics);
        }

        private void Diagram_PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.Scale == 1)
            {
                this.Application.Click(e.X, e.Y);
                this.Application.Mover.StartPoint = e.Location;
            }
        }

        private void Diagram_PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            this.Application.Mover.LastPoint = e.Location;
            this.Application.Mover.Move();
        }

        private void Diagram_PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.Scale == 1)
            {
                this.Application.Mover.StartPoint = new Point(0, 0);

                this.Application.LastSelectedClass = this.Application.SelectedClass;
                this.Application.SavePositions();
            }
        }

        private void Diagram_PictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Scale == 1)
            {
                this.Application.EditClass(e.X, e.Y);
            }
        }

        private void Diagram_NewButton_Click(object sender, EventArgs e)
        {
            this.Application.AddClass(new Class());

            this.Application.SelectedCorner = null;

            this.Application.Painter.RefreshData();
        }

        private void Diagram_DeleteButton_Click(object sender, EventArgs e)
        {
            Class c = this.Application.SelectedClass;

            
            if (c != null)
                this.Context.Remove(this.Context.Class.Find(c.Id));

            this.Application.SelectedCorner = null;
            this.Context.SaveChanges();
            this.Application.Painter.RefreshData();
        }

        public void Diagram_PictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && this.Scale < 3)
                this.Scale += 0.1;
            if (e.Delta < 0 && this.Scale > 0.5)
                this.Scale -= 0.1;

            this.MouseCenter = e.Location;
        }

        private void Diagram_ScreenshotButton_Click(object sender, EventArgs e)
        {
            this.Bitmap = new Bitmap(this.Application.CountWidth() - this.Application.GetStartX(), this.Application.CountHeight() - this.Application.GetStartY());

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = DateTime.Now.ToString("MM-dd-yyyTHH-mm-ss") + ".jpg";

            Graphics g = Graphics.FromImage(this.Bitmap);

            g.FillRectangle(Brushes.White, 0, 0, this.Application.CountWidth() - this.Application.GetStartX(), this.Application.CountHeight() - this.Application.GetStartY());

            g.TranslateTransform(-this.Application.GetStartX(), -this.Application.GetStartY());

            this.Application.Painter.DrawClass(g);
            this.Application.Painter.DrawPoint(g);

            this.Bitmap.Save(path + @"\" + fileName);
        }
    }
}