namespace MongoDB_Repository
{
    partial class FormGlavna
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tipMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.letovanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zimovanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wellnessSpaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekskurzijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipMenuStrip,
            this.administratorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(810, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tipMenuStrip
            // 
            this.tipMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.letovanjeToolStripMenuItem,
            this.zimovanjeToolStripMenuItem,
            this.wellnessSpaToolStripMenuItem,
            this.ekskurzijaToolStripMenuItem});
            this.tipMenuStrip.Name = "tipMenuStrip";
            this.tipMenuStrip.Size = new System.Drawing.Size(171, 24);
            this.tipMenuStrip.Text = "Izaberite tip putovanja";
            this.tipMenuStrip.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.izaberiteTipPutovanjaToolStripMenuItem_DropDownItemClicked);
            // 
            // letovanjeToolStripMenuItem
            // 
            this.letovanjeToolStripMenuItem.Name = "letovanjeToolStripMenuItem";
            this.letovanjeToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.letovanjeToolStripMenuItem.Text = "Letovanje";
            // 
            // zimovanjeToolStripMenuItem
            // 
            this.zimovanjeToolStripMenuItem.Name = "zimovanjeToolStripMenuItem";
            this.zimovanjeToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.zimovanjeToolStripMenuItem.Text = "Zimovanje";
            // 
            // wellnessSpaToolStripMenuItem
            // 
            this.wellnessSpaToolStripMenuItem.Name = "wellnessSpaToolStripMenuItem";
            this.wellnessSpaToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.wellnessSpaToolStripMenuItem.Text = "Wellness&Spa";
            // 
            // ekskurzijaToolStripMenuItem
            // 
            this.ekskurzijaToolStripMenuItem.Name = "ekskurzijaToolStripMenuItem";
            this.ekskurzijaToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.ekskurzijaToolStripMenuItem.Text = "Ekskurzija";
            // 
            // administratorToolStripMenuItem
            // 
            this.administratorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem});
            this.administratorToolStripMenuItem.Name = "administratorToolStripMenuItem";
            this.administratorToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.administratorToolStripMenuItem.Text = "Administrator";
            this.administratorToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.administratorToolStripMenuItem_DropDownItemClicked);
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.logInToolStripMenuItem.Text = "Log in";
            // 
            // FormGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MongoDB_Repository.Properties.Resources.MR_2980_accesible_tourism1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(810, 525);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormGlavna";
            this.Text = "FormGlavna";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tipMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem letovanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zimovanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wellnessSpaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekskurzijaToolStripMenuItem;
    }
}