using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMoneyAgent
{
   public  class OutRecord
    {
        public OutRecord()
        { }
        /// <summary>
        /// 传入支出记录编号的构造函数
        /// </summary>
        /// <param name="id">支出记录编号</param>
        public OutRecord(int id)
        {
            this.id = id;
        }

        private int id;
        /// <summary>
        /// 获取或设置支出记录的编号
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

        private DateTime outTime;
        /// <summary>
        /// 获取或设置支出时间，包括年月日时分秒
        /// </summary>
        public DateTime OutTime
        {
            get
            {
                return this.outTime;
            }
            set
            {
                this.outTime = value;
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

        private string outType = "";
        /// <summary>
        /// 获取或设置该记录的支出方式，包含在方式表中
        /// </summary>
        public string OutType
        {
            get
            {
                return this.outType;
            }
            set
            {
                this.outType = value;
            }
        }

        private string outUsage = "";
        /// <summary>
        /// 获取或设置该记录的来源类型，包括在用途表中，比如：工资等
        /// </summary>
        public string OutUsage
        {
            get
            {
                return this.outUsage;
            }
            set
            {
                this.outUsage = value;
            }
        }

        private decimal amount = 0.0M;
        /// <summary>
        /// 获取或设置本次支出的金额
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

        private string bankCard = "";
        /// <summary>
        /// 获取或设置当前支出的付账银行卡卡号
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

        private string descrption = "";
        /// <summary>
        /// 获取或设置该支出的说明
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
