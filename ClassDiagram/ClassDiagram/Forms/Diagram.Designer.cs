namespace ClassDiagram
{
    partial class Diagram
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Diagram_PictureBox = new PictureBox();
            Diagram_NewButton = new Button();
            Diagram_DeleteButton = new Button();
            Timer = new System.Windows.Forms.Timer(components);
            Diagram_ScreenshotButton = new Button();
            ((System.ComponentModel.ISupportInitialize)Diagram_PictureBox).BeginInit();
            SuspendLayout();
            // 
            // Diagram_PictureBox
            // 
            Diagram_PictureBox.Location = new Point(12, 12);
            Diagram_PictureBox.Name = "Diagram_PictureBox";
            Diagram_PictureBox.Size = new Size(1240, 1017);
            Diagram_PictureBox.TabIndex = 0;
            Diagram_PictureBox.TabStop = false;
            Diagram_PictureBox.Paint += Diagram_PictureBox_Paint;
            Diagram_PictureBox.MouseDoubleClick += Diagram_PictureBox_MouseDoubleClick;
            Diagram_PictureBox.MouseDown += Diagram_PictureBox_MouseDown;
            Diagram_PictureBox.MouseMove += Diagram_PictureBox_MouseMove;
            Diagram_PictureBox.MouseUp += Diagram_PictureBox_MouseUp;
            Diagram_PictureBox.MouseWheel += Diagram_PictureBox_MouseWheel;
            // 
            // Diagram_NewButton
            // 
            Diagram_NewButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Diagram_NewButton.Location = new Point(1146, 894);
            Diagram_NewButton.Name = "Diagram_NewButton";
            Diagram_NewButton.Size = new Size(106, 44);
            Diagram_NewButton.TabIndex = 1;
            Diagram_NewButton.Text = "New";
            Diagram_NewButton.UseVisualStyleBackColor = true;
            Diagram_NewButton.Click += Diagram_NewButton_Click;
            // 
            // Diagram_DeleteButton
            // 
            Diagram_DeleteButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Diagram_DeleteButton.Location = new Point(1146, 944);
            Diagram_DeleteButton.Name = "Diagram_DeleteButton";
            Diagram_DeleteButton.Size = new Size(106, 44);
            Diagram_DeleteButton.TabIndex = 2;
            Diagram_DeleteButton.Text = "Delete";
            Diagram_DeleteButton.UseVisualStyleBackColor = true;
            Diagram_DeleteButton.Click += Diagram_DeleteButton_Click;
            // 
            // Timer
            // 
            Timer.Enabled = true;
            Timer.Interval = 20;
            Timer.Tick += Timer_Tick;
            // 
            // Diagram_ScreenshotButton
            // 
            Diagram_ScreenshotButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Diagram_ScreenshotButton.Location = new Point(23, 944);
            Diagram_ScreenshotButton.Name = "Diagram_ScreenshotButton";
            Diagram_ScreenshotButton.Size = new Size(127, 44);
            Diagram_ScreenshotButton.TabIndex = 5;
            Diagram_ScreenshotButton.Text = "Screenshot";
            Diagram_ScreenshotButton.UseVisualStyleBackColor = true;
            Diagram_ScreenshotButton.Click += Diagram_ScreenshotButton_Click;
            // 
            // Diagram
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 1041);
            Controls.Add(Diagram_ScreenshotButton);
            Controls.Add(Diagram_DeleteButton);
            Controls.Add(Diagram_NewButton);
            Controls.Add(Diagram_PictureBox);
            Name = "Diagram";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Class Diagram";
            ((System.ComponentModel.ISupportInitialize)Diagram_PictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Diagram_PictureBox;
        private Button Diagram_NewButton;
        private Button Diagram_DeleteButton;
        private System.Windows.Forms.Timer Timer;
        private Button Diagram_ScreenshotButton;
    }
}