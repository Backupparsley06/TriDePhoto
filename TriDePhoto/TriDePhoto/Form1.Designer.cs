namespace TriDePhoto
{
    partial class TriDePhoto
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
            this.BTN_LoadPhoto = new System.Windows.Forms.Button();
            this.PB_affichageSac = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_affichageSac)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_LoadPhoto
            // 
            this.BTN_LoadPhoto.Location = new System.Drawing.Point(12, 610);
            this.BTN_LoadPhoto.Name = "BTN_LoadPhoto";
            this.BTN_LoadPhoto.Size = new System.Drawing.Size(102, 32);
            this.BTN_LoadPhoto.TabIndex = 0;
            this.BTN_LoadPhoto.Text = "Load Photo";
            this.BTN_LoadPhoto.UseVisualStyleBackColor = true;
            this.BTN_LoadPhoto.Click += new System.EventHandler(this.BTN_LoadPhoto_Click);
            // 
            // PB_affichageSac
            // 
            this.PB_affichageSac.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PB_affichageSac.Location = new System.Drawing.Point(12, 12);
            this.PB_affichageSac.Name = "PB_affichageSac";
            this.PB_affichageSac.Size = new System.Drawing.Size(1409, 388);
            this.PB_affichageSac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_affichageSac.TabIndex = 1;
            this.PB_affichageSac.TabStop = false;
            // 
            // TriDePhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 654);
            this.Controls.Add(this.PB_affichageSac);
            this.Controls.Add(this.BTN_LoadPhoto);
            this.Name = "TriDePhoto";
            this.Text = "Tri de photo";
            ((System.ComponentModel.ISupportInitialize)(this.PB_affichageSac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_LoadPhoto;
        private System.Windows.Forms.PictureBox PB_affichageSac;
    }
}

