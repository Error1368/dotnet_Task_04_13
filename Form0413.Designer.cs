
namespace T0413
{
    partial class Form0413
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxNameFirst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownCountFirst = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDistanceFirst = new System.Windows.Forms.NumericUpDown();
            this.buttonCreateFirst = new System.Windows.Forms.Button();
            this.labelInfoFirst = new System.Windows.Forms.Label();
            this.labelInfoSecond = new System.Windows.Forms.Label();
            this.buttonCreateSecond = new System.Windows.Forms.Button();
            this.numericUpDownDistanceSecond = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCountSecond = new System.Windows.Forms.NumericUpDown();
            this.textBoxNameSecond = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownSpeedSecond = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDistanceFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDistanceSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeedSecond)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(528, 243);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.labelInfoFirst);
            this.groupBox1.Controls.Add(this.buttonCreateFirst);
            this.groupBox1.Controls.Add(this.numericUpDownDistanceFirst);
            this.groupBox1.Controls.Add(this.numericUpDownCountFirst);
            this.groupBox1.Controls.Add(this.textBoxNameFirst);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Web Class first Level";
            // 
            // textBoxNameFirst
            // 
            this.textBoxNameFirst.Location = new System.Drawing.Point(116, 16);
            this.textBoxNameFirst.MaxLength = 20;
            this.textBoxNameFirst.Name = "textBoxNameFirst";
            this.textBoxNameFirst.Size = new System.Drawing.Size(125, 20);
            this.textBoxNameFirst.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:\r\n\r\nStansions Count:\r\n\r\nAverage Distance:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDownSpeedSecond);
            this.groupBox2.Controls.Add(this.labelInfoSecond);
            this.groupBox2.Controls.Add(this.buttonCreateSecond);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numericUpDownDistanceSecond);
            this.groupBox2.Controls.Add(this.textBoxNameSecond);
            this.groupBox2.Controls.Add(this.numericUpDownCountSecond);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 243);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Web Class second Level";
            // 
            // numericUpDownCountFirst
            // 
            this.numericUpDownCountFirst.Location = new System.Drawing.Point(116, 40);
            this.numericUpDownCountFirst.Name = "numericUpDownCountFirst";
            this.numericUpDownCountFirst.Size = new System.Drawing.Size(125, 20);
            this.numericUpDownCountFirst.TabIndex = 2;
            // 
            // numericUpDownDistanceFirst
            // 
            this.numericUpDownDistanceFirst.Location = new System.Drawing.Point(116, 66);
            this.numericUpDownDistanceFirst.Name = "numericUpDownDistanceFirst";
            this.numericUpDownDistanceFirst.Size = new System.Drawing.Size(125, 20);
            this.numericUpDownDistanceFirst.TabIndex = 3;
            // 
            // buttonCreateFirst
            // 
            this.buttonCreateFirst.Location = new System.Drawing.Point(15, 118);
            this.buttonCreateFirst.Name = "buttonCreateFirst";
            this.buttonCreateFirst.Size = new System.Drawing.Size(226, 25);
            this.buttonCreateFirst.TabIndex = 4;
            this.buttonCreateFirst.Text = "Create";
            this.buttonCreateFirst.UseVisualStyleBackColor = true;
            this.buttonCreateFirst.Click += new System.EventHandler(this.buttonCreateFirst_Click);
            // 
            // labelInfoFirst
            // 
            this.labelInfoFirst.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelInfoFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelInfoFirst.Location = new System.Drawing.Point(15, 150);
            this.labelInfoFirst.Name = "labelInfoFirst";
            this.labelInfoFirst.Size = new System.Drawing.Size(226, 83);
            this.labelInfoFirst.TabIndex = 5;
            this.labelInfoFirst.Text = "Params:";
            // 
            // labelInfoSecond
            // 
            this.labelInfoSecond.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelInfoSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelInfoSecond.Location = new System.Drawing.Point(9, 150);
            this.labelInfoSecond.Name = "labelInfoSecond";
            this.labelInfoSecond.Size = new System.Drawing.Size(234, 83);
            this.labelInfoSecond.TabIndex = 11;
            this.labelInfoSecond.Text = "Params:";
            // 
            // buttonCreateSecond
            // 
            this.buttonCreateSecond.Location = new System.Drawing.Point(9, 118);
            this.buttonCreateSecond.Name = "buttonCreateSecond";
            this.buttonCreateSecond.Size = new System.Drawing.Size(234, 25);
            this.buttonCreateSecond.TabIndex = 10;
            this.buttonCreateSecond.Text = "Create";
            this.buttonCreateSecond.UseVisualStyleBackColor = true;
            this.buttonCreateSecond.Click += new System.EventHandler(this.buttonCreateSecond_Click);
            // 
            // numericUpDownDistanceSecond
            // 
            this.numericUpDownDistanceSecond.Location = new System.Drawing.Point(118, 66);
            this.numericUpDownDistanceSecond.Name = "numericUpDownDistanceSecond";
            this.numericUpDownDistanceSecond.Size = new System.Drawing.Size(125, 20);
            this.numericUpDownDistanceSecond.TabIndex = 9;
            // 
            // numericUpDownCountSecond
            // 
            this.numericUpDownCountSecond.Location = new System.Drawing.Point(118, 40);
            this.numericUpDownCountSecond.Name = "numericUpDownCountSecond";
            this.numericUpDownCountSecond.Size = new System.Drawing.Size(125, 20);
            this.numericUpDownCountSecond.TabIndex = 8;
            // 
            // textBoxNameSecond
            // 
            this.textBoxNameSecond.Location = new System.Drawing.Point(118, 16);
            this.textBoxNameSecond.MaxLength = 20;
            this.textBoxNameSecond.Name = "textBoxNameSecond";
            this.textBoxNameSecond.Size = new System.Drawing.Size(125, 20);
            this.textBoxNameSecond.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 91);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name:\r\n\r\nStansions Count:\r\n\r\nAverage Distance:\r\n\r\nAverage data speed:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDownSpeedSecond
            // 
            this.numericUpDownSpeedSecond.Location = new System.Drawing.Point(118, 92);
            this.numericUpDownSpeedSecond.Name = "numericUpDownSpeedSecond";
            this.numericUpDownSpeedSecond.Size = new System.Drawing.Size(125, 20);
            this.numericUpDownSpeedSecond.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 243);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "T 04 13";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDistanceFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDistanceSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeedSecond)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxNameFirst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelInfoFirst;
        private System.Windows.Forms.Button buttonCreateFirst;
        private System.Windows.Forms.NumericUpDown numericUpDownDistanceFirst;
        private System.Windows.Forms.NumericUpDown numericUpDownCountFirst;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeedSecond;
        private System.Windows.Forms.Label labelInfoSecond;
        private System.Windows.Forms.Button buttonCreateSecond;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownDistanceSecond;
        private System.Windows.Forms.TextBox textBoxNameSecond;
        private System.Windows.Forms.NumericUpDown numericUpDownCountSecond;
    }
}

