namespace File_Cabinet_V0._1
{
    partial class addBook
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseProgram = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.topPanel);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 458);
            this.panel1.TabIndex = 0;
            // 
            // CloseProgram
            // 
            this.CloseProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseProgram.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseProgram.FlatAppearance.BorderSize = 0;
            this.CloseProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseProgram.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseProgram.Location = new System.Drawing.Point(247, 0);
            this.CloseProgram.Name = "CloseProgram";
            this.CloseProgram.Size = new System.Drawing.Size(35, 35);
            this.CloseProgram.TabIndex = 0;
            this.CloseProgram.Text = "X";
            this.CloseProgram.UseVisualStyleBackColor = true;
            this.CloseProgram.Click += new System.EventHandler(this.CloseProgram_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.topPanel.Controls.Add(this.CloseProgram);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(282, 35);
            this.topPanel.TabIndex = 3;
            // 
            // addBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(286, 462);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить книгу";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button CloseProgram;
    }
}