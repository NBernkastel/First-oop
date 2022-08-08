namespace genetical
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
            this.components = new System.ComponentModel.Container();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.numericSells = new System.Windows.Forms.NumericUpDown();
            this.start = new System.Windows.Forms.Button();
            this.numericfood = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.timercount = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericSells)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericfood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timercount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // numericSells
            // 
            this.numericSells.Location = new System.Drawing.Point(1002, 58);
            this.numericSells.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericSells.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericSells.Name = "numericSells";
            this.numericSells.Size = new System.Drawing.Size(82, 20);
            this.numericSells.TabIndex = 1;
            this.numericSells.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(1002, 12);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 2;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // numericfood
            // 
            this.numericfood.Location = new System.Drawing.Point(1002, 84);
            this.numericfood.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericfood.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericfood.Name = "numericfood";
            this.numericfood.Size = new System.Drawing.Size(82, 20);
            this.numericfood.TabIndex = 3;
            this.numericfood.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1023, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // timercount
            // 
            this.timercount.Location = new System.Drawing.Point(1002, 110);
            this.timercount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.timercount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timercount.Name = "timercount";
            this.timercount.Size = new System.Drawing.Size(82, 20);
            this.timercount.TabIndex = 5;
            this.timercount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1084, 468);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1084, 468);
            this.Controls.Add(this.timercount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericfood);
            this.Controls.Add(this.start);
            this.Controls.Add(this.numericSells);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericSells)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericfood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timercount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.NumericUpDown numericSells;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.NumericUpDown numericfood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown timercount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

