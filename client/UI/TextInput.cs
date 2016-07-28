using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFRKInspector.UI
{
    public partial class TextInput : Form
    {
        public TextInput()
        {
            InitializeComponent();
        }

        public string Label
        {
            get
            {
                return label1.Text;
            }

            set
            {
                if (value == null)
                {
                    label1.Text = "";
                }
                else
                {
                    label1.Text = value.ToString();
                }
            }
        }
        
        public string Value
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                if (value == null)
                {
                    textBox1.Text = "";
                }
                else
                {
                    textBox1.Text = value.ToString();
                }
                
            }

        }
        
        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
