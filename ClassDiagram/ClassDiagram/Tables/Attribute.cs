using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagram.Tables
{
    [Table("Attribute")]
    public class Attribute
    {
        [Browsable(false)]
        public int Id { get; set; }
        [Browsable(false)]
        public int ClassId { get; set; }
        public char Modificator { get; set; }
        public string Name { get; set; }
        public string DataType { get; set; }
    }
}
