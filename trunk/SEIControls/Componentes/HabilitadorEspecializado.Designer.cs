namespace SEIControls
{
    partial class HabilitadorEspecializado
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HabilitadorEspecializado));
            this.lblPrimeiroHab = new System.Windows.Forms.Label();
            this.nivel3 = new System.Windows.Forms.PictureBox();
            this.nivel2 = new System.Windows.Forms.PictureBox();
            this.nivel1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nivel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivel1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrimeiroHab
            // 
            this.lblPrimeiroHab.AutoSize = true;
            this.lblPrimeiroHab.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimeiroHab.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPrimeiroHab.Location = new System.Drawing.Point(1, 0);
            this.lblPrimeiroHab.Name = "lblPrimeiroHab";
            this.lblPrimeiroHab.Size = new System.Drawing.Size(83, 15);
            this.lblPrimeiroHab.TabIndex = 25;
            this.lblPrimeiroHab.Text = "Primeiro Hab.";
            this.lblPrimeiroHab.Click += new System.EventHandler(this.lblPrimeiroHab_Click);
            // 
            // nivel3
            // 
            this.nivel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nivel3.ErrorImage = global::SEIControls.Properties.Resources.desmarcado;
            this.nivel3.Image = global::SEIControls.Properties.Resources.desmarcado;
            this.nivel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nivel3.InitialImage = ((System.Drawing.Image)(resources.GetObject("nivel3.InitialImage")));
            this.nivel3.Location = new System.Drawing.Point(203, 3);
            this.nivel3.Name = "nivel3";
            this.nivel3.Size = new System.Drawing.Size(26, 8);
            this.nivel3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nivel3.TabIndex = 24;
            this.nivel3.TabStop = false;
            this.nivel3.Click += new System.EventHandler(this.nivel3_Click);
            // 
            // nivel2
            // 
            this.nivel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nivel2.ErrorImage = global::SEIControls.Properties.Resources.desmarcado;
            this.nivel2.Image = global::SEIControls.Properties.Resources.desmarcado;
            this.nivel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nivel2.InitialImage = ((System.Drawing.Image)(resources.GetObject("nivel2.InitialImage")));
            this.nivel2.Location = new System.Drawing.Point(173, 3);
            this.nivel2.Name = "nivel2";
            this.nivel2.Size = new System.Drawing.Size(26, 8);
            this.nivel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nivel2.TabIndex = 23;
            this.nivel2.TabStop = false;
            this.nivel2.Click += new System.EventHandler(this.nivel2_Click);
            // 
            // nivel1
            // 
            this.nivel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nivel1.ErrorImage = global::SEIControls.Properties.Resources.desmarcado;
            this.nivel1.Image = global::SEIControls.Properties.Resources.desmarcado;
            this.nivel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nivel1.InitialImage = global::SEIControls.Properties.Resources.desmarcado;
            this.nivel1.Location = new System.Drawing.Point(143, 3);
            this.nivel1.Name = "nivel1";
            this.nivel1.Size = new System.Drawing.Size(26, 8);
            this.nivel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nivel1.TabIndex = 22;
            this.nivel1.TabStop = false;
            this.nivel1.Click += new System.EventHandler(this.nivel1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPrimeiroHab);
            this.panel1.Controls.Add(this.nivel1);
            this.panel1.Controls.Add(this.nivel3);
            this.panel1.Controls.Add(this.nivel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 14);
            this.panel1.TabIndex = 26;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // HabilitadorEspecializado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "HabilitadorEspecializado";
            this.Size = new System.Drawing.Size(232, 14);
            this.Load += new System.EventHandler(this.HabilitadorEspecializado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nivel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPrimeiroHab;
        private System.Windows.Forms.PictureBox nivel3;
        private System.Windows.Forms.PictureBox nivel2;
        private System.Windows.Forms.PictureBox nivel1;
        private System.Windows.Forms.Panel panel1;
    }
}
