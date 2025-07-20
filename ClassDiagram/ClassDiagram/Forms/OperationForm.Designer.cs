namespace ClassDiagram
{
    partial class OperationForm
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
            OperationForm_SaveButton = new Button();
            OperationForm_CancelButton = new Button();
            OperationForm_ModifierLabel = new Label();
            OperationForm_NameLabel = new Label();
            OperationForm_ReturnsLabel = new Label();
            Operation_ModifComboBox = new ComboBox();
            Operation_NameTextBox = new TextBox();
            Operation_ReturnsTextBox = new TextBox();
            Operation_DataGrid = new DataGridView();
            OperationForm_AddButton = new Button();
            OperationForm_DeleteButton = new Button();
            OperationForm_EditButton = new Button();
            OperationForm_OperAtrLabel = new Label();
            Name = new DataGridViewTextBoxColumn();
            DataType = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)Operation_DataGrid).BeginInit();
            SuspendLayout();
            // 
            // OperationForm_SaveButton
            // 
            OperationForm_SaveButton.Location = new System.Drawing.Point(456, 306);
            OperationForm_SaveButton.Name = "OperationForm_SaveButton";
            OperationForm_SaveButton.Size = new Size(75, 23);
            OperationForm_SaveButton.TabIndex = 0;
            OperationForm_SaveButton.Text = "Save";
            OperationForm_SaveButton.UseVisualStyleBackColor = true;
            OperationForm_SaveButton.Click += OperationForm_SaveButton_Click;
            // 
            // OperationForm_CancelButton
            // 
            OperationForm_CancelButton.Location = new System.Drawing.Point(537, 306);
            OperationForm_CancelButton.Name = "OperationForm_CancelButton";
            OperationForm_CancelButton.Size = new Size(75, 23);
            OperationForm_CancelButton.TabIndex = 1;
            OperationForm_CancelButton.Text = "Cancel";
            OperationForm_CancelButton.UseVisualStyleBackColor = true;
            OperationForm_CancelButton.Click += OperationForm_CancelButton_Click;
            // 
            // OperationForm_ModifierLabel
            // 
            OperationForm_ModifierLabel.AutoSize = true;
            OperationForm_ModifierLabel.Location = new System.Drawing.Point(32, 39);
            OperationForm_ModifierLabel.Name = "OperationForm_ModifierLabel";
            OperationForm_ModifierLabel.Size = new Size(55, 15);
            OperationForm_ModifierLabel.TabIndex = 2;
            OperationForm_ModifierLabel.Text = "Modifier:";
            // 
            // OperationForm_NameLabel
            // 
            OperationForm_NameLabel.AutoSize = true;
            OperationForm_NameLabel.Location = new System.Drawing.Point(45, 72);
            OperationForm_NameLabel.Name = "OperationForm_NameLabel";
            OperationForm_NameLabel.Size = new Size(42, 15);
            OperationForm_NameLabel.TabIndex = 3;
            OperationForm_NameLabel.Text = "Name:";
            // 
            // OperationForm_ReturnsLabel
            // 
            OperationForm_ReturnsLabel.AutoSize = true;
            OperationForm_ReturnsLabel.Location = new System.Drawing.Point(37, 101);
            OperationForm_ReturnsLabel.Name = "OperationForm_ReturnsLabel";
            OperationForm_ReturnsLabel.Size = new Size(50, 15);
            OperationForm_ReturnsLabel.TabIndex = 4;
            OperationForm_ReturnsLabel.Text = "Returns:";
            // 
            // Operation_ModifComboBox
            // 
            Operation_ModifComboBox.FormattingEnabled = true;
            Operation_ModifComboBox.Items.AddRange(new object[] { "+", "-", "#" });
            Operation_ModifComboBox.Location = new System.Drawing.Point(93, 31);
            Operation_ModifComboBox.Name = "Operation_ModifComboBox";
            Operation_ModifComboBox.Size = new Size(54, 23);
            Operation_ModifComboBox.TabIndex = 5;
            // 
            // Operation_NameTextBox
            // 
            Operation_NameTextBox.Location = new System.Drawing.Point(93, 64);
            Operation_NameTextBox.Name = "Operation_NameTextBox";
            Operation_NameTextBox.Size = new Size(282, 23);
            Operation_NameTextBox.TabIndex = 6;
            // 
            // Operation_ReturnsTextBox
            // 
            Operation_ReturnsTextBox.Location = new System.Drawing.Point(93, 98);
            Operation_ReturnsTextBox.Name = "Operation_ReturnsTextBox";
            Operation_ReturnsTextBox.Size = new Size(282, 23);
            Operation_ReturnsTextBox.TabIndex = 7;
            // 
            // Operation_DataGrid
            // 
            Operation_DataGrid.AllowUserToAddRows = false;
            Operation_DataGrid.AllowUserToDeleteRows = false;
            Operation_DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Operation_DataGrid.Columns.AddRange(new DataGridViewColumn[] { Name, DataType });
            Operation_DataGrid.Location = new System.Drawing.Point(32, 153);
            Operation_DataGrid.Name = "Operation_DataGrid";
            Operation_DataGrid.ReadOnly = true;
            Operation_DataGrid.RowTemplate.Height = 25;
            Operation_DataGrid.Size = new Size(342, 136);
            Operation_DataGrid.TabIndex = 8;
            // 
            // OperationForm_AddButton
            // 
            OperationForm_AddButton.Location = new System.Drawing.Point(32, 306);
            OperationForm_AddButton.Name = "OperationForm_AddButton";
            OperationForm_AddButton.Size = new Size(75, 23);
            OperationForm_AddButton.TabIndex = 9;
            OperationForm_AddButton.Text = "Add";
            OperationForm_AddButton.UseVisualStyleBackColor = true;
            OperationForm_AddButton.Click += OperationForm_AddButton_Click;
            // 
            // OperationForm_DeleteButton
            // 
            OperationForm_DeleteButton.Location = new System.Drawing.Point(300, 306);
            OperationForm_DeleteButton.Name = "OperationForm_DeleteButton";
            OperationForm_DeleteButton.Size = new Size(75, 23);
            OperationForm_DeleteButton.TabIndex = 10;
            OperationForm_DeleteButton.Text = "Delete";
            OperationForm_DeleteButton.UseVisualStyleBackColor = true;
            OperationForm_DeleteButton.Click += OperationForm_DeleteButton_Click;
            // 
            // OperationForm_EditButton
            // 
            OperationForm_EditButton.Location = new System.Drawing.Point(166, 306);
            OperationForm_EditButton.Name = "OperationForm_EditButton";
            OperationForm_EditButton.Size = new Size(75, 23);
            OperationForm_EditButton.TabIndex = 11;
            OperationForm_EditButton.Text = "Edit";
            OperationForm_EditButton.UseVisualStyleBackColor = true;
            OperationForm_EditButton.Click += OperationForm_EditButton_Click;
            // 
            // OperationForm_OperAtrLabel
            // 
            OperationForm_OperAtrLabel.AutoSize = true;
            OperationForm_OperAtrLabel.Location = new System.Drawing.Point(143, 135);
            OperationForm_OperAtrLabel.Name = "OperationForm_OperAtrLabel";
            OperationForm_OperAtrLabel.Size = new Size(118, 15);
            OperationForm_OperAtrLabel.TabIndex = 12;
            OperationForm_OperAtrLabel.Text = "Operation Attributes:";
            // 
            // Name
            // 
            Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Name.DataPropertyName = "Name";
            Name.HeaderText = "Name";
            Name.Name = "Name";
            Name.ReadOnly = true;
            Name.Resizable = DataGridViewTriState.False;
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
            // OperationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 341);
            Controls.Add(OperationForm_OperAtrLabel);
            Controls.Add(OperationForm_EditButton);
            Controls.Add(OperationForm_DeleteButton);
            Controls.Add(OperationForm_AddButton);
            Controls.Add(Operation_DataGrid);
            Controls.Add(Operation_ReturnsTextBox);
            Controls.Add(Operation_NameTextBox);
            Controls.Add(Operation_ModifComboBox);
            Controls.Add(OperationForm_ReturnsLabel);
            Controls.Add(OperationForm_NameLabel);
            Controls.Add(OperationForm_ModifierLabel);
            Controls.Add(OperationForm_CancelButton);
            Controls.Add(OperationForm_SaveButton);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Operation";
            ((System.ComponentModel.ISupportInitialize)Operation_DataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OperationForm_SaveButton;
        private Button OperationForm_CancelButton;
        private Label OperationForm_ModifierLabel;
        private Label OperationForm_NameLabel;
        private Label OperationForm_ReturnsLabel;
        private ComboBox Operation_ModifComboBox;
        private TextBox Operation_NameTextBox;
        private TextBox Operation_ReturnsTextBox;
        private DataGridView Operation_DataGrid;
        private Button OperationForm_AddButton;
        private Button OperationForm_DeleteButton;
        private Button OperationForm_EditButton;
        private Label OperationForm_OperAtrLabel;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn DataType;
    }
}