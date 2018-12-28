namespace _3bGeneticsAlg
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
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.UseBackTrac = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTimeEx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbExact = new System.Windows.Forms.TextBox();
            this.btnDo = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnGenSolve = new System.Windows.Forms.Button();
            this.tbTimeGen = new System.Windows.Forms.TextBox();
            this.tbGen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.CapacityBox = new System.Windows.Forms.NumericUpDown();
            this.lbFiles = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nudElem = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.nudItems = new System.Windows.Forms.NumericUpDown();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CapacityBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudElem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItems)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(425, 106);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 17);
            this.radioButton2.TabIndex = 78;
            this.radioButton2.Text = "Полный перебор";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // UseBackTrac
            // 
            this.UseBackTrac.AutoSize = true;
            this.UseBackTrac.Checked = true;
            this.UseBackTrac.Location = new System.Drawing.Point(424, 80);
            this.UseBackTrac.Margin = new System.Windows.Forms.Padding(2);
            this.UseBackTrac.Name = "UseBackTrac";
            this.UseBackTrac.Size = new System.Drawing.Size(84, 17);
            this.UseBackTrac.TabIndex = 77;
            this.UseBackTrac.TabStop = true;
            this.UseBackTrac.Text = "Бэктрекинг";
            this.UseBackTrac.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 76;
            this.label5.Text = "Время в секундах:";
            // 
            // tbTimeEx
            // 
            this.tbTimeEx.Location = new System.Drawing.Point(296, 55);
            this.tbTimeEx.Name = "tbTimeEx";
            this.tbTimeEx.ReadOnly = true;
            this.tbTimeEx.Size = new System.Drawing.Size(100, 20);
            this.tbTimeEx.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "Решение точного алгоритма:";
            // 
            // tbExact
            // 
            this.tbExact.Location = new System.Drawing.Point(25, 55);
            this.tbExact.Multiline = true;
            this.tbExact.Name = "tbExact";
            this.tbExact.ReadOnly = true;
            this.tbExact.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbExact.Size = new System.Drawing.Size(258, 128);
            this.tbExact.TabIndex = 73;
            // 
            // btnDo
            // 
            this.btnDo.Location = new System.Drawing.Point(297, 80);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(98, 67);
            this.btnDo.TabIndex = 72;
            this.btnDo.Text = "Решить точным алгоритмом";
            this.btnDo.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(294, 212);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 13);
            this.label13.TabIndex = 83;
            this.label13.Text = "Время в секундах:";
            // 
            // btnGenSolve
            // 
            this.btnGenSolve.Location = new System.Drawing.Point(295, 259);
            this.btnGenSolve.Name = "btnGenSolve";
            this.btnGenSolve.Size = new System.Drawing.Size(98, 67);
            this.btnGenSolve.TabIndex = 82;
            this.btnGenSolve.Text = "Решить генетическим алгоритмом";
            this.btnGenSolve.UseVisualStyleBackColor = true;
            // 
            // tbTimeGen
            // 
            this.tbTimeGen.Location = new System.Drawing.Point(295, 234);
            this.tbTimeGen.Name = "tbTimeGen";
            this.tbTimeGen.ReadOnly = true;
            this.tbTimeGen.Size = new System.Drawing.Size(100, 20);
            this.tbTimeGen.TabIndex = 81;
            // 
            // tbGen
            // 
            this.tbGen.Location = new System.Drawing.Point(24, 235);
            this.tbGen.Multiline = true;
            this.tbGen.Name = "tbGen";
            this.tbGen.ReadOnly = true;
            this.tbGen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbGen.Size = new System.Drawing.Size(259, 130);
            this.tbGen.TabIndex = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 13);
            this.label4.TabIndex = 79;
            this.label4.Text = "Решение генетического алгоритма:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(605, 32);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 13);
            this.label15.TabIndex = 85;
            this.label15.Text = "Размер носителя:";
            // 
            // CapacityBox
            // 
            this.CapacityBox.Location = new System.Drawing.Point(719, 32);
            this.CapacityBox.Margin = new System.Windows.Forms.Padding(2);
            this.CapacityBox.Name = "CapacityBox";
            this.CapacityBox.Size = new System.Drawing.Size(122, 20);
            this.CapacityBox.TabIndex = 84;
            this.CapacityBox.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // lbFiles
            // 
            this.lbFiles.FormattingEnabled = true;
            this.lbFiles.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.lbFiles.Location = new System.Drawing.Point(610, 88);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.Size = new System.Drawing.Size(94, 277);
            this.lbFiles.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(608, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 86;
            this.label2.Text = "Размеры файлов:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Элемент:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudElem);
            this.groupBox1.Location = new System.Drawing.Point(722, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(122, 126);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(9, 84);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(102, 30);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 49);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nudElem
            // 
            this.nudElem.Location = new System.Drawing.Point(9, 24);
            this.nudElem.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudElem.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudElem.Name = "nudElem";
            this.nudElem.Size = new System.Drawing.Size(102, 20);
            this.nudElem.TabIndex = 0;
            this.nudElem.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 11);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "N";
            // 
            // nudItems
            // 
            this.nudItems.Location = new System.Drawing.Point(33, 10);
            this.nudItems.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudItems.Name = "nudItems";
            this.nudItems.Size = new System.Drawing.Size(78, 20);
            this.nudItems.TabIndex = 32;
            this.nudItems.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(9, 34);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(102, 46);
            this.btnGenerate.TabIndex = 31;
            this.btnGenerate.Text = "Сгенерировать N размеров дискет";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.nudItems);
            this.groupBox2.Controls.Add(this.btnGenerate);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Location = new System.Drawing.Point(722, 232);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(122, 136);
            this.groupBox2.TabIndex = 89;
            this.groupBox2.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(9, 87);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 36);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 470);
            this.Controls.Add(this.lbFiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.CapacityBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnGenSolve);
            this.Controls.Add(this.tbTimeGen);
            this.Controls.Add(this.tbGen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.UseBackTrac);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTimeEx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbExact);
            this.Controls.Add(this.btnDo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CapacityBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudElem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItems)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton UseBackTrac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTimeEx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbExact;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnGenSolve;
        private System.Windows.Forms.TextBox tbTimeGen;
        private System.Windows.Forms.TextBox tbGen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown CapacityBox;
        private System.Windows.Forms.ListBox lbFiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nudElem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nudItems;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClear;
    }
}

