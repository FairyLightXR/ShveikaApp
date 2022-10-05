namespace ShveikaApp.Views.UserCtrl
{
    partial class ProductCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductCard));
            this.ProductPic = new System.Windows.Forms.PictureBox();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ManufacturerLbl = new System.Windows.Forms.Label();
            this.CostLbl = new System.Windows.Forms.Label();
            this.IDLbl = new System.Windows.Forms.Label();
            this.DiscountLbl = new System.Windows.Forms.Label();
            this.DescrTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPic)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductPic
            // 
            this.ProductPic.Image = ((System.Drawing.Image)(resources.GetObject("ProductPic.Image")));
            this.ProductPic.Location = new System.Drawing.Point(19, 21);
            this.ProductPic.Name = "ProductPic";
            this.ProductPic.Size = new System.Drawing.Size(207, 137);
            this.ProductPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductPic.TabIndex = 0;
            this.ProductPic.TabStop = false;
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLbl.Location = new System.Drawing.Point(273, 21);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(118, 21);
            this.TitleLbl.TabIndex = 1;
            this.TitleLbl.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(273, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Производитель:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(273, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Цена:";
            // 
            // ManufacturerLbl
            // 
            this.ManufacturerLbl.AutoSize = true;
            this.ManufacturerLbl.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManufacturerLbl.Location = new System.Drawing.Point(423, 114);
            this.ManufacturerLbl.Name = "ManufacturerLbl";
            this.ManufacturerLbl.Size = new System.Drawing.Size(49, 20);
            this.ManufacturerLbl.TabIndex = 1;
            this.ManufacturerLbl.Text = "label1";
            // 
            // CostLbl
            // 
            this.CostLbl.AutoSize = true;
            this.CostLbl.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostLbl.Location = new System.Drawing.Point(338, 150);
            this.CostLbl.Name = "CostLbl";
            this.CostLbl.Size = new System.Drawing.Size(49, 20);
            this.CostLbl.TabIndex = 1;
            this.CostLbl.Text = "label1";
            // 
            // IDLbl
            // 
            this.IDLbl.AutoSize = true;
            this.IDLbl.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDLbl.Location = new System.Drawing.Point(805, 138);
            this.IDLbl.Name = "IDLbl";
            this.IDLbl.Size = new System.Drawing.Size(28, 20);
            this.IDLbl.TabIndex = 1;
            this.IDLbl.Text = "ID";
            this.IDLbl.Visible = false;
            // 
            // DiscountLbl
            // 
            this.DiscountLbl.AutoSize = true;
            this.DiscountLbl.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountLbl.Location = new System.Drawing.Point(805, 67);
            this.DiscountLbl.Name = "DiscountLbl";
            this.DiscountLbl.Size = new System.Drawing.Size(21, 20);
            this.DiscountLbl.TabIndex = 1;
            this.DiscountLbl.Text = "%";
            // 
            // DescrTxt
            // 
            this.DescrTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescrTxt.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescrTxt.Location = new System.Drawing.Point(276, 48);
            this.DescrTxt.Multiline = true;
            this.DescrTxt.Name = "DescrTxt";
            this.DescrTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescrTxt.Size = new System.Drawing.Size(326, 51);
            this.DescrTxt.TabIndex = 2;
            // 
            // ProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.DescrTxt);
            this.Controls.Add(this.CostLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DiscountLbl);
            this.Controls.Add(this.IDLbl);
            this.Controls.Add(this.ManufacturerLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.ProductPic);
            this.Name = "ProductCard";
            this.Size = new System.Drawing.Size(1004, 183);
            ((System.ComponentModel.ISupportInitialize)(this.ProductPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ProductPic;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ManufacturerLbl;
        private System.Windows.Forms.Label CostLbl;
        public System.Windows.Forms.Label IDLbl;
        private System.Windows.Forms.Label DiscountLbl;
        private System.Windows.Forms.TextBox DescrTxt;
    }
}
