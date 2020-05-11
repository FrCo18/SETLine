namespace SETLine
{
    partial class FormAddOrDelOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddOrDelOrder));
            this.labelType = new System.Windows.Forms.Label();
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.Worker = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tovar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelTovar = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelWorker = new System.Windows.Forms.Label();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.comboBoxTovar = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelWorkerShow = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(10, 224);
            this.labelType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(112, 24);
            this.labelType.TabIndex = 47;
            this.labelType.Text = "Тип товара";
            // 
            // listViewOrders
            // 
            this.listViewOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Worker,
            this.Client,
            this.Type,
            this.Tovar,
            this.Price});
            this.listViewOrders.GridLines = true;
            this.listViewOrders.HideSelection = false;
            this.listViewOrders.Location = new System.Drawing.Point(466, 107);
            this.listViewOrders.Margin = new System.Windows.Forms.Padding(6);
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(560, 319);
            this.listViewOrders.TabIndex = 45;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            this.listViewOrders.View = System.Windows.Forms.View.Details;
            this.listViewOrders.SelectedIndexChanged += new System.EventHandler(this.listViewClients_SelectedIndexChanged);
            // 
            // Worker
            // 
            this.Worker.Text = "Сотрудник";
            this.Worker.Width = 151;
            // 
            // Client
            // 
            this.Client.Text = "Клиент";
            this.Client.Width = 106;
            // 
            // Type
            // 
            this.Type.Text = "Тип товара";
            this.Type.Width = 139;
            // 
            // Tovar
            // 
            this.Tovar.Text = "Товар";
            this.Tovar.Width = 91;
            // 
            // Price
            // 
            this.Price.Text = "Цена";
            // 
            // buttonDel
            // 
            this.buttonDel.ForeColor = System.Drawing.Color.Black;
            this.buttonDel.Location = new System.Drawing.Point(837, 438);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(6);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(189, 61);
            this.buttonDel.TabIndex = 44;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.Location = new System.Drawing.Point(599, 438);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(6);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(189, 61);
            this.buttonAdd.TabIndex = 42;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelTovar
            // 
            this.labelTovar.AutoSize = true;
            this.labelTovar.Location = new System.Drawing.Point(10, 333);
            this.labelTovar.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTovar.Name = "labelTovar";
            this.labelTovar.Size = new System.Drawing.Size(65, 24);
            this.labelTovar.TabIndex = 38;
            this.labelTovar.Text = "Товар";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(10, 121);
            this.labelClient.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(75, 24);
            this.labelClient.TabIndex = 37;
            this.labelClient.Text = "Клиент";
            // 
            // labelWorker
            // 
            this.labelWorker.AutoSize = true;
            this.labelWorker.Location = new System.Drawing.Point(17, 14);
            this.labelWorker.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelWorker.Name = "labelWorker";
            this.labelWorker.Size = new System.Drawing.Size(107, 24);
            this.labelWorker.TabIndex = 36;
            this.labelWorker.Text = "Сотрудник";
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(15, 150);
            this.comboBoxClient.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(398, 32);
            this.comboBoxClient.TabIndex = 48;
            this.comboBoxClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressFalse);
            // 
            // comboBoxTovar
            // 
            this.comboBoxTovar.FormattingEnabled = true;
            this.comboBoxTovar.Location = new System.Drawing.Point(15, 363);
            this.comboBoxTovar.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxTovar.Name = "comboBoxTovar";
            this.comboBoxTovar.Size = new System.Drawing.Size(398, 32);
            this.comboBoxTovar.TabIndex = 50;
            this.comboBoxTovar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressFalse);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Телефон",
            "Смартфон",
            "Переферия"});
            this.comboBoxType.Location = new System.Drawing.Point(15, 254);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(398, 32);
            this.comboBoxType.TabIndex = 50;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            this.comboBoxType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressFalse);
            // 
            // labelWorkerShow
            // 
            this.labelWorkerShow.AutoSize = true;
            this.labelWorkerShow.Location = new System.Drawing.Point(17, 67);
            this.labelWorkerShow.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelWorkerShow.Name = "labelWorkerShow";
            this.labelWorkerShow.Size = new System.Drawing.Size(119, 24);
            this.labelWorkerShow.TabIndex = 51;
            this.labelWorkerShow.Text = "Неизвестно";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::SETLine.Properties.Resources.SETLineLogo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(575, 14);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(451, 77);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 52;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormAddOrDelOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(1)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1045, 513);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelWorkerShow);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.comboBoxTovar);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.listViewOrders);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelTovar);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.labelWorker);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormAddOrDelOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание или удаление заказа";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ListView listViewOrders;
        private System.Windows.Forms.ColumnHeader Worker;
        private System.Windows.Forms.ColumnHeader Client;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Tovar;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelTovar;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelWorker;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.ComboBox comboBoxTovar;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelWorkerShow;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}