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
    public partial class AddBankCardForm : Form
    {
        private string name;
        public AddBankCardForm(string name)
        {
            InitializeComponent();
            this.name = name;
            string[] rightTypeString = Enum.GetNames(typeof(BankType));
            cmbBank.Items.AddRange(rightTypeString);
            cmbBank.SelectedIndex = 1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //判断卡号是否合法
            if (string.IsNullOrEmpty(this.mtbCardNo.Text.Trim()))
            {
                MessageBox.Show("请输入合法的银行卡号！", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                //让卡号输入框获得焦点
                this.mtbCardNo.Focus();
                return;
            }

            //构建要保存的银行卡对象
            BankCardClass bkInfo = new BankCardClass();
            bkInfo.Balance = (decimal)this.nudBalance.Value;
            bkInfo.BankName = this.cmbBank.Text;
            bkInfo.CardNo = this.mtbCardNo.Text.Trim();
            bkInfo.Name = this.name;

            //保存新银行卡到数据库，根据结果提示
            if (BankCardSQL.AddBankCards(bkInfo))
            {
                MessageBox.Show("添加银行卡：" + bkInfo.CardNo + "，成功！", "提示",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("添加银行卡：" + bkInfo.CardNo + "，失败！", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddBankCardForm_Load(object sender, EventArgs e)
        {
            this.tbName.Text = this.name;
            this.cmbBank.SelectedIndex = 0;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
           // this.cmbBank.SelectedIndex = 0;
            this.mtbCardNo.Clear();
            this.nudBalance.Value = (decimal)0.0;
        }
    }
}
