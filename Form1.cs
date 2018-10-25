using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckSpell
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GenDict();
        }

        List<DictModel> model = new List<DictModel>();
        string[] rawData;
        List<string> result = new List<string>();

        private void dictBtn_Click(object sender, EventArgs e)
        {

            Form2 dictPopup = new Form2(model);
            dictPopup.Show();

        }

        private void GenDict()
        {

            var data = System.IO.File.ReadAllLines(@"D:\Visual Project\CheckSpell\CheckSpell\CheckSpell\word.txt"); //ได้เป็น array
                                                                                                                    //  var oText = string.Empty;
            foreach (var item in data) // วนตั้งแต่ตัวแรกถึงตัวสุดท้าย
            {
                var splitText = item.Split(' ');

                var newWord = new DictModel();
                newWord.Key = splitText.First();
                newWord.Suggest = splitText[1];

                model.Add(newWord);

                //   oText += newWord.Key + ":" + newWord.Suggest + Environment.NewLine;
            }

            // richTextBoxResult.Text = oText;

        }


        private void readBtn_Click(object sender, EventArgs e)
        {
            var fileData = System.IO.File.ReadAllLines(@"D:\Visual Project\CheckSpell\CheckSpell\CheckSpell\HOLBROOKDAT.txt"); //ได้เป็น array
            rawData = fileData;

            richTextBoxRaw.Text = string.Join(Environment.NewLine, fileData);
            processBtn.Enabled = true;


        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void processBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in rawData)
            {
                var GetWord = item.Split(' ');

                foreach (var word in GetWord)
                {
                    foreach (var dict in model)
                    {
                        if (dict.Key == word)
                        {
                            result.Add(word + " ==> " + dict.Suggest);
                            listBox1.Items.Add(word + " ==> " + dict.Suggest);
                        }
                    }
                }
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var text = listBox1.GetItemText(listBox1.SelectedItem);

            var split = Regex.Split(text, " ==> ");
            textBox1.Text = split.First();
            textBox2.Text = split.Last();



            SetHighLight(split.First());
        }

        private void SetHighLight(string input)
        {
            //clear color
            richTextBoxRaw.Select(0, richTextBoxRaw.Text.Length);
            richTextBoxRaw.SelectionBackColor = Color.White;
            richTextBoxRaw.SelectionColor = Color.Black;

            if (string.IsNullOrEmpty(input))
                return;

            int countWord = 0;
            int s_start = richTextBoxRaw.SelectionStart, startIndex = 0, index;

            while ((index = richTextBoxRaw.Text.IndexOf(" " + input + " ", startIndex)) != -1
                || (index = richTextBoxRaw.Text.IndexOf(" " + input + ".", startIndex)) != -1
                || (index = richTextBoxRaw.Text.IndexOf(" " + input + ",", startIndex)) != -1
                || (index = richTextBoxRaw.Text.IndexOf(input + ",", startIndex)) != -1
                || (index = richTextBoxRaw.Text.IndexOf(input + ".", startIndex)) != -1
                || (index = richTextBoxRaw.Text.IndexOf(input + " ", startIndex)) != -1
                )
            {

                if ((index = richTextBoxRaw.Text.IndexOf(" " + input + " ", startIndex)) != -1
                || (index = richTextBoxRaw.Text.IndexOf(" " + input + ".", startIndex)) != -1
                || (index = richTextBoxRaw.Text.IndexOf(" " + input + ",", startIndex)) != -1)
                {
                    richTextBoxRaw.Select(index + 1, input.Length);
                }
                else if ((index = richTextBoxRaw.Text.IndexOf(input + ",", startIndex)) != -1
                || (index = richTextBoxRaw.Text.IndexOf(input + ".", startIndex)) != -1
                || (index = richTextBoxRaw.Text.IndexOf(input + " ", startIndex)) != -1)
                {
                    richTextBoxRaw.Select(index, input.Length);
                }

                richTextBoxRaw.SelectionBackColor = Color.Blue;
                richTextBoxRaw.SelectionColor = Color.White;

                startIndex = index + input.Length;
                countWord++;
            }

            richTextBoxRaw.SelectionStart = s_start;
            richTextBoxRaw.SelectionLength = 0;
            richTextBoxRaw.SelectionColor = Color.Black;


            label2.Text = "Count :" + countWord;

            ////Select the line from it's number
            //var startIndex = richTextBoxRaw.GetFirstCharIndexFromLine(5);
            //richTextBoxRaw.Select(4, 14);

            ////Set the selected text fore and background color
            //richTextBoxRaw.SelectionColor = System.Drawing.Color.White;
            //richTextBoxRaw.SelectionBackColor = System.Drawing.Color.Blue;

        }



    }

    public class DictModel
    {
        public string Key { get; set; }
        public string Suggest { get; set; }
    }
}
