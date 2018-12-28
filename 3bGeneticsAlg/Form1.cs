using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3bGeneticsAlg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lbFiles.Items.Add(nudElem.Value);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            lbFiles.Items.Remove(lbFiles.SelectedItem);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
            lbFiles.Items.Clear();
        }

        private void ClearAll()
        {
            tbExact.Clear();
            tbTimeEx.Clear();
            tbTimeGen.Clear();
            tbGen.Clear();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            lbFiles.Items.Clear();
            int capacity = (int)CapacityBox.Value;
            for (int i = 0; i < nudItems.Value; i++)
            {
                lbFiles.Items.Add(r.Next(1, capacity));
            }
        }
    }
}
