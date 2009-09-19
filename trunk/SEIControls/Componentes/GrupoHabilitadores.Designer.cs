namespace SEIControls
{
    partial class GrupoHabilitadores
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
            this.quintoHab = new SEIControls.HabilitadorEspecializado();
            this.quartoHab = new SEIControls.HabilitadorEspecializado();
            this.terceiroHab = new SEIControls.HabilitadorEspecializado();
            this.segundoHab = new SEIControls.HabilitadorEspecializado();
            this.habilitadorGenerico = new SEIControls.HabilitadorGenerico();
            this.primeiroHab = new SEIControls.HabilitadorEspecializado();
            this.SuspendLayout();
            // 
            // quintoHab
            // 
            this.quintoHab.Location = new System.Drawing.Point(0, 103);
            this.quintoHab.Name = "quintoHab";
            this.quintoHab.Nome = "Quinto Hab.";
            this.quintoHab.Size = new System.Drawing.Size(232, 14);
            this.quintoHab.TabIndex = 5;
            this.quintoHab.Valor = 0;
            // 
            // quartoHab
            // 
            this.quartoHab.Location = new System.Drawing.Point(0, 83);
            this.quartoHab.Name = "quartoHab";
            this.quartoHab.Nome = "Quarto Hab.";
            this.quartoHab.Size = new System.Drawing.Size(232, 14);
            this.quartoHab.TabIndex = 4;
            this.quartoHab.Valor = 0;
            // 
            // terceiroHab
            // 
            this.terceiroHab.Location = new System.Drawing.Point(0, 63);
            this.terceiroHab.Name = "terceiroHab";
            this.terceiroHab.Nome = "Terceiro Hab.";
            this.terceiroHab.Size = new System.Drawing.Size(232, 14);
            this.terceiroHab.TabIndex = 3;
            this.terceiroHab.Valor = 0;
            // 
            // segundoHab
            // 
            this.segundoHab.Location = new System.Drawing.Point(0, 43);
            this.segundoHab.Name = "segundoHab";
            this.segundoHab.Nome = "Segundo Hab.";
            this.segundoHab.Size = new System.Drawing.Size(232, 14);
            this.segundoHab.TabIndex = 2;
            this.segundoHab.Valor = 0;
            // 
            // habilitadorGenerico
            // 
            this.habilitadorGenerico.Location = new System.Drawing.Point(0, 0);
            this.habilitadorGenerico.Name = "habilitadorGenerico";
            this.habilitadorGenerico.Nome = "Habilitador Genérico";
            this.habilitadorGenerico.Size = new System.Drawing.Size(291, 17);
            this.habilitadorGenerico.TabIndex = 1;
            this.habilitadorGenerico.Valor = 0;
            // 
            // primeiroHab
            // 
            this.primeiroHab.Location = new System.Drawing.Point(0, 23);
            this.primeiroHab.Name = "primeiroHab";
            this.primeiroHab.Nome = "Primeiro Hab.";
            this.primeiroHab.Size = new System.Drawing.Size(232, 14);
            this.primeiroHab.TabIndex = 0;
            this.primeiroHab.Valor = 0;
            // 
            // GrupoHabilitadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.quintoHab);
            this.Controls.Add(this.quartoHab);
            this.Controls.Add(this.terceiroHab);
            this.Controls.Add(this.segundoHab);
            this.Controls.Add(this.habilitadorGenerico);
            this.Controls.Add(this.primeiroHab);
            this.Name = "GrupoHabilitadores";
            this.Size = new System.Drawing.Size(293, 121);
            this.Load += new System.EventHandler(this.GrupoHabilitadores_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private HabilitadorEspecializado primeiroHab;
        private HabilitadorGenerico habilitadorGenerico;
        private HabilitadorEspecializado segundoHab;
        private HabilitadorEspecializado terceiroHab;
        private HabilitadorEspecializado quartoHab;
        private HabilitadorEspecializado quintoHab;
    }
}
