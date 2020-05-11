namespace SETLine
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonWorkers = new System.Windows.Forms.Button();
            this.buttonInventory = new System.Windows.Forms.Button();
            this.buttonAddOrDelOrder = new System.Windows.Forms.Button();
            this.buttonClients = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonConnectedClients = new System.Windows.Forms.Button();
            this.buttonConnectClient = new System.Windows.Forms.Button();
            this.buttonRates = new System.Windows.Forms.Button();
            this.buttonSales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonWorkers
            // 
            this.buttonWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWorkers.Location = new System.Drawing.Point(33, 62);
            this.buttonWorkers.Name = "buttonWorkers";
            this.buttonWorkers.Size = new System.Drawing.Size(258, 49);
            this.buttonWorkers.TabIndex = 0;
            this.buttonWorkers.Text = "Сотрудники";
            this.buttonWorkers.UseVisualStyleBackColor = true;
            this.buttonWorkers.Click += new System.EventHandler(this.buttonWorkers_Click);
            // 
            // buttonInventory
            // 
            this.buttonInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInventory.Location = new System.Drawing.Point(33, 172);
            this.buttonInventory.Name = "buttonInventory";
            this.buttonInventory.Size = new System.Drawing.Size(258, 49);
            this.buttonInventory.TabIndex = 1;
            this.buttonInventory.Text = "Склад";
            this.buttonInventory.UseVisualStyleBackColor = true;
            this.buttonInventory.Click += new System.EventHandler(this.buttonInventory_Click);
            // 
            // buttonAddOrDelOrder
            // 
            this.buttonAddOrDelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddOrDelOrder.Location = new System.Drawing.Point(33, 227);
            this.buttonAddOrDelOrder.Name = "buttonAddOrDelOrder";
            this.buttonAddOrDelOrder.Size = new System.Drawing.Size(258, 88);
            this.buttonAddOrDelOrder.TabIndex = 3;
            this.buttonAddOrDelOrder.Text = "Создать или убрать покупку";
            this.buttonAddOrDelOrder.UseVisualStyleBackColor = true;
            this.buttonAddOrDelOrder.Click += new System.EventHandler(this.buttonPlaceOrder_Click);
            // 
            // buttonClients
            // 
            this.buttonClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClients.Location = new System.Drawing.Point(33, 117);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(258, 49);
            this.buttonClients.TabIndex = 4;
            this.buttonClients.Text = "Клиенты";
            this.buttonClients.UseVisualStyleBackColor = true;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // buttonConnectedClients
            // 
            this.buttonConnectedClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConnectedClients.Location = new System.Drawing.Point(329, 321);
            this.buttonConnectedClients.Name = "buttonConnectedClients";
            this.buttonConnectedClients.Size = new System.Drawing.Size(258, 49);
            this.buttonConnectedClients.TabIndex = 9;
            this.buttonConnectedClients.Text = "Подключенные клиенты";
            this.buttonConnectedClients.UseVisualStyleBackColor = true;
            this.buttonConnectedClients.Click += new System.EventHandler(this.buttonConnectClients_Click);
            // 
            // buttonConnectClient
            // 
            this.buttonConnectClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConnectClient.Location = new System.Drawing.Point(329, 266);
            this.buttonConnectClient.Name = "buttonConnectClient";
            this.buttonConnectClient.Size = new System.Drawing.Size(258, 49);
            this.buttonConnectClient.TabIndex = 10;
            this.buttonConnectClient.Text = "Подключить клиента";
            this.buttonConnectClient.UseVisualStyleBackColor = true;
            this.buttonConnectClient.Click += new System.EventHandler(this.buttonConnectClient_Click);
            // 
            // buttonRates
            // 
            this.buttonRates.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRates.Location = new System.Drawing.Point(329, 211);
            this.buttonRates.Name = "buttonRates";
            this.buttonRates.Size = new System.Drawing.Size(258, 49);
            this.buttonRates.TabIndex = 15;
            this.buttonRates.Text = "Тарифы";
            this.buttonRates.UseVisualStyleBackColor = true;
            this.buttonRates.Click += new System.EventHandler(this.buttonRates_Click);
            // 
            // buttonSales
            // 
            this.buttonSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSales.Location = new System.Drawing.Point(33, 321);
            this.buttonSales.Name = "buttonSales";
            this.buttonSales.Size = new System.Drawing.Size(258, 49);
            this.buttonSales.TabIndex = 16;
            this.buttonSales.Text = "Продажи";
            this.buttonSales.UseVisualStyleBackColor = true;
            this.buttonSales.Click += new System.EventHandler(this.buttonSales_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 391);
            this.Controls.Add(this.buttonSales);
            this.Controls.Add(this.buttonRates);
            this.Controls.Add(this.buttonConnectClient);
            this.Controls.Add(this.buttonConnectedClients);
            this.Controls.Add(this.buttonClients);
            this.Controls.Add(this.buttonAddOrDelOrder);
            this.Controls.Add(this.buttonInventory);
            this.Controls.Add(this.buttonWorkers);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonWorkers;
        private System.Windows.Forms.Button buttonInventory;
        private System.Windows.Forms.Button buttonAddOrDelOrder;
        private System.Windows.Forms.Button buttonClients;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonConnectedClients;
        private System.Windows.Forms.Button buttonConnectClient;
        private System.Windows.Forms.Button buttonRates;
        private System.Windows.Forms.Button buttonSales;
    }
}

