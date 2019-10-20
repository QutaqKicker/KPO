using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kpo4162_nvm.Lib.source
{
    public partial class FrmEnterprise : Form
    {
        public FrmEnterprise()
        {
            InitializeComponent();
        }

        private Enterprise _enterprise = null;

        public Enterprise Enterprise
        {
            get { return _enterprise; }
        }

        public void SetEnterprise(Enterprise enterprise)
        {
            _enterprise = enterprise;
        }

        private void FrmEnterprise_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
