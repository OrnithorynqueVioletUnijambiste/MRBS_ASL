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
            this.deStandLbl = new System.Windows.Forms.Label();
            this.partenairesStandLbl = new System.Windows.Forms.Label();
            this.partenairesDgv = new System.Windows.Forms.DataGridView();
            this.enleverBtn = new System.Windows.Forms.Button();
            this.ajouterBtn = new System.Windows.Forms.Button();
            this.partenairesCbx = new System.Windows.Forms.ComboBox();
            this.partenaireLbl = new System.Windows.Forms.Label();
            this.standCbx = new System.Windows.Forms.ComboBox();
            this.standLbl = new System.Windows.Forms.Label();
            this.tabAtelier = new System.Windows.Forms.TabPage();
            this.tabCtrlASL.SuspendLayout();
            this.tabStand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partenairesDgv)).BeginInit();
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
            this.tabStand.Controls.Add(this.deStandLbl);
            this.tabStand.Controls.Add(this.partenairesStandLbl);
            this.tabStand.Controls.Add(this.partenairesDgv);
            this.tabStand.Controls.Add(this.enleverBtn);
            this.tabStand.Controls.Add(this.ajouterBtn);
            this.tabStand.Controls.Add(this.partenairesCbx);
            this.tabStand.Controls.Add(this.partenaireLbl);
            this.tabStand.Controls.Add(this.standCbx);
            this.tabStand.Controls.Add(this.standLbl);
            this.tabStand.Location = new System.Drawing.Point(4, 22);
            this.tabStand.Name = "tabStand";
            this.tabStand.Padding = new System.Windows.Forms.Padding(3);
            this.tabStand.Size = new System.Drawing.Size(545, 404);
            this.tabStand.TabIndex = 1;
            this.tabStand.Text = "Gestion des stands";
            this.tabStand.UseVisualStyleBackColor = true;
            // 
            // deStandLbl
            // 
            this.deStandLbl.AutoSize = true;
            this.deStandLbl.Location = new System.Drawing.Point(345, 34);
            this.deStandLbl.Name = "deStandLbl";
            this.deStandLbl.Size = new System.Drawing.Size(0, 13);
            this.deStandLbl.TabIndex = 8;
            // 
            // partenairesStandLbl
            // 
            this.partenairesStandLbl.AutoSize = true;
            this.partenairesStandLbl.Location = new System.Drawing.Point(279, 34);
            this.partenairesStandLbl.Name = "partenairesStandLbl";
            this.partenairesStandLbl.Size = new System.Drawing.Size(60, 13);
            this.partenairesStandLbl.TabIndex = 7;
            this.partenairesStandLbl.Text = "Partenaires";
            // 
            // partenairesDgv
            // 
            this.partenairesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partenairesDgv.Location = new System.Drawing.Point(282, 62);
            this.partenairesDgv.Name = "partenairesDgv";
            this.partenairesDgv.Size = new System.Drawing.Size(215, 259);
            this.partenairesDgv.TabIndex = 6;
            this.partenairesDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.partenairesDgv_CellContentClick);
            // 
            // enleverBtn
            // 
            this.enleverBtn.Location = new System.Drawing.Point(134, 224);
            this.enleverBtn.Name = "enleverBtn";
            this.enleverBtn.Size = new System.Drawing.Size(76, 26);
            this.enleverBtn.TabIndex = 5;
            this.enleverBtn.Text = "Enlever";
            this.enleverBtn.UseVisualStyleBackColor = true;
            this.enleverBtn.Click += new System.EventHandler(this.enleverBtn_Click);
            // 
            // ajouterBtn
            // 
            this.ajouterBtn.Location = new System.Drawing.Point(39, 224);
            this.ajouterBtn.Name = "ajouterBtn";
            this.ajouterBtn.Size = new System.Drawing.Size(66, 27);
            this.ajouterBtn.TabIndex = 4;
            this.ajouterBtn.Text = "Ajouter";
            this.ajouterBtn.UseVisualStyleBackColor = true;
            this.ajouterBtn.Click += new System.EventHandler(this.ajouterBtn_Click);
            // 
            // partenairesCbx
            // 
            this.partenairesCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.partenairesCbx.FormattingEnabled = true;
            this.partenairesCbx.Location = new System.Drawing.Point(39, 171);
            this.partenairesCbx.Name = "partenairesCbx";
            this.partenairesCbx.Size = new System.Drawing.Size(171, 21);
            this.partenairesCbx.TabIndex = 3;
            // 
            // partenaireLbl
            // 
            this.partenaireLbl.AutoSize = true;
            this.partenaireLbl.Location = new System.Drawing.Point(36, 140);
            this.partenaireLbl.Name = "partenaireLbl";
            this.partenaireLbl.Size = new System.Drawing.Size(60, 13);
            this.partenaireLbl.TabIndex = 2;
            this.partenaireLbl.Text = "Partenaires";
            // 
            // standCbx
            // 
            this.standCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.standCbx.FormattingEnabled = true;
            this.standCbx.Location = new System.Drawing.Point(39, 62);
            this.standCbx.Name = "standCbx";
            this.standCbx.Size = new System.Drawing.Size(171, 21);
            this.standCbx.TabIndex = 1;
            this.standCbx.SelectedIndexChanged += new System.EventHandler(this.standCbx_SelectedIndexChanged);
            // 
            // standLbl
            // 
            this.standLbl.AutoSize = true;
            this.standLbl.Location = new System.Drawing.Point(36, 34);
            this.standLbl.Name = "standLbl";
            this.standLbl.Size = new System.Drawing.Size(40, 13);
            this.standLbl.TabIndex = 0;
            this.standLbl.Text = "Stands";
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
            this.Load += new System.EventHandler(this.AssisesSportLorrain_Load);
            this.tabCtrlASL.ResumeLayout(false);
            this.tabStand.ResumeLayout(false);
            this.tabStand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partenairesDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrlASL;
        private System.Windows.Forms.TabPage tabInscription;
        private System.Windows.Forms.TabPage tabStand;
        private System.Windows.Forms.TabPage tabAtelier;
        private System.Windows.Forms.Label deStandLbl;
        private System.Windows.Forms.Label partenairesStandLbl;
        private System.Windows.Forms.DataGridView partenairesDgv;
        private System.Windows.Forms.Button enleverBtn;
        private System.Windows.Forms.Button ajouterBtn;
        private System.Windows.Forms.ComboBox partenairesCbx;
        private System.Windows.Forms.Label partenaireLbl;
        private System.Windows.Forms.ComboBox standCbx;
        private System.Windows.Forms.Label standLbl;
    }
}

