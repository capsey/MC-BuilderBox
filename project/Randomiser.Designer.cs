namespace MC_BuilderBox
{
    partial class Randomiser
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
            this.components = new System.ComponentModel.Container();
            this.startButton = new System.Windows.Forms.CheckBox();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.interval = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hotbar7 = new System.Windows.Forms.CheckBox();
            this.hotbar9 = new System.Windows.Forms.CheckBox();
            this.hotbar1 = new System.Windows.Forms.CheckBox();
            this.hotbar8 = new System.Windows.Forms.CheckBox();
            this.hotbar2 = new System.Windows.Forms.CheckBox();
            this.hotbar3 = new System.Windows.Forms.CheckBox();
            this.hotbar6 = new System.Windows.Forms.CheckBox();
            this.hotbar4 = new System.Windows.Forms.CheckBox();
            this.hotbar5 = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.mainBox = new System.Windows.Forms.ComboBox();
            this.main = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.interval)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(410, 181);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(120, 60);
            this.startButton.TabIndex = 27;
            this.startButton.Text = "Start";
            this.startButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.CheckedChanged += new System.EventHandler(this.startButton_CheckedChanged);
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(13, 109);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(161, 17);
            this.intervalLabel.TabIndex = 26;
            this.intervalLabel.Text = "Randomise Interval (ms)";
            // 
            // interval
            // 
            this.interval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.interval.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.interval.Location = new System.Drawing.Point(16, 132);
            this.interval.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.interval.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.interval.Name = "interval";
            this.interval.Size = new System.Drawing.Size(90, 24);
            this.interval.TabIndex = 25;
            this.interval.ThousandsSeparator = true;
            this.interval.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.interval.ValueChanged += new System.EventHandler(this.interval_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hotbar7);
            this.groupBox1.Controls.Add(this.hotbar9);
            this.groupBox1.Controls.Add(this.hotbar1);
            this.groupBox1.Controls.Add(this.hotbar8);
            this.groupBox1.Controls.Add(this.hotbar2);
            this.groupBox1.Controls.Add(this.hotbar3);
            this.groupBox1.Controls.Add(this.hotbar6);
            this.groupBox1.Controls.Add(this.hotbar4);
            this.groupBox1.Controls.Add(this.hotbar5);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 83);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected hotbar items";
            // 
            // hotbar7
            // 
            this.hotbar7.Appearance = System.Windows.Forms.Appearance.Button;
            this.hotbar7.Cursor = System.Windows.Forms.Cursors.Default;
            this.hotbar7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotbar7.Location = new System.Drawing.Point(345, 23);
            this.hotbar7.Name = "hotbar7";
            this.hotbar7.Size = new System.Drawing.Size(50, 50);
            this.hotbar7.TabIndex = 16;
            this.hotbar7.Text = "7";
            this.hotbar7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hotbar7.UseVisualStyleBackColor = true;
            // 
            // hotbar9
            // 
            this.hotbar9.Appearance = System.Windows.Forms.Appearance.Button;
            this.hotbar9.Cursor = System.Windows.Forms.Cursors.Default;
            this.hotbar9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotbar9.Location = new System.Drawing.Point(457, 23);
            this.hotbar9.Name = "hotbar9";
            this.hotbar9.Size = new System.Drawing.Size(50, 50);
            this.hotbar9.TabIndex = 18;
            this.hotbar9.Text = "9";
            this.hotbar9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hotbar9.UseVisualStyleBackColor = true;
            // 
            // hotbar1
            // 
            this.hotbar1.Appearance = System.Windows.Forms.Appearance.Button;
            this.hotbar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.hotbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotbar1.Location = new System.Drawing.Point(9, 23);
            this.hotbar1.Name = "hotbar1";
            this.hotbar1.Size = new System.Drawing.Size(50, 50);
            this.hotbar1.TabIndex = 10;
            this.hotbar1.Text = "1";
            this.hotbar1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hotbar1.UseVisualStyleBackColor = true;
            // 
            // hotbar8
            // 
            this.hotbar8.Appearance = System.Windows.Forms.Appearance.Button;
            this.hotbar8.Cursor = System.Windows.Forms.Cursors.Default;
            this.hotbar8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotbar8.Location = new System.Drawing.Point(401, 23);
            this.hotbar8.Name = "hotbar8";
            this.hotbar8.Size = new System.Drawing.Size(50, 50);
            this.hotbar8.TabIndex = 17;
            this.hotbar8.Text = "8";
            this.hotbar8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hotbar8.UseVisualStyleBackColor = true;
            // 
            // hotbar2
            // 
            this.hotbar2.Appearance = System.Windows.Forms.Appearance.Button;
            this.hotbar2.Cursor = System.Windows.Forms.Cursors.Default;
            this.hotbar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotbar2.Location = new System.Drawing.Point(65, 23);
            this.hotbar2.Name = "hotbar2";
            this.hotbar2.Size = new System.Drawing.Size(50, 50);
            this.hotbar2.TabIndex = 11;
            this.hotbar2.Text = "2";
            this.hotbar2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hotbar2.UseVisualStyleBackColor = true;
            // 
            // hotbar3
            // 
            this.hotbar3.Appearance = System.Windows.Forms.Appearance.Button;
            this.hotbar3.Cursor = System.Windows.Forms.Cursors.Default;
            this.hotbar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotbar3.Location = new System.Drawing.Point(121, 23);
            this.hotbar3.Name = "hotbar3";
            this.hotbar3.Size = new System.Drawing.Size(50, 50);
            this.hotbar3.TabIndex = 12;
            this.hotbar3.Text = "3";
            this.hotbar3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hotbar3.UseVisualStyleBackColor = true;
            // 
            // hotbar6
            // 
            this.hotbar6.Appearance = System.Windows.Forms.Appearance.Button;
            this.hotbar6.Cursor = System.Windows.Forms.Cursors.Default;
            this.hotbar6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotbar6.Location = new System.Drawing.Point(289, 23);
            this.hotbar6.Name = "hotbar6";
            this.hotbar6.Size = new System.Drawing.Size(50, 50);
            this.hotbar6.TabIndex = 15;
            this.hotbar6.Text = "6";
            this.hotbar6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hotbar6.UseVisualStyleBackColor = true;
            // 
            // hotbar4
            // 
            this.hotbar4.Appearance = System.Windows.Forms.Appearance.Button;
            this.hotbar4.Cursor = System.Windows.Forms.Cursors.Default;
            this.hotbar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotbar4.Location = new System.Drawing.Point(177, 23);
            this.hotbar4.Name = "hotbar4";
            this.hotbar4.Size = new System.Drawing.Size(50, 50);
            this.hotbar4.TabIndex = 13;
            this.hotbar4.Text = "4";
            this.hotbar4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hotbar4.UseVisualStyleBackColor = true;
            // 
            // hotbar5
            // 
            this.hotbar5.Appearance = System.Windows.Forms.Appearance.Button;
            this.hotbar5.Cursor = System.Windows.Forms.Cursors.Default;
            this.hotbar5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotbar5.Location = new System.Drawing.Point(233, 23);
            this.hotbar5.Name = "hotbar5";
            this.hotbar5.Size = new System.Drawing.Size(50, 50);
            this.hotbar5.TabIndex = 14;
            this.hotbar5.Text = "5";
            this.hotbar5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hotbar5.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // mainBox
            // 
            this.mainBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mainBox.FormattingEnabled = true;
            this.mainBox.Items.AddRange(new object[] {
            "None",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.mainBox.Location = new System.Drawing.Point(16, 188);
            this.mainBox.Name = "mainBox";
            this.mainBox.Size = new System.Drawing.Size(121, 24);
            this.mainBox.TabIndex = 28;
            // 
            // main
            // 
            this.main.AutoSize = true;
            this.main.Location = new System.Drawing.Point(13, 165);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(115, 17);
            this.main.TabIndex = 29;
            this.main.Text = "Main Hotbar Item";
            // 
            // Randomiser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 253);
            this.Controls.Add(this.main);
            this.Controls.Add(this.mainBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.intervalLabel);
            this.Controls.Add(this.interval);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Randomiser";
            this.Text = "Hotbar randomiser";
            ((System.ComponentModel.ISupportInitialize)(this.interval)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox startButton;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.NumericUpDown interval;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox hotbar7;
        private System.Windows.Forms.CheckBox hotbar9;
        private System.Windows.Forms.CheckBox hotbar1;
        private System.Windows.Forms.CheckBox hotbar8;
        private System.Windows.Forms.CheckBox hotbar2;
        private System.Windows.Forms.CheckBox hotbar3;
        private System.Windows.Forms.CheckBox hotbar6;
        private System.Windows.Forms.CheckBox hotbar4;
        private System.Windows.Forms.CheckBox hotbar5;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ComboBox mainBox;
        private System.Windows.Forms.Label main;
    }
}

