namespace SETLine
{
    partial class FormRates
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
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.listViewRates = new System.Windows.Forms.ListView();
            this.Rate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Minutes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxMinutes = new System.Windows.Forms.TextBox();
            this.textBoxGB = new System.Windows.Forms.TextBox();
            this.labelMinutes = new System.Windows.Forms.Label();
            this.labelGB = new System.Windows.Forms.Label();
            this.labelRate = new System.Windows.Forms.Label();
            this.textRate = new System.Windows.Forms.TextBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(11, 376);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(54, 24);
            this.labelPrice.TabIndex = 59;
            this.labelPrice.Text = "Цена";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(16, 405);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(180, 29);
            this.textBoxPrice.TabIndex = 58;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber);
            // 
            // listViewRates
            // 
            this.listViewRates.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Rate,
            this.GB,
            this.Minutes,
            this.Price});
            this.listViewRates.GridLines = true;
            this.listViewRates.HideSelection = false;
            this.listViewRates.Location = new System.Drawing.Point(226, 89);
            this.listViewRates.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listViewRates.Name = "listViewRates";
            this.listViewRates.Size = new System.Drawing.Size(862, 442);
            this.listViewRates.TabIndex = 57;
            this.listViewRates.UseCompatibleStateImageBehavior = false;
            this.listViewRates.View = System.Windows.Forms.View.Details;
            this.listViewRates.SelectedIndexChanged += new System.EventHandler(this.listViewRates_SelectedIndexChanged);
            // 
            // Rate
            // 
            this.Rate.Text = "Тариф";
            this.Rate.Width = 151;
            // 
            // GB
            // 
            this.GB.Text = "ГБ";
            this.GB.Width = 106;
            // 
            // Minutes
            // 
            this.Minutes.Text = "Миннуты";
            this.Minutes.Width = 106;
            // 
            // Price
            // 
            this.Price.Text = "Цена";
            this.Price.Width = 91;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(943, 543);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(145, 45);
            this.buttonDel.TabIndex = 56;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(786, 543);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(145, 45);
            this.buttonEdit.TabIndex = 55;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(629, 543);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(145, 45);
            this.buttonAdd.TabIndex = 54;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxMinutes
            // 
            this.textBoxMinutes.Location = new System.Drawing.Point(16, 313);
            this.textBoxMinutes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxMinutes.Name = "textBoxMinutes";
            this.textBoxMinutes.Size = new System.Drawing.Size(180, 29);
            this.textBoxMinutes.TabIndex = 53;
            this.textBoxMinutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber);
            // 
            // textBoxGB
            // 
            this.textBoxGB.Location = new System.Drawing.Point(16, 213);
            this.textBoxGB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxGB.Name = "textBoxGB";
            this.textBoxGB.Size = new System.Drawing.Size(180, 29);
            this.textBoxGB.TabIndex = 52;
            this.textBoxGB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber);
            // 
            // labelMinutes
            // 
            this.labelMinutes.AutoSize = true;
            this.labelMinutes.Location = new System.Drawing.Point(11, 283);
            this.labelMinutes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(80, 24);
            this.labelMinutes.TabIndex = 50;
            this.labelMinutes.Text = "Минуты";
            // 
            // labelGB
            // 
            this.labelGB.AutoSize = true;
            this.labelGB.Location = new System.Drawing.Point(11, 184);
            this.labelGB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelGB.Name = "labelGB";
            this.labelGB.Size = new System.Drawing.Size(34, 24);
            this.labelGB.TabIndex = 49;
            this.labelGB.Text = "ГБ";
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Location = new System.Drawing.Point(11, 89);
            this.labelRate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(68, 24);
            this.labelRate.TabIndex = 48;
            this.labelRate.Text = "Тариф";
            // 
            // textRate
            // 
            this.textRate.Location = new System.Drawing.Point(16, 119);
            this.textRate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textRate.Name = "textRate";
            this.textRate.Size = new System.Drawing.Size(180, 29);
            this.textRate.TabIndex = 51;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::SETLine.Properties.Resources.SETLineLogo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(652, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(451, 77);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 60;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 614);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.listViewRates);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxMinutes);
            this.Controls.Add(this.textBoxGB);
            this.Controls.Add(this.textRate);
            this.Controls.Add(this.labelMinutes);
            this.Controls.Add(this.labelGB);
            this.Controls.Add(this.labelRate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormRates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тарифы";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.ListView listViewRates;
        private System.Windows.Forms.ColumnHeader Rate;
        private System.Windows.Forms.ColumnHeader GB;
        private System.Windows.Forms.ColumnHeader Minutes;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxMinutes;
        private System.Windows.Forms.TextBox textBoxGB;
        private System.Windows.Forms.Label labelMinutes;
        private System.Windows.Forms.Label labelGB;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.TextBox textRate;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}