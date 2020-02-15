namespace MongoDB_Repository
{
    partial class FormKomentar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKomentar));
            this.tbSlika = new System.Windows.Forms.TextBox();
            this.tbTekst = new System.Windows.Forms.TextBox();
            this.tbOcena = new System.Windows.Forms.TextBox();
            this.btnSubmit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblCena = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // tbSlika
            // 
            this.tbSlika.Location = new System.Drawing.Point(288, 86);
            this.tbSlika.Name = "tbSlika";
            this.tbSlika.Size = new System.Drawing.Size(274, 22);
            this.tbSlika.TabIndex = 0;
            // 
            // tbTekst
            // 
            this.tbTekst.Location = new System.Drawing.Point(288, 155);
            this.tbTekst.Multiline = true;
            this.tbTekst.Name = "tbTekst";
            this.tbTekst.Size = new System.Drawing.Size(274, 79);
            this.tbTekst.TabIndex = 1;
            // 
            // tbOcena
            // 
            this.tbOcena.Location = new System.Drawing.Point(495, 364);
            this.tbOcena.Name = "tbOcena";
            this.tbOcena.Size = new System.Drawing.Size(46, 22);
            this.tbOcena.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.ActiveBorderThickness = 1;
            this.btnSubmit.ActiveCornerRadius = 20;
            this.btnSubmit.ActiveFillColor = System.Drawing.Color.MidnightBlue;
            this.btnSubmit.ActiveForecolor = System.Drawing.Color.White;
            this.btnSubmit.ActiveLineColor = System.Drawing.Color.MidnightBlue;
            this.btnSubmit.BackColor = System.Drawing.Color.Turquoise;
            this.btnSubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubmit.BackgroundImage")));
            this.btnSubmit.ButtonText = "Submit";
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSubmit.IdleBorderThickness = 1;
            this.btnSubmit.IdleCornerRadius = 20;
            this.btnSubmit.IdleFillColor = System.Drawing.Color.White;
            this.btnSubmit.IdleForecolor = System.Drawing.Color.MidnightBlue;
            this.btnSubmit.IdleLineColor = System.Drawing.Color.MidnightBlue;
            this.btnSubmit.Location = new System.Drawing.Point(40, 373);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(181, 41);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.BackColor = System.Drawing.Color.Transparent;
            this.lblCena.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCena.Location = new System.Drawing.Point(284, 9);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(227, 46);
            this.lblCena.TabIndex = 4;
            this.lblCena.Text = "Putanja do slike\r\nkoju zelite da zakacite";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(284, 129);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(106, 23);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Text = "Komentar";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(305, 366);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(146, 23);
            this.bunifuCustomLabel2.TabIndex = 6;
            this.bunifuCustomLabel2.Text = "Ocena mesta";
            // 
            // FormKomentar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MongoDB_Repository.Properties.Resources.impacto_uso_TIC_en_turismo_810x565;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(588, 440);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbOcena);
            this.Controls.Add(this.tbTekst);
            this.Controls.Add(this.tbSlika);
            this.Name = "FormKomentar";
            this.Text = "FormKomentar";
            this.Load += new System.EventHandler(this.FormKomentar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSlika;
        private System.Windows.Forms.TextBox tbTekst;
        private System.Windows.Forms.TextBox tbOcena;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSubmit;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCena;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
    }
}