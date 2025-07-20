using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagram.Tables
{
    [Table("Class")]
    public class Class
    {
        [Browsable(false)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        [ForeignKey("ClassId")]
        public List<Attribute> Attribute { get; set; }

        [ForeignKey("ClassId")]
        public List<Operation> Operation { get; set; }
    }
}
