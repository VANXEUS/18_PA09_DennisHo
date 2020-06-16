namespace _18_PA09_DennisHo
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
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.lbl_SelectCurrency = new System.Windows.Forms.Label();
            this.rdb_JPY = new System.Windows.Forms.RadioButton();
            this.rdb_USD = new System.Windows.Forms.RadioButton();
            this.lbl_Value = new System.Windows.Forms.Label();
            this.txt_ConvertedAmount = new System.Windows.Forms.TextBox();
            this.btn_Convert = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.rdb_MalaysianRinggit = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(167, 48);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(218, 20);
            this.txt_Amount.TabIndex = 0;
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Amount.Location = new System.Drawing.Point(42, 50);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(59, 18);
            this.lbl_Amount.TabIndex = 1;
            this.lbl_Amount.Text = "Amount";
            this.lbl_Amount.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_SelectCurrency
            // 
            this.lbl_SelectCurrency.AutoSize = true;
            this.lbl_SelectCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectCurrency.Location = new System.Drawing.Point(42, 93);
            this.lbl_SelectCurrency.Name = "lbl_SelectCurrency";
            this.lbl_SelectCurrency.Size = new System.Drawing.Size(113, 18);
            this.lbl_SelectCurrency.TabIndex = 2;
            this.lbl_SelectCurrency.Text = "Select Currency";
            // 
            // rdb_JPY
            // 
            this.rdb_JPY.AutoSize = true;
            this.rdb_JPY.Location = new System.Drawing.Point(212, 95);
            this.rdb_JPY.Name = "rdb_JPY";
            this.rdb_JPY.Size = new System.Drawing.Size(93, 17);
            this.rdb_JPY.TabIndex = 3;
            this.rdb_JPY.TabStop = true;
            this.rdb_JPY.Text = "Japanese Yen";
            this.rdb_JPY.UseVisualStyleBackColor = true;
            // 
            // rdb_USD
            // 
            this.rdb_USD.AutoSize = true;
            this.rdb_USD.Location = new System.Drawing.Point(212, 128);
            this.rdb_USD.Name = "rdb_USD";
            this.rdb_USD.Size = new System.Drawing.Size(75, 17);
            this.rdb_USD.TabIndex = 4;
            this.rdb_USD.TabStop = true;
            this.rdb_USD.Text = "US Dollars";
            this.rdb_USD.UseVisualStyleBackColor = true;
            // 
            // lbl_Value
            // 
            this.lbl_Value.AutoSize = true;
            this.lbl_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Value.Location = new System.Drawing.Point(42, 181);
            this.lbl_Value.Name = "lbl_Value";
            this.lbl_Value.Size = new System.Drawing.Size(44, 18);
            this.lbl_Value.TabIndex = 5;
            this.lbl_Value.Text = "Value";
            // 
            // txt_ConvertedAmount
            // 
            this.txt_ConvertedAmount.Location = new System.Drawing.Point(167, 182);
            this.txt_ConvertedAmount.Name = "txt_ConvertedAmount";
            this.txt_ConvertedAmount.ReadOnly = true;
            this.txt_ConvertedAmount.Size = new System.Drawing.Size(218, 20);
            this.txt_ConvertedAmount.TabIndex = 6;
            this.txt_ConvertedAmount.TextChanged += new System.EventHandler(this.txt_ConvertedAmount_TextChanged);
            // 
            // btn_Convert
            // 
            this.btn_Convert.Location = new System.Drawing.Point(413, 109);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(75, 23);
            this.btn_Convert.TabIndex = 7;
            this.btn_Convert.Text = "Convert";
            this.btn_Convert.UseVisualStyleBackColor = true;
            this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(413, 138);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 8;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // rdb_MalaysianRinggit
            // 
            this.rdb_MalaysianRinggit.AutoSize = true;
            this.rdb_MalaysianRinggit.Location = new System.Drawing.Point(212, 159);
            this.rdb_MalaysianRinggit.Name = "rdb_MalaysianRinggit";
            this.rdb_MalaysianRinggit.Size = new System.Drawing.Size(108, 17);
            this.rdb_MalaysianRinggit.TabIndex = 4;
            this.rdb_MalaysianRinggit.TabStop = true;
            this.rdb_MalaysianRinggit.Text = "Malaysian Ringgit";
            this.rdb_MalaysianRinggit.UseVisualStyleBackColor = true;
            this.rdb_MalaysianRinggit.CheckedChanged += new System.EventHandler(this.rdb_Ringgit_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 249);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Convert);
            this.Controls.Add(this.txt_ConvertedAmount);
            this.Controls.Add(this.lbl_Value);
            this.Controls.Add(this.rdb_MalaysianRinggit);
            this.Controls.Add(this.rdb_USD);
            this.Controls.Add(this.rdb_JPY);
            this.Controls.Add(this.lbl_SelectCurrency);
            this.Controls.Add(this.lbl_Amount);
            this.Controls.Add(this.txt_Amount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.Label lbl_SelectCurrency;
        private System.Windows.Forms.RadioButton rdb_JPY;
        private System.Windows.Forms.RadioButton rdb_USD;
        private System.Windows.Forms.Label lbl_Value;
        private System.Windows.Forms.TextBox txt_ConvertedAmount;
        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.RadioButton rdb_MalaysianRinggit;
    }
}

