using ClassDiagram.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagram
{
    public class Mover
    {
        public Application App { get; set; }

        public Point StartPoint { get; set; } = new Point();
        public Point LastPoint { get; set; } = new Point();

        public Mover(Application a)
        {
            this.App = a;
        }

        public void Move()
        {
            if (this.App.LastSelectedClass == this.App.SelectedClass && this.App.SelectedClass != null)
            {
                if (this.App.SelectedClass != null && StartPoint.X != 0 && StartPoint.Y != 0)
                    if (!CornerSelected())
                        this.MoveClass();
                    else
                        this.Resize();
            }
            else if (this.App.MoveWorld == true && StartPoint.X != 0 && StartPoint.Y != 0)
            {
                this.MoveEnvironment();
            }
        }

        public void MoveEnvironment()
        {
            foreach (Class item in this.App.Context.Class)
            {
                item.X += this.LastPoint.X - this.StartPoint.X;
                item.Y += this.LastPoint.Y - this.StartPoint.Y;
            }

            this.StartPoint = this.LastPoint;
        }

        public void MoveClass()
        {
            if (this.LastPoint.X > 0 && this.LastPoint.Y > 0 && this.LastPoint.X < this.App.Sizes.X && this.LastPoint.Y < this.App.Sizes.Y)
            {
                this.App.SelectedClass.X += this.LastPoint.X - this.StartPoint.X;
                this.App.SelectedClass.Y += this.LastPoint.Y - this.StartPoint.Y;
                
                this.StartPoint= this.LastPoint;

                this.MoveCorner();
            }
        }

        public bool CornerSelected()
        {
            if (this.App.SelectedCorner != null)
                if (StartPoint.X > this.App.SelectedCorner.X && StartPoint.X < this.App.SelectedCorner.X + this.App.SelectedCorner.Size)
                    if (StartPoint.Y > this.App.SelectedCorner.Y && StartPoint.Y < this.App.SelectedCorner.Y + this.App.SelectedCorner.Size)
                        return true;

            return false;
        }

        public void Resize()
        {
            this.App.SelectedClass.Width = this.LastPoint.X - this.App.SelectedClass.X;
            if (this.App.SelectedClass.Width < 100)
                this.App.SelectedClass.Width = 100;

            this.App.SelectedClass.Height = this.LastPoint.Y - this.App.SelectedClass.Y;
            if (this.App.SelectedClass.Height < 150)
                this.App.SelectedClass.Height = 150;
        }

        public void MoveCorner()
        {
            this.App.SelectedCorner.X = this.App.SelectedClass.X + this.App.SelectedClass.Width - this.App.SelectedCorner.Size;
            this.App.SelectedCorner.Y = this.App.SelectedClass.Y + this.App.SelectedClass.Height - this.App.SelectedCorner.Size;
        }
    }
}
