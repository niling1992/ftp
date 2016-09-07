namespace ftp
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.textBox_content = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_submit = new System.Windows.Forms.Button();
            this.button_attachment = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox_attachment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_title
            // 
            this.textBox_title.AcceptsReturn = true;
            this.textBox_title.AcceptsTab = true;
            this.textBox_title.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_title.Location = new System.Drawing.Point(93, 14);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(341, 29);
            this.textBox_title.TabIndex = 0;
            // 
            // textBox_content
            // 
            this.textBox_content.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_content.Location = new System.Drawing.Point(93, 57);
            this.textBox_content.Multiline = true;
            this.textBox_content.Name = "textBox_content";
            this.textBox_content.Size = new System.Drawing.Size(341, 139);
            this.textBox_content.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(32, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "主题";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(32, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "正文";
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(211, 232);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(87, 34);
            this.button_submit.TabIndex = 4;
            this.button_submit.Text = "提交";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_attachment
            // 
            this.button_attachment.Location = new System.Drawing.Point(12, 201);
            this.button_attachment.Name = "button_attachment";
            this.button_attachment.Size = new System.Drawing.Size(68, 26);
            this.button_attachment.TabIndex = 5;
            this.button_attachment.Text = "添加附件";
            this.button_attachment.UseVisualStyleBackColor = true;
            this.button_attachment.Click += new System.EventHandler(this.button_attachment_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox_attachment
            // 
            this.textBox_attachment.BackColor = System.Drawing.Color.White;
            this.textBox_attachment.Location = new System.Drawing.Point(93, 205);
            this.textBox_attachment.Name = "textBox_attachment";
            this.textBox_attachment.ReadOnly = true;
            this.textBox_attachment.Size = new System.Drawing.Size(340, 21);
            this.textBox_attachment.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 278);
            this.Controls.Add(this.textBox_attachment);
            this.Controls.Add(this.button_attachment);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_content);
            this.Controls.Add(this.textBox_title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.TextBox textBox_content;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.Button button_attachment;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox_attachment;
    }
}

