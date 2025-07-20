using ClassDiagram.DataSources;
using ClassDiagram.Tables;
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
    public partial class OperationForm : Form
    {
        public DatabaseContext DatabaseContext = new DatabaseContext();
        public OperationAttributesDataSource Data { get; set; }
        public Operation Operation { get; set; }

        public bool New { get; set; } = false;

        public OperationForm(Operation o)
        {
            InitializeComponent();

            this.Operation = o;

            this.Data = new(this.Operation);

            this.Operation_DataGrid.DataSource = Data.GetList();
            this.Operation_DataGrid.AutoGenerateColumns = true;

            this.Operation_NameTextBox.Text = o.Name;
            this.Operation_ReturnsTextBox.Text = o.ReturnDataType;
            this.Operation_ModifComboBox.Text = o.Modificator.ToString();
        }

        private void OperationForm_SaveButton_Click(object sender, EventArgs e)
        {
            this.Save();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void OperationForm_CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }              

        private void OperationForm_AddButton_Click(object sender, EventArgs e)
        {
            if (this.New == false)
            {
                OperationAttributeForm opAtrFrm = new OperationAttributeForm(new OperationAttribute() { OperationId = this.Operation.Id });
                if (opAtrFrm.ShowDialog() == DialogResult.OK)
                    this.Data.AddOpAtr(opAtrFrm.OperationAttribute);
            }
        }

        private void OperationForm_EditButton_Click(object sender, EventArgs e)
        {
            if (this.Data.GetList().Count > 0)
            {
                OperationAttribute opAtr = this.Operation_DataGrid.CurrentRow.DataBoundItem as OperationAttribute;
                OperationAttributeForm opAtrFrm = new OperationAttributeForm(opAtr);

                if (opAtrFrm.ShowDialog() == DialogResult.OK)
                    this.Data.EditOpAtr(opAtrFrm.OperationAttribute);
            }
        }

        private void OperationForm_DeleteButton_Click(object sender, EventArgs e)
        {
            if (this.Data.GetList().Count > 0)
                this.Data.DeleteOpAtr(this.Operation_DataGrid.CurrentRow.DataBoundItem as OperationAttribute);
        }

        private void Save()
        {
            if (this.Operation_NameTextBox.Text.Trim() != "")
                this.Operation.Name = this.Operation_NameTextBox.Text;
            else
                this.Operation.Name = "NewOperation";

            if (this.Operation_ReturnsTextBox.Text.Trim() != "")
                this.Operation.ReturnDataType = this.Operation_ReturnsTextBox.Text;
            else
                this.Operation.ReturnDataType = "undefined";
            
            if (this.Operation_ModifComboBox.Text != "")
                this.Operation.Modificator = this.Operation_ModifComboBox.Text.ToCharArray()[0];
            else
                this.Operation.Modificator = '+';
        }
    }
}
