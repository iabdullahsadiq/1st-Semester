namespace Calculator
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
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.rbsum = new System.Windows.Forms.RadioButton();
            this.rbsub = new System.Windows.Forms.RadioButton();
            this.rbmultiply = new System.Windows.Forms.RadioButton();
            this.rbdivide = new System.Windows.Forms.RadioButton();
            this.lbltitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(201, 108);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(114, 20);
            this.txtnum1.TabIndex = 0;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(201, 159);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(114, 20);
            this.txtnum2.TabIndex = 1;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(120, 111);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(55, 17);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Num 1";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(120, 162);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(55, 17);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Num 2";
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(201, 277);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(114, 23);
            this.btncalculate.TabIndex = 4;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // rbsum
            // 
            this.rbsum.AutoSize = true;
            this.rbsum.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbsum.Location = new System.Drawing.Point(91, 215);
            this.rbsum.Name = "rbsum";
            this.rbsum.Size = new System.Drawing.Size(46, 19);
            this.rbsum.TabIndex = 6;
            this.rbsum.TabStop = true;
            this.rbsum.Text = "Add";
            this.rbsum.UseVisualStyleBackColor = true;
            // 
            // rbsub
            // 
            this.rbsub.AutoSize = true;
            this.rbsub.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbsub.Location = new System.Drawing.Point(162, 215);
            this.rbsub.Name = "rbsub";
            this.rbsub.Size = new System.Drawing.Size(79, 19);
            this.rbsub.TabIndex = 7;
            this.rbsub.TabStop = true;
            this.rbsub.Text = "Substract";
            this.rbsub.UseVisualStyleBackColor = true;
            // 
            // rbmultiply
            // 
            this.rbmultiply.AutoSize = true;
            this.rbmultiply.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbmultiply.Location = new System.Drawing.Point(267, 215);
            this.rbmultiply.Name = "rbmultiply";
            this.rbmultiply.Size = new System.Drawing.Size(71, 19);
            this.rbmultiply.TabIndex = 8;
            this.rbmultiply.TabStop = true;
            this.rbmultiply.Text = "Multiply";
            this.rbmultiply.UseVisualStyleBackColor = true;
            // 
            // rbdivide
            // 
            this.rbdivide.AutoSize = true;
            this.rbdivide.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdivide.Location = new System.Drawing.Point(382, 215);
            this.rbdivide.Name = "rbdivide";
            this.rbdivide.Size = new System.Drawing.Size(61, 19);
            this.rbdivide.TabIndex = 9;
            this.rbdivide.TabStop = true;
            this.rbdivide.Text = "Divide";
            this.rbdivide.UseVisualStyleBackColor = true;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(192, 38);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(135, 30);
            this.lbltitle.TabIndex = 10;
            this.lbltitle.Text = "Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(524, 448);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.rbdivide);
            this.Controls.Add(this.rbmultiply);
            this.Controls.Add(this.rbsub);
            this.Controls.Add(this.rbsum);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.RadioButton rbsum;
        private System.Windows.Forms.RadioButton rbsub;
        private System.Windows.Forms.RadioButton rbmultiply;
        private System.Windows.Forms.RadioButton rbdivide;
        private System.Windows.Forms.Label lbltitle;
    }
}

