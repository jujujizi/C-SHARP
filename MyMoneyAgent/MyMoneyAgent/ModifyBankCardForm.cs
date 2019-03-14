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
    public partial class ModifyBankCardForm : Form
    {
        private BankCardClass bkInfo;
        public ModifyBankCardForm(BankCardClass bkInfo)
        {
            InitializeComponent();
            this.bkInfo = bkInfo;
        }

        private void ModifyBankCardForm_Load(object sender, EventArgs e)
        {
            this.tbName.Text = this.bkInfo.Name;
            this.tbBank.Text = this.bkInfo.BankName;
            this.mtbCardNo.Text = this.bkInfo.CardNo;
            this.nudBalance.Value = this.bkInfo.Balance;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //构建要保存的银行卡对象
            this.bkInfo.Balance = (decimal)this.nudBalance.Value;

            //保存新银行卡到数据库，根据结果提示
            if (BankCardSQL.MdyBankCards(this.bkInfo))
            {
                MessageBox.Show("修改银行卡：" + this.bkInfo.CardNo + "，成功！", "提示",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("修改银行卡：" + this.bkInfo.CardNo + "，失败！", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.nudBalance.Value = (decimal)0.0;
        }


    }
}
