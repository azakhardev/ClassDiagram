using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassDiagram.Tables;

namespace ClassDiagram
{
    public partial class OperationAttributeForm : Form
    {
        public DatabaseContext Context = new DatabaseContext();
        public OperationAttribute OperationAttribute { get; set; }
        public OperationAttributeForm(OperationAttribute oa)
        {
            InitializeComponent();

            OperationAttribute = oa;

            this.OAForm_NameTextBox.Text = oa.Name;
            this.OAForm_DataTextBox.Text = oa.DataType;
        }


        private void OAForm_SaveButton_Click(object sender, EventArgs e)
        {
            this.Save();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void OAForm_CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private void Save()
        {
            this.OperationAttribute.Name = this.OAForm_NameTextBox.Text;
            this.OperationAttribute.DataType = this.OAForm_DataTextBox.Text;
        }
    }
}
