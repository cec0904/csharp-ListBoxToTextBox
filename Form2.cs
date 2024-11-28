using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ListBoxToTextBox
{
    public partial class Form2 : Form
    {
        public List<string> SelectedItems { get; private set; }

        public Form2()
        {
            InitializeComponent();
            SelectedItems = new List<string>();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // ListBox에서 선택된 항목을 리스트에 추가
            foreach (var item in listBox1.SelectedItems)
            {
                SelectedItems.Add(item.ToString());
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
