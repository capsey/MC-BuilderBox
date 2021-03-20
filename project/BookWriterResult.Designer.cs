namespace MC_BuilderBox
{
    partial class BookWriterResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookWriterResult));
            this.prevPage = new System.Windows.Forms.Button();
            this.nextPage = new System.Windows.Forms.Button();
            this.counter = new System.Windows.Forms.Label();
            this.pageText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // prevPage
            // 
            this.prevPage.Location = new System.Drawing.Point(13, 13);
            this.prevPage.Name = "prevPage";
            this.prevPage.Size = new System.Drawing.Size(60, 50);
            this.prevPage.TabIndex = 0;
            this.prevPage.Text = "<<";
            this.prevPage.UseVisualStyleBackColor = true;
            this.prevPage.Click += new System.EventHandler(this.prevPage_Click);
            // 
            // nextPage
            // 
            this.nextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextPage.Location = new System.Drawing.Point(310, 13);
            this.nextPage.Name = "nextPage";
            this.nextPage.Size = new System.Drawing.Size(60, 50);
            this.nextPage.TabIndex = 1;
            this.nextPage.Text = ">>";
            this.nextPage.UseVisualStyleBackColor = true;
            this.nextPage.Click += new System.EventHandler(this.nextPage_Click);
            // 
            // counter
            // 
            this.counter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.counter.Location = new System.Drawing.Point(79, 13);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(225, 50);
            this.counter.TabIndex = 2;
            this.counter.Text = "100 / 100";
            this.counter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pageText
            // 
            this.pageText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pageText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pageText.Location = new System.Drawing.Point(13, 70);
            this.pageText.Name = "pageText";
            this.pageText.ReadOnly = true;
            this.pageText.Size = new System.Drawing.Size(357, 341);
            this.pageText.TabIndex = 3;
            this.pageText.Text = resources.GetString("pageText.Text");
            // 
            // BookWriterResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 423);
            this.Controls.Add(this.pageText);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.nextPage);
            this.Controls.Add(this.prevPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BookWriterResult";
            this.Text = "BookWriterResult";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button prevPage;
        private System.Windows.Forms.Button nextPage;
        private System.Windows.Forms.Label counter;
        private System.Windows.Forms.RichTextBox pageText;
    }
}