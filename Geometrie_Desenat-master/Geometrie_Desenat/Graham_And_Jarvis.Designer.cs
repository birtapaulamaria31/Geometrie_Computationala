
namespace Geometrie_Desenat
{
    partial class Graham_And_Jarvis
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
            this.textNumarPuncte = new System.Windows.Forms.TextBox();
            this.drawJarvis = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.generateRandom = new System.Windows.Forms.Button();
            this.textPuncteManual = new System.Windows.Forms.TextBox();
            this.addPoint = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(959, 544);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textNumarPuncte
            // 
            this.textNumarPuncte.Location = new System.Drawing.Point(751, 36);
            this.textNumarPuncte.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textNumarPuncte.Name = "textNumarPuncte";
            this.textNumarPuncte.Size = new System.Drawing.Size(135, 20);
            this.textNumarPuncte.TabIndex = 1;
            // 
            // drawJarvis
            // 
            this.drawJarvis.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.drawJarvis.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawJarvis.Location = new System.Drawing.Point(781, 476);
            this.drawJarvis.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.drawJarvis.Name = "drawJarvis";
            this.drawJarvis.Size = new System.Drawing.Size(83, 45);
            this.drawJarvis.TabIndex = 3;
            this.drawJarvis.Text = "Jarvis";
            this.drawJarvis.UseVisualStyleBackColor = false;
            this.drawJarvis.Click += new System.EventHandler(this.drawJarvis_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(781, 417);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Graham";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // generateRandom
            // 
            this.generateRandom.BackColor = System.Drawing.Color.Red;
            this.generateRandom.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateRandom.Location = new System.Drawing.Point(750, 60);
            this.generateRandom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.generateRandom.Name = "generateRandom";
            this.generateRandom.Size = new System.Drawing.Size(136, 45);
            this.generateRandom.TabIndex = 8;
            this.generateRandom.Text = "Generate Random";
            this.generateRandom.UseVisualStyleBackColor = false;
            this.generateRandom.Click += new System.EventHandler(this.generateRandom_Click);
            // 
            // textPuncteManual
            // 
            this.textPuncteManual.Location = new System.Drawing.Point(751, 210);
            this.textPuncteManual.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textPuncteManual.Name = "textPuncteManual";
            this.textPuncteManual.Size = new System.Drawing.Size(135, 20);
            this.textPuncteManual.TabIndex = 9;
            // 
            // addPoint
            // 
            this.addPoint.BackColor = System.Drawing.Color.Red;
            this.addPoint.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPoint.Location = new System.Drawing.Point(750, 234);
            this.addPoint.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.addPoint.Name = "addPoint";
            this.addPoint.Size = new System.Drawing.Size(136, 45);
            this.addPoint.TabIndex = 10;
            this.addPoint.Text = "Add Point";
            this.addPoint.UseVisualStyleBackColor = false;
            this.addPoint.Click += new System.EventHandler(this.addPoint_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.clearButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(781, 304);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(83, 29);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(699, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Write number of random points:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(689, 189);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Write coordinates of specific points:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(803, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "OR";
            // 
            // Graham_And_Jarvis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 544);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addPoint);
            this.Controls.Add(this.textPuncteManual);
            this.Controls.Add(this.generateRandom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.drawJarvis);
            this.Controls.Add(this.textNumarPuncte);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Graham_And_Jarvis";
            this.Text = "GrahamScan";
            this.Load += new System.EventHandler(this.GrahamScan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textNumarPuncte;
        private System.Windows.Forms.Button drawJarvis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button generateRandom;
        private System.Windows.Forms.TextBox textPuncteManual;
        private System.Windows.Forms.Button addPoint;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}