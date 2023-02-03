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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 450);
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
    }
}