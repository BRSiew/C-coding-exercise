namespace Shapes
{
    partial class Shapes
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
            this.txtSqr = new System.Windows.Forms.Button();
            this.txtCirc = new System.Windows.Forms.Button();
            this.txtTri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSqr
            // 
            this.txtSqr.Location = new System.Drawing.Point(196, 71);
            this.txtSqr.Name = "txtSqr";
            this.txtSqr.Size = new System.Drawing.Size(75, 23);
            this.txtSqr.TabIndex = 0;
            this.txtSqr.Text = "Next";
            this.txtSqr.UseVisualStyleBackColor = true;
            this.txtSqr.Click += new System.EventHandler(this.txtSqr_Click);
            // 
            // txtCirc
            // 
            this.txtCirc.Location = new System.Drawing.Point(196, 134);
            this.txtCirc.Name = "txtCirc";
            this.txtCirc.Size = new System.Drawing.Size(75, 23);
            this.txtCirc.TabIndex = 1;
            this.txtCirc.Text = "Next";
            this.txtCirc.UseVisualStyleBackColor = true;
            this.txtCirc.Click += new System.EventHandler(this.txtCirc_Click);
            // 
            // txtTri
            // 
            this.txtTri.Location = new System.Drawing.Point(196, 195);
            this.txtTri.Name = "txtTri";
            this.txtTri.Size = new System.Drawing.Size(75, 23);
            this.txtTri.TabIndex = 2;
            this.txtTri.Text = "Next";
            this.txtTri.UseVisualStyleBackColor = true;
            this.txtTri.Click += new System.EventHandler(this.txtTri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Square";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Circle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Triangle";
            // 
            // Shapes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 331);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTri);
            this.Controls.Add(this.txtCirc);
            this.Controls.Add(this.txtSqr);
            this.Name = "Shapes";
            this.Text = "Shapes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtSqr;
        private System.Windows.Forms.Button txtCirc;
        private System.Windows.Forms.Button txtTri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

