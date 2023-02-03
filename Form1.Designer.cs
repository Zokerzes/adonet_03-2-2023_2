namespace adonet_03_2_2023_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_comand = new System.Windows.Forms.TextBox();
            this.btn_fill = new System.Windows.Forms.Button();
            this.btn_Upd = new System.Windows.Forms.Button();
            this.mainGrid = new System.Windows.Forms.DataGridView();
            this.btn_allGoods = new System.Windows.Forms.Button();
            this.btn_AllSupliers = new System.Windows.Forms.Button();
            this.btn_allDelivery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_comand
            // 
            this.txt_comand.Location = new System.Drawing.Point(79, 12);
            this.txt_comand.Name = "txt_comand";
            this.txt_comand.Size = new System.Drawing.Size(613, 23);
            this.txt_comand.TabIndex = 0;
            // 
            // btn_fill
            // 
            this.btn_fill.Location = new System.Drawing.Point(79, 53);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(273, 23);
            this.btn_fill.TabIndex = 1;
            this.btn_fill.Text = "Заполнить";
            this.btn_fill.UseVisualStyleBackColor = true;
            this.btn_fill.Click += new System.EventHandler(this.btn_fill_Click);
            // 
            // btn_Upd
            // 
            this.btn_Upd.Location = new System.Drawing.Point(405, 53);
            this.btn_Upd.Name = "btn_Upd";
            this.btn_Upd.Size = new System.Drawing.Size(287, 23);
            this.btn_Upd.TabIndex = 2;
            this.btn_Upd.Text = "Обновить";
            this.btn_Upd.UseVisualStyleBackColor = true;
            this.btn_Upd.Click += new System.EventHandler(this.btn_Upd_Click);
            // 
            // mainGrid
            // 
            this.mainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainGrid.Location = new System.Drawing.Point(79, 91);
            this.mainGrid.Name = "mainGrid";
            this.mainGrid.RowTemplate.Height = 25;
            this.mainGrid.Size = new System.Drawing.Size(613, 347);
            this.mainGrid.TabIndex = 3;
            // 
            // btn_allGoods
            // 
            this.btn_allGoods.Location = new System.Drawing.Point(722, 53);
            this.btn_allGoods.Name = "btn_allGoods";
            this.btn_allGoods.Size = new System.Drawing.Size(120, 23);
            this.btn_allGoods.TabIndex = 4;
            this.btn_allGoods.Text = "все товары";
            this.btn_allGoods.UseVisualStyleBackColor = true;
            this.btn_allGoods.Click += new System.EventHandler(this.btn_allGoods_Click);
            // 
            // btn_AllSupliers
            // 
            this.btn_AllSupliers.Location = new System.Drawing.Point(722, 82);
            this.btn_AllSupliers.Name = "btn_AllSupliers";
            this.btn_AllSupliers.Size = new System.Drawing.Size(120, 23);
            this.btn_AllSupliers.TabIndex = 5;
            this.btn_AllSupliers.Text = "все поставщики";
            this.btn_AllSupliers.UseVisualStyleBackColor = true;
            this.btn_AllSupliers.Click += new System.EventHandler(this.btn_AllSupliers_Click);
            // 
            // btn_allDelivery
            // 
            this.btn_allDelivery.Location = new System.Drawing.Point(722, 111);
            this.btn_allDelivery.Name = "btn_allDelivery";
            this.btn_allDelivery.Size = new System.Drawing.Size(120, 23);
            this.btn_allDelivery.TabIndex = 6;
            this.btn_allDelivery.Text = "все поставки";
            this.btn_allDelivery.UseVisualStyleBackColor = true;
            this.btn_allDelivery.Click += new System.EventHandler(this.btn_allDelivery_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.btn_allDelivery);
            this.Controls.Add(this.btn_AllSupliers);
            this.Controls.Add(this.btn_allGoods);
            this.Controls.Add(this.mainGrid);
            this.Controls.Add(this.btn_Upd);
            this.Controls.Add(this.btn_fill);
            this.Controls.Add(this.txt_comand);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_comand;
        private Button btn_fill;
        private Button btn_Upd;
        private DataGridView mainGrid;
        private Button btn_allGoods;
        private Button btn_AllSupliers;
        private Button btn_allDelivery;
    }
}