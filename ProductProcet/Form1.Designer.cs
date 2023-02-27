namespace ProductProcet
{
    partial class Form1
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
            this.DgwProducts = new System.Windows.Forms.DataGridView();
            this.unitName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StockAmount = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.UnitPrice = new System.Windows.Forms.GroupBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TbxAmountUpdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbxNameUpdate = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgwProducts)).BeginInit();
            this.UnitPrice.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgwProducts
            // 
            this.DgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwProducts.Location = new System.Drawing.Point(161, 11);
            this.DgwProducts.Name = "DgwProducts";
            this.DgwProducts.Size = new System.Drawing.Size(518, 173);
            this.DgwProducts.TabIndex = 0;
            this.DgwProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwProducts_CellContentClick);
            // 
            // unitName
            // 
            this.unitName.AutoSize = true;
            this.unitName.Location = new System.Drawing.Point(17, 22);
            this.unitName.Name = "unitName";
            this.unitName.Size = new System.Drawing.Size(48, 13);
            this.unitName.TabIndex = 1;
            this.unitName.Text = "Ürün Adı";
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Fiyatı";
            // 
            // StockAmount
            // 
            this.StockAmount.AutoSize = true;
            this.StockAmount.Location = new System.Drawing.Point(17, 122);
            this.StockAmount.Name = "StockAmount";
            this.StockAmount.Size = new System.Drawing.Size(59, 13);
            this.StockAmount.TabIndex = 3;
            this.StockAmount.Text = "Stok Adedi";
           
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(85, 19);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(122, 20);
            this.TextBox1.TabIndex = 5;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(85, 65);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(122, 20);
            this.TextBox2.TabIndex = 6;
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(85, 119);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(122, 20);
            this.TextBox3.TabIndex = 7;
            // 
            // UnitPrice
            // 
            this.UnitPrice.Controls.Add(this.BtnAdd);
            this.UnitPrice.Controls.Add(this.unitName);
            this.UnitPrice.Controls.Add(this.TextBox3);
            this.UnitPrice.Controls.Add(this.label2);
            this.UnitPrice.Controls.Add(this.TextBox2);
            this.UnitPrice.Controls.Add(this.StockAmount);
            this.UnitPrice.Controls.Add(this.TextBox1);
            this.UnitPrice.Location = new System.Drawing.Point(36, 190);
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Size = new System.Drawing.Size(375, 219);
            this.UnitPrice.TabIndex = 8;
            this.UnitPrice.TabStop = false;
            this.UnitPrice.Text = "Ürün Ekle";
           
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(118, 157);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 26);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "Ekle";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.BtnUpdate);
            this.gbxUpdate.Controls.Add(this.label1);
            this.gbxUpdate.Controls.Add(this.TbxAmountUpdate);
            this.gbxUpdate.Controls.Add(this.label3);
            this.gbxUpdate.Controls.Add(this.TbxUnitPriceUpdate);
            this.gbxUpdate.Controls.Add(this.label4);
            this.gbxUpdate.Controls.Add(this.TbxNameUpdate);
            this.gbxUpdate.Location = new System.Drawing.Point(472, 206);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(375, 219);
            this.gbxUpdate.TabIndex = 9;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Ürün Güncelle";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(118, 157);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 26);
            this.BtnUpdate.TabIndex = 8;
            this.BtnUpdate.Text = "Güncelle";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adı";
            // 
            // TbxAmountUpdate
            // 
            this.TbxAmountUpdate.Location = new System.Drawing.Point(85, 119);
            this.TbxAmountUpdate.Name = "TbxAmountUpdate";
            this.TbxAmountUpdate.Size = new System.Drawing.Size(122, 20);
            this.TbxAmountUpdate.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Fiyatı";
            // 
            // TbxUnitPriceUpdate
            // 
            this.TbxUnitPriceUpdate.Location = new System.Drawing.Point(85, 65);
            this.TbxUnitPriceUpdate.Name = "TbxUnitPriceUpdate";
            this.TbxUnitPriceUpdate.Size = new System.Drawing.Size(122, 20);
            this.TbxUnitPriceUpdate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stok Adedi";
            // 
            // TbxNameUpdate
            // 
            this.TbxNameUpdate.Location = new System.Drawing.Point(85, 19);
            this.TbxNameUpdate.Name = "TbxNameUpdate";
            this.TbxNameUpdate.Size = new System.Drawing.Size(122, 20);
            this.TbxNameUpdate.TabIndex = 5;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(731, 31);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(102, 23);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "sil";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.UnitPrice);
            this.Controls.Add(this.DgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgwProducts)).EndInit();
            this.UnitPrice.ResumeLayout(false);
            this.UnitPrice.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgwProducts;
        private System.Windows.Forms.Label unitName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label StockAmount;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.TextBox TextBox3;
        private System.Windows.Forms.GroupBox UnitPrice;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbxAmountUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbxUnitPriceUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbxNameUpdate;
        private System.Windows.Forms.Button BtnDelete;
    }
}

