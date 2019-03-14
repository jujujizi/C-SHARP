using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMoneyAgent
{

    public enum BankType
    {
        CCB,PBC,BC,CB,ABC,CMB,OtherBank
    };
    /// <summary>
    /// 银行卡操作记录
    /// </summary>
    public enum CardOps
    {
        /// <summary>
        /// 收入
        /// </summary>
        Income = 0,
        /// <summary>
        /// 支出
        /// </summary>
        Payout = 1,
    }

    public class BankCardClass
    {
        /// <summary>
        /// 银行卡号
        /// </summary>
        private string cardNo;
        public string CardNo
        {
            get
            {
                return this.cardNo;
            }
            set
            {
                this.cardNo = value;
            }
        }

        /// <summary>
        /// 银行卡所在用户
        /// </summary>
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        /// <summary>
        /// 开户银行
        /// </summary>
        private string bankName;
        public string BankName
        {
            get
            {
                return this.bankName;
            }
            set
            {
                this.bankName = value;
            }
        }

        /// <summary>
        /// 银行卡余额
        /// </summary>
        private decimal balance;
        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        public override string ToString()
        {
            return this.cardNo;
        }
    }
}
