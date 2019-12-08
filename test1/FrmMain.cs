using Kpo4162_nvm.Lib;
using Kpo4162_nvm.Lib.source;
using Kpo4162_nvm.Lib.source.Enterprises;
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
        private List<IEnterprise> enterpriseList = new List<IEnterprise>();

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
            IEnterpriseFactory factory = AppGlobalSettings.GetEnterpriseFactory("Test");
            IEnterpriseListLoader loader = factory.CreateEnterpriseLoader(AppGlobalSettings.DataFileName);

            loader.Execute();

            List<IEnterprise> enterprises = loader.GetEnterprises();

            bsEnterprises.DataSource = enterprises;
            dgvAgroEnterprises.DataSource = bsEnterprises;
        }

        private void MnOpenEnterPrise_Click(object sender, EventArgs e)
        {
            var frmEnterprice = new FrmEnterprise();

            Enterprise enterprise = (bsEnterprises.Current as Enterprise);
            frmEnterprice.SetEnterprise(enterprise);

            frmEnterprice.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            tbDataFileName.Text = AppGlobalSettings.DataFileName;
            tbLogPath.Text = AppGlobalSettings.LogPath;
        }
    }
}
