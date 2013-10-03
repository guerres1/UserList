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
    public partial class AddEntryForm : Form
    {
        public AddEntryForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PhoneListEntry tempPerson = new PhoneListEntry( textBox1.Text, textBox2.Text);
            EntryArray.AddEntry(tempPerson);
            this.Close();
        }
    }
}
