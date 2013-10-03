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
    public partial class EditEntrycs : Form
    {

        private int arrayIndex;
        public EditEntrycs()
        {
            InitializeComponent();
        }

        public EditEntrycs(int index)
        {
            InitializeComponent();
            textBox1.Text = EntryArray.GetName( index );
            textBox2.Text = EntryArray.GetNumber(index);
            arrayIndex = index;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntryArray.SetName(arrayIndex, textBox1.Text);
            EntryArray.SetNumber(arrayIndex, textBox2.Text);
            this.Close();
        }


    }
}
