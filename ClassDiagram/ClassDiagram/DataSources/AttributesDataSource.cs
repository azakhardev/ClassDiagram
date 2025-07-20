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
    public class AttributesDataSource : IListSource
    {
        public DatabaseContext Context = new DatabaseContext();
        public BindingList<Tables.Attribute> Attributes = new();

        public AttributesDataSource(Class c)
        {
            //this.Context.Attribute.Load();
            //this.Attributes = this.Context.Attribute.Local.ToBindingList();
            this.Attributes = new BindingList<Tables.Attribute>(this.Context.Attribute.Where(x => x.ClassId == c.Id).ToList());
        }

        public bool ContainsListCollection => true;

        public IList GetList()
        {
            return this.Attributes;
        }

        public void AddAttribut(Tables.Attribute a)
        {
            this.Attributes.Add(a);
            this.Context.Attribute.Add(a);
            this.Context.SaveChanges();
        }

        public void EditAttribute(Tables.Attribute a) 
        {
            Tables.Attribute updatedAttribute = this.Context.Attribute.Find(a.Id);

            updatedAttribute.Name = a.Name;
            updatedAttribute.Modificator = a.Modificator;
            updatedAttribute.DataType = a.DataType;

            this.Attributes.Insert(Attributes.IndexOf(a), updatedAttribute);
            this.Attributes.RemoveAt(Attributes.IndexOf(a));
            this.Context.SaveChanges();
        }

        public void DeleteAttribute(Tables.Attribute a)
        {
            this.Attributes.Remove(a);
            this.Context.Attribute.Remove(a);
            this.Context.SaveChanges();
        }
    }
}