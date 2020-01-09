namespace Polyominoes
{
    partial class PolyominoeForm
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
            this.status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.pnlBoard = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(16, 642);
            this.status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(112, 25);
            this.status.TabIndex = 0;
            this.status.Text = "statusText";
            this.status.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "size:";
            // 
            // nudSize
            // 
            this.nudSize.Location = new System.Drawing.Point(79, 9);
            this.nudSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudSize.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudSize.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(160, 31);
            this.nudSize.TabIndex = 2;
            this.nudSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudSize.ValueChanged += new System.EventHandler(this.nudSize_ValueChanged);
            // 
            // pnlBoard
            // 
            this.pnlBoard.BackColor = System.Drawing.Color.White;
            this.pnlBoard.Location = new System.Drawing.Point(180, 92);
            this.pnlBoard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(533, 500);
            this.pnlBoard.TabIndex = 3;
            // 
            // PolyominoeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 679);
            this.Controls.Add(this.pnlBoard);
            this.Controls.Add(this.nudSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.status);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PolyominoeForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PolyominoeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.Panel pnlBoard;
    }
}

