namespace LINQ
{
    partial class Form2
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
            this.btn_YerelPersonel = new System.Windows.Forms.Button();
            this.lbl_PersoneSayi = new System.Windows.Forms.Label();
            this.lbl_POM = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Yas = new System.Windows.Forms.Label();
            this.lbl_Maas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_YerelPersonel
            // 
            this.btn_YerelPersonel.Location = new System.Drawing.Point(15, 24);
            this.btn_YerelPersonel.Name = "btn_YerelPersonel";
            this.btn_YerelPersonel.Size = new System.Drawing.Size(142, 38);
            this.btn_YerelPersonel.TabIndex = 0;
            this.btn_YerelPersonel.Text = "Yerel Personel";
            this.btn_YerelPersonel.UseVisualStyleBackColor = true;
            this.btn_YerelPersonel.Click += new System.EventHandler(this.btn_YerelPersonel_Click);
            // 
            // lbl_PersoneSayi
            // 
            this.lbl_PersoneSayi.AutoSize = true;
            this.lbl_PersoneSayi.Location = new System.Drawing.Point(12, 83);
            this.lbl_PersoneSayi.Name = "lbl_PersoneSayi";
            this.lbl_PersoneSayi.Size = new System.Drawing.Size(160, 17);
            this.lbl_PersoneSayi.TabIndex = 1;
            this.lbl_PersoneSayi.Text = "Şu anda 0 personel var.";
            // 
            // lbl_POM
            // 
            this.lbl_POM.AutoSize = true;
            this.lbl_POM.Location = new System.Drawing.Point(12, 109);
            this.lbl_POM.Name = "lbl_POM";
            this.lbl_POM.Size = new System.Drawing.Size(201, 17);
            this.lbl_POM.TabIndex = 2;
            this.lbl_POM.Text = "Personel maaşı ortalama 0 TL.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Son eklenen personelin:";
            // 
            // lbl_Yas
            // 
            this.lbl_Yas.AutoSize = true;
            this.lbl_Yas.Location = new System.Drawing.Point(135, 161);
            this.lbl_Yas.Name = "lbl_Yas";
            this.lbl_Yas.Size = new System.Drawing.Size(51, 17);
            this.lbl_Yas.TabIndex = 4;
            this.lbl_Yas.Text = "Yaşı: 0";
            // 
            // lbl_Maas
            // 
            this.lbl_Maas.AutoSize = true;
            this.lbl_Maas.Location = new System.Drawing.Point(125, 187);
            this.lbl_Maas.Name = "lbl_Maas";
            this.lbl_Maas.Size = new System.Drawing.Size(61, 17);
            this.lbl_Maas.TabIndex = 5;
            this.lbl_Maas.Text = "Maaşı: 0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 268);
            this.Controls.Add(this.lbl_Maas);
            this.Controls.Add(this.lbl_Yas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_POM);
            this.Controls.Add(this.lbl_PersoneSayi);
            this.Controls.Add(this.btn_YerelPersonel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_YerelPersonel;
        private System.Windows.Forms.Label lbl_PersoneSayi;
        private System.Windows.Forms.Label lbl_POM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Yas;
        private System.Windows.Forms.Label lbl_Maas;
    }
}