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
        private List<Enterprise> enterpriseList = new List<Enterprise>();

        private BindingSource bsEnterprises = new BindingSource();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void MnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateStatusBar(int Percent)
        {
            FileOpeningProgress.Value = Percent;
        }

        private void MnOpen_Click(object sender, EventArgs e)
        {
            IEnterpriseListLoader load = new EnterpriseListSplitFileLoader(AppGlobalSettings.DataFileName);
            UpdateStatusBar(0);
            load.Execute(UpdateStatusBar);

            List<IEnterprise> enterprises = load.GetEnterprises();

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
