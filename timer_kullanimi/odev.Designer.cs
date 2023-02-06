namespace timer_kullanimi
{
    partial class odev
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
            this.components = new System.ComponentModel.Container();
            this.btn_K = new System.Windows.Forms.Button();
            this.btn_S = new System.Windows.Forms.Button();
            this.btn_Y = new System.Windows.Forms.Button();
            this.btn_sayac = new System.Windows.Forms.Button();
            this.süre = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_K
            // 
            this.btn_K.Location = new System.Drawing.Point(153, 50);
            this.btn_K.Name = "btn_K";
            this.btn_K.Size = new System.Drawing.Size(143, 50);
            this.btn_K.TabIndex = 0;
            this.btn_K.Text = "K";
            this.btn_K.UseVisualStyleBackColor = true;
            // 
            // btn_S
            // 
            this.btn_S.Location = new System.Drawing.Point(153, 106);
            this.btn_S.Name = "btn_S";
            this.btn_S.Size = new System.Drawing.Size(143, 52);
            this.btn_S.TabIndex = 0;
            this.btn_S.Text = "S";
            this.btn_S.UseVisualStyleBackColor = true;
            // 
            // btn_Y
            // 
            this.btn_Y.Location = new System.Drawing.Point(153, 164);
            this.btn_Y.Name = "btn_Y";
            this.btn_Y.Size = new System.Drawing.Size(143, 52);
            this.btn_Y.TabIndex = 0;
            this.btn_Y.Text = "Y";
            this.btn_Y.UseVisualStyleBackColor = true;
            // 
            // btn_sayac
            // 
            this.btn_sayac.Location = new System.Drawing.Point(153, 222);
            this.btn_sayac.Name = "btn_sayac";
            this.btn_sayac.Size = new System.Drawing.Size(143, 52);
            this.btn_sayac.TabIndex = 0;
            this.btn_sayac.Text = "button1";
            this.btn_sayac.UseVisualStyleBackColor = true;
            // 
            // süre
            // 
            this.süre.Tick += new System.EventHandler(this.süre_Tick);
            // 
            // odev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 344);
            this.Controls.Add(this.btn_sayac);
            this.Controls.Add(this.btn_Y);
            this.Controls.Add(this.btn_S);
            this.Controls.Add(this.btn_K);
            this.Name = "odev";
            this.Text = "odev";
            this.Load += new System.EventHandler(this.odev_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_K;
        private System.Windows.Forms.Button btn_S;
        private System.Windows.Forms.Button btn_Y;
        private System.Windows.Forms.Button btn_sayac;
        private System.Windows.Forms.Timer süre;
    }
}