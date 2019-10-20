using Kpo4162_nvm;
using Kpo4162_nvm.Lib;
using Kpo4162_nvm.Lib.source;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPO
{
    public partial class FrmMain : Form
    {
        private List<AgroEnterprise> enterpriseList = new List<AgroEnterprise>();

        private BindingSource bsEnterprises = new BindingSource();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void MnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MnOpen_Click(object sender, EventArgs e)
        {
            AgroEnterprisesLoader enterprises = new AgroEnterprisesLoader("EnterpriseLab4.txt");

            enterprises.Execute();

            bsEnterprises.DataSource = enterprises.Enterprises;
            dgvAgroEnterprises.DataSource = bsEnterprises;
        }

        private void MnOpenEnterPrise_Click(object sender, EventArgs e)
        {
            var frmEnterprice = new FrmEnterprise();

            AgroEnterprise enterprise = (bsEnterprises.Current as AgroEnterprise);
            frmEnterprice.SetEnterprise(enterprise);

            frmEnterprice.ShowDialog();
        }
    }
}
