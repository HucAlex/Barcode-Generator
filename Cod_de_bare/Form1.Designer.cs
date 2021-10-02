namespace Cod_de_bare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.generare = new System.Windows.Forms.Button();
            this.salvare = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.valoare = new System.Windows.Forms.TextBox();
            this.val = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(115, 161);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(296, 43);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "deseneaza chenar";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox2.Location = new System.Drawing.Point(115, 210);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(296, 43);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "deseneaza valoare text";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(115, 259);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(296, 38);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "negativ (alb pe negru)";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // generare
            // 
            this.generare.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generare.ForeColor = System.Drawing.Color.Blue;
            this.generare.Location = new System.Drawing.Point(73, 358);
            this.generare.Name = "generare";
            this.generare.Size = new System.Drawing.Size(155, 46);
            this.generare.TabIndex = 3;
            this.generare.Text = "Genereaza";
            this.generare.UseVisualStyleBackColor = true;
            this.generare.Click += new System.EventHandler(this.generare_Click);
            // 
            // salvare
            // 
            this.salvare.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvare.ForeColor = System.Drawing.Color.Red;
            this.salvare.Location = new System.Drawing.Point(283, 358);
            this.salvare.Name = "salvare";
            this.salvare.Size = new System.Drawing.Size(147, 46);
            this.salvare.TabIndex = 4;
            this.salvare.Text = "Salvare";
            this.salvare.UseVisualStyleBackColor = true;
            this.salvare.Click += new System.EventHandler(this.salvare_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(466, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // valoare
            // 
            this.valoare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valoare.Location = new System.Drawing.Point(178, 303);
            this.valoare.Multiline = true;
            this.valoare.Name = "valoare";
            this.valoare.Size = new System.Drawing.Size(233, 44);
            this.valoare.TabIndex = 6;
            this.valoare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valoare.KeyDown += new System.Windows.Forms.KeyEventHandler(this.valoare_KeyDown);
            // 
            // val
            // 
            this.val.AutoSize = true;
            this.val.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.val.Location = new System.Drawing.Point(136, 133);
            this.val.Name = "val";
            this.val.Size = new System.Drawing.Size(0, 25);
            this.val.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Valoare";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 427);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.val);
            this.Controls.Add(this.valoare);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.salvare);
            this.Controls.Add(this.generare);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cod de bare";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button generare;
        private System.Windows.Forms.Button salvare;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox valoare;
        private System.Windows.Forms.Label val;
        private System.Windows.Forms.Label label1;
    }
}

