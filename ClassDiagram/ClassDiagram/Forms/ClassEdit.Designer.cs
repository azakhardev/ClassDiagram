namespace ClassDiagram
{
    partial class ClassEdit
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
            ClassName_Label = new Label();
            ClassEdit_CloseButton = new Button();
            ClassEdit_SaveButton = new Button();
            ClassEdit_NameTextBox = new TextBox();
            ClassEdit_AttributesGrid = new DataGridView();
            ClassEdit_OperationsGrid = new DataGridView();
            Attributes_Label = new Label();
            Operations_Label = new Label();
            ClassEdit_AAddButton = new Button();
            ClassEdit_ADeleteButton = new Button();
            ClassEdit_OAddButton = new Button();
            ClassEdit_ODeleteButton = new Button();
            ClassEdit_OEditButton = new Button();
            ClassEdit_AEditButton = new Button();
            OModif = new DataGridViewTextBoxColumn();
            OName = new DataGridViewTextBoxColumn();
            ReturnDataType = new DataGridViewTextBoxColumn();
            AModif = new DataGridViewTextBoxColumn();
            AName = new DataGridViewTextBoxColumn();
            DataType = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ClassEdit_AttributesGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ClassEdit_OperationsGrid).BeginInit();
            SuspendLayout();
            // 
            // ClassName_Label
            // 
            ClassName_Label.AutoSize = true;
            ClassName_Label.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ClassName_Label.Location = new System.Drawing.Point(358, -2);
            ClassName_Label.Name = "ClassName_Label";
            ClassName_Label.Size = new Size(114, 25);
            ClassName_Label.TabIndex = 0;
            ClassName_Label.Text = "Class Name:";
            // 
            // ClassEdit_CloseButton
            // 
            ClassEdit_CloseButton.Location = new System.Drawing.Point(713, 415);
            ClassEdit_CloseButton.Name = "ClassEdit_CloseButton";
            ClassEdit_CloseButton.Size = new Size(75, 23);
            ClassEdit_CloseButton.TabIndex = 1;
            ClassEdit_CloseButton.Text = "Close";
            ClassEdit_CloseButton.UseVisualStyleBackColor = true;
            ClassEdit_CloseButton.Click += ClassEdit_CloseButton_Click;
            // 
            // ClassEdit_SaveButton
            // 
            ClassEdit_SaveButton.Location = new System.Drawing.Point(12, 415);
            ClassEdit_SaveButton.Name = "ClassEdit_SaveButton";
            ClassEdit_SaveButton.Size = new Size(75, 23);
            ClassEdit_SaveButton.TabIndex = 2;
            ClassEdit_SaveButton.Text = "Save";
            ClassEdit_SaveButton.UseVisualStyleBackColor = true;
            ClassEdit_SaveButton.Click += ClassEdit_SaveButton_Click;
            // 
            // ClassEdit_NameTextBox
            // 
            ClassEdit_NameTextBox.Location = new System.Drawing.Point(272, 26);
            ClassEdit_NameTextBox.Name = "ClassEdit_NameTextBox";
            ClassEdit_NameTextBox.Size = new Size(296, 23);
            ClassEdit_NameTextBox.TabIndex = 3;
            ClassEdit_NameTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // ClassEdit_AttributesGrid
            // 
            ClassEdit_AttributesGrid.AllowUserToAddRows = false;
            ClassEdit_AttributesGrid.AllowUserToDeleteRows = false;
            ClassEdit_AttributesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClassEdit_AttributesGrid.Columns.AddRange(new DataGridViewColumn[] { AModif, AName, DataType });
            ClassEdit_AttributesGrid.Location = new System.Drawing.Point(32, 81);
            ClassEdit_AttributesGrid.Name = "ClassEdit_AttributesGrid";
            ClassEdit_AttributesGrid.ReadOnly = true;
            ClassEdit_AttributesGrid.RowTemplate.Height = 25;
            ClassEdit_AttributesGrid.Size = new Size(370, 280);
            ClassEdit_AttributesGrid.TabIndex = 4;
            // 
            // ClassEdit_OperationsGrid
            // 
            ClassEdit_OperationsGrid.AllowUserToAddRows = false;
            ClassEdit_OperationsGrid.AllowUserToDeleteRows = false;
            ClassEdit_OperationsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClassEdit_OperationsGrid.Columns.AddRange(new DataGridViewColumn[] { OModif, OName, ReturnDataType });
            ClassEdit_OperationsGrid.Location = new System.Drawing.Point(418, 81);
            ClassEdit_OperationsGrid.Name = "ClassEdit_OperationsGrid";
            ClassEdit_OperationsGrid.ReadOnly = true;
            ClassEdit_OperationsGrid.RowTemplate.Height = 25;
            ClassEdit_OperationsGrid.Size = new Size(370, 280);
            ClassEdit_OperationsGrid.TabIndex = 5;
            // 
            // Attributes_Label
            // 
            Attributes_Label.AutoSize = true;
            Attributes_Label.Location = new System.Drawing.Point(195, 63);
            Attributes_Label.Name = "Attributes_Label";
            Attributes_Label.Size = new Size(62, 15);
            Attributes_Label.TabIndex = 6;
            Attributes_Label.Text = "Attributes:";
            // 
            // Operations_Label
            // 
            Operations_Label.AutoSize = true;
            Operations_Label.Location = new System.Drawing.Point(588, 63);
            Operations_Label.Name = "Operations_Label";
            Operations_Label.Size = new Size(65, 15);
            Operations_Label.TabIndex = 7;
            Operations_Label.Text = "Operations";
            // 
            // ClassEdit_AAddButton
            // 
            ClassEdit_AAddButton.Location = new System.Drawing.Point(100, 367);
            ClassEdit_AAddButton.Name = "ClassEdit_AAddButton";
            ClassEdit_AAddButton.Size = new Size(75, 23);
            ClassEdit_AAddButton.TabIndex = 8;
            ClassEdit_AAddButton.Text = "Add";
            ClassEdit_AAddButton.UseVisualStyleBackColor = true;
            ClassEdit_AAddButton.Click += ClassEdit_AAddButton_Click;
            // 
            // ClassEdit_ADeleteButton
            // 
            ClassEdit_ADeleteButton.Location = new System.Drawing.Point(290, 367);
            ClassEdit_ADeleteButton.Name = "ClassEdit_ADeleteButton";
            ClassEdit_ADeleteButton.Size = new Size(75, 23);
            ClassEdit_ADeleteButton.TabIndex = 9;
            ClassEdit_ADeleteButton.Text = "Delete";
            ClassEdit_ADeleteButton.UseVisualStyleBackColor = true;
            ClassEdit_ADeleteButton.Click += ClassEdit_ADeleteButton_Click;
            // 
            // ClassEdit_OAddButton
            // 
            ClassEdit_OAddButton.Location = new System.Drawing.Point(493, 367);
            ClassEdit_OAddButton.Name = "ClassEdit_OAddButton";
            ClassEdit_OAddButton.Size = new Size(75, 23);
            ClassEdit_OAddButton.TabIndex = 10;
            ClassEdit_OAddButton.Text = "Add";
            ClassEdit_OAddButton.UseVisualStyleBackColor = true;
            ClassEdit_OAddButton.Click += ClassEdit_OAddButton_Click;
            // 
            // ClassEdit_ODeleteButton
            // 
            ClassEdit_ODeleteButton.Location = new System.Drawing.Point(656, 367);
            ClassEdit_ODeleteButton.Name = "ClassEdit_ODeleteButton";
            ClassEdit_ODeleteButton.Size = new Size(75, 23);
            ClassEdit_ODeleteButton.TabIndex = 11;
            ClassEdit_ODeleteButton.Text = "Delete";
            ClassEdit_ODeleteButton.UseVisualStyleBackColor = true;
            ClassEdit_ODeleteButton.Click += ClassEdit_ODeleteButton_Click;
            // 
            // ClassEdit_OEditButton
            // 
            ClassEdit_OEditButton.Location = new System.Drawing.Point(575, 367);
            ClassEdit_OEditButton.Name = "ClassEdit_OEditButton";
            ClassEdit_OEditButton.Size = new Size(75, 23);
            ClassEdit_OEditButton.TabIndex = 12;
            ClassEdit_OEditButton.Text = "Edit";
            ClassEdit_OEditButton.UseVisualStyleBackColor = true;
            ClassEdit_OEditButton.Click += ClassEdit_OEditButton_Click;
            // 
            // ClassEdit_AEditButton
            // 
            ClassEdit_AEditButton.Location = new System.Drawing.Point(195, 367);
            ClassEdit_AEditButton.Name = "ClassEdit_AEditButton";
            ClassEdit_AEditButton.Size = new Size(75, 23);
            ClassEdit_AEditButton.TabIndex = 13;
            ClassEdit_AEditButton.Text = "Edit";
            ClassEdit_AEditButton.UseVisualStyleBackColor = true;
            ClassEdit_AEditButton.Click += ClassEdit_AEditButton_Click;
            // 
            // OModif
            // 
            OModif.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OModif.DataPropertyName = "Modificator";
            OModif.HeaderText = "Modificator";
            OModif.Name = "OModif";
            OModif.ReadOnly = true;
            OModif.Resizable = DataGridViewTriState.False;
            // 
            // OName
            // 
            OName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OName.DataPropertyName = "Name";
            OName.HeaderText = "Name";
            OName.Name = "OName";
            OName.ReadOnly = true;
            OName.Resizable = DataGridViewTriState.True;
            // 
            // ReturnDataType
            // 
            ReturnDataType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ReturnDataType.DataPropertyName = "ReturnDataType";
            ReturnDataType.HeaderText = "Returns";
            ReturnDataType.Name = "ReturnDataType";
            ReturnDataType.ReadOnly = true;
            ReturnDataType.Resizable = DataGridViewTriState.False;
            // 
            // AModif
            // 
            AModif.DataPropertyName = "Modificator";
            AModif.HeaderText = "Modificator";
            AModif.Name = "AModif";
            AModif.ReadOnly = true;
            AModif.Resizable = DataGridViewTriState.False;
            // 
            // AName
            // 
            AName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AName.DataPropertyName = "Name";
            AName.HeaderText = "Name";
            AName.Name = "AName";
            AName.ReadOnly = true;
            // 
            // DataType
            // 
            DataType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataType.DataPropertyName = "DataType";
            DataType.HeaderText = "DataType";
            DataType.Name = "DataType";
            DataType.ReadOnly = true;
            DataType.Resizable = DataGridViewTriState.False;
            // 
            // ClassEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ClassEdit_AEditButton);
            Controls.Add(ClassEdit_OEditButton);
            Controls.Add(ClassEdit_ODeleteButton);
            Controls.Add(ClassEdit_OAddButton);
            Controls.Add(ClassEdit_ADeleteButton);
            Controls.Add(ClassEdit_AAddButton);
            Controls.Add(Operations_Label);
            Controls.Add(Attributes_Label);
            Controls.Add(ClassEdit_OperationsGrid);
            Controls.Add(ClassEdit_AttributesGrid);
            Controls.Add(ClassEdit_NameTextBox);
            Controls.Add(ClassEdit_SaveButton);
            Controls.Add(ClassEdit_CloseButton);
            Controls.Add(ClassName_Label);
            Name = "ClassEdit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Class";
            ((System.ComponentModel.ISupportInitialize)ClassEdit_AttributesGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)ClassEdit_OperationsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ClassName_Label;
        private Button ClassEdit_CloseButton;
        private Button ClassEdit_SaveButton;
        private TextBox ClassEdit_NameTextBox;
        private DataGridView ClassEdit_AttributesGrid;
        private DataGridView ClassEdit_OperationsGrid;
        private Label Attributes_Label;
        private Label Operations_Label;
        private Button ClassEdit_AAddButton;
        private Button ClassEdit_ADeleteButton;
        private Button ClassEdit_OAddButton;
        private Button ClassEdit_ODeleteButton;
        private Button ClassEdit_OEditButton;
        private Button ClassEdit_AEditButton;
        private DataGridViewTextBoxColumn AModif;
        private DataGridViewTextBoxColumn AName;
        private DataGridViewTextBoxColumn DataType;
        private DataGridViewTextBoxColumn OModif;
        private DataGridViewTextBoxColumn OName;
        private DataGridViewTextBoxColumn ReturnDataType;
    }
}