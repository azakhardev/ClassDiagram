using ClassDiagram.Tables;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Crypto.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace ClassDiagram
{
    public class Painter
    {
        public DatabaseContext Context { get; set; }
        public Application App { get; set; }
        //public StringFormat Fomrat { get; set; }
        public int PadY { get; set; }
        public string Font { get; set; } = "Arial";
        public int Pieces { get; set; } = 5;

        public List<Class> Classes { get; set; }
        public List<Tables.Attribute> Attributes { get; set; }
        public List<Operation> Operations { get; set; }

        public List<OperationAttribute> OperationAttributes { get; set; }

        public Painter(Application a)
        {
            this.App = a;
            this.Context = this.App.Context;
            //this.Fomrat = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            RefreshData();
        }

        public void RefreshData()
        {
            this.Classes = this.Context.Class.ToList();
            this.Attributes = this.Context.Attribute.ToList();
            this.Operations = this.Context.Operation.ToList();
            this.OperationAttributes = this.Context.OperationAttribue.ToList();
        }

        public void DrawClass(Graphics g)
        {
            this.Classes.Clear();
            
            foreach (Class item in this.Context.Class)
            {
                g.FillRectangle(Brushes.LightGray, item.X, item.Y, item.Width, item.Height);

                g.DrawLine(Pens.Black, item.X, item.Y + item.Height / Pieces, item.X + item.Width, item.Y + item.Height / Pieces);
                g.DrawLine(Pens.Black, item.X, item.Y + item.Height / Pieces * 3, item.X + item.Width, item.Y + item.Height / Pieces * 3);

                SizeF size = g.MeasureString(item.Name, new Font(Font, 20));
                string str = this.TrimString(item, item.Name, Font, 20, g);

                g.DrawString(str, new Font(Font, 20), Brushes.Black,
                    item.X + item.Width / 2 - size.Width / 2,
                    item.Y + item.Height / Pieces - size.Height);

                this.DrawAttributes(item, g);
                this.DrawOperations(item, g);
            }
        }

        public void DrawPoint(Graphics g)
        {
            Class item = this.App.SelectedClass;
            if (item != null && this.App.SelectedCorner != null)
                g.FillRectangle(Brushes.Black, item.X + item.Width - this.App.SelectedCorner.Size,
                    item.Y + item.Height - this.App.SelectedCorner.Size, this.App.SelectedCorner.Size, this.App.SelectedCorner.Size);
        }

        public void DrawAttributes(Class c, Graphics g)
        {
            this.PadY = 0;

            foreach (Tables.Attribute item in this.Attributes.Where(a => a.ClassId == c.Id))
            {
                SizeF size = g.MeasureString($"{item.Modificator} {item.Name}:{item.DataType}", new Font(Font, 12));
                string str = this.TrimString(c, $"{item.Modificator} {item.Name}:{item.DataType}", Font, 12, g);

                if (this.PadY + size.Height + c.Height / Pieces < c.Height - c.Height / Pieces * 2)
                {
                    g.DrawString(str, new Font(Font, 12), Brushes.Black, c.X + 2, c.Y + PadY + c.Height / Pieces);
                    this.PadY += Convert.ToInt32(size.Height);
                }
            }
        }

        public void DrawOperations(Class c, Graphics g)
        {
            PadY = 0;
            foreach (Operation item in this.Operations.Where(o => o.ClassId == c.Id))
            {
                SizeF size = g.MeasureString($"{item.Modificator} {item.Name}({DrawOperationAttributes(item, g)}):{item.ReturnDataType}", new Font(Font, 12));
                string str = TrimString(c, $"{item.Modificator} {item.Name}({DrawOperationAttributes(item, g)}):{item.ReturnDataType}", Font, 12, g);

                if (this.PadY + size.Height + c.Height / Pieces < c.Height / Pieces * 3)
                {
                    g.DrawString(str, new Font(Font, 12), Brushes.Black, c.X + 2, c.Y + PadY + c.Height / Pieces * 3);
                    this.PadY += Convert.ToInt32(size.Height);
                }
            }
        }

        public string DrawOperationAttributes(Operation o, Graphics g)
        {
            string atributes = "";

            foreach (OperationAttribute item in this.OperationAttributes.Where(oa => oa.OperationId == o.Id))
            {
                atributes += $"{item.Name}:{item.DataType}, ";
            }

            if (atributes.Length > 3)
                atributes = atributes.Substring(0, atributes.Length - 2);

            return atributes;
        }

        public string TrimString(Class c, string str, string font, int fontSize, Graphics g)
        {
            SizeF size = g.MeasureString(str, new Font(font, fontSize));
            string newString = str;
            bool cutted = false;

            while (size.Width > c.Width - 2)
            {
                newString = newString.Substring(0, newString.Length - 1);
                size = g.MeasureString(newString, new Font(font, fontSize));
                cutted = true;
            }

            if (cutted == true)
                return newString + "..";
            else
                return newString;
        }

        public void Screenshot(Graphics g) 
        {

        }
    }
}
