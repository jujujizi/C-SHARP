using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMoneyAgent
{
    class UsageItem
    {
        private string usage;
        /// <summary>
        /// 使用用途
        /// </summary>
        public string Usage
        {
            get
            {
                return this.usage;
            }
            set
            {
                this.usage = value;
            }
        }

        private string description;
        /// <summary>
        /// 使用用途的说明
        /// </summary>
        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
            }
        }

        /// <summary>
        /// 重写ToString()方法，提供界面显示
        /// </summary>
        public override string ToString()
        {
            return this.usage;
        }
    }

    /// <summary>
    /// 支付类型
    /// </summary>
    public class PayTypeItem
    {
        private string payType;
        /// <summary>
        /// 支付类型
        /// </summary>
        public string PayType
        {
            get
            {
                return this.payType;
            }
            set
            {
                this.payType = value;
            }
        }

        private string description;
        /// <summary>
        /// 支付类型说明
        /// </summary>
        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
            }
        }

        /// <summary>
        /// 重写ToString()方法，提供界面显示
        /// </summary>
        public override string ToString()
        {
            return this.payType;
        }
    }
}
