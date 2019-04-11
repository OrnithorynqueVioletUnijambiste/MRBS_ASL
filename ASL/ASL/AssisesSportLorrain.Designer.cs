namespace ASL
{
    partial class AssisesSportLorrain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabCtrlASL = new System.Windows.Forms.TabControl();
            this.tabInscription = new System.Windows.Forms.TabPage();
            this.tabStand = new System.Windows.Forms.TabPage();
            this.tabAtelier = new System.Windows.Forms.TabPage();
            this.tabCtrlASL.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrlASL
            // 
            this.tabCtrlASL.Controls.Add(this.tabInscription);
            this.tabCtrlASL.Controls.Add(this.tabStand);
            this.tabCtrlASL.Controls.Add(this.tabAtelier);
            this.tabCtrlASL.Location = new System.Drawing.Point(12, 12);
            this.tabCtrlASL.Name = "tabCtrlASL";
            this.tabCtrlASL.SelectedIndex = 0;
            this.tabCtrlASL.Size = new System.Drawing.Size(553, 430);
            this.tabCtrlASL.TabIndex = 0;
            // 
            // tabInscription
            // 
            this.tabInscription.Location = new System.Drawing.Point(4, 22);
            this.tabInscription.Name = "tabInscription";
            this.tabInscription.Padding = new System.Windows.Forms.Padding(3);
            this.tabInscription.Size = new System.Drawing.Size(545, 404);
            this.tabInscription.TabIndex = 0;
            this.tabInscription.Text = "Inscription aux ateliers";
            this.tabInscription.UseVisualStyleBackColor = true;
            // 
            // tabStand
            // 
            this.tabStand.Location = new System.Drawing.Point(4, 22);
            this.tabStand.Name = "tabStand";
            this.tabStand.Padding = new System.Windows.Forms.Padding(3);
            this.tabStand.Size = new System.Drawing.Size(545, 404);
            this.tabStand.TabIndex = 1;
            this.tabStand.Text = "Gestion des stands";
            this.tabStand.UseVisualStyleBackColor = true;
            // 
            // tabAtelier
            // 
            this.tabAtelier.Location = new System.Drawing.Point(4, 22);
            this.tabAtelier.Name = "tabAtelier";
            this.tabAtelier.Padding = new System.Windows.Forms.Padding(3);
            this.tabAtelier.Size = new System.Drawing.Size(545, 404);
            this.tabAtelier.TabIndex = 2;
            this.tabAtelier.Text = "Gestion des ateliers";
            this.tabAtelier.UseVisualStyleBackColor = true;
            // 
            // AssisesSportLorrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 454);
            this.Controls.Add(this.tabCtrlASL);
            this.Name = "AssisesSportLorrain";
            this.Text = "Assises du Sport Lorrain";
            this.tabCtrlASL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrlASL;
        private System.Windows.Forms.TabPage tabInscription;
        private System.Windows.Forms.TabPage tabStand;
        private System.Windows.Forms.TabPage tabAtelier;
    }
}

