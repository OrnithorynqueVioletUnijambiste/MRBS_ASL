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
            this.lbDateFin = new System.Windows.Forms.Label();
            this.lbDateDebut = new System.Windows.Forms.Label();
            this.btnSupprimerAtelier = new System.Windows.Forms.Button();
            this.txbAtelier = new System.Windows.Forms.TextBox();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.btnModifierAtelier = new System.Windows.Forms.Button();
            this.lbAtelierExistant = new System.Windows.Forms.Label();
            this.lbCapacite = new System.Windows.Forms.Label();
            this.lbAtelier = new System.Windows.Forms.Label();
            this.dgvAteliers = new System.Windows.Forms.DataGridView();
            this.btnAddAtelier = new System.Windows.Forms.Button();
            this.txbCapacite = new System.Windows.Forms.TextBox();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.tabTheme = new System.Windows.Forms.TabPage();
            this.lbThemes = new System.Windows.Forms.Label();
            this.btnSupprimerTheme = new System.Windows.Forms.Button();
            this.btnAjouterTheme = new System.Windows.Forms.Button();
            this.btnModifierTheme = new System.Windows.Forms.Button();
            this.cbAtelierAssoc = new System.Windows.Forms.ComboBox();
            this.lbAtelierAssocie = new System.Windows.Forms.Label();
            this.lbThemesFromAtelier = new System.Windows.Forms.Label();
            this.lbTheme = new System.Windows.Forms.Label();
            this.txbTheme = new System.Windows.Forms.TextBox();
            this.dgvThemes = new System.Windows.Forms.DataGridView();
            this.tabCtrlASL.SuspendLayout();
            this.tabAtelier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAteliers)).BeginInit();
            this.tabTheme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCtrlASL
            // 
            this.tabCtrlASL.Controls.Add(this.tabInscription);
            this.tabCtrlASL.Controls.Add(this.tabStand);
            this.tabCtrlASL.Controls.Add(this.tabAtelier);
            this.tabCtrlASL.Controls.Add(this.tabTheme);
            this.tabCtrlASL.Location = new System.Drawing.Point(12, 12);
            this.tabCtrlASL.Name = "tabCtrlASL";
            this.tabCtrlASL.SelectedIndex = 0;
            this.tabCtrlASL.Size = new System.Drawing.Size(636, 467);
            this.tabCtrlASL.TabIndex = 0;
            // 
            // tabInscription
            // 
            this.tabInscription.Location = new System.Drawing.Point(4, 22);
            this.tabInscription.Name = "tabInscription";
            this.tabInscription.Padding = new System.Windows.Forms.Padding(3);
            this.tabInscription.Size = new System.Drawing.Size(628, 441);
            this.tabInscription.TabIndex = 0;
            this.tabInscription.Text = "Inscription aux ateliers";
            this.tabInscription.UseVisualStyleBackColor = true;
            // 
            // tabStand
            // 
            this.tabStand.Location = new System.Drawing.Point(4, 22);
            this.tabStand.Name = "tabStand";
            this.tabStand.Padding = new System.Windows.Forms.Padding(3);
            this.tabStand.Size = new System.Drawing.Size(628, 441);
            this.tabStand.TabIndex = 1;
            this.tabStand.Text = "Gestion des stands";
            this.tabStand.UseVisualStyleBackColor = true;
            // 
            // tabAtelier
            // 
            this.tabAtelier.Controls.Add(this.lbDateFin);
            this.tabAtelier.Controls.Add(this.lbDateDebut);
            this.tabAtelier.Controls.Add(this.btnSupprimerAtelier);
            this.tabAtelier.Controls.Add(this.txbAtelier);
            this.tabAtelier.Controls.Add(this.dtpDateFin);
            this.tabAtelier.Controls.Add(this.btnModifierAtelier);
            this.tabAtelier.Controls.Add(this.lbAtelierExistant);
            this.tabAtelier.Controls.Add(this.lbCapacite);
            this.tabAtelier.Controls.Add(this.lbAtelier);
            this.tabAtelier.Controls.Add(this.dgvAteliers);
            this.tabAtelier.Controls.Add(this.btnAddAtelier);
            this.tabAtelier.Controls.Add(this.txbCapacite);
            this.tabAtelier.Controls.Add(this.dtpDateDebut);
            this.tabAtelier.Location = new System.Drawing.Point(4, 22);
            this.tabAtelier.Name = "tabAtelier";
            this.tabAtelier.Padding = new System.Windows.Forms.Padding(3);
            this.tabAtelier.Size = new System.Drawing.Size(628, 441);
            this.tabAtelier.TabIndex = 2;
            this.tabAtelier.Text = "Gestion des Ateliers";
            this.tabAtelier.UseVisualStyleBackColor = true;
            // 
            // lbDateFin
            // 
            this.lbDateFin.AutoSize = true;
            this.lbDateFin.Location = new System.Drawing.Point(277, 98);
            this.lbDateFin.Name = "lbDateFin";
            this.lbDateFin.Size = new System.Drawing.Size(68, 13);
            this.lbDateFin.TabIndex = 16;
            this.lbDateFin.Text = "Date de Fin :";
            // 
            // lbDateDebut
            // 
            this.lbDateDebut.AutoSize = true;
            this.lbDateDebut.Location = new System.Drawing.Point(277, 51);
            this.lbDateDebut.Name = "lbDateDebut";
            this.lbDateDebut.Size = new System.Drawing.Size(83, 13);
            this.lbDateDebut.TabIndex = 15;
            this.lbDateDebut.Text = "Date de Début :";
            // 
            // btnSupprimerAtelier
            // 
            this.btnSupprimerAtelier.Location = new System.Drawing.Point(519, 277);
            this.btnSupprimerAtelier.Name = "btnSupprimerAtelier";
            this.btnSupprimerAtelier.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimerAtelier.TabIndex = 14;
            this.btnSupprimerAtelier.Text = "Supprimer";
            this.btnSupprimerAtelier.UseVisualStyleBackColor = true;
            this.btnSupprimerAtelier.Click += new System.EventHandler(this.BtnSupprimerAtelier_Click);
            // 
            // txbAtelier
            // 
            this.txbAtelier.Location = new System.Drawing.Point(87, 48);
            this.txbAtelier.Name = "txbAtelier";
            this.txbAtelier.Size = new System.Drawing.Size(100, 20);
            this.txbAtelier.TabIndex = 13;
            this.txbAtelier.TextChanged += new System.EventHandler(this.txbAtelier_TextChanged);
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpDateFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFin.Location = new System.Drawing.Point(366, 95);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(154, 20);
            this.dtpDateFin.TabIndex = 17;
            // 
            // btnModifierAtelier
            // 
            this.btnModifierAtelier.Location = new System.Drawing.Point(519, 228);
            this.btnModifierAtelier.Name = "btnModifierAtelier";
            this.btnModifierAtelier.Size = new System.Drawing.Size(75, 23);
            this.btnModifierAtelier.TabIndex = 11;
            this.btnModifierAtelier.Text = "Modifier";
            this.btnModifierAtelier.UseVisualStyleBackColor = true;
            this.btnModifierAtelier.Click += new System.EventHandler(this.btnModifierAtelier_Click);
            // 
            // lbAtelierExistant
            // 
            this.lbAtelierExistant.AutoSize = true;
            this.lbAtelierExistant.Location = new System.Drawing.Point(32, 155);
            this.lbAtelierExistant.Name = "lbAtelierExistant";
            this.lbAtelierExistant.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbAtelierExistant.Size = new System.Drawing.Size(85, 13);
            this.lbAtelierExistant.TabIndex = 10;
            this.lbAtelierExistant.Text = "Ateliers existants";
            // 
            // lbCapacite
            // 
            this.lbCapacite.AutoSize = true;
            this.lbCapacite.Location = new System.Drawing.Point(32, 98);
            this.lbCapacite.Name = "lbCapacite";
            this.lbCapacite.Size = new System.Drawing.Size(55, 13);
            this.lbCapacite.TabIndex = 9;
            this.lbCapacite.Text = "Capacité :";
            // 
            // lbAtelier
            // 
            this.lbAtelier.AutoSize = true;
            this.lbAtelier.Location = new System.Drawing.Point(32, 51);
            this.lbAtelier.Name = "lbAtelier";
            this.lbAtelier.Size = new System.Drawing.Size(42, 13);
            this.lbAtelier.TabIndex = 7;
            this.lbAtelier.Text = "Atelier :";
            // 
            // dgvAteliers
            // 
            this.dgvAteliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAteliers.Location = new System.Drawing.Point(35, 181);
            this.dgvAteliers.Name = "dgvAteliers";
            this.dgvAteliers.Size = new System.Drawing.Size(466, 244);
            this.dgvAteliers.TabIndex = 6;
            this.dgvAteliers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAteliers_CellContentClick);
            // 
            // btnAddAtelier
            // 
            this.btnAddAtelier.Location = new System.Drawing.Point(519, 181);
            this.btnAddAtelier.Name = "btnAddAtelier";
            this.btnAddAtelier.Size = new System.Drawing.Size(75, 23);
            this.btnAddAtelier.TabIndex = 4;
            this.btnAddAtelier.Text = "Ajouter";
            this.btnAddAtelier.UseVisualStyleBackColor = true;
            this.btnAddAtelier.Click += new System.EventHandler(this.btnAddAtelier_Click);
            // 
            // txbCapacite
            // 
            this.txbCapacite.Location = new System.Drawing.Point(87, 95);
            this.txbCapacite.Name = "txbCapacite";
            this.txbCapacite.Size = new System.Drawing.Size(100, 20);
            this.txbCapacite.TabIndex = 3;
            this.txbCapacite.TextChanged += new System.EventHandler(this.txbCapacite_TextChanged);
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpDateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateDebut.Location = new System.Drawing.Point(366, 48);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(154, 20);
            this.dtpDateDebut.TabIndex = 18;
            // 
            // tabTheme
            // 
            this.tabTheme.Controls.Add(this.lbThemes);
            this.tabTheme.Controls.Add(this.btnSupprimerTheme);
            this.tabTheme.Controls.Add(this.btnAjouterTheme);
            this.tabTheme.Controls.Add(this.btnModifierTheme);
            this.tabTheme.Controls.Add(this.cbAtelierAssoc);
            this.tabTheme.Controls.Add(this.lbAtelierAssocie);
            this.tabTheme.Controls.Add(this.lbThemesFromAtelier);
            this.tabTheme.Controls.Add(this.lbTheme);
            this.tabTheme.Controls.Add(this.txbTheme);
            this.tabTheme.Controls.Add(this.dgvThemes);
            this.tabTheme.Location = new System.Drawing.Point(4, 22);
            this.tabTheme.Name = "tabTheme";
            this.tabTheme.Padding = new System.Windows.Forms.Padding(3);
            this.tabTheme.Size = new System.Drawing.Size(628, 441);
            this.tabTheme.TabIndex = 3;
            this.tabTheme.Text = "Gestion des Themes";
            this.tabTheme.UseVisualStyleBackColor = true;
            // 
            // lbThemes
            // 
            this.lbThemes.AutoSize = true;
            this.lbThemes.Location = new System.Drawing.Point(32, 53);
            this.lbThemes.Name = "lbThemes";
            this.lbThemes.Size = new System.Drawing.Size(40, 13);
            this.lbThemes.TabIndex = 27;
            this.lbThemes.Text = "Thème";
            // 
            // btnSupprimerTheme
            // 
            this.btnSupprimerTheme.Location = new System.Drawing.Point(519, 277);
            this.btnSupprimerTheme.Name = "btnSupprimerTheme";
            this.btnSupprimerTheme.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimerTheme.TabIndex = 25;
            this.btnSupprimerTheme.Text = "Supprimer";
            this.btnSupprimerTheme.UseVisualStyleBackColor = true;
            this.btnSupprimerTheme.Click += new System.EventHandler(this.BtnSupprimerTheme_Click);
            // 
            // btnAjouterTheme
            // 
            this.btnAjouterTheme.Location = new System.Drawing.Point(519, 181);
            this.btnAjouterTheme.Name = "btnAjouterTheme";
            this.btnAjouterTheme.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterTheme.TabIndex = 24;
            this.btnAjouterTheme.Text = "Ajouter";
            this.btnAjouterTheme.UseVisualStyleBackColor = true;
            this.btnAjouterTheme.Click += new System.EventHandler(this.BtnAjouterTheme_Click);
            // 
            // btnModifierTheme
            // 
            this.btnModifierTheme.Location = new System.Drawing.Point(519, 228);
            this.btnModifierTheme.Name = "btnModifierTheme";
            this.btnModifierTheme.Size = new System.Drawing.Size(75, 23);
            this.btnModifierTheme.TabIndex = 23;
            this.btnModifierTheme.Text = "Modifier";
            this.btnModifierTheme.UseVisualStyleBackColor = true;
            this.btnModifierTheme.Click += new System.EventHandler(this.BtnModifierTheme_Click);
            // 
            // cbAtelierAssoc
            // 
            this.cbAtelierAssoc.FormattingEnabled = true;
            this.cbAtelierAssoc.Location = new System.Drawing.Point(381, 50);
            this.cbAtelierAssoc.Name = "cbAtelierAssoc";
            this.cbAtelierAssoc.Size = new System.Drawing.Size(121, 21);
            this.cbAtelierAssoc.TabIndex = 21;
            this.cbAtelierAssoc.SelectedIndexChanged += new System.EventHandler(this.CbAtelierAssoc_SelectedIndexChanged);
            // 
            // lbAtelierAssocie
            // 
            this.lbAtelierAssocie.AutoSize = true;
            this.lbAtelierAssocie.Location = new System.Drawing.Point(300, 53);
            this.lbAtelierAssocie.Name = "lbAtelierAssocie";
            this.lbAtelierAssocie.Size = new System.Drawing.Size(81, 13);
            this.lbAtelierAssocie.TabIndex = 20;
            this.lbAtelierAssocie.Text = "Atelier associé :";
            // 
            // lbThemesFromAtelier
            // 
            this.lbThemesFromAtelier.AutoSize = true;
            this.lbThemesFromAtelier.Location = new System.Drawing.Point(32, 154);
            this.lbThemesFromAtelier.Name = "lbThemesFromAtelier";
            this.lbThemesFromAtelier.Size = new System.Drawing.Size(89, 13);
            this.lbThemesFromAtelier.TabIndex = 19;
            this.lbThemesFromAtelier.Text = "Themes existants";
            // 
            // lbTheme
            // 
            this.lbTheme.Location = new System.Drawing.Point(0, 0);
            this.lbTheme.Name = "lbTheme";
            this.lbTheme.Size = new System.Drawing.Size(100, 23);
            this.lbTheme.TabIndex = 26;
            // 
            // txbTheme
            // 
            this.txbTheme.Location = new System.Drawing.Point(84, 50);
            this.txbTheme.Name = "txbTheme";
            this.txbTheme.Size = new System.Drawing.Size(156, 20);
            this.txbTheme.TabIndex = 17;
            this.txbTheme.TextChanged += new System.EventHandler(this.TxbTheme_TextChanged);
            // 
            // dgvThemes
            // 
            this.dgvThemes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThemes.Location = new System.Drawing.Point(35, 181);
            this.dgvThemes.Name = "dgvThemes";
            this.dgvThemes.Size = new System.Drawing.Size(467, 247);
            this.dgvThemes.TabIndex = 16;
            // 
            // AssisesSportLorrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 493);
            this.Controls.Add(this.tabCtrlASL);
            this.Name = "AssisesSportLorrain";
            this.Text = "Assises du Sport Lorrain";
            this.Load += new System.EventHandler(this.AssisesSportLorrain_Load);
            this.tabCtrlASL.ResumeLayout(false);
            this.tabAtelier.ResumeLayout(false);
            this.tabAtelier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAteliers)).EndInit();
            this.tabTheme.ResumeLayout(false);
            this.tabTheme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrlASL;
        private System.Windows.Forms.TabPage tabInscription;
        private System.Windows.Forms.TabPage tabStand;
        private System.Windows.Forms.TabPage tabAtelier;
        private System.Windows.Forms.TextBox txbCapacite;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.Button btnAddAtelier;
        private System.Windows.Forms.DataGridView dgvAteliers;
        private System.Windows.Forms.Label lbAtelierExistant;
        private System.Windows.Forms.Label lbCapacite;
        private System.Windows.Forms.Label lbAtelier;
        private System.Windows.Forms.Button btnModifierAtelier;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.TextBox txbAtelier;
        private System.Windows.Forms.TabPage tabTheme;
        private System.Windows.Forms.Label lbThemesFromAtelier;
        private System.Windows.Forms.Label lbTheme;
        private System.Windows.Forms.TextBox txbTheme;
        private System.Windows.Forms.DataGridView dgvThemes;
        private System.Windows.Forms.ComboBox cbAtelierAssoc;
        private System.Windows.Forms.Label lbAtelierAssocie;
        private System.Windows.Forms.Button btnAjouterTheme;
        private System.Windows.Forms.Button btnModifierTheme;
        private System.Windows.Forms.Button btnSupprimerTheme;
        private System.Windows.Forms.Button btnSupprimerAtelier;
        private System.Windows.Forms.Label lbDateFin;
        private System.Windows.Forms.Label lbDateDebut;
        private System.Windows.Forms.Label lbThemes;
    }
}

