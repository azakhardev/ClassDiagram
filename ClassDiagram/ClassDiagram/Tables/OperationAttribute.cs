using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagram.Tables
{
    [Table("OperationAttribute")]
    public class OperationAttribute
    {
        [Browsable(false)]
        public int Id { get; set; }

        [Browsable(false)]
        public int OperationId { get; set; }

        public string Name { get; set; }

        public string DataType { get; set; }
    }
}
