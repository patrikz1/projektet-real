﻿namespace Projekt
{
    partial class PodcastPlayer
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
            this.listPodcasts = new System.Windows.Forms.ListView();
            this.headerAvsnitt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerNamn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerFrekvens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerKategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblURL = new System.Windows.Forms.Label();
            this.lblFrekvens = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.txtBoxURL = new System.Windows.Forms.TextBox();
            this.comboFrekvens = new System.Windows.Forms.ComboBox();
            this.comboKategori = new System.Windows.Forms.ComboBox();
            this.btnNewPod = new System.Windows.Forms.Button();
            this.btnSavePod = new System.Windows.Forms.Button();
            this.btnRemovePod = new System.Windows.Forms.Button();
            this.lblKategorier = new System.Windows.Forms.Label();
            this.listCategories = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnNewCategory = new System.Windows.Forms.Button();
            this.btnSaveCategory = new System.Windows.Forms.Button();
            this.btnRemoveCategory = new System.Windows.Forms.Button();
            this.listAvsnitt = new System.Windows.Forms.ListView();
            this.lblAvsnitt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listPodcasts
            // 
            this.listPodcasts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerAvsnitt,
            this.headerNamn,
            this.headerFrekvens,
            this.headerKategori});
            this.listPodcasts.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listPodcasts.Location = new System.Drawing.Point(23, 25);
            this.listPodcasts.Name = "listPodcasts";
            this.listPodcasts.Size = new System.Drawing.Size(411, 155);
            this.listPodcasts.TabIndex = 0;
            this.listPodcasts.UseCompatibleStateImageBehavior = false;
            this.listPodcasts.View = System.Windows.Forms.View.Details;
            // 
            // headerAvsnitt
            // 
            this.headerAvsnitt.Text = " Avsnitt";
            this.headerAvsnitt.Width = 73;
            // 
            // headerNamn
            // 
            this.headerNamn.Text = "Namn";
            this.headerNamn.Width = 141;
            // 
            // headerFrekvens
            // 
            this.headerFrekvens.Text = "Frekvens";
            this.headerFrekvens.Width = 98;
            // 
            // headerKategori
            // 
            this.headerKategori.Text = "Kategori";
            this.headerKategori.Width = 95;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURL.Location = new System.Drawing.Point(20, 189);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(38, 15);
            this.lblURL.TabIndex = 1;
            this.lblURL.Text = "URL :";
            // 
            // lblFrekvens
            // 
            this.lblFrekvens.AutoSize = true;
            this.lblFrekvens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrekvens.Location = new System.Drawing.Point(168, 193);
            this.lblFrekvens.Name = "lblFrekvens";
            this.lblFrekvens.Size = new System.Drawing.Size(132, 15);
            this.lblFrekvens.TabIndex = 2;
            this.lblFrekvens.Text = "Uppdateringsfrekvens :";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategori.Location = new System.Drawing.Point(318, 192);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(59, 15);
            this.lblKategori.TabIndex = 3;
            this.lblKategori.Text = "Kategori :";
            // 
            // txtBoxURL
            // 
            this.txtBoxURL.Location = new System.Drawing.Point(23, 208);
            this.txtBoxURL.Name = "txtBoxURL";
            this.txtBoxURL.Size = new System.Drawing.Size(139, 20);
            this.txtBoxURL.TabIndex = 4;
            // 
            // comboFrekvens
            // 
            this.comboFrekvens.FormattingEnabled = true;
            this.comboFrekvens.Items.AddRange(new object[] {
            "hej",
            "test"});
            this.comboFrekvens.Location = new System.Drawing.Point(171, 208);
            this.comboFrekvens.Name = "comboFrekvens";
            this.comboFrekvens.Size = new System.Drawing.Size(136, 21);
            this.comboFrekvens.TabIndex = 5;
            // 
            // comboKategori
            // 
            this.comboKategori.FormattingEnabled = true;
            this.comboKategori.Items.AddRange(new object[] {
            "test",
            "hej"});
            this.comboKategori.Location = new System.Drawing.Point(313, 208);
            this.comboKategori.Name = "comboKategori";
            this.comboKategori.Size = new System.Drawing.Size(121, 21);
            this.comboKategori.TabIndex = 6;
            // 
            // btnNewPod
            // 
            this.btnNewPod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPod.Location = new System.Drawing.Point(197, 235);
            this.btnNewPod.Name = "btnNewPod";
            this.btnNewPod.Size = new System.Drawing.Size(75, 23);
            this.btnNewPod.TabIndex = 7;
            this.btnNewPod.Text = "Ny...";
            this.btnNewPod.UseVisualStyleBackColor = true;
            this.btnNewPod.Click += new System.EventHandler(this.btnNewPod_Click);
            // 
            // btnSavePod
            // 
            this.btnSavePod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePod.Location = new System.Drawing.Point(278, 235);
            this.btnSavePod.Name = "btnSavePod";
            this.btnSavePod.Size = new System.Drawing.Size(75, 23);
            this.btnSavePod.TabIndex = 8;
            this.btnSavePod.Text = "Spara";
            this.btnSavePod.UseVisualStyleBackColor = true;
            this.btnSavePod.Click += new System.EventHandler(this.btnSavePod_Click);
            // 
            // btnRemovePod
            // 
            this.btnRemovePod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePod.Location = new System.Drawing.Point(359, 235);
            this.btnRemovePod.Name = "btnRemovePod";
            this.btnRemovePod.Size = new System.Drawing.Size(75, 23);
            this.btnRemovePod.TabIndex = 9;
            this.btnRemovePod.Text = "Ta bort...";
            this.btnRemovePod.UseVisualStyleBackColor = true;
            // 
            // lblKategorier
            // 
            this.lblKategorier.AutoSize = true;
            this.lblKategorier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorier.Location = new System.Drawing.Point(469, 9);
            this.lblKategorier.Name = "lblKategorier";
            this.lblKategorier.Size = new System.Drawing.Size(64, 13);
            this.lblKategorier.TabIndex = 10;
            this.lblKategorier.Text = "Kategorier : ";
            // 
            // listCategories
            // 
            this.listCategories.Location = new System.Drawing.Point(472, 25);
            this.listCategories.Name = "listCategories";
            this.listCategories.Size = new System.Drawing.Size(258, 155);
            this.listCategories.TabIndex = 11;
            this.listCategories.UseCompatibleStateImageBehavior = false;
            this.listCategories.View = System.Windows.Forms.View.List;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(472, 192);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 20);
            this.textBox1.TabIndex = 12;
            // 
            // btnNewCategory
            // 
            this.btnNewCategory.Location = new System.Drawing.Point(481, 218);
            this.btnNewCategory.Name = "btnNewCategory";
            this.btnNewCategory.Size = new System.Drawing.Size(75, 23);
            this.btnNewCategory.TabIndex = 13;
            this.btnNewCategory.Text = "Ny...";
            this.btnNewCategory.UseVisualStyleBackColor = true;
            // 
            // btnSaveCategory
            // 
            this.btnSaveCategory.Location = new System.Drawing.Point(562, 218);
            this.btnSaveCategory.Name = "btnSaveCategory";
            this.btnSaveCategory.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCategory.TabIndex = 14;
            this.btnSaveCategory.Text = "Spara";
            this.btnSaveCategory.UseVisualStyleBackColor = true;
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.Location = new System.Drawing.Point(643, 218);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveCategory.TabIndex = 15;
            this.btnRemoveCategory.Text = "Ta bort...";
            this.btnRemoveCategory.UseVisualStyleBackColor = true;
            // 
            // listAvsnitt
            // 
            this.listAvsnitt.Location = new System.Drawing.Point(23, 285);
            this.listAvsnitt.Name = "listAvsnitt";
            this.listAvsnitt.Size = new System.Drawing.Size(411, 158);
            this.listAvsnitt.TabIndex = 16;
            this.listAvsnitt.UseCompatibleStateImageBehavior = false;
            // 
            // lblAvsnitt
            // 
            this.lblAvsnitt.AutoSize = true;
            this.lblAvsnitt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvsnitt.Location = new System.Drawing.Point(28, 263);
            this.lblAvsnitt.Name = "lblAvsnitt";
            this.lblAvsnitt.Size = new System.Drawing.Size(47, 16);
            this.lblAvsnitt.TabIndex = 17;
            this.lblAvsnitt.Text = "Avsnitt\r\n";
            this.lblAvsnitt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PodcastPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(761, 480);
            this.Controls.Add(this.lblAvsnitt);
            this.Controls.Add(this.listAvsnitt);
            this.Controls.Add(this.btnRemoveCategory);
            this.Controls.Add(this.btnSaveCategory);
            this.Controls.Add(this.btnNewCategory);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listCategories);
            this.Controls.Add(this.lblKategorier);
            this.Controls.Add(this.btnRemovePod);
            this.Controls.Add(this.btnSavePod);
            this.Controls.Add(this.btnNewPod);
            this.Controls.Add(this.comboKategori);
            this.Controls.Add(this.comboFrekvens);
            this.Controls.Add(this.txtBoxURL);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.lblFrekvens);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.listPodcasts);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "PodcastPlayer";
            this.Text = "Podcast-Spelare";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listPodcasts;
        private System.Windows.Forms.ColumnHeader headerAvsnitt;
        private System.Windows.Forms.ColumnHeader headerNamn;
        private System.Windows.Forms.ColumnHeader headerFrekvens;
        private System.Windows.Forms.ColumnHeader headerKategori;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Label lblFrekvens;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.TextBox txtBoxURL;
        private System.Windows.Forms.ComboBox comboFrekvens;
        private System.Windows.Forms.ComboBox comboKategori;
        private System.Windows.Forms.Button btnNewPod;
        private System.Windows.Forms.Button btnSavePod;
        private System.Windows.Forms.Button btnRemovePod;
        private System.Windows.Forms.Label lblKategorier;
        private System.Windows.Forms.ListView listCategories;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnNewCategory;
        private System.Windows.Forms.Button btnSaveCategory;
        private System.Windows.Forms.Button btnRemoveCategory;
        private System.Windows.Forms.ListView listAvsnitt;
        private System.Windows.Forms.Label lblAvsnitt;
    }
}