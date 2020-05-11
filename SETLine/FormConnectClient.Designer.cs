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
            this.SuspendLayout();
            // 
            // comboBoxRates
            // 
            this.comboBoxRates.FormattingEnabled = true;
            this.comboBoxRates.Location = new System.Drawing.Point(19, 220);
            this.comboBoxRates.Name = "comboBoxRates";
            this.comboBoxRates.Size = new System.Drawing.Size(219, 21);
            this.comboBoxRates.TabIndex = 60;
            this.comboBoxRates.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressFalse);
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(19, 164);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(219, 21);
            this.comboBoxClient.TabIndex = 58;
            this.comboBoxClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressFalse);
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Location = new System.Drawing.Point(16, 204);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(40, 13);
            this.labelRate.TabIndex = 57;
            this.labelRate.Text = "Тариф";
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(524, 342);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(161, 50);
            this.buttonDel.TabIndex = 55;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(160, 342);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(161, 50);
            this.buttonAdd.TabIndex = 54;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(16, 148);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(43, 13);
            this.labelClient.TabIndex = 52;
            this.labelClient.Text = "Клиент";
            // 
            // labelWorker
            // 
            this.labelWorker.AutoSize = true;
            this.labelWorker.Location = new System.Drawing.Point(20, 90);
            this.labelWorker.Name = "labelWorker";
            this.labelWorker.Size = new System.Drawing.Size(60, 13);
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
            this.listViewConnects.Location = new System.Drawing.Point(288, 90);
            this.listViewConnects.Name = "listViewConnects";
            this.listViewConnects.Size = new System.Drawing.Size(397, 190);
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
            this.buttonEdit.Location = new System.Drawing.Point(343, 342);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(161, 50);
            this.buttonEdit.TabIndex = 62;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelWorkerShow
            // 
            this.labelWorkerShow.AutoSize = true;
            this.labelWorkerShow.Location = new System.Drawing.Point(20, 118);
            this.labelWorkerShow.Name = "labelWorkerShow";
            this.labelWorkerShow.Size = new System.Drawing.Size(68, 13);
            this.labelWorkerShow.TabIndex = 64;
            this.labelWorkerShow.Text = "Неизвестно";
            // 
            // FormConnectClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "FormConnectClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подключить клиента";
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
    }
}