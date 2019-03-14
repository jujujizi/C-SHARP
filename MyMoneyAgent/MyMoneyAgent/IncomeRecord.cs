using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMoneyAgent
{
    public class IncomeRecord
    {
        
        public IncomeRecord( )
        {}
        /// <summary>
        /// 传入收入记录编号的构造函数
        /// </summary>
        /// <param name="id">收入记录编号</param>
        public IncomeRecord(int id)
        {
            this.id = id;
        }

        private int id;
        /// <summary>
        /// 获取或设置收入记录的编号
        /// </summary>
        public int ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        private DateTime incomeTime;
        /// <summary>
        /// 获取或设置收入时间，包括年月日时分秒
        /// </summary>
        public DateTime IncomeTime
        {
            get
            {
                return this.incomeTime;
            }
            set
            {
                this.incomeTime = value;
            }
        }

        private DateTime recordTime;
        /// <summary>
        /// 获取或设置，该记录的记录时间，最近一次修改时间
        /// </summary>
        public DateTime RecordTime
        {
            get
            {
                return this.recordTime;
            }
            set
            {
                this.recordTime = value;
            }
        }

        private string incomeType="";
        /// <summary>
        /// 获取或设置该记录的收入方式，包含在方式表中
        /// </summary>
        public string IncomeType
        {
            get
            {
                return this.incomeType;
            }
            set
            {
                this.incomeType = value;
            }
        }

        private string incomeUsage="";
        /// <summary>
        /// 获取或设置该记录的来源类型，包括在用途表中，比如：工资等
        /// </summary>
        public string IncomUsage
        {
            get
            {
                return this.incomeUsage;
            }
            set
            {
                this.incomeUsage = value;
            }
        }

        private decimal amount=0.0M;
        /// <summary>
        /// 获取或设置本次收入的金额
        /// </summary>
        public decimal Amount
        {
            get
            {
                return this.amount;
            }
            set
            {
                this.amount = value;   
            }
        }

        private string bankCard="";
        /// <summary>
        /// 获取或设置当前收入存入到的银行卡卡号
        /// </summary>
        public string BankCard
        {
            get
            {
                return this.bankCard;
            }
            set
            {
                this.bankCard = value;
            }
        }

        private string descrption="";
        /// <summary>
        /// 获取或设置该收入的说明
        /// </summary>
        public string Description
        {
            get
            {
                return this.descrption;
            }
            set
            {
                this.descrption = value;
            }
        }
    }
}
