using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace dictionaryprj
{

    public partial class Form1 : Form
    {
        List<Image> images = new List<Image>();
        
        List<string> temp = new List<string>();

        Form2 form2 = new Form2();//////////MỚI

        public Form1()
        {

            InitializeComponent();
            images.Add(Properties.Resources.textbox_user_1);
            images.Add(Properties.Resources.textbox_user_2);
            images.Add(Properties.Resources.textbox_user_3);
            images.Add(Properties.Resources.textbox_user_4);
            images.Add(Properties.Resources.textbox_user_5);
            images.Add(Properties.Resources.textbox_user_6);
            images.Add(Properties.Resources.textbox_user_7);
            images.Add(Properties.Resources.textbox_user_8);
            images.Add(Properties.Resources.textbox_user_9);
            images.Add(Properties.Resources.textbox_user_10);
            images.Add(Properties.Resources.textbox_user_11);
            images.Add(Properties.Resources.textbox_user_12);
            images.Add(Properties.Resources.textbox_user_13);
            images.Add(Properties.Resources.textbox_user_14);
            images.Add(Properties.Resources.textbox_user_15);
            images.Add(Properties.Resources.textbox_user_16);
            images.Add(Properties.Resources.textbox_user_17);
            images.Add(Properties.Resources.textbox_user_18);
            images.Add(Properties.Resources.textbox_user_19);
            images.Add(Properties.Resources.textbox_user_20);
            images.Add(Properties.Resources.textbox_user_21);
            images.Add(Properties.Resources.textbox_user_22);
            images.Add(Properties.Resources.textbox_user_23);
            images.Add(Properties.Resources.textbox_user_24);
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            test.BringToFront();
            searchbtn.Cursor = Cursors.Hand;
            ovalPictureBox1.Image = Properties.Resources.debut;
            

            try
            {


                TuDien My_dict = new TuDien();
                AutoCompleteStringCollection autoCompleteData = new AutoCompleteStringCollection();
                autoCompleteData.AddRange(My_dict.Keys.ToArray());

                inputword.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                inputword.AutoCompleteSource = AutoCompleteSource.CustomSource;
                inputword.AutoCompleteCustomSource = autoCompleteData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu từ điển: " + ex.Message);
            }
            


        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public class WordDesc
        {
            public string nghiaTV;
            public string loaitu;
            public string phienam;

            public WordDesc(string nghiaTV, string loaitu, string phienam)
            {
                this.nghiaTV = nghiaTV;
                this.loaitu = loaitu;
                this.phienam = phienam;
            }
            public override string ToString()
            {
                return $"Nghĩa Tiếng Việt: {nghiaTV}, Loại từ: {loaitu}, Phiên âm: {phienam}";
            }
        }

        public class TuDien
        {
            public List<string> Keys;
            public List<WordDesc> Values;

           
                public TuDien()
                {
                    Keys = new List<string>();
                    Values = new List<WordDesc>();

                    // Đọc nội dung từ tài nguyên (Resources)
                    string resourceContent = Properties.Resources.anhviet; // Tên của file trong Resources
                    string[] lines = resourceContent.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

                    foreach (var line in lines)
                    {
                        string[] words = line.Split(',');
                        if (words.Length >= 4)
                        {
                            Keys.Add(words[0]);
                            WordDesc word = new WordDesc(words[1], words[2], words[3]);
                            Values.Add(word);
                        }
                    }
                }
            

            public void Add(string key, WordDesc WordDesc)
            {
                Keys.Add(key);
                Values.Add(WordDesc);
            }

            public WordDesc GetValueOBJ(object key)
            {
                int index = Keys.IndexOf(key.ToString());

                return Values[index];
            }
            public WordDesc GetValue(string key)
            {
                int index = Keys.IndexOf(key);
                if (index == -1)
                {
                    throw new KeyNotFoundException($"The key '{key}' was not found in the dictionary.");
                }
                return Values[index];
            }
            public void Remove(string key)
            {
                int index = Keys.IndexOf(key);
                if (index >= 0)
                {
                    Keys.RemoveAt(index);
                    Values.RemoveAt(index);
                }
            }

            public void Swap(int j)
            {
                string temp = Keys[j];
                Keys[j] = Keys[j + 1];
                Keys[j + 1] = temp;

            }

            public void Swap2(string keya, string keyb)
            {
                int indexA = Keys.IndexOf(keya);
                int indexB = Keys.IndexOf(keyb);
                if (indexA >= 0 && indexB >= 0)
                {
                    (Keys[indexA], Keys[indexB]) = (Keys[indexB], Keys[indexA]);
                    (Values[indexA], Values[indexB]) = (Values[indexB], Values[indexA]);
                }
            }
            public void Sort()
            {
                // Sắp xếp đồng thời hai danh sách bằng Bubble Sort
                for (int i = 0; i < Keys.Count - 1; i++)
                {
                    for (int j = 0; j < Keys.Count - i - 1; j++)
                    {
                        if (string.Compare(Keys[j], Keys[j + 1], StringComparison.Ordinal) > 0)
                        {
                            // Hoán đổi phần tử trong cả hai danh sách
                            (Keys[j], Keys[j + 1]) = (Keys[j + 1], Keys[j]);
                            (Values[j], Values[j + 1]) = (Values[j + 1], Values[j]);
                        }
                    }
                }
            }

            public void Sort2()
            {
                // Sắp xếp đồng thời hai danh sách bằng Bubble Sort
                for (int i = 0; i < Keys.Count - 1; i++)
                {
                    for (int j = 0; j < Keys.Count - 1; j++)
                    {
                        if (String.Compare(Keys[j], Keys[j + 1]) > 0)
                        {
                            Swap(j);
                        }
                    }
                }
            }

        }

       

        private void inputword_TextChanged(object sender, EventArgs e)
        {
            if (inputword.Text.Length > 0 && inputword.Text.Length <= 15)
            {
                ovalPictureBox1.Image = images[inputword.Text.Length - 1];
                ovalPictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (inputword.Text.Length <= 0)
                ovalPictureBox1.Image = Properties.Resources.debut;
            else
                ovalPictureBox1.Image = images[22];
        }

        private void inputword_Click(object sender, EventArgs e)
        {
            if (inputword.Text.Length > 0)
                ovalPictureBox1.Image = images[inputword.Text.Length - 1];
            else
                ovalPictureBox1.Image = Properties.Resources.debut;
        }

        
        private void searchbtn_Click(object sender, EventArgs e)
        {

            try
            {
                // Khởi tạo đối tượng từ điển
                TuDien My_dict = new TuDien();
                

                // Lấy từ người dùng nhập
                string word = inputword.Text;

                // Lấy đối tượng WordDesc tương ứng với từ
                WordDesc result = My_dict.GetValue(word);

                // Hiển thị thông tin vào các TextBox
                meaning.Text = result.nghiaTV;    // Hiển thị nghĩa tiếng Việt
                type.Text = result.loaitu;     // Hiển thị loại từ
                phienam.Text = result.phienam;    // Hiển thị phiên âm
            }
            //catch (FileNotFoundException ex)
            //{
            //    MessageBox.Show("File không tồn tại: " + ex.Message);
            //}
            catch (KeyNotFoundException)
            {
                ovalPictureBox1.Image = Properties.Resources.textbox_password;
                meaning.Text = null;
                type.Text = null;
                phienam.Text = null;

                MessageBox.Show("Không tìm thấy từ: " + inputword.Text);
                
            }

        }

        private void test_Click(object sender, EventArgs e)
        {
            //if (redheart.Visible == false)
            //{
            //    redheart.Visible = true;
            //    whiteheart.Visible = false;

            //}
            //else
            //{
            //    redheart.Visible = false;
            //    whiteheart.Visible = true;
            //}
            if (inputword.Text.Length>0)
                MessageBox.Show("not null");
            else
                MessageBox.Show("null");
                 
        }

        private void redheart_Click(object sender, EventArgs e)
        {
            
            TuDien My_dict = new TuDien();
            if (My_dict.Keys.Contains(inputword.Text) && inputword.Text.Length > 0)
            {
                //temp.Remove(inputword.Text);
                MessageBox.Show("Bạn đã loại từ "+inputword.Text+" ra khỏi danh sách");
                redheart.Visible = false;
                whiteheart.Visible = true; 

            
            }
            else
                MessageBox.Show("Từ này không có trong favorite");


        }
        
        private void whiteheart_Click(object sender, EventArgs e)
        {
            
            

            TuDien My_dict = new TuDien();
            if (My_dict.Keys.Contains(inputword.Text)&& (meaning.Text.Length > 2))
            {
                
                //temp.Add(inputword.Text);
                whiteheart.Visible = false;
                redheart.Visible = true;
                MessageBox.Show("Bạn đã thêm từ: "+inputword.Text+" vào danh sách yêu thích");

              
                
            }
            else if (My_dict.Keys.Contains(inputword.Text)&&(meaning.Text.Length<1))
            {
                MessageBox.Show("Hãy search trước khi thêm từ vào yêu thích");

            }
            else
                MessageBox.Show("Bạn chưa nhập từ vào hoặc từ bạn nhập không có trong từ điển");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (form2.listBoxFAV.Items.Contains(inputword.Text))
            {
                MessageBox.Show("Từ này đã có trong danh sách yêu thích");
            }
            else
            {
                form2.listBoxFAV.Items.Add(inputword.Text);
            }
            
        }
    }
}
