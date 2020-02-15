namespace MongoDB_Repository
{
    partial class FormEkskurzija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEkskurzija));
            this.lbLokacija = new System.Windows.Forms.Label();
            this.lbCena = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUtisak = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLokacija
            // 
            this.lbLokacija.AutoSize = true;
            this.lbLokacija.BackColor = System.Drawing.Color.Transparent;
            this.lbLokacija.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLokacija.ForeColor = System.Drawing.Color.Black;
            this.lbLokacija.Location = new System.Drawing.Point(75, 36);
            this.lbLokacija.Name = "lbLokacija";
            this.lbLokacija.Size = new System.Drawing.Size(86, 30);
            this.lbLokacija.TabIndex = 29;
            this.lbLokacija.Text = "label1";
            // 
            // lbCena
            // 
            this.lbCena.AutoSize = true;
            this.lbCena.BackColor = System.Drawing.Color.Transparent;
            this.lbCena.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCena.ForeColor = System.Drawing.Color.Black;
            this.lbCena.Location = new System.Drawing.Point(547, 36);
            this.lbCena.Name = "lbCena";
            this.lbCena.Size = new System.Drawing.Size(86, 30);
            this.lbCena.TabIndex = 28;
            this.lbCena.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Location = new System.Drawing.Point(503, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 383);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(358, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 383);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(544, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(78, 24);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SeaShell;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(58, 342);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(262, 227);
            this.textBox1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(354, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 42);
            this.label1.TabIndex = 31;
            this.label1.Text = "Pregledaj komentare\r\n po oceni";
            // 
            // btnUtisak
            // 
            this.btnUtisak.ActiveBorderThickness = 1;
            this.btnUtisak.ActiveCornerRadius = 20;
            this.btnUtisak.ActiveFillColor = System.Drawing.Color.Navy;
            this.btnUtisak.ActiveForecolor = System.Drawing.Color.White;
            this.btnUtisak.ActiveLineColor = System.Drawing.Color.Navy;
            this.btnUtisak.BackColor = System.Drawing.SystemColors.Control;
            this.btnUtisak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUtisak.BackgroundImage")));
            this.btnUtisak.ButtonText = "Dodaj utisak";
            this.btnUtisak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUtisak.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtisak.ForeColor = System.Drawing.Color.Navy;
            this.btnUtisak.IdleBorderThickness = 1;
            this.btnUtisak.IdleCornerRadius = 20;
            this.btnUtisak.IdleFillColor = System.Drawing.Color.White;
            this.btnUtisak.IdleForecolor = System.Drawing.Color.Navy;
            this.btnUtisak.IdleLineColor = System.Drawing.Color.Navy;
            this.btnUtisak.Location = new System.Drawing.Point(408, 554);
            this.btnUtisak.Margin = new System.Windows.Forms.Padding(5);
            this.btnUtisak.Name = "btnUtisak";
            this.btnUtisak.Size = new System.Drawing.Size(186, 58);
            this.btnUtisak.TabIndex = 30;
            this.btnUtisak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUtisak.Click += new System.EventHandler(this.btnUtisak_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(58, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 200);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // FormEkskurzija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MongoDB_Repository.Properties.Resources._0a1a_182;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(681, 648);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUtisak);
            this.Controls.Add(this.lbLokacija);
            this.Controls.Add(this.lbCena);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximumSize = new System.Drawing.Size(699, 695);
            this.MinimumSize = new System.Drawing.Size(699, 695);
            this.Name = "FormEkskurzija";
            this.Text = "FormEkskurzija";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLokacija;
        private System.Windows.Forms.Label lbCena;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUtisak;
        private System.Windows.Forms.Label label1;
    }
}