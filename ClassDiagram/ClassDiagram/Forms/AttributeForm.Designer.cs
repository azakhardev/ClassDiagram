namespace ClassDiagram
{
    partial class AttributeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ModifierLabel = new Label();
            Name = new Label();
            DataType = new Label();
            NewAttribute_ModifComboBox = new ComboBox();
            NewAttribute_NameTextBox = new TextBox();
            NewAttribute_DataTextBox = new TextBox();
            NewAttribute_SaveButton = new Button();
            NewAttribute_CancelButton = new Button();
            SuspendLayout();
            // 
            // ModifierLabel
            // 
            ModifierLabel.AutoSize = true;
            ModifierLabel.Location = new System.Drawing.Point(40, 21);
            ModifierLabel.Name = "ModifierLabel";
            ModifierLabel.Size = new Size(55, 15);
            ModifierLabel.TabIndex = 0;
            ModifierLabel.Text = "Modifier:";
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Location = new System.Drawing.Point(53, 64);
            Name.Name = "Name";
            Name.Size = new Size(42, 15);
            Name.TabIndex = 1;
            Name.Text = "Name:";
            // 
            // DataType
            // 
            DataType.AutoSize = true;
            DataType.Location = new System.Drawing.Point(37, 108);
            DataType.Name = "DataType";
            DataType.Size = new Size(58, 15);
            DataType.TabIndex = 2;
            DataType.Text = "DataType:";
            // 
            // NewAttribute_ModifComboBox
            // 
            NewAttribute_ModifComboBox.FormattingEnabled = true;
            NewAttribute_ModifComboBox.Items.AddRange(new object[] { "+", "-", "#" });
            NewAttribute_ModifComboBox.Location = new System.Drawing.Point(101, 18);
            NewAttribute_ModifComboBox.Name = "NewAttribute_ModifComboBox";
            NewAttribute_ModifComboBox.Size = new Size(64, 23);
            NewAttribute_ModifComboBox.TabIndex = 3;
            // 
            // NewAttribute_NameTextBox
            // 
            NewAttribute_NameTextBox.Location = new System.Drawing.Point(101, 61);
            NewAttribute_NameTextBox.Name = "NewAttribute_NameTextBox";
            NewAttribute_NameTextBox.Size = new Size(210, 23);
            NewAttribute_NameTextBox.TabIndex = 4;
            // 
            // NewAttribute_DataTextBox
            // 
            NewAttribute_DataTextBox.Location = new System.Drawing.Point(101, 105);
            NewAttribute_DataTextBox.Name = "NewAttribute_DataTextBox";
            NewAttribute_DataTextBox.Size = new Size(133, 23);
            NewAttribute_DataTextBox.TabIndex = 5;
            // 
            // NewAttribute_SaveButton
            // 
            NewAttribute_SaveButton.Location = new System.Drawing.Point(20, 166);
            NewAttribute_SaveButton.Name = "NewAttribute_SaveButton";
            NewAttribute_SaveButton.Size = new Size(75, 23);
            NewAttribute_SaveButton.TabIndex = 6;
            NewAttribute_SaveButton.Text = "Save";
            NewAttribute_SaveButton.UseVisualStyleBackColor = true;
            NewAttribute_SaveButton.Click += NewAttribute_SaveButton_Click;
            // 
            // NewAttribute_CancelButton
            // 
            NewAttribute_CancelButton.Location = new System.Drawing.Point(377, 166);
            NewAttribute_CancelButton.Name = "NewAttribute_CancelButton";
            NewAttribute_CancelButton.Size = new Size(75, 23);
            NewAttribute_CancelButton.TabIndex = 7;
            NewAttribute_CancelButton.Text = "Cancel";
            NewAttribute_CancelButton.UseVisualStyleBackColor = true;
            NewAttribute_CancelButton.Click += NewAttribute_CancelButton_Click;
            // 
            // AttributeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 201);
            Controls.Add(NewAttribute_CancelButton);
            Controls.Add(NewAttribute_SaveButton);
            Controls.Add(NewAttribute_DataTextBox);
            Controls.Add(NewAttribute_NameTextBox);
            Controls.Add(NewAttribute_ModifComboBox);
            Controls.Add(DataType);
            Controls.Add(Name);
            Controls.Add(ModifierLabel);
            StartPosition = FormStartPosition.CenterParent;
            Text = "New Attribute";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ModifierLabel;
        private Label Name;
        private Label DataType;
        private ComboBox NewAttribute_ModifComboBox;
        private TextBox NewAttribute_NameTextBox;
        private TextBox NewAttribute_DataTextBox;
        private Button NewAttribute_SaveButton;
        private Button NewAttribute_CancelButton;
    }
}