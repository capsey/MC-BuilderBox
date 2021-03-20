namespace MC_BuilderBox
{
    partial class BookWriter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookWriter));
            this.label1 = new System.Windows.Forms.Label();
            this.bookName = new System.Windows.Forms.TextBox();
            this.bookText = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book name:";
            // 
            // bookName
            // 
            this.bookName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookName.Location = new System.Drawing.Point(102, 9);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(241, 22);
            this.bookName.TabIndex = 1;
            this.bookName.Text = "Lorem ipsum";
            // 
            // bookText
            // 
            this.bookText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bookText.Location = new System.Drawing.Point(12, 62);
            this.bookText.Name = "bookText";
            this.bookText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.bookText.Size = new System.Drawing.Size(331, 302);
            this.bookText.TabIndex = 2;
            this.bookText.Text = resources.GetString("bookText.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Text:";
            // 
            // convert
            // 
            this.convert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.convert.Location = new System.Drawing.Point(353, 309);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(135, 55);
            this.convert.TabIndex = 4;
            this.convert.Text = "Convert ";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // BookWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 376);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bookText);
            this.Controls.Add(this.bookName);
            this.Controls.Add(this.label1);
            this.Name = "BookWriter";
            this.Text = "Book Writer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookName;
        private System.Windows.Forms.RichTextBox bookText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button convert;
    }
}