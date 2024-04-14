using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComptMaelSystemV4
{
    public partial class ModulePage : Form
    {
        public ModulePage()
        {
            InitializeComponent();
        }

        private void btn_OrdValidation_Click(object sender, EventArgs e)
        {
            formOrderValidationSystem formordervalidationsystem = new formOrderValidationSystem();

            formordervalidationsystem.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }
    }
}
