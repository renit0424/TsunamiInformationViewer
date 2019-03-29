using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TsunamiInformationViewer
{
    public partial class Setting : Form
    {
        public string InputText { get; set; }

        public Setting()
        {
            InitializeComponent();
        }

        private void Setting_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //プロパティに値を設定する
            InputText = this.textBox1.Text;
            this.Close();
        }
    }
}
