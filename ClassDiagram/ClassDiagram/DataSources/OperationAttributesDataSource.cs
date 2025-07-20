using ClassDiagram.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagram.DataSources
{
    public class OperationAttributesDataSource : IListSource
    {
        public DatabaseContext Context = new DatabaseContext();
        public BindingList<OperationAttribute> OperationAttributes = new ();

        public OperationAttributesDataSource(Operation o)
        {
            this.OperationAttributes = new BindingList<OperationAttribute>(this.Context.OperationAttribue.Where(oa => oa.OperationId == o.Id).ToList());
        }

        public bool ContainsListCollection => true;

        public IList GetList()
        {
            return this.OperationAttributes;
        }

        public void AddOpAtr(OperationAttribute oa) 
        {
            this.OperationAttributes.Add(oa);
            this.Context.OperationAttribue.Add(oa);
            this.Context.SaveChanges();
        }

        public void EditOpAtr(OperationAttribute oa) 
        {
            OperationAttribute updatedOA = this.Context.OperationAttribue.Find(oa.Id);

            updatedOA.Name = oa.Name;
            updatedOA.DataType = oa.DataType;

            this.OperationAttributes.Insert(this.OperationAttributes.IndexOf(oa), updatedOA);
            this.OperationAttributes.RemoveAt(this.OperationAttributes.IndexOf(oa));
            this.Context.SaveChanges();
        }

        public void DeleteOpAtr(OperationAttribute oa) 
        {
            this.OperationAttributes.Remove(oa);
            this.Context.OperationAttribue.Remove(this.Context.OperationAttribue.Find(oa.Id));
            this.Context.SaveChanges();
        }
    }
}
