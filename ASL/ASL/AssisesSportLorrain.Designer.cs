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
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.btnModifier = new System.Windows.Forms.Button();
            this.lbAtelierExistant = new System.Windows.Forms.Label();
            this.lbCapacite = new System.Windows.Forms.Label();
            this.lbTheme = new System.Windows.Forms.Label();
            this.lbAtelier = new System.Windows.Forms.Label();
            this.dgvAteliers = new System.Windows.Forms.DataGridView();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txbCapacite = new System.Windows.Forms.TextBox();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.txbAtelier = new System.Windows.Forms.TextBox();
            this.txbTheme = new System.Windows.Forms.TextBox();
            this.tabCtrlASL.SuspendLayout();
            this.tabAtelier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAteliers)).BeginInit();
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
            this.tabCtrlASL.Size = new System.Drawing.Size(781, 430);
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
            this.tabAtelier.Controls.Add(this.txbTheme);
            this.tabAtelier.Controls.Add(this.txbAtelier);
            this.tabAtelier.Controls.Add(this.dtpDateFin);
            this.tabAtelier.Controls.Add(this.btnModifier);
            this.tabAtelier.Controls.Add(this.lbAtelierExistant);
            this.tabAtelier.Controls.Add(this.lbCapacite);
            this.tabAtelier.Controls.Add(this.lbTheme);
            this.tabAtelier.Controls.Add(this.lbAtelier);
            this.tabAtelier.Controls.Add(this.dgvAteliers);
            this.tabAtelier.Controls.Add(this.btnAnnuler);
            this.tabAtelier.Controls.Add(this.btnAdd);
            this.tabAtelier.Controls.Add(this.txbCapacite);
            this.tabAtelier.Controls.Add(this.dtpDateDebut);
            this.tabAtelier.Location = new System.Drawing.Point(4, 22);
            this.tabAtelier.Name = "tabAtelier";
            this.tabAtelier.Padding = new System.Windows.Forms.Padding(3);
            this.tabAtelier.Size = new System.Drawing.Size(773, 404);
            this.tabAtelier.TabIndex = 2;
            this.tabAtelier.Text = "Mise en place des ateliers";
            this.tabAtelier.UseVisualStyleBackColor = true;
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtpDateFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFin.Location = new System.Drawing.Point(241, 135);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(151, 20);
            this.dtpDateFin.TabIndex = 12;
            this.dtpDateFin.ValueChanged += new System.EventHandler(this.dtpDateFin_ValueChanged);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(146, 177);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 11;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // lbAtelierExistant
            // 
            this.lbAtelierExistant.AutoSize = true;
            this.lbAtelierExistant.Location = new System.Drawing.Point(27, 221);
            this.lbAtelierExistant.Name = "lbAtelierExistant";
            this.lbAtelierExistant.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbAtelierExistant.Size = new System.Drawing.Size(85, 13);
            this.lbAtelierExistant.TabIndex = 10;
            this.lbAtelierExistant.Text = "Ateliers existants";
            // 
            // lbCapacite
            // 
            this.lbCapacite.AutoSize = true;
            this.lbCapacite.Location = new System.Drawing.Point(238, 51);
            this.lbCapacite.Name = "lbCapacite";
            this.lbCapacite.Size = new System.Drawing.Size(49, 13);
            this.lbCapacite.TabIndex = 9;
            this.lbCapacite.Text = "Capacité";
            // 
            // lbTheme
            // 
            this.lbTheme.AutoSize = true;
            this.lbTheme.Location = new System.Drawing.Point(13, 91);
            this.lbTheme.Name = "lbTheme";
            this.lbTheme.Size = new System.Drawing.Size(40, 13);
            this.lbTheme.TabIndex = 8;
            this.lbTheme.Text = "Thème";
            // 
            // lbAtelier
            // 
            this.lbAtelier.AutoSize = true;
            this.lbAtelier.Location = new System.Drawing.Point(13, 48);
            this.lbAtelier.Name = "lbAtelier";
            this.lbAtelier.Size = new System.Drawing.Size(36, 13);
            this.lbAtelier.TabIndex = 7;
            this.lbAtelier.Text = "Atelier";
            // 
            // dgvAteliers
            // 
            this.dgvAteliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAteliers.Location = new System.Drawing.Point(30, 237);
            this.dgvAteliers.Name = "dgvAteliers";
            this.dgvAteliers.Size = new System.Drawing.Size(487, 150);
            this.dgvAteliers.TabIndex = 6;
            this.dgvAteliers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAteliers_CellContentClick);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(251, 177);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(54, 177);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txbCapacite
            // 
            this.txbCapacite.Location = new System.Drawing.Point(293, 48);
            this.txbCapacite.Name = "txbCapacite";
            this.txbCapacite.Size = new System.Drawing.Size(100, 20);
            this.txbCapacite.TabIndex = 3;
            this.txbCapacite.TextChanged += new System.EventHandler(this.txbCapacite_TextChanged);
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtpDateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateDebut.Location = new System.Drawing.Point(54, 135);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(144, 20);
            this.dtpDateDebut.TabIndex = 2;
            this.dtpDateDebut.ValueChanged += new System.EventHandler(this.dtpDateDebut_ValueChanged);
            // 
            // txbAtelier
            // 
            this.txbAtelier.Location = new System.Drawing.Point(72, 48);
            this.txbAtelier.Name = "txbAtelier";
            this.txbAtelier.Size = new System.Drawing.Size(100, 20);
            this.txbAtelier.TabIndex = 13;
            this.txbAtelier.TextChanged += new System.EventHandler(this.txbAtelier_TextChanged);
            // 
            // txbTheme
            // 
            this.txbTheme.Location = new System.Drawing.Point(72, 88);
            this.txbTheme.Name = "txbTheme";
            this.txbTheme.Size = new System.Drawing.Size(100, 20);
            this.txbTheme.TabIndex = 14;
            this.txbTheme.TextChanged += new System.EventHandler(this.txbTheme_TextChanged);
            // 
            // AssisesSportLorrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 454);
            this.Controls.Add(this.tabCtrlASL);
            this.Name = "AssisesSportLorrain";
            this.Text = "Assises du Sport Lorrain";
            this.tabCtrlASL.ResumeLayout(false);
            this.tabAtelier.ResumeLayout(false);
            this.tabAtelier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAteliers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrlASL;
        private System.Windows.Forms.TabPage tabInscription;
        private System.Windows.Forms.TabPage tabStand;
        private System.Windows.Forms.TabPage tabAtelier;
        private System.Windows.Forms.TextBox txbCapacite;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvAteliers;
        private System.Windows.Forms.Label lbAtelierExistant;
        private System.Windows.Forms.Label lbCapacite;
        private System.Windows.Forms.Label lbTheme;
        private System.Windows.Forms.Label lbAtelier;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.TextBox txbTheme;
        private System.Windows.Forms.TextBox txbAtelier;
    }
}

