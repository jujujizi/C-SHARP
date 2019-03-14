using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMoneyAgent
{
    public partial   class IncomeReForm : Form
    {
        private string name;
        private IncomeRecord record;
        private bool readoly;
        public  IncomeReForm(string nm, IncomeRecord rec, bool ro)
        {
            InitializeComponent();
            this.name = nm;
            this.record = rec;
            this.readoly = ro;
        }
        public IncomeRecord Record
        {
            get
            {
                return this.record;
            }
        }
        public bool ReadOnly
        {
            get
            {
                return this.readoly;
            }
        }
        private void ReadOnlyUI()
        {
            this.cmbBankCard.Enabled = !this.readoly;
            this.cmbType.Enabled = !this.readoly;
            this.cmbUsage.Enabled = !this.readoly;
            this.nudAmout.ReadOnly = this.readoly;
            this.rtbDes.ReadOnly = this.readoly;
            this.dtpInTime.Enabled = !this.readoly;
        }
        private void ShowRecord()
        {
            this.grbPara.Text = "收入记录----" + this.record.ID.ToString();
            this.cmbBankCard.Text = this.record.BankCard;
            this.cmbType.Text = this.record.IncomeType;
            this.cmbUsage.Text = this.record.IncomUsage;
            this.dtpInTime.Value = this.record.IncomeTime;
            this.rtbDes.Text = this.record.Description;
        }
        private void LoadBankCard()
        {
            this.cmbBankCard.Items.Add("无");
            //从数据库加载
            List<BankCardClass> bankList = BankCardSQL.LoadBankCardList(this.name);
            if (bankList != null)
            {
                //加载成功，则逐个添加到下拉列表
                foreach (BankCardClass bank in bankList)
                {
                    this.cmbBankCard.Items.Add(bank);
                }
            }
        }
        private void LoadTypeList()
        {
            this.cmbType.Items.Add("无");
            //从数据库加载
            List<PayTypeItem> tyLst = BankCardSQL.LoadPayTypeList();
            if (tyLst != null)
            {
                //加载成功，则逐个添加到下拉列表
                foreach (PayTypeItem item in tyLst)
                {
                    this.cmbType.Items.Add(item);
                }
            }
        }
        private void LoadUsageList()
        {
            this.cmbUsage.Items.Add("无");
            //从数据库加载
            List<UsageItem> usageLst = BankCardSQL.LoadUseageList();
            if (usageLst != null)
            {
                //加载成功，则逐个添加到下拉列表
                foreach (UsageItem item in usageLst)
                {
                    this.cmbUsage.Items.Add(item);
                }
            }
        }

        private void IncomeReForm_Load(object sender, EventArgs e)
        {
            //根据只读属性锁定界面
            this.ReadOnlyUI();
            //加载银行卡、收入方式、收入来源
            this.LoadBankCard();
            this.LoadTypeList();
            this.LoadUsageList();
            //显示当前记录
            this.ShowRecord();
            if (this.readoly)
            {
                this.Text = "查看收入记录";
            }
            else
            {
                this.Text = "编辑收入记录";
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!this.readoly)
            {
                this.record.Amount = (decimal)this.nudAmout.Value;
                this.record.BankCard = this.cmbBankCard.Text;
                this.record.IncomeType = this.cmbType.Text;
                if (string.IsNullOrEmpty(this.record.IncomeType))
                {
                    MessageBox.Show(this, "请从列表中选择收入方式！", "提示",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                this.record.IncomUsage = this.cmbUsage.Text;
                if (string.IsNullOrEmpty(this.record.IncomUsage))
                {
                    MessageBox.Show(this, "请从列表中选择收入来源", "提示",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                this.record.IncomeTime = this.dtpInTime.Value;
                this.record.Description = this.rtbDes.Text.Trim();
                this.record.RecordTime = DateTime.Now;
            }
            this.DialogResult = DialogResult.OK;
        }


    }
}
