namespace ClassDiagram
{
    partial class OperationAttributeForm
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
            OA_NAmeLabel = new Label();
            OA_DataLabel = new Label();
            OAForm_NameTextBox = new TextBox();
            OAForm_DataTextBox = new TextBox();
            OAForm_SaveButton = new Button();
            OAForm_CancelButton = new Button();
            SuspendLayout();
            // 
            // OA_NAmeLabel
            // 
            OA_NAmeLabel.AutoSize = true;
            OA_NAmeLabel.Location = new Point(37, 25);
            OA_NAmeLabel.Name = "OA_NAmeLabel";
            OA_NAmeLabel.Size = new Size(42, 15);
            OA_NAmeLabel.TabIndex = 0;
            OA_NAmeLabel.Text = "Name:";
            // 
            // OA_DataLabel
            // 
            OA_DataLabel.AutoSize = true;
            OA_DataLabel.Location = new Point(18, 63);
            OA_DataLabel.Name = "OA_DataLabel";
            OA_DataLabel.Size = new Size(61, 15);
            OA_DataLabel.TabIndex = 1;
            OA_DataLabel.Text = "Data Type:";
            // 
            // OAForm_NameTextBox
            // 
            OAForm_NameTextBox.Location = new Point(85, 22);
            OAForm_NameTextBox.Name = "OAForm_NameTextBox";
            OAForm_NameTextBox.Size = new Size(287, 23);
            OAForm_NameTextBox.TabIndex = 2;
            // 
            // OAForm_DataTextBox
            // 
            OAForm_DataTextBox.Location = new Point(85, 60);
            OAForm_DataTextBox.Name = "OAForm_DataTextBox";
            OAForm_DataTextBox.Size = new Size(287, 23);
            OAForm_DataTextBox.TabIndex = 3;
            // 
            // OAForm_SaveButton
            // 
            OAForm_SaveButton.Location = new Point(18, 126);
            OAForm_SaveButton.Name = "OAForm_SaveButton";
            OAForm_SaveButton.Size = new Size(75, 23);
            OAForm_SaveButton.TabIndex = 4;
            OAForm_SaveButton.Text = "Save";
            OAForm_SaveButton.UseVisualStyleBackColor = true;
            OAForm_SaveButton.Click += OAForm_SaveButton_Click;
            // 
            // OAForm_CancelButton
            // 
            OAForm_CancelButton.Location = new Point(297, 126);
            OAForm_CancelButton.Name = "OAForm_CancelButton";
            OAForm_CancelButton.Size = new Size(75, 23);
            OAForm_CancelButton.TabIndex = 5;
            OAForm_CancelButton.Text = "Cancel";
            OAForm_CancelButton.UseVisualStyleBackColor = true;
            OAForm_CancelButton.Click += OAForm_CancelButton_Click;
            // 
            // OperationAttributeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 161);
            Controls.Add(OAForm_CancelButton);
            Controls.Add(OAForm_SaveButton);
            Controls.Add(OAForm_DataTextBox);
            Controls.Add(OAForm_NameTextBox);
            Controls.Add(OA_DataLabel);
            Controls.Add(OA_NAmeLabel);
            Name = "OperationAttributeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Attribute for Operation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OA_NAmeLabel;
        private Label OA_DataLabel;
        private TextBox OAForm_NameTextBox;
        private TextBox OAForm_DataTextBox;
        private Button OAForm_SaveButton;
        private Button OAForm_CancelButton;
    }
}