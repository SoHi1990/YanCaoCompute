namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.rad_caculate1 = new System.Windows.Forms.RadioButton();
            this.rad_caculate2 = new System.Windows.Forms.RadioButton();
            this.txt_source = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.rad_caculate3 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_numInterval = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "导出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rad_caculate1
            // 
            this.rad_caculate1.AutoSize = true;
            this.rad_caculate1.Checked = true;
            this.rad_caculate1.Location = new System.Drawing.Point(121, 41);
            this.rad_caculate1.Name = "rad_caculate1";
            this.rad_caculate1.Size = new System.Drawing.Size(58, 19);
            this.rad_caculate1.TabIndex = 1;
            this.rad_caculate1.TabStop = true;
            this.rad_caculate1.Text = "汇总";
            this.rad_caculate1.UseVisualStyleBackColor = true;
            // 
            // rad_caculate2
            // 
            this.rad_caculate2.AutoSize = true;
            this.rad_caculate2.Location = new System.Drawing.Point(121, 83);
            this.rad_caculate2.Name = "rad_caculate2";
            this.rad_caculate2.Size = new System.Drawing.Size(58, 19);
            this.rad_caculate2.TabIndex = 2;
            this.rad_caculate2.TabStop = true;
            this.rad_caculate2.Text = "汇总";
            this.rad_caculate2.UseVisualStyleBackColor = true;
            // 
            // txt_source
            // 
            this.txt_source.Location = new System.Drawing.Point(182, 169);
            this.txt_source.Name = "txt_source";
            this.txt_source.Size = new System.Drawing.Size(236, 25);
            this.txt_source.TabIndex = 3;
            this.txt_source.Text = "C:/123.xls";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "数据源文件路径：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "目标文件路径：";
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(184, 212);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(236, 25);
            this.txt_result.TabIndex = 6;
            this.txt_result.Text = "D:/123.xls";
            // 
            // rad_caculate3
            // 
            this.rad_caculate3.AutoSize = true;
            this.rad_caculate3.Location = new System.Drawing.Point(260, 83);
            this.rad_caculate3.Name = "rad_caculate3";
            this.rad_caculate3.Size = new System.Drawing.Size(58, 19);
            this.rad_caculate3.TabIndex = 3;
            this.rad_caculate3.TabStop = true;
            this.rad_caculate3.Text = "明细";
            this.rad_caculate3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "计数：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "求商：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "计算范围：";
            // 
            // txt_numInterval
            // 
            this.txt_numInterval.Location = new System.Drawing.Point(182, 129);
            this.txt_numInterval.Name = "txt_numInterval";
            this.txt_numInterval.Size = new System.Drawing.Size(236, 25);
            this.txt_numInterval.TabIndex = 3;
            this.txt_numInterval.Text = "50;100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 383);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_numInterval);
            this.Controls.Add(this.txt_source);
            this.Controls.Add(this.rad_caculate2);
            this.Controls.Add(this.rad_caculate3);
            this.Controls.Add(this.rad_caculate1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rad_caculate1;
        private System.Windows.Forms.RadioButton rad_caculate2;
        private System.Windows.Forms.TextBox txt_source;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.RadioButton rad_caculate3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_numInterval;
    }
}

