using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WinFormDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text + " = "+ passwordGenerator((int)numericUpDown1.Value, checkBox1.Checked, true, checkBox2.Checked, checkBox3.Checked).ToString());

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public string passwordGenerator(int length, bool includeUppercase, bool includeLowercase, bool includeNumbers, bool includeSpecialChars)
        {
            const string uppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lowercaseChars = "abcdefghijklmnopqrstuvwxyz";
            const string numberChars = "0123456789";
            const string specialChars = "!@#$%^&*()_+-=[]{}|;:,.<>?";
            StringBuilder characterSet = new StringBuilder();
            if (includeUppercase)
                characterSet.Append(uppercaseChars);
            if (includeLowercase)
                characterSet.Append(lowercaseChars);
            if (includeNumbers)
                characterSet.Append(numberChars);
            if (includeSpecialChars)
                characterSet.Append(specialChars);
            if (characterSet.Length == 0)
                throw new ArgumentException("At least one character type must be selected.");
            Random random = new Random();
            StringBuilder password = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                int index = random.Next(characterSet.Length);
                password.Append(characterSet[index]);
            }
            return password.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool includeUppercase = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            bool includeNumbers= checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            bool includeSpecialCharacters = checkBox3.Checked;
        }
    }
}
