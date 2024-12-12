using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static dictionaryprj.Form1;

namespace dictionaryprj
{
    public partial class Form2 : Form
    {
   
        public Form2()
        {

            InitializeComponent();
        }
        public bool isDeleting = false;
        int Count = 0;
        string[] Keyss;
        private void listBoxFAV_SelectedValueChanged(object sender, EventArgs e)
        {
            
                
            if (!isDeleting)
            {
                if (listBoxFAV.SelectedItem != null)
                {
                    TuDien My_dict = new TuDien();

                    string word = listBoxFAV.SelectedItem.ToString();
                    // Lấy đối tượng WordDesc tương ứng với từ
                    WordDesc result = My_dict.GetValue(word);

                    // Hiển thị thông tin vào các TextBox
                    meaning.Text = result.nghiaTV;    // Hiển thị nghĩa tiếng Việt
                    type.Text = result.loaitu;     // Hiển thị loại từ
                    phienam.Text = result.phienam;    // Hiển thị phiên âm
                }               
            }
                    
        }

        private void DeletefromFaV_Click(object sender, EventArgs e)
        {
            isDeleting = true;

            listBoxFAV.Items.Remove(listBoxFAV.SelectedItem);
            meaning.Text = null;
            type.Text = null;
            phienam.Text = null;
            Count = 0;

            isDeleting = false;

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (Count == 0)
            {   
                Keyss = new string[listBoxFAV.Items.Count];
                listBoxFAV.Items.CopyTo(Keyss, 0);
            }
            

            listBoxFAV.Items.Clear();
            Count++;

            foreach (string str in Keyss)
            {
                if (str.StartsWith(textBox1.Text, StringComparison.CurrentCultureIgnoreCase))
                {
                    listBoxFAV.Items.Add(str);
                }
            }

        }
    }
}
