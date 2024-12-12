namespace dictionaryprj
{
    partial class Form2
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
            this.listBoxFAV = new System.Windows.Forms.ListBox();
            this.DeletefromFaV = new System.Windows.Forms.Button();
            this.meaning = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.phienam = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxFAV
            // 
            this.listBoxFAV.AllowDrop = true;
            this.listBoxFAV.FormattingEnabled = true;
            this.listBoxFAV.ItemHeight = 20;
            this.listBoxFAV.Location = new System.Drawing.Point(42, 84);
            this.listBoxFAV.Name = "listBoxFAV";
            this.listBoxFAV.Size = new System.Drawing.Size(260, 324);
            this.listBoxFAV.TabIndex = 0;
            this.listBoxFAV.SelectedValueChanged += new System.EventHandler(this.listBoxFAV_SelectedValueChanged);
            // 
            // DeletefromFaV
            // 
            this.DeletefromFaV.Location = new System.Drawing.Point(486, 260);
            this.DeletefromFaV.Name = "DeletefromFaV";
            this.DeletefromFaV.Size = new System.Drawing.Size(189, 43);
            this.DeletefromFaV.TabIndex = 1;
            this.DeletefromFaV.Text = "Xóa khỏi Favorite";
            this.DeletefromFaV.UseVisualStyleBackColor = true;
            this.DeletefromFaV.Click += new System.EventHandler(this.DeletefromFaV_Click);
            // 
            // meaning
            // 
            this.meaning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.meaning.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meaning.Location = new System.Drawing.Point(436, 64);
            this.meaning.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.meaning.Multiline = true;
            this.meaning.Name = "meaning";
            this.meaning.Size = new System.Drawing.Size(284, 69);
            this.meaning.TabIndex = 3;
            this.meaning.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // type
            // 
            this.type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.type.Location = new System.Drawing.Point(436, 170);
            this.type.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.type.Multiline = true;
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(114, 28);
            this.type.TabIndex = 4;
            // 
            // phienam
            // 
            this.phienam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phienam.Location = new System.Drawing.Point(606, 172);
            this.phienam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phienam.Name = "phienam";
            this.phienam.Size = new System.Drawing.Size(114, 26);
            this.phienam.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.phienam);
            this.Controls.Add(this.type);
            this.Controls.Add(this.meaning);
            this.Controls.Add(this.DeletefromFaV);
            this.Controls.Add(this.listBoxFAV);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DeletefromFaV;
        public System.Windows.Forms.ListBox listBoxFAV;
        private System.Windows.Forms.TextBox meaning;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.TextBox phienam;
        private System.Windows.Forms.TextBox textBox1;
    }
}