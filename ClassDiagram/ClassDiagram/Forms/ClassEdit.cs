using ClassDiagram.DataSources;
using ClassDiagram.Tables;
using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassDiagram
{
    public partial class ClassEdit : Form
    {
        public DatabaseContext Context = new DatabaseContext();

        public Class Class { get; set; }

        public AttributesDataSource AttributesData { get; set; }
        public OperationsDataSource OperationsData { get; set; }


        public ClassEdit(Class c)
        {
            InitializeComponent();
            this.Class = c;

            this.AttributesData = new(this.Class);
            this.OperationsData = new(this.Class);

            this.ClassEdit_AttributesGrid.DataSource = this.AttributesData.GetList();
            this.ClassEdit_AttributesGrid.AutoGenerateColumns = true;

            this.ClassEdit_OperationsGrid.DataSource = this.OperationsData.GetList();
            this.ClassEdit_OperationsGrid.AutoGenerateColumns = true;

            this.ClassEdit_NameTextBox.Text = c.Name;
        }

        private void ClassEdit_CloseButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ClassEdit_SaveButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Class.Name = this.ClassEdit_NameTextBox.Text;
            this.Close();
        }

        private void ClassEdit_AAddButton_Click(object sender, EventArgs e)
        {
            AttributeForm atrFrm = new AttributeForm(new Tables.Attribute() { ClassId = this.Class.Id });

            if (atrFrm.ShowDialog() == DialogResult.OK)
                this.AttributesData.AddAttribut(atrFrm.Attribute);
        }

        private void ClassEdit_AEditButton_Click(object sender, EventArgs e)
        {
            if (this.AttributesData.GetList().Count > 0)
            {
                Tables.Attribute atr = this.ClassEdit_AttributesGrid.CurrentRow.DataBoundItem as Tables.Attribute;
                AttributeForm atrFrm = new AttributeForm(atr);

                if (atrFrm.ShowDialog() == DialogResult.OK)
                    this.AttributesData.EditAttribute(atrFrm.Attribute);
            }
        }

        private void ClassEdit_ADeleteButton_Click(object sender, EventArgs e)
        {
            if (AttributesData.GetList().Count > 0)
                this.AttributesData.DeleteAttribute(this.ClassEdit_AttributesGrid.CurrentRow.DataBoundItem as Tables.Attribute);
        }

        private void ClassEdit_OAddButton_Click(object sender, EventArgs e)
        {
            OperationForm opFrm = new OperationForm(new Operation() { ClassId = this.Class.Id }) { New = true };

            if (opFrm.ShowDialog() == DialogResult.OK)
                this.OperationsData.AddOperation(opFrm.Operation);
        }

        private void ClassEdit_OEditButton_Click(object sender, EventArgs e)
        {
            if (this.OperationsData.GetList().Count > 0)
            {
                Operation op = this.ClassEdit_OperationsGrid.CurrentRow.DataBoundItem as Operation;
                OperationForm opFrm = new OperationForm(op);

                if (opFrm.ShowDialog() == DialogResult.OK)
                    this.OperationsData.EditOperation(opFrm.Operation);
            }
        }

        private void ClassEdit_ODeleteButton_Click(object sender, EventArgs e)
        {
            if (OperationsData.GetList().Count > 0)
                this.OperationsData.DeleteOperation(this.ClassEdit_OperationsGrid.CurrentRow.DataBoundItem as Operation);
        }
    }
}