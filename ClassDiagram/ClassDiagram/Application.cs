using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ClassDiagram.Tables;

namespace ClassDiagram
{
    public class Application
    {
        public DatabaseContext Context = new DatabaseContext();

        public Class SelectedClass { get; set; }
        public Class LastSelectedClass { get; set; }

        public Corner SelectedCorner { get; set; }

        public Mover Mover { get; set; }
        public Painter Painter { get; set; }

        public Point Sizes { get; set; }
        public bool MoveWorld { get; set; } = true;
        public Graphics Graphics { get; set; }

        public Application()
        {
            this.Mover = new Mover(this);
            this.Painter = new Painter(this);
        }

        public void Click(int x, int y)
        {
            foreach (var item in this.Context.Class)
            {
                if (x > item.X && x < item.X + item.Width)
                    if (y > item.Y && y < item.Y + item.Height)
                    {
                        this.SelectedClass = item;
                        this.MoveWorld = false;

                        this.SetCorner(this.SelectedClass);
                        return;
                    }
            }

            this.SelectedClass = null;
            this.MoveWorld = true;
            this.SetCorner(this.SelectedClass);
        }

        public void SetCorner(Class c)
        {
            if (this.SelectedClass != null)
                this.SelectedCorner = new Corner(c.X + c.Width, c.Y + c.Height) { Position = "BottomRight" };
            else
                this.SelectedCorner = null;
        }

        public void EditClass(int x, int y)
        {
            if (this.SelectedClass != null)
                if (x > this.SelectedClass.X && x < this.SelectedClass.X + this.SelectedClass.Width)
                    if (y > this.SelectedClass.Y && y < this.SelectedClass.Y + this.SelectedClass.Height)
                    {
                        ClassEdit ce = new ClassEdit(this.SelectedClass);
                        ce.ShowDialog();
                    }

            this.Painter.RefreshData();
        }

        public void AddClass(Class c)
        {
            c.Name = "NewClass";
            c.X = 10; c.Y = 10;
            c.Width = 400; c.Height = 250;

            this.Context.Class.Add(c);
            this.Context.SaveChanges();
        }

        public void SavePositions()
        {
            foreach (Class item in Context.Class)
            {
                if (SelectedClass == item)
                {
                    item.X = SelectedClass.X;
                    item.Y = SelectedClass.Y;
                    item.Width = SelectedClass.Width;
                    item.Height = SelectedClass.Height;
                }
            }

            Context.SaveChanges();
        }

        public int CountWidth()
        {
            int startX = 0;
            int endX = 0;

            foreach (Class item in Context.Class)
            {
                if (startX < item.X)
                {
                    if (startX == 0)
                        startX = Math.Min(startX, item.X);
                    else
                        startX = item.X;
                }
                if (endX < item.X + item.Width)
                    endX = item.X + item.Width;
            }

            return endX - startX;
        }

        public int CountHeight()
        {
            int startY = 0;
            int endY = 0;

            foreach (Class item in Context.Class)
            {
                if (startY < item.Y)
                {
                    if (startY == 0)
                        startY = Math.Min(startY, item.Y);
                    else
                        startY = item.Y;
                }
                if (endY < item.Y + item.Height)
                    endY = item.Y + item.Height;
            }

            return endY - startY;
        }

        public int GetStartX()
        {
            int startX = 0;

            foreach (Class item in Context.Class) 
            {
                startX = Math.Max(startX, item.X);
            }

            foreach (Class item in Context.Class)
            {
                if (startX > item.X)
                {
                    if (startX == 0)
                        startX = Math.Min(startX, item.X);
                    else
                        startX = item.X;
                }
            }

            return startX;
        }

        public int GetStartY()
        {
            int startY = 0;

            foreach (Class item in Context.Class)
            {
                startY = Math.Max(startY, item.X);
            }

            foreach (Class item in Context.Class)
            {
                if (startY > item.Y)
                {
                    if (startY == 0)
                        startY = Math.Min(startY, item.Y);
                    else
                        startY = item.Y;
                }
            }

            return startY;
        }
    }
}
