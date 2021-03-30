namespace point
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_remove = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_addPoint = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_drawMedians = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(881, 594);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_drawMedians);
            this.panel1.Controls.Add(this.btn_remove);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.btn_addPoint);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Location = new System.Drawing.Point(905, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 594);
            this.panel1.TabIndex = 1;
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(141, 400);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(102, 30);
            this.btn_remove.TabIndex = 3;
            this.btn_remove.Text = "Undo";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 141);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(59, 26);
            this.textBox2.TabIndex = 3;
            // 
            // btn_addPoint
            // 
            this.btn_addPoint.Location = new System.Drawing.Point(75, 190);
            this.btn_addPoint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_addPoint.Name = "btn_addPoint";
            this.btn_addPoint.Size = new System.Drawing.Size(132, 45);
            this.btn_addPoint.TabIndex = 2;
            this.btn_addPoint.Text = "Draw";
            this.btn_addPoint.UseVisualStyleBackColor = true;
            this.btn_addPoint.Click += new System.EventHandler(this.btn_addPoint_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 141);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 26);
            this.textBox1.TabIndex = 2;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(141, 478);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(102, 30);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(140, 438);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(102, 32);
            this.btn_refresh.TabIndex = 0;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_drawMedians
            // 
            this.btn_drawMedians.Location = new System.Drawing.Point(75, 262);
            this.btn_drawMedians.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_drawMedians.Name = "btn_drawMedians";
            this.btn_drawMedians.Size = new System.Drawing.Size(132, 45);
            this.btn_drawMedians.TabIndex = 4;
            this.btn_drawMedians.Text = "Draw Medians";
            this.btn_drawMedians.UseVisualStyleBackColor = true;
            this.btn_drawMedians.Click += new System.EventHandler(this.btn_drawMedians_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_addPoint;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_drawMedians;
    }
}

