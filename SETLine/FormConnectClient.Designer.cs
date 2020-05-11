namespace SETLine
{
    partial class FormConnectClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConnectClient));
            this.comboBoxRates = new System.Windows.Forms.ComboBox();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.labelRate = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelWorker = new System.Windows.Forms.Label();
            this.listViewConnects = new System.Windows.Forms.ListView();
            this.Worker = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelWorkerShow = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxRates
            // 
            this.comboBoxRates.FormattingEnabled = true;
            this.comboBoxRates.Location = new System.Drawing.Point(29, 332);
            this.comboBoxRates.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxRates.Name = "comboBoxRates";
            this.comboBoxRates.Size = new System.Drawing.Size(398, 32);
            this.comboBoxRates.TabIndex = 60;
            this.comboBoxRates.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressFalse);
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(29, 229);
            this.comboBoxClient.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(398, 32);
            this.comboBoxClient.TabIndex = 58;
            this.comboBoxClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressFalse);
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Location = new System.Drawing.Point(23, 303);
            this.labelRate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(68, 24);
            this.labelRate.TabIndex = 57;
            this.labelRate.Text = "Тариф";
            // 
            // buttonDel
            // 
            this.buttonDel.ForeColor = System.Drawing.Color.Black;
            this.buttonDel.Location = new System.Drawing.Point(830, 500);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(192, 43);
            this.buttonDel.TabIndex = 55;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.Location = new System.Drawing.Point(422, 500);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(192, 43);
            this.buttonAdd.TabIndex = 54;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(23, 199);
            this.labelClient.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(75, 24);
            this.labelClient.TabIndex = 52;
            this.labelClient.Text = "Клиент";
            // 
            // labelWorker
            // 
            this.labelWorker.AutoSize = true;
            this.labelWorker.Location = new System.Drawing.Point(31, 92);
            this.labelWorker.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelWorker.Name = "labelWorker";
            this.labelWorker.Size = new System.Drawing.Size(107, 24);
            this.labelWorker.TabIndex = 51;
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
            this.listViewConnects.Location = new System.Drawing.Point(449, 124);
            this.listViewConnects.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listViewConnects.Name = "listViewConnects";
            this.listViewConnects.Size = new System.Drawing.Size(588, 347);
            this.listViewConnects.TabIndex = 61;
            this.listViewConnects.UseCompatibleStateImageBehavior = false;
            this.listViewConnects.View = System.Windows.Forms.View.Details;
            this.listViewConnects.SelectedIndexChanged += new System.EventHandler(this.listViewConnects_SelectedIndexChanged);
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
            // buttonEdit
            // 
            this.buttonEdit.ForeColor = System.Drawing.Color.Black;
            this.buttonEdit.Location = new System.Drawing.Point(626, 500);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(192, 43);
            this.buttonEdit.TabIndex = 62;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelWorkerShow
            // 
            this.labelWorkerShow.AutoSize = true;
            this.labelWorkerShow.Location = new System.Drawing.Point(31, 144);
            this.labelWorkerShow.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelWorkerShow.Name = "labelWorkerShow";
            this.labelWorkerShow.Size = new System.Drawing.Size(119, 24);
            this.labelWorkerShow.TabIndex = 64;
            this.labelWorkerShow.Text = "Неизвестно";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::SETLine.Properties.Resources.SETLineLogo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(425, 25);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(520, 87);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 65;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormConnectClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(1)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1052, 567);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelWorkerShow);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.listViewConnects);
            this.Controls.Add(this.comboBoxRates);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.labelRate);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.labelWorker);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormConnectClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подключить клиента";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxRates;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelWorker;
        private System.Windows.Forms.ListView listViewConnects;
        private System.Windows.Forms.ColumnHeader Worker;
        private System.Windows.Forms.ColumnHeader Client;
        private System.Windows.Forms.ColumnHeader Rate;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.Label labelWorkerShow;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}