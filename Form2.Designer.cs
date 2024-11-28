using System.Windows.Forms;
using System;

namespace ListBoxToTextBox
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private ListBox listBox1;
        private Button btnConfirm;

        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "김치",
            "김밥",
            "삼겹살",
            "돈까스",
            "생선까스",
            "과일"});
            this.listBox1.Location = new System.Drawing.Point(0, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(200, 148);
            this.listBox1.TabIndex = 0;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(49, 174);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 30);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "확인";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 209);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConfirm);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "김기춘이 좋아하는 음식";
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(227, 238);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "음식 선택";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private Panel panel1;
        private GroupBox groupBox1;
    }
}
