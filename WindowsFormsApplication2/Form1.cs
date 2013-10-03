using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEntryForm addEntry = new AddEntryForm();
            addEntry.ShowDialog();
            UpdateListBox();
        }

        public void UpdateListBox()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < EntryArray.ListSize(); i++)
            {
                listBox1.Items.Add(EntryArray.GetName(i));
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex == -1)
            {
                System.Windows.Forms.MessageBox.Show("Please select an entry from the list.");
                return;     
            }
            else
            {
                EditEntrycs EditEntryForm = new EditEntrycs( listBox1.SelectedIndex );
                EditEntryForm.ShowDialog();
                UpdateListBox();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                System.Windows.Forms.MessageBox.Show("Please select an entry from the list.");
                return;
            }
            else
            {
                EntryArray.DeleteEntry(listBox1.SelectedIndex);
                UpdateListBox();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            EntryArray.MoveEntryUp(listBox1.SelectedIndex);
            UpdateListBox();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            EntryArray.MoveEntryDown(listBox1.SelectedIndex);
            UpdateListBox();
        }

    }
}
