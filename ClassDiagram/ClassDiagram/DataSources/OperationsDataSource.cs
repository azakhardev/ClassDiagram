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
    public class OperationsDataSource : IListSource
    {
        public DatabaseContext Context = new DatabaseContext();
        public BindingList<Operation> Operations = new();

        public OperationsDataSource(Class c)
        {
            this.Operations = new BindingList<Operation>(this.Context.Operation.Where(o => o.ClassId == c.Id).ToList());
        }

        public bool ContainsListCollection => true;

        public IList GetList()
        {
            return this.Operations;
        }

        public void AddOperation(Operation o)
        {
            this.Operations.Add(o);
            this.Context.Operation.Add(o);
            this.Context.SaveChanges();
        }

        public void EditOperation(Operation o)
        {
            Operation updatedOperation = this.Context.Operation.Find(o.Id);

            updatedOperation.Modificator = o.Modificator;
            updatedOperation.Name = o.Name;
            updatedOperation.ReturnDataType = o.ReturnDataType;

            this.Operations.Insert(this.Operations.IndexOf(o), updatedOperation);
            this.Operations.RemoveAt(Operations.IndexOf(o));
            this.Context.SaveChanges();
        }

        public void DeleteOperation(Operation o)
        {
            this.Operations.Remove(o);
            this.Context.Operation.Remove(Context.Operation.Find(o.Id));
            this.Context.SaveChanges();
        }
    }
}
