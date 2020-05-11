namespace SETLine
{
    partial class FormConnectedClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConnectedClients));
            this.comboBoxWorker = new System.Windows.Forms.ComboBox();
            this.labelWorker = new System.Windows.Forms.Label();
            this.listViewConnects = new System.Windows.Forms.ListView();
            this.Worker = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxWorker
            // 
            this.comboBoxWorker.FormattingEnabled = true;
            this.comboBoxWorker.Location = new System.Drawing.Point(22, 194);
            this.comboBoxWorker.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxWorker.Name = "comboBoxWorker";
            this.comboBoxWorker.Size = new System.Drawing.Size(275, 32);
            this.comboBoxWorker.TabIndex = 0;
            this.comboBoxWorker.SelectedIndexChanged += new System.EventHandler(this.comboBoxWorker_SelectedIndexChanged);
            // 
            // labelWorker
            // 
            this.labelWorker.AutoSize = true;
            this.labelWorker.Location = new System.Drawing.Point(17, 164);
            this.labelWorker.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelWorker.Name = "labelWorker";
            this.labelWorker.Size = new System.Drawing.Size(107, 24);
            this.labelWorker.TabIndex = 1;
            this.labelWorker.Text = "Сотрудник";
            // 
            // listViewConnects
            // 
            this.listViewConnects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Worker,
            this.Client,
            this.Rate,
            this.Price,
            this.Phone});
            this.listViewConnects.GridLines = true;
            this.listViewConnects.HideSelection = false;
            this.listViewConnects.Location = new System.Drawing.Point(343, 137);
            this.listViewConnects.Margin = new System.Windows.Forms.Padding(6);
            this.listViewConnects.Name = "listViewConnects";
            this.listViewConnects.Size = new System.Drawing.Size(725, 347);
            this.listViewConnects.TabIndex = 62;
            this.listViewConnects.UseCompatibleStateImageBehavior = false;
            this.listViewConnects.View = System.Windows.Forms.View.Details;
            // 
            // Worker
            // 
            this.Worker.Text = "Сотрудник";
            this.Worker.Width = 79;
            // 
            // Client
            // 
            this.Client.Text = "Клиент";
            this.Client.Width = 80;
            // 
            // Rate
            // 
            this.Rate.Text = "Тариф";
            this.Rate.Width = 89;
            // 
            // Price
            // 
            this.Price.Text = "Цена";
            this.Price.Width = 74;
            // 
            // Phone
            // 
            this.Phone.Text = "Телефон";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::SETLine.Properties.Resources.SETLineLogo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(617, 27);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(451, 77);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 63;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormConnectedClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(1)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1093, 508);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.listViewConnects);
            this.Controls.Add(this.labelWorker);
            this.Controls.Add(this.comboBoxWorker);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormConnectedClients";
            this.Text = "Сотрудниики подключившие клиентов";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxWorker;
        private System.Windows.Forms.Label labelWorker;
        private System.Windows.Forms.ListView listViewConnects;
        private System.Windows.Forms.ColumnHeader Worker;
        private System.Windows.Forms.ColumnHeader Client;
        private System.Windows.Forms.ColumnHeader Rate;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}