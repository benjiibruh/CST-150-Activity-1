using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Activity_14
{
    public partial class Form1 : Form
    {
        private List<string> selectedItems;

        public Form1()
        {
            InitializeComponent();
            selectedItems = new List<string>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Add some items to the radio button group
            radioButton1.Text = "Item 1";
            radioButton2.Text = "Item 2";
            radioButton3.Text = "Item 3";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Check if any radio button is selected
            if (radioButton1.Checked)
                AddItemToList(radioButton1.Text);
            else if (radioButton2.Checked)
                AddItemToList(radioButton2.Text);
            else if (radioButton3.Checked)
                AddItemToList(radioButton3.Text);
            else
                MessageBox.Show("Please select an item!");

            // Check if any check box is selected
            if (checkBox1.Checked)
                AddItemToList(checkBox1.Text);
            if (checkBox2.Checked)
                AddItemToList(checkBox2.Text);
            if (checkBox3.Checked)
                AddItemToList(checkBox3.Text);
        }

        private void AddItemToList(string item)
        {
            selectedItems.Add(item);
            listBox.Items.Add(item);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            selectedItems.Clear();
            listBox.Items.Clear();
        }
    }
}
