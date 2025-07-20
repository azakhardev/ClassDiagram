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
    public partial class AttributeForm : Form
    {
        public Tables.Attribute Attribute { get; set; }
        public AttributeForm(Tables.Attribute a)
        {
            InitializeComponent();
            this.Attribute = a;

            this.NewAttribute_NameTextBox.Text = a.Name;
            this.NewAttribute_DataTextBox.Text = a.DataType;
            this.NewAttribute_ModifComboBox.Text = a.Modificator.ToString();
        }

        private void NewAttribute_SaveButton_Click(object sender, EventArgs e)
        {
            this.Save();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void NewAttribute_CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Save() 
        {
            if(this.NewAttribute_NameTextBox.Text.Trim() != "")
                this.Attribute.Name = this.NewAttribute_NameTextBox.Text;
            else
                this.Attribute.Name = "NewAtr";

            if (this.NewAttribute_DataTextBox.Text.Trim() != "")
                this.Attribute.DataType = this.NewAttribute_DataTextBox.Text;
            else
                this.Attribute.DataType = "undefined";
            
            if (this.NewAttribute_ModifComboBox.SelectedItem != null)
                this.Attribute.Modificator = this.NewAttribute_ModifComboBox.Text.ToCharArray()[0];
            else
                this.Attribute.Modificator = '+';
        }
    }
}
