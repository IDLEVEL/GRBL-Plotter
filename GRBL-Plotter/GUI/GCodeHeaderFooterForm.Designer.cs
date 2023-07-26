namespace GrblPlotter.GUI
{
    partial class GCodeHeaderFooterForm
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
            this.gcodeTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gcodeTextBox
            // 
            this.gcodeTextBox.Location = new System.Drawing.Point(12, 12);
            this.gcodeTextBox.Multiline = true;
            this.gcodeTextBox.Name = "gcodeTextBox";
            this.gcodeTextBox.Size = new System.Drawing.Size(758, 492);
            this.gcodeTextBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(758, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnSaveClick);
            // 
            // GCodeHeaderFooterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gcodeTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GCodeHeaderFooterForm";
            this.Text = "GCodeHeaderFooterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gcodeTextBox;
        private System.Windows.Forms.Button button1;
    }
}