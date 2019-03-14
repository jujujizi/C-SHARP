using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyMoneyAgent
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private string title = "个人财务管理系统";
        private UserClass curUser;
        private void InitUI()
        {
            this.tslbCurUser.Text = "未登录";
            this.tabctrOps.Visible = false;
            this.Text = this.title + "-----"+this.tslbCurUser.Text;
            this.tsmiChangeUser.Enabled = false;
            this.tsbtnChangeUser.Enabled = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.InitUI();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm();
            af.ShowDialog(this);
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            //退出提示，真的要退出，才允许退出
            if (MessageBox.Show(this, "你真的要退出？", "提示",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


        private void LogInSuccess(UserClass user)
        {
            //登录成功处理
            this.curUser = user;
            this.Text = this.title + "-----" + this.curUser.ToString();
            this.tslbCurUser.Text = "登录用户:" + this.curUser.ToString();
            this.tabctrOps.Visible = true;
            //登录成功，根据用户权限屏蔽可用功能
            if (this.curUser.Right != UserRights.Administrator)
            {
                //对非管理员用户屏蔽用户管理和其他操作功能
                this.tabctrOps.TabPages.Remove(this.tpUserMng);
                this.tabctrOps.TabPages.Remove(this.tpOther);
            }
            else
            {
                //对非管理员用户启用用户管理和其他操作功能
                if (!this.tabctrOps.TabPages.Contains(this.tpUserMng))
                {
                    this.tabctrOps.TabPages.Add(this.tpUserMng);
                }
                if (!this.tabctrOps.TabPages.Contains(this.tpOther))
                {
                    this.tabctrOps.TabPages.Add(this.tpOther);
                }
                //加载用户列表
                this.LoadUserList();
            }
            //加载银行卡、支出、收入记录
            this.LoadBankCardList();
            this.LoadIncomRecList();
            this.LoadOutRecList();
        }
        private void LogIn()
        {
            LoginForm dlg = new LoginForm();
            //显示登录对话框
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                this.LogInSuccess(dlg.GetCurUser());
                this.tsmiChangeUser.Enabled = true;
                this.tsbtnChangeUser.Enabled = true;
                this.tsmiLogin.Enabled = false;
                this.tsbtnLogIn.Enabled = false;
            }
            else
            {
                //登录失败处理
                this.tslbCurUser.Text = "未登录";
                this.tabctrOps.Visible = false;
                this.Text = this.title + "----未登录";
                this.tsmiChangeUser.Enabled = false;
                this.tsbtnChangeUser.Enabled = false;
                this.curUser = null;
            }
        }

        private void tsmiLogin_Click(object sender, EventArgs e)
        {
            this.LogIn();
        }

        private void tsbtnChangeUser_Click(object sender, EventArgs e)
        {
            this.LogIn();
        }
        private void LoadUserList()
        {
            //清空原有数据显示
            this.treeUser.Nodes.Clear();
            //加载用户列表
            List<UserClass> userList = UserSql.LoadUserList();
            if (userList != null)
            {
                //依次显示所有的用户信息
                foreach (UserClass user in userList)
                {
                    TreeNode node = new TreeNode();
                    node.Text = user.Name;
                    node.Tag = user;
                    this.treeUser.Nodes.Add(node);
                }
            }
        }

        private void btnFreshUser_Click(object sender, EventArgs e)
        {
            this.LoadUserList(); 
        }

        private void treeUser_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //将树中节点表示的数据更新到界面
            UserClass user = (UserClass)e.Node.Tag;
            this.tbName.Text = user.Name;
            this.tbPwd.Text = user.Password;
            this.cmbRight.Text = user.Right.ToString();
        }

        private void btnDelUser_Click(object sender, EventArgs e)
        {
            if (this.treeUser.SelectedNode == null)
            {
                MessageBox.Show(this, "请选中要删除的用户！！！", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //获取要删除的用户
            UserClass user = (UserClass)this.treeUser.SelectedNode.Tag;
            //询问用户确认删除操作
            if (MessageBox.Show(this, "真的要删除用户:" + user.Name + "?", "提示",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            //删除用户
            if (UserSql.DeleteUser(user.Name))
            {
                MessageBox.Show(this, "删除成功！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //删除成功，刷新用户列表
                this.LoadUserList();
            }
            else
            {
                MessageBox.Show(this, "删除失败！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            //不是管理员，不允许添加用户
            if (this.curUser.Right != UserRights.Administrator)
            {
                MessageBox.Show(this, "你不是管理员，不能添加用户", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //创建添加用户对话框
            AddUserForm auf = new AddUserForm();
            //添加用户操作成功，则重新更新用户列表
            if (auf.ShowDialog(this) == DialogResult.OK)
            {
                this.LoadUserList();
            }
        }

        private void btnModifyUser_Click(object sender, EventArgs e)
        {
            //创建修改密码对话框
            ModifyPasswardForm mpf = new ModifyPasswardForm();
            //显示对话框，完成密码修改操作
            mpf.ShowDialog();
            //重新加载用户列表
            this.LoadUserList();
        }
        private void LoadBankCardList()
        {
            //加载当前用户的银行卡列表
            List<BankCardClass> cdLst = BankCardSQL.LoadBankCardList(this.curUser.Name);
            //清空原有银行卡列表
            this.treeBankCard.Nodes.Clear();
            if ((cdLst == null) || (cdLst.Count <= 0))
            {
                MessageBox.Show(this, "你还没有银行卡信息，请先添加银行卡！", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //依次添加列表中所有的银行卡到界面
            foreach (BankCardClass bk in cdLst)
            {
                //生成子节点，并显示到界面
                TreeNode node = new TreeNode();
                node.Text = bk.CardNo;
                node.Tag = bk;
                treeBankCard.Nodes.Add(node);
            }
        }

        private void btnFreshCard_Click(object sender, EventArgs e)
        {
            this.LoadBankCardList();
        }

        private void btnAddCard_Click(object sender, EventArgs e)
        {
             //创建添加银行卡对话框
            AddBankCardForm abf= new AddBankCardForm(this.curUser.Name);
            //显示对话框，执行添加操作
            if (abf.ShowDialog(this) == DialogResult.OK)
            { 
                //添加成功，刷新银行卡列表
                this.LoadBankCardList( );
            }
        }

        private void btnDelCard_Click(object sender, EventArgs e)
        {
            //判断是否有选中的银行卡
            if (this.treeBankCard.SelectedNode == null)
            {
                MessageBox.Show(this, "请选中要删除的银行卡！", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //获取选中的银行卡
            BankCardClass bk = (BankCardClass)this.treeBankCard.SelectedNode.Tag;
            //删除前确认
            if (MessageBox.Show(this, "你真的要删除银行卡：" + bk.CardNo + "？", "提示",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (BankCardSQL.DeleteBankCard(bk.CardNo))
            {
                MessageBox.Show(this, "删除银行卡：" + bk.CardNo + "，成功！", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LoadBankCardList();
            }
            else
            {
                MessageBox.Show(this, "删除银行卡：" + bk.CardNo + "，失败！", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void treeBankCard_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //获取选中银行卡
            BankCardClass bkInfo = (BankCardClass)e.Node.Tag;
            //清除原有内容
            this.dgvCardOps.Rows.Clear();
            //显示银行卡记录
            int newRowIndex = this.dgvCardOps.Rows.Add();
            this.dgvCardOps["colBankNo", newRowIndex].Value = bkInfo.CardNo;
            this.dgvCardOps["colBankName", newRowIndex].Value = bkInfo.BankName;
            this.dgvCardOps["colBankBanlance", newRowIndex].Value = bkInfo.Balance.ToString("f2") + "￥";
        }

        private void btnLoadType_Click(object sender, EventArgs e)
        {
            //先清空界面
            this.lstUseType.Items.Clear();
            //从数据库加载现有方式列表
            List<PayTypeItem> usageLst = BankCardSQL.LoadPayTypeList();
            if (usageLst != null)
            {
                //加载成功，则显示到界面
                foreach (PayTypeItem item in usageLst)
                {
                    this.lstUseType.Items.Add(item);
                }
            }
            else
            {
                //加载失败，提示
                MessageBox.Show(this, "加载方式列表失败，确保数据库可链接!", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelType_Click(object sender, EventArgs e)
        {
            //如果没有选中任何方式，则不删除，直接退出
            if (this.lstUseType.SelectedItem == null)
            {
                return;
            }
            //获取选中的支付方式
            PayTypeItem item = (PayTypeItem)this.lstUseType.SelectedItem;
            //通过BankCardAccessor删除支付方式
            if (BankCardSQL.DeletePayType(item.PayType))
            {
                this.btnLoadType_Click(null, null);
                //删除成功提示成功
                MessageBox.Show(this, "删除支付方式:" + item.PayType + ",成功！", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //删除失败，提示失败
                MessageBox.Show(this, "删除支付方式:" + item.PayType + ",失败！", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            //检查方式名称的合法性
            if (string.IsNullOrEmpty(this.tbUseType.Text))
            {
                MessageBox.Show(this, "请输入正确的方式名称，不能已经存在，也不能为空！", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //检查方式说明的合法性
            if (string.IsNullOrEmpty(this.tbUseTypeDes.Text))
            {
                MessageBox.Show(this, "请输入正确的方式说明，不能为空！", "提示",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //创建方式对象
            PayTypeItem item = new PayTypeItem();
            //获取新方式数据
            item.PayType = this.tbUseType.Text.Trim();
            item.Description = this.tbUseTypeDes.Text.Trim();
            //添加到数据库
            if (BankCardSQL.AddPayType(item))
            {
                //重新加载方式列表
                this.btnLoadType_Click(null, null);
                //删除成功提示成功
                MessageBox.Show(this, "添加支付方式:" + item.PayType + ",成功！", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //删除成功提示成功
                MessageBox.Show(this, "添加支付方式:" + item.PayType + ",失败！", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadUse_Click(object sender, EventArgs e)
        {
            //先清空界面
            this.lstUsage.Items.Clear();
            //从数据库加载现有用途列表
            List<UsageItem> usageLst = BankCardSQL.LoadUseageList();
            if (usageLst != null)
            {
                //加载成功，则显示到界面
                foreach (UsageItem item in usageLst)
                {
                    this.lstUsage.Items.Add(item);
                }
            }
            else
            {
                //加载失败，提示
                MessageBox.Show(this, "加载用途列表失败，确保数据库可链接!", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelUse_Click(object sender, EventArgs e)
        {
            //如果没有选中任何用途，则不删除，直接退出
            if (this.lstUsage.SelectedItem == null)
            {
                return;
            }
            //获取选中的用途
            UsageItem item = (UsageItem)this.lstUsage.SelectedItem;
            //通过BankCardAccessor删除用途
            if (BankCardSQL.DeleteUsage(item.Usage))
            {
                this.btnLoadUse_Click(null, null);
                //删除成功提示成功
                MessageBox.Show(this, "删除用途:" + item.Usage + ",成功！", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //删除失败，提示失败
                MessageBox.Show(this, "删除用途:" + item.Usage + ",失败！", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstUseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //如果有选中的支付方式，则更新
            if (this.lstUseType.SelectedItem != null)
            {
                //获取选中的支付方式
                PayTypeItem item = (PayTypeItem)this.lstUseType.SelectedItem;
                //将支付方式的名称和说明显示到界面
                this.tbUseType.Text = item.PayType;
                this.tbUseTypeDes.Text = item.Description;
            }
        }

        private void btnAddUse_Click(object sender, EventArgs e)
        {
            //检查用途名称的合法性
            if (string.IsNullOrEmpty(this.tbUsage.Text))
            {
                MessageBox.Show(this, "请输入正确的用途名称，不能已经存在，也不能为空！", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //检查用途说明的合法性
            if (string.IsNullOrEmpty(this.tbUsageDes.Text))
            {
                MessageBox.Show(this, "请输入正确的用途说明，不能为空！", "提示",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //创建用途对象
            UsageItem item = new UsageItem();
            //获取新用途数据
            item.Usage = this.tbUsage.Text.Trim();
            item.Description = this.tbUsageDes.Text.Trim();
            //添加到数据库
            if (BankCardSQL.AddUsage(item))
            {
                //重新加载用途列表
                this.btnLoadUse_Click(null, null);
                //删除成功提示成功
                MessageBox.Show(this, "添加用途:" + item.Usage + ",成功！", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //删除成功提示成功
                MessageBox.Show(this, "添加用途:" + item.Usage + ",失败！", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lstUsage_SelectedIndexChanged(object sender, EventArgs e)
        {
            //如果有选中的用途，则更新
            if (this.lstUsage.SelectedItem != null)
            {
                //获取选中的用途
                UsageItem item = (UsageItem)this.lstUsage.SelectedItem;
                //将用途的名称和说明显示到界面
                this.tbUsage.Text = item.Usage;
                this.tbUsageDes.Text = item.Description;
            }
        }

     

        private void tabctrOps_SelectedIndexChanged(object sender, EventArgs e)
        {
            string op;
            //根据当前选择页面，制定当前操作 
            switch (this.tabctrOps.SelectedIndex)
            {
                case 0:
                    op = "用户管理";
                    break;
                case 1:
                    op = "收入管理";
                    break;
                case 2:
                    op = "支出管理";
                    break;
                case 3:
                    op = "银行卡管理";
                    break;
                case 4:
                    op = "其他功能";
                    break;
                default:
                    op = "无操作";
                    break;
            }
            this.Text = this.title + "----" + op;
        }
        private void LoadOutRecList()
        {
            //清除原界面上的数据
            this.dgvOutRec.Rows.Clear();
            List<OutRecord> recLst;
            //从数据库加载支出记录列表
            recLst = OutSQL.LoadOutRcdList(this.curUser.Name);
            //加载失败，可能是数据库连接不成功，提示
            if (recLst == null)
            {
                MessageBox.Show(this, "加载已有支出记录失败，请确认数据库连接！", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //依次显示所有的收入记录到界面
            foreach (OutRecord rec in recLst)
            {
                //添加一行到界面
                int newRowIndex = this.dgvOutRec.Rows.Add();
                this.dgvOutRec.Rows[newRowIndex].Tag = rec;
                //显示信息到新添加的行
                this.dgvOutRec.Rows[newRowIndex].Cells["colOutID"].Value = rec.ID;
                this.dgvOutRec.Rows[newRowIndex].Cells["colOutTime"].Value = rec.OutTime;
                this.dgvOutRec.Rows[newRowIndex].Cells["colOutType"].Value = rec.OutType;
                this.dgvOutRec.Rows[newRowIndex].Cells["colOutUsage"].Value = rec.OutUsage;
                this.dgvOutRec.Rows[newRowIndex].Cells["colOutRecTime"].Value = rec.RecordTime;
                this.dgvOutRec.Rows[newRowIndex].Cells["colOutDes"].Value = rec.Description;
                this.dgvOutRec.Rows[newRowIndex].Cells["colOutBank"].Value = rec.BankCard;
                this.dgvOutRec.Rows[newRowIndex].Cells["colOutAmount"].Value = rec.Amount;
            }
        }

        private void btnLdOutRec_Click(object sender, EventArgs e)
        {
            this.LoadOutRecList();
        }

        private void btnModifyOutRec_Click(object sender, EventArgs e)
        {
            //判断是否有选中的记录
            if (this.dgvOutRec.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "没有选中任何记录！", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //获取支出记录的数据
            OutRecord rec;
            rec = (OutRecord)this.dgvOutRec.SelectedRows[0].Tag;
            //创建可修改对话框
            OutReForm orf = new OutReForm(this.curUser.Name, rec, false);
            //显示对话框，进行编辑操作
            if (orf.ShowDialog(this) == DialogResult.OK)
            {
                //修改记录成功，则更新指定记录
                if (OutSQL.ModifyOutRec(this.curUser.Name, rec))
                {
                    this.dgvOutRec.SelectedRows[0].Cells["colOutID"].Value = rec.ID;
                    this.dgvOutRec.SelectedRows[0].Cells["colOutTime"].Value = rec.OutTime;
                    this.dgvOutRec.SelectedRows[0].Cells["colOutType"].Value = rec.OutType;
                    this.dgvOutRec.SelectedRows[0].Cells["colOutUsage"].Value = rec.OutUsage;
                    this.dgvOutRec.SelectedRows[0].Cells["colOutRecTime"].Value = rec.RecordTime;
                    this.dgvOutRec.SelectedRows[0].Cells["colOutDes"].Value = rec.Description;
                    this.dgvOutRec.SelectedRows[0].Cells["colOutBank"].Value = rec.BankCard;
                    this.dgvOutRec.SelectedRows[0].Cells["colOutAmount"].Value = rec.Amount;
                }
                else
                {
                    MessageBox.Show(this, "修改记录失败！", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDelOutRec_Click(object sender, EventArgs e)
        {
            //判断是否有选中的记录
            if (this.dgvOutRec.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "没有选中任何记录！", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //获取选中记录的数据
            OutRecord rec;
            rec = (OutRecord)this.dgvOutRec.SelectedRows[0].Tag;
            //再次确认删除操作
            if (MessageBox.Show(this, "真的要删除支出记录----" + rec.ID.ToString() + "？", "提示",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //删除记录
                if (OutSQL.DeleteOutRec(this.curUser.Name, rec.ID))
                {
                    //删除成功，从表格移除
                    this.dgvOutRec.Rows.Remove(this.dgvOutRec.SelectedRows[0]);
                }
                else
                {
                    //删除失败，则提示
                    MessageBox.Show(this, "删除支出记录----" + rec.ID.ToString() + ",失败！", "提示",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnAddNewOutRec_Click(object sender, EventArgs e)
        {
            //创建用来保存新记录的对象
            int newId = OutSQL.GetUsableOutID(this.curUser.Name);
            if (newId == 0)
            {
                MessageBox.Show(this, "无法获取可用的支出记录编号，请确保数据库连接正确！", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            OutRecord rec = new OutRecord();
            rec.ID = newId;
            rec.OutTime = DateTime.Now;
            rec.RecordTime = DateTime.Now;
            //创建支出记录编辑对话框
            OutReForm dlg = new OutReForm(this.curUser.Name, rec, false);
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                //添加记录成功，则添加到界面
                if (OutSQL.AddOutRec(this.curUser.Name, rec))
                {
                    //添加一行到界面
                    int newRowIndex = this.dgvOutRec.Rows.Add();
                    this.dgvOutRec.Rows[newRowIndex].Tag = rec;
                    //显示信息到新添加的行
                    this.dgvOutRec.Rows[newRowIndex].Cells["colOutID"].Value = rec.ID;
                    this.dgvOutRec.Rows[newRowIndex].Cells["colOutTime"].Value = rec.OutTime;
                    this.dgvOutRec.Rows[newRowIndex].Cells["colOutType"].Value = rec.OutType;
                    this.dgvOutRec.Rows[newRowIndex].Cells["colOutUsage"].Value = rec.OutUsage;
                    this.dgvOutRec.Rows[newRowIndex].Cells["colOutRecTime"].Value = rec.RecordTime;
                    this.dgvOutRec.Rows[newRowIndex].Cells["colOutDes"].Value = rec.Description;
                    this.dgvOutRec.Rows[newRowIndex].Cells["colOutBank"].Value = rec.BankCard;
                    this.dgvOutRec.Rows[newRowIndex].Cells["colOutAmount"].Value = rec.Amount;
                }
                else
                {
                    MessageBox.Show(this, "添加记录失败！", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dgvOutRec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //如果双击的记录，则显示详细信息
            if (e.RowIndex >= 0)
            {
                //获取要显示详细信息的记录
                OutRecord rec;
                rec = (OutRecord)this.dgvOutRec.Rows[e.RowIndex].Tag;
                //创建只读的记录查看对话框
                OutReForm dlg;
                dlg = new OutReForm(this.curUser.Name, rec, true);
                //显示对话框
                dlg.ShowDialog(this);
            }
        }
        private void LoadIncomRecList()
        {
            //清除原界面上的数据
            this.dgvInRec.Rows.Clear();
            List<IncomeRecord> recLst;
            //从数据库加载收入记录列表
            recLst = IncomeSQL.LoadIncomRcdList(this.curUser.Name);
            //加载失败，可能是数据库连接不成功，提示
            if (recLst == null)
            {
                MessageBox.Show(this, "加载已有收入记录失败，请确认数据库连接！", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //依次显示所有的收入记录到界面
            foreach (IncomeRecord rec in recLst)
            {
                //添加一行到界面
                int newRowIndex = this.dgvInRec.Rows.Add();
                this.dgvInRec.Rows[newRowIndex].Tag = rec;
                //显示信息到新添加的行
                this.dgvInRec.Rows[newRowIndex].Cells["colInID"].Value = rec.ID;
                this.dgvInRec.Rows[newRowIndex].Cells["colInInTime"].Value = rec.IncomeTime;
                this.dgvInRec.Rows[newRowIndex].Cells["colInType"].Value = rec.IncomeType;
                this.dgvInRec.Rows[newRowIndex].Cells["colInUsage"].Value = rec.IncomUsage;
                this.dgvInRec.Rows[newRowIndex].Cells["colInRecTime"].Value = rec.RecordTime;
                this.dgvInRec.Rows[newRowIndex].Cells["colInDes"].Value = rec.Description;
                this.dgvInRec.Rows[newRowIndex].Cells["colInBank"].Value = rec.BankCard;
                this.dgvInRec.Rows[newRowIndex].Cells["colInAmount"].Value = rec.Amount;
            }
        }

        private void btnLdIncomRec_Click(object sender, EventArgs e)
        {
            this.LoadIncomRecList();
        }

        private void btnModifyIncomRec_Click(object sender, EventArgs e)
        {
            //判断是否有选中的记录
            if (this.dgvInRec.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "没有选中任何记录！", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //获取选中记录的数据
            IncomeRecord rec;
            rec = (IncomeRecord)this.dgvInRec.SelectedRows[0].Tag;
            //创建可修改对话框
            IncomeReForm dlg = new IncomeReForm(this.curUser.Name, rec, false);
            //显示对话框，进行编辑操作
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                //修改记录成功，则更新指定记录
                if (IncomeSQL.ModifyIncomrec(this.curUser.Name, rec))
                {
                    this.dgvInRec.SelectedRows[0].Cells["colInID"].Value = rec.ID;
                    this.dgvInRec.SelectedRows[0].Cells["colInInTime"].Value = rec.IncomeTime;
                    this.dgvInRec.SelectedRows[0].Cells["colInType"].Value = rec.IncomeType;
                    this.dgvInRec.SelectedRows[0].Cells["colInUsage"].Value = rec.IncomUsage;
                    this.dgvInRec.SelectedRows[0].Cells["colInRecTime"].Value = rec.RecordTime;
                    this.dgvInRec.SelectedRows[0].Cells["colInDes"].Value = rec.Description;
                    this.dgvInRec.SelectedRows[0].Cells["colInBank"].Value = rec.BankCard;
                    this.dgvInRec.SelectedRows[0].Cells["colInAmount"].Value = rec.Amount;
                }
                else
                {
                    MessageBox.Show(this, "修改记录失败！", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDelIncomRec_Click(object sender, EventArgs e)
        {
            //判断是否有选中的记录
            if (this.dgvInRec.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "没有选中任何记录！", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //获取选中记录的数据
            IncomeRecord rec;
            rec = (IncomeRecord)this.dgvInRec.SelectedRows[0].Tag;
            //再次确认删除操作
            if (MessageBox.Show(this, "真的要删除收入记录----" + rec.ID.ToString() + "？", "提示",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //删除记录
                if (IncomeSQL.DeleteIncomRec(this.curUser.Name, rec.ID))
                {
                    //删除成功，从表格移除
                    this.dgvInRec.Rows.Remove(this.dgvInRec.SelectedRows[0]);
                }
                else
                {
                    //删除失败，则提示
                    MessageBox.Show(this, "删除收入记录----" + rec.ID.ToString() + ",失败！", "提示",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnAddNewIncomRec_Click(object sender, EventArgs e)
        {
            //创建用来保存新记录的对象
            int newId = IncomeSQL.GetUsableIncomID(this.curUser.Name);
            if (newId == 0)
            {
                MessageBox.Show(this, "无法获取可用的收入记录编号，请确保数据库连接正确！", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            IncomeRecord rec = new IncomeRecord();
            rec.ID = newId;
            rec.IncomeTime = DateTime.Now;
            rec.RecordTime = DateTime.Now;
            //创建收入记录编辑对话框
            IncomeReForm dlg = new IncomeReForm(this.curUser.Name, rec, false);
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                //添加记录成功，则添加到界面
                if (IncomeSQL.AddIncomRec(this.curUser.Name, rec))
                {
                    //添加一行到界面
                    int newRowIndex = this.dgvInRec.Rows.Add();
                    this.dgvInRec.Rows[newRowIndex].Tag = rec;
                    //显示信息到新添加的行
                    this.dgvInRec.Rows[newRowIndex].Cells["colInID"].Value = rec.ID;
                    this.dgvInRec.Rows[newRowIndex].Cells["colInInTime"].Value = rec.IncomeTime;
                    this.dgvInRec.Rows[newRowIndex].Cells["colInType"].Value = rec.IncomeType;
                    this.dgvInRec.Rows[newRowIndex].Cells["colInUsage"].Value = rec.IncomUsage;
                    this.dgvInRec.Rows[newRowIndex].Cells["colInRecTime"].Value = rec.RecordTime;
                    this.dgvInRec.Rows[newRowIndex].Cells["colInDes"].Value = rec.Description;
                    this.dgvInRec.Rows[newRowIndex].Cells["colInBank"].Value = rec.BankCard;
                    this.dgvInRec.Rows[newRowIndex].Cells["colInAmount"].Value = rec.Amount;
                }
                else
                {
                    MessageBox.Show(this, "添加记录失败！", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dgvInRec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //如果双击的记录，则显示详细信息
            if (e.RowIndex >= 0)
            {
                //获取要显示详细信息的记录
                IncomeRecord rec;
                rec = (IncomeRecord)this.dgvInRec.Rows[e.RowIndex].Tag;
                //创建只读的记录查看对话框
                IncomeReForm dlg;
                dlg = new IncomeReForm(this.curUser.Name, rec, true);
                //显示对话框
                dlg.ShowDialog(this);
            }
        }

        private void btnMdyBanlance_Click(object sender, EventArgs e)
        {
            //判断是否有选中的银行卡
            if (this.treeBankCard.SelectedNode == null)
            {
                MessageBox.Show(this, "请先选中要修改的银行卡！", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //获取被选中的银行卡
            BankCardClass bkInfo = (BankCardClass)this.treeBankCard.SelectedNode.Tag;
            //创建修改对话框
            ModifyBankCardForm dlg = new ModifyBankCardForm(bkInfo);
            //显示修改银行卡余额界面，成功则重新加载银行卡列表
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                this.LoadBankCardList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //清除原界面上的数据
            this.dgvOutRec.Rows.Clear();
             List<OutRecord> recList;
            //从数据库加载支出记录列表
           /* SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet("MyMoney");
            string connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=""E:\c++练习\MyMoneyAgent - 副本 (2) - 副本\MyMoneyAgent\MyMoney.mdf"";Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);//创建链接对象
 
                conn.Open();
                //查询数据库中
                string cmdTxt = "SELECT [支出编号], [姓名], [支出时间], [记录时间], [支出方式], " +
                                "[支出类型], [金额], [银行卡号], [支出说明] FROM [支出记录] ";
                SqlCommand comm = new SqlCommand(cmdTxt, conn);
                da.SelectCommand = comm;
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                da.Fill(ds, "支出记录");
                dgvOutRec.DataSource = ds.Tables["支出记录"];
                //关闭连接
                conn.Close();*/
            recList = OutSQL.LoadOutRcdListSearch(this.curUser.Name, date1.Value.ToString(), date2.Value.ToString());
            //加载失败，可能是数据库连接不成功，提示
            if (recList == null)
            {
                MessageBox.Show(this, "加载已有支出记录失败，请确认数据库连接！", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //依次显示所有的支出记录到界面
            foreach (OutRecord rec in recList)
            {
                //添加一行到界面
                int newRowIndex = this.dgvOutRec.Rows.Add();
                this.dgvOutRec.Rows[newRowIndex].Tag = rec;
                //显示信息到新添加的行
                this.dgvOutRec.Rows[newRowIndex].Cells["colOutID"].Value = rec.ID;
                this.dgvOutRec.Rows[newRowIndex].Cells["colOutTime"].Value = rec.OutTime;
                this.dgvOutRec.Rows[newRowIndex].Cells["colOutType"].Value = rec.OutType;
                this.dgvOutRec.Rows[newRowIndex].Cells["colOutUsage"].Value = rec.OutUsage;
                this.dgvOutRec.Rows[newRowIndex].Cells["colOutRecTime"].Value = rec.RecordTime;
                this.dgvOutRec.Rows[newRowIndex].Cells["colOutDes"].Value = rec.Description;
                this.dgvOutRec.Rows[newRowIndex].Cells["colOutBank"].Value = rec.BankCard;
                this.dgvOutRec.Rows[newRowIndex].Cells["colOutAmount"].Value = rec.Amount;
            }
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            //清除原界面上的数据
            this.dgvInRec.Rows.Clear();
            List<IncomeRecord> recLst;
            //从数据库加载收入记录列表
            recLst = IncomeSQL.LoadIncomRcdListDate(this.curUser.Name, dtpdate1.Value.ToString(), dtpdate2.Value.ToString());
            //加载失败，可能是数据库连接不成功，提示
            if (recLst == null)
            {
                MessageBox.Show(this, "加载已有收入记录失败，请确认数据库连接！", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //依次显示所有的收入记录到界面
            foreach (IncomeRecord rec in recLst)
            {
                //添加一行到界面
                int newRowIndex = this.dgvInRec.Rows.Add();
                this.dgvInRec.Rows[newRowIndex].Tag = rec;
                //显示信息到新添加的行
                this.dgvInRec.Rows[newRowIndex].Cells["colInID"].Value = rec.ID;
                this.dgvInRec.Rows[newRowIndex].Cells["colInInTime"].Value = rec.IncomeTime;
                this.dgvInRec.Rows[newRowIndex].Cells["colInType"].Value = rec.IncomeType;
                this.dgvInRec.Rows[newRowIndex].Cells["colInUsage"].Value = rec.IncomUsage;
                this.dgvInRec.Rows[newRowIndex].Cells["colInRecTime"].Value = rec.RecordTime;
                this.dgvInRec.Rows[newRowIndex].Cells["colInDes"].Value = rec.Description;
                this.dgvInRec.Rows[newRowIndex].Cells["colInBank"].Value = rec.BankCard;
                this.dgvInRec.Rows[newRowIndex].Cells["colInAmount"].Value = rec.Amount;
            }
        }

       /* private void btnoutTotal_Click(object sender, EventArgs e)
        {
            double total = 0;
            int i;
            for (i = 0; i < dgvOutRec.Rows.Count; i++)
            {
                total += double.Parse(dgvOutRec.Rows[i].Cells["colOutAmount"].Value.ToString());
            }
            lbloutTotal.Text = total.ToString() + "元"; 
        }

        private void btninTotal_Click(object sender, EventArgs e)
        {
            double total = 0;
            int i;
            for (i = 0; i < dgvInRec.Rows.Count; i++)
            {
                total += double.Parse(dgvInRec.Rows[i].Cells["colInAmount"].Value.ToString());
            }
            lblinTotal.Text = total.ToString() + "元"; 
        }
        */
        private void tsbtnLogIn_Click(object sender, EventArgs e)
        {
            tsmiLogin.PerformClick();
        }

        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            tsmiExit.PerformClick();
        }

        private void tsmiChangeUser_Click(object sender, EventArgs e)
        {
            this.LogIn();
        }

       /* private void btnDelBankRec_Click(object sender, EventArgs e)
        {
            //判断是否有选中的银行卡记录
            if (this.dgvCardOps.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "没有选中任何记录！", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //获取选中记录的数据
            BankCardClass  rec=new BankCardClass ();
            rec = (BankCardClass) this.dgvCardOps.SelectedRows[0].Tag;
            //再次确认删除操作
            if (MessageBox.Show(this, "真的要删除这条银行卡记录----" + rec.CardNo + "？", "提示",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //删除记录
                if (BankCardSQL.DeleteBank( rec.CardNo ))
                {
                    //删除成功，从表格移除
                    this.dgvCardOps.Rows.Remove(this.dgvCardOps.SelectedRows[0]);
                }
                else
                {
                    //删除失败，则提示
                    MessageBox.Show(this, "删除银行卡记录----" + rec.CardNo + ",失败！", "提示",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }*/

        private void tsmiHelp_Click(object sender, EventArgs e)
        {
            HelpForm hp = new HelpForm();
            hp.Show();
        }







    }
}
