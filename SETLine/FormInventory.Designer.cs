namespace SETLine
{
    partial class FormInventory
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
            this.listViewPhones = new System.Windows.Forms.ListView();
            this.NameTovar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.listViewSmartPhones = new System.Windows.Forms.ListView();
            this.NameTovar1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewPeriphery = new System.Windows.Forms.ListView();
            this.NameTovar2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(11, 337);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(54, 24);
            this.labelPrice.TabIndex = 47;
            this.labelPrice.Text = "Цена";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(15, 364);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(380, 29);
            this.textBoxPrice.TabIndex = 46;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber);
            // 
            // listViewPhones
            // 
            this.listViewPhones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameTovar,
            this.Category,
            this.Quantity,
            this.Price});
            this.listViewPhones.GridLines = true;
            this.listViewPhones.HideSelection = false;
            this.listViewPhones.Location = new System.Drawing.Point(453, 104);
            this.listViewPhones.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listViewPhones.Name = "listViewPhones";
            this.listViewPhones.Size = new System.Drawing.Size(825, 442);
            this.listViewPhones.TabIndex = 45;
            this.listViewPhones.UseCompatibleStateImageBehavior = false;
            this.listViewPhones.View = System.Windows.Forms.View.Details;
            this.listViewPhones.SelectedIndexChanged += new System.EventHandler(this.listViewPhones_SelectedIndexChanged);
            // 
            // NameTovar
            // 
            this.NameTovar.Text = "Наименование";
            this.NameTovar.Width = 151;
            // 
            // Category
            // 
            this.Category.Text = "Категория";
            this.Category.Width = 106;
            // 
            // Quantity
            // 
            this.Quantity.DisplayIndex = 3;
            this.Quantity.Text = "Количество";
            // 
            // Price
            // 
            this.Price.DisplayIndex = 2;
            this.Price.Text = "Цена";
            this.Price.Width = 91;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(1128, 573);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(149, 58);
            this.buttonDel.TabIndex = 44;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(967, 573);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(149, 58);
            this.buttonEdit.TabIndex = 43;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(806, 573);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(149, 58);
            this.buttonAdd.TabIndex = 42;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(15, 126);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(380, 29);
            this.textBoxName.TabIndex = 39;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(9, 190);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(105, 24);
            this.labelCategory.TabIndex = 37;
            this.labelCategory.Text = "Категория";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(9, 96);
            this.labelName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(144, 24);
            this.labelName.TabIndex = 36;
            this.labelName.Text = "Наименование";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Телефоны",
            "Смартфоны",
            "Переферия"});
            this.comboBoxCategory.Location = new System.Drawing.Point(15, 220);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(380, 32);
            this.comboBoxCategory.TabIndex = 48;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            this.comboBoxCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressFalse);
            // 
            // listViewSmartPhones
            // 
            this.listViewSmartPhones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameTovar1,
            this.Category1,
            this.Quantity1,
            this.Price1});
            this.listViewSmartPhones.GridLines = true;
            this.listViewSmartPhones.HideSelection = false;
            this.listViewSmartPhones.Location = new System.Drawing.Point(453, 104);
            this.listViewSmartPhones.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listViewSmartPhones.Name = "listViewSmartPhones";
            this.listViewSmartPhones.Size = new System.Drawing.Size(825, 442);
            this.listViewSmartPhones.TabIndex = 49;
            this.listViewSmartPhones.UseCompatibleStateImageBehavior = false;
            this.listViewSmartPhones.View = System.Windows.Forms.View.Details;
            this.listViewSmartPhones.SelectedIndexChanged += new System.EventHandler(this.listViewSmartPhones_SelectedIndexChanged);
            // 
            // NameTovar1
            // 
            this.NameTovar1.Text = "Наименование";
            this.NameTovar1.Width = 151;
            // 
            // Category1
            // 
            this.Category1.Text = "Категория";
            this.Category1.Width = 106;
            // 
            // Quantity1
            // 
            this.Quantity1.DisplayIndex = 3;
            this.Quantity1.Text = "Количество";
            // 
            // Price1
            // 
            this.Price1.DisplayIndex = 2;
            this.Price1.Text = "Цена";
            this.Price1.Width = 91;
            // 
            // listViewPeriphery
            // 
            this.listViewPeriphery.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameTovar2,
            this.Category2,
            this.Quantity2,
            this.Price2});
            this.listViewPeriphery.GridLines = true;
            this.listViewPeriphery.HideSelection = false;
            this.listViewPeriphery.Location = new System.Drawing.Point(453, 104);
            this.listViewPeriphery.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listViewPeriphery.Name = "listViewPeriphery";
            this.listViewPeriphery.Size = new System.Drawing.Size(825, 442);
            this.listViewPeriphery.TabIndex = 50;
            this.listViewPeriphery.UseCompatibleStateImageBehavior = false;
            this.listViewPeriphery.View = System.Windows.Forms.View.Details;
            this.listViewPeriphery.SelectedIndexChanged += new System.EventHandler(this.listViewPeriphery_SelectedIndexChanged);
            // 
            // NameTovar2
            // 
            this.NameTovar2.Text = "Наименование";
            this.NameTovar2.Width = 151;
            // 
            // Category2
            // 
            this.Category2.Text = "Категория";
            this.Category2.Width = 106;
            // 
            // Quantity2
            // 
            this.Quantity2.Text = "Количество";
            // 
            // Price2
            // 
            this.Price2.Text = "Цена";
            this.Price2.Width = 91;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(15, 292);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(380, 29);
            this.textBoxQuantity.TabIndex = 51;
            this.textBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber);
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(9, 264);
            this.labelQuantity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(117, 24);
            this.labelQuantity.TabIndex = 52;
            this.labelQuantity.Text = "Количество";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::SETLine.Properties.Resources.SETLineLogo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(844, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(451, 77);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 53;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 638);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.listViewPeriphery);
            this.Controls.Add(this.listViewSmartPhones);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.listViewPhones);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склад";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.ListView listViewPhones;
        private System.Windows.Forms.ColumnHeader NameTovar;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ListView listViewSmartPhones;
        private System.Windows.Forms.ColumnHeader NameTovar1;
        private System.Windows.Forms.ColumnHeader Category1;
        private System.Windows.Forms.ColumnHeader Price1;
        private System.Windows.Forms.ListView listViewPeriphery;
        private System.Windows.Forms.ColumnHeader NameTovar2;
        private System.Windows.Forms.ColumnHeader Category2;
        private System.Windows.Forms.ColumnHeader Price2;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Quantity2;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.ColumnHeader Quantity1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}