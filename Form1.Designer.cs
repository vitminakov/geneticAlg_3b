namespace _3bGenetic
{
    partial class MainForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbExact = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.UseBackTrac = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTimeEx = new System.Windows.Forms.TextBox();
            this.btnDo = new System.Windows.Forms.Button();
            this.tbGen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.CapacityBox = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudElem = new System.Windows.Forms.NumericUpDown();
            this.lbFiles = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudItems = new System.Windows.Forms.NumericUpDown();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnGenSolve = new System.Windows.Forms.Button();
            this.tbTimeGen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CapacityBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudElem)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudItems)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Решение точного алгоритма:";
            // 
            // tbExact
            // 
            this.tbExact.Location = new System.Drawing.Point(14, 32);
            this.tbExact.Multiline = true;
            this.tbExact.Name = "tbExact";
            this.tbExact.ReadOnly = true;
            this.tbExact.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbExact.Size = new System.Drawing.Size(258, 128);
            this.tbExact.TabIndex = 48;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(207, 7);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 17);
            this.radioButton2.TabIndex = 76;
            this.radioButton2.Text = "Полный перебор";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // UseBackTrac
            // 
            this.UseBackTrac.AutoSize = true;
            this.UseBackTrac.Checked = true;
            this.UseBackTrac.Location = new System.Drawing.Point(323, 8);
            this.UseBackTrac.Margin = new System.Windows.Forms.Padding(2);
            this.UseBackTrac.Name = "UseBackTrac";
            this.UseBackTrac.Size = new System.Drawing.Size(84, 17);
            this.UseBackTrac.TabIndex = 75;
            this.UseBackTrac.TabStop = true;
            this.UseBackTrac.Text = "Бэктрекинг";
            this.UseBackTrac.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "Время в секундах:";
            // 
            // tbTimeEx
            // 
            this.tbTimeEx.Location = new System.Drawing.Point(307, 67);
            this.tbTimeEx.Name = "tbTimeEx";
            this.tbTimeEx.ReadOnly = true;
            this.tbTimeEx.Size = new System.Drawing.Size(100, 20);
            this.tbTimeEx.TabIndex = 73;
            // 
            // btnDo
            // 
            this.btnDo.Location = new System.Drawing.Point(307, 93);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(100, 53);
            this.btnDo.TabIndex = 72;
            this.btnDo.Text = "Выполнить полный алгоритм";
            this.btnDo.UseVisualStyleBackColor = true;
            // 
            // tbGen
            // 
            this.tbGen.Location = new System.Drawing.Point(15, 215);
            this.tbGen.Multiline = true;
            this.tbGen.Name = "tbGen";
            this.tbGen.ReadOnly = true;
            this.tbGen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbGen.Size = new System.Drawing.Size(259, 130);
            this.tbGen.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 13);
            this.label4.TabIndex = 82;
            this.label4.Text = "Решение генетического алгоритма:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(475, 22);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 13);
            this.label15.TabIndex = 88;
            this.label15.Text = "Размер носителя:";
            // 
            // CapacityBox
            // 
            this.CapacityBox.Location = new System.Drawing.Point(589, 22);
            this.CapacityBox.Margin = new System.Windows.Forms.Padding(2);
            this.CapacityBox.Name = "CapacityBox";
            this.CapacityBox.Size = new System.Drawing.Size(122, 20);
            this.CapacityBox.TabIndex = 87;
            this.CapacityBox.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudElem);
            this.groupBox1.Location = new System.Drawing.Point(589, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(122, 126);
            this.groupBox1.TabIndex = 85;
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
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 49);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
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
            // lbFiles
            // 
            this.lbFiles.FormattingEnabled = true;
            this.lbFiles.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.lbFiles.Location = new System.Drawing.Point(478, 49);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.Size = new System.Drawing.Size(94, 277);
            this.lbFiles.TabIndex = 84;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.nudItems);
            this.groupBox2.Controls.Add(this.btnGenerate);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Location = new System.Drawing.Point(589, 211);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(122, 136);
            this.groupBox2.TabIndex = 86;
            this.groupBox2.TabStop = false;
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
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(9, 87);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 36);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 89;
            this.button1.Text = "Настройки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(306, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 13);
            this.label13.TabIndex = 92;
            this.label13.Text = "Время в секундах:";
            // 
            // btnGenSolve
            // 
            this.btnGenSolve.Location = new System.Drawing.Point(307, 245);
            this.btnGenSolve.Name = "btnGenSolve";
            this.btnGenSolve.Size = new System.Drawing.Size(98, 67);
            this.btnGenSolve.TabIndex = 91;
            this.btnGenSolve.Text = "Решить генетическим алгоритмом";
            this.btnGenSolve.UseVisualStyleBackColor = true;
            // 
            // tbTimeGen
            // 
            this.tbTimeGen.Location = new System.Drawing.Point(307, 220);
            this.tbTimeGen.Name = "tbTimeGen";
            this.tbTimeGen.ReadOnly = true;
            this.tbTimeGen.Size = new System.Drawing.Size(100, 20);
            this.tbTimeGen.TabIndex = 90;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 386);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnGenSolve);
            this.Controls.Add(this.tbTimeGen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.CapacityBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbFiles);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbGen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.UseBackTrac);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTimeEx);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbExact);
            this.Name = "MainForm";
            this.Text = "Генетический алгоритм";
            ((System.ComponentModel.ISupportInitialize)(this.CapacityBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudElem)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbExact;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton UseBackTrac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTimeEx;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.TextBox tbGen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown CapacityBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudElem;
        private System.Windows.Forms.ListBox lbFiles;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudItems;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnGenSolve;
        private System.Windows.Forms.TextBox tbTimeGen;
    }
}

