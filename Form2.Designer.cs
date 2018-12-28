namespace _3bGenetic
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
            this.label12 = new System.Windows.Forms.Label();
            this.nudParentChrom = new System.Windows.Forms.NumericUpDown();
            this.nudMutCnt = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudChrom = new System.Windows.Forms.NumericUpDown();
            this.nudMutation = new System.Windows.Forms.NumericUpDown();
            this.nudSteps = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudParentChrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMutCnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMutation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSteps)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 13);
            this.label12.TabIndex = 74;
            this.label12.Text = "Количество хромосом:";
            // 
            // nudParentChrom
            // 
            this.nudParentChrom.Location = new System.Drawing.Point(15, 255);
            this.nudParentChrom.Name = "nudParentChrom";
            this.nudParentChrom.Size = new System.Drawing.Size(120, 20);
            this.nudParentChrom.TabIndex = 73;
            this.nudParentChrom.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nudMutCnt
            // 
            this.nudMutCnt.Location = new System.Drawing.Point(15, 136);
            this.nudMutCnt.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMutCnt.Name = "nudMutCnt";
            this.nudMutCnt.Size = new System.Drawing.Size(120, 20);
            this.nudMutCnt.TabIndex = 72;
            this.nudMutCnt.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 13);
            this.label11.TabIndex = 71;
            this.label11.Text = "Количество мутирующих хромосом:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 13);
            this.label10.TabIndex = 70;
            this.label10.Text = "в каждом поколении:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 13);
            this.label8.TabIndex = 69;
            this.label8.Text = "Кол-во отобранных хромосом";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 68;
            this.label7.Text = "Вероятность мутации:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 13);
            this.label6.TabIndex = 67;
            this.label6.Text = "Максимальное количество шагов:";
            // 
            // nudChrom
            // 
            this.nudChrom.Location = new System.Drawing.Point(15, 190);
            this.nudChrom.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudChrom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudChrom.Name = "nudChrom";
            this.nudChrom.Size = new System.Drawing.Size(120, 20);
            this.nudChrom.TabIndex = 66;
            this.nudChrom.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // nudMutation
            // 
            this.nudMutation.Location = new System.Drawing.Point(15, 84);
            this.nudMutation.Name = "nudMutation";
            this.nudMutation.Size = new System.Drawing.Size(120, 20);
            this.nudMutation.TabIndex = 65;
            this.nudMutation.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nudSteps
            // 
            this.nudSteps.Location = new System.Drawing.Point(15, 36);
            this.nudSteps.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudSteps.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudSteps.Name = "nudSteps";
            this.nudSteps.Size = new System.Drawing.Size(117, 20);
            this.nudSteps.TabIndex = 64;
            this.nudSteps.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 295);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.nudParentChrom);
            this.Controls.Add(this.nudMutCnt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudChrom);
            this.Controls.Add(this.nudMutation);
            this.Controls.Add(this.nudSteps);
            this.Name = "Form2";
            this.Text = "Настройка ген.алгоритма";
            ((System.ComponentModel.ISupportInitialize)(this.nudParentChrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMutCnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMutation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSteps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudParentChrom;
        private System.Windows.Forms.NumericUpDown nudMutCnt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudChrom;
        private System.Windows.Forms.NumericUpDown nudMutation;
        private System.Windows.Forms.NumericUpDown nudSteps;
    }
}