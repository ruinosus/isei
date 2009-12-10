namespace SEIControls
{
    partial class EspecializacaoEditavel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EspecializacaoEditavel));
            this.nivel1 = new System.Windows.Forms.PictureBox();
            this.nivel3 = new System.Windows.Forms.PictureBox();
            this.nivel2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbEspecializacao = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nivel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivel2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nivel1
            // 
            this.nivel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nivel1.ErrorImage = global::SEIControls.Properties.Resources.desmarcado;
            this.nivel1.Image = global::SEIControls.Properties.Resources.desmarcado;
            this.nivel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nivel1.InitialImage = global::SEIControls.Properties.Resources.desmarcado;
            this.nivel1.Location = new System.Drawing.Point(143, 8);
            this.nivel1.Name = "nivel1";
            this.nivel1.Size = new System.Drawing.Size(26, 8);
            this.nivel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nivel1.TabIndex = 22;
            this.nivel1.TabStop = false;
            // 
            // nivel3
            // 
            this.nivel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nivel3.ErrorImage = global::SEIControls.Properties.Resources.desmarcado;
            this.nivel3.Image = global::SEIControls.Properties.Resources.desmarcado;
            this.nivel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nivel3.InitialImage = ((System.Drawing.Image)(resources.GetObject("nivel3.InitialImage")));
            this.nivel3.Location = new System.Drawing.Point(203, 8);
            this.nivel3.Name = "nivel3";
            this.nivel3.Size = new System.Drawing.Size(26, 8);
            this.nivel3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nivel3.TabIndex = 24;
            this.nivel3.TabStop = false;
            // 
            // nivel2
            // 
            this.nivel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nivel2.ErrorImage = global::SEIControls.Properties.Resources.desmarcado;
            this.nivel2.Image = global::SEIControls.Properties.Resources.desmarcado;
            this.nivel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nivel2.InitialImage = ((System.Drawing.Image)(resources.GetObject("nivel2.InitialImage")));
            this.nivel2.Location = new System.Drawing.Point(173, 8);
            this.nivel2.Name = "nivel2";
            this.nivel2.Size = new System.Drawing.Size(26, 8);
            this.nivel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nivel2.TabIndex = 23;
            this.nivel2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbEspecializacao);
            this.panel1.Controls.Add(this.nivel1);
            this.panel1.Controls.Add(this.nivel3);
            this.panel1.Controls.Add(this.nivel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 25);
            this.panel1.TabIndex = 27;
            // 
            // cmbEspecializacao
            // 
            this.cmbEspecializacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecializacao.FormattingEnabled = true;
            this.cmbEspecializacao.Location = new System.Drawing.Point(3, 2);
            this.cmbEspecializacao.Name = "cmbEspecializacao";
            this.cmbEspecializacao.Size = new System.Drawing.Size(137, 21);
            this.cmbEspecializacao.TabIndex = 25;
            // 
            // EspecializacaoEditavel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "EspecializacaoEditavel";
            this.Size = new System.Drawing.Size(268, 34);
            ((System.ComponentModel.ISupportInitialize)(this.nivel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nivel2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox nivel1;
        private System.Windows.Forms.PictureBox nivel3;
        private System.Windows.Forms.PictureBox nivel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbEspecializacao;
    }
}
