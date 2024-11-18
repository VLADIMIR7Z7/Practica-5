namespace NetWorkEquipmentForms
{
    partial class Form1
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
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.btnAddWifiRouter = new System.Windows.Forms.Button();
            this.btnAddSwitcher = new System.Windows.Forms.Button();
            this.btnShowDevices = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(11, 132);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(629, 192);
            this.txtOutput.TabIndex = 0;
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.Location = new System.Drawing.Point(11, 12);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(157, 92);
            this.btnAddEquipment.TabIndex = 1;
            this.btnAddEquipment.Text = "Добавить оборудование";
            this.btnAddEquipment.UseVisualStyleBackColor = true;
            this.btnAddEquipment.Click += new System.EventHandler(this.btnAddEquipment_Click_1);
            // 
            // btnAddWifiRouter
            // 
            this.btnAddWifiRouter.Location = new System.Drawing.Point(174, 12);
            this.btnAddWifiRouter.Name = "btnAddWifiRouter";
            this.btnAddWifiRouter.Size = new System.Drawing.Size(168, 92);
            this.btnAddWifiRouter.TabIndex = 2;
            this.btnAddWifiRouter.Text = "Добавить Wi-Fi маршрутизатор";
            this.btnAddWifiRouter.UseVisualStyleBackColor = true;
            this.btnAddWifiRouter.Click += new System.EventHandler(this.btnAddWifiRouter_Click_1);
            // 
            // btnAddSwitcher
            // 
            this.btnAddSwitcher.Location = new System.Drawing.Point(348, 12);
            this.btnAddSwitcher.Name = "btnAddSwitcher";
            this.btnAddSwitcher.Size = new System.Drawing.Size(148, 92);
            this.btnAddSwitcher.TabIndex = 3;
            this.btnAddSwitcher.Text = "Добавить свитч";
            this.btnAddSwitcher.UseVisualStyleBackColor = true;
            this.btnAddSwitcher.Click += new System.EventHandler(this.btnAddSwitcher_Click_1);
            // 
            // btnShowDevices
            // 
            this.btnShowDevices.Location = new System.Drawing.Point(502, 12);
            this.btnShowDevices.Name = "btnShowDevices";
            this.btnShowDevices.Size = new System.Drawing.Size(138, 92);
            this.btnShowDevices.TabIndex = 4;
            this.btnShowDevices.Text = "Показать устройства";
            this.btnShowDevices.UseVisualStyleBackColor = true;
            this.btnShowDevices.Click += new System.EventHandler(this.btnShowDevices_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(241, 349);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(153, 56);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShowDevices);
            this.Controls.Add(this.btnAddSwitcher);
            this.Controls.Add(this.btnAddWifiRouter);
            this.Controls.Add(this.btnAddEquipment);
            this.Controls.Add(this.txtOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.Button btnAddWifiRouter;
        private System.Windows.Forms.Button btnAddSwitcher;
        private System.Windows.Forms.Button btnShowDevices;
        private System.Windows.Forms.Button btnExit;
    }
}

