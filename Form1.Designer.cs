namespace Undantagshantering1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxAntal = new System.Windows.Forms.TextBox();
            this.tbxIndex = new System.Windows.Forms.TextBox();
            this.tbxVärde = new System.Windows.Forms.TextBox();
            this.btnGenerera = new System.Windows.Forms.Button();
            this.btnVisa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Antal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Index";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Värde";
            // 
            // tbxAntal
            // 
            this.tbxAntal.Location = new System.Drawing.Point(81, 35);
            this.tbxAntal.Name = "tbxAntal";
            this.tbxAntal.Size = new System.Drawing.Size(100, 26);
            this.tbxAntal.TabIndex = 3;
            // 
            // tbxIndex
            // 
            this.tbxIndex.Location = new System.Drawing.Point(81, 74);
            this.tbxIndex.Name = "tbxIndex";
            this.tbxIndex.Size = new System.Drawing.Size(100, 26);
            this.tbxIndex.TabIndex = 4;
            // 
            // tbxVärde
            // 
            this.tbxVärde.Location = new System.Drawing.Point(81, 115);
            this.tbxVärde.Name = "tbxVärde";
            this.tbxVärde.ReadOnly = true;
            this.tbxVärde.Size = new System.Drawing.Size(100, 26);
            this.tbxVärde.TabIndex = 5;
            // 
            // btnGenerera
            // 
            this.btnGenerera.Location = new System.Drawing.Point(198, 34);
            this.btnGenerera.Name = "btnGenerera";
            this.btnGenerera.Size = new System.Drawing.Size(103, 29);
            this.btnGenerera.TabIndex = 6;
            this.btnGenerera.Text = "Generera";
            this.btnGenerera.UseVisualStyleBackColor = true;
            this.btnGenerera.Click += new System.EventHandler(this.btnGenerera_Click);
            // 
            // btnVisa
            // 
            this.btnVisa.Location = new System.Drawing.Point(198, 74);
            this.btnVisa.Name = "btnVisa";
            this.btnVisa.Size = new System.Drawing.Size(103, 29);
            this.btnVisa.TabIndex = 7;
            this.btnVisa.Text = "Visa värde";
            this.btnVisa.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 161);
            this.Controls.Add(this.btnVisa);
            this.Controls.Add(this.btnGenerera);
            this.Controls.Add(this.tbxVärde);
            this.Controls.Add(this.tbxIndex);
            this.Controls.Add(this.tbxAntal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ex s 39-40";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxAntal;
        private System.Windows.Forms.TextBox tbxIndex;
        private System.Windows.Forms.TextBox tbxVärde;
        private System.Windows.Forms.Button btnGenerera;
        private System.Windows.Forms.Button btnVisa;
    }
}

