using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataAccesses;
using InvoicingUtil;

namespace InvoicingApp
{
    public partial class machineTypeDialogForm : Form
    {

        /// <summary>
        /// 数据库连接句柄
        /// </summary>
        DataAccess dataAccess = null;

        /// <summary>
        /// 定义返回字符串
        /// </summary>
        private string child_apparatus_name = string.Empty;

        private Boolean bs = true;

        public string Child_apparatus_name
        {
            get { return child_apparatus_name; }
            set { child_apparatus_name = value; }
        }

        public machineTypeDialogForm()
        {
            InitializeComponent();
        }
        //***********************************************************************
        /// <summary>
        /// 查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/14 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnFind_Click(object sender, EventArgs e)
        {
            foreach (Control control in groupBox1.Controls)
            {
                if (control is TextBox)
                {
                    if (Util.CheckRegex(control.Text.Trim()) && !((TextBox)control).ReadOnly)
                    {
                        MessageBox.Show("不可以输入非法字符，请重新输入！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        control.Focus();
                        return;
                    }
                }
            }
            bs = true;

            foreach (TreeNode tr in tv_tc_apparatus.Nodes)
            {
                tr.ForeColor = Color.Black;
                foreach (TreeNode tr1 in tr.Nodes)
                {
                    tr1.ForeColor = Color.Black;
                    foreach (TreeNode tr2 in tr1.Nodes)
                    {
                        tr2.ForeColor = Color.Black;
                    }
                }
            }
            TreeNode tnRet = null;

            this.tv_tc_apparatus.CollapseAll();

            foreach (TreeNode tn in tv_tc_apparatus.Nodes)
            {

                tnRet = FindNode(tn, txt_apparatus_code_select.Text, txt_apparatus_name_select.Text, cmb_apparatus_type_Select.SelectedItem.ToString());
                if (tnRet != null)
                {
                    tnRet.Expand();
                    break;
                }
            }

            if (bs)
            {
                MessageBox.Show("数据不存在，请查看输入的条件是否正确！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return ;
            }

            tv_tc_apparatus.SelectedNode = null;

        }

        private TreeNode FindNode(TreeNode tnParent, string strValue, string strValue1, string strValue2)
        {
            if (tnParent == null) return null;

            //截取选中字符串     
            string[] arraystring = tnParent.Text.ToString().Split(new string[] { "|", "|", "|" }, StringSplitOptions.None);

            string input = strValue + strValue1 + strValue2;

            if (cmb_apparatus_type_Select.SelectedIndex == 0)
            {
                strValue2 = "";
            }


            if (arraystring.Length == 3)
            {
                if (arraystring[0].IndexOf(strValue) > -1 && arraystring[1].IndexOf(strValue1) > -1 && arraystring[2].IndexOf(strValue2) > -1)
                    return tnParent;
            }
            if (strValue2 == "")
            {
                if (arraystring.Length == 2)
                {
                    if (arraystring[0].IndexOf(strValue) > -1 && arraystring[1].IndexOf(strValue1) > -1)
                        return tnParent;
                }
            }

            TreeNode tnRet = null;
            foreach (TreeNode tn in tnParent.Nodes)
            {
                tnRet = FindNode(tn, strValue, strValue1, strValue2);
                if (tnRet != null)
                {
                    bs = false;
                    if (tnRet.LastNode == null)
                    {
                        if (tnParent.Parent != null)
                        {
                            tnParent.Parent.Expand();
                        }
                        tnParent.Expand();
                        tnRet.ForeColor = Color.Red;
                        tnRet.Parent.Expand();
                    }
                    else
                    {
                        tnParent.Expand();
                        tnRet.ForeColor = Color.Red;
                        tnRet.Expand();
                    }

                }
            }

            return tnRet;
        }

        //***********************************************************************
        /// <summary>
        /// 画面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/14 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void MachineTypeForm_Load(object sender, EventArgs e)
        {
            cmb_apparatus_type_Select.SelectedIndex = 0;

            try
            {
                //打开数据库连接
                dataAccess = new DataAccess();
                dataAccess.Open();

                //取得操作类
                GetData getData = new GetData(dataAccess.Connection);

                //取得单表数据
                DataTable dt = getData.GetSingleTable("tc_apparatus");
                DataTable dtLast = dt.Clone();

                //对数据按升序排列
                DataRow[] drs = dt.Select("", "apparatus_code ASC");

                for (int i = 0; i < drs.Length; i++)
                {
                    DataRow dr = dtLast.NewRow();
                    dr[0] = drs[i][0];
                    dr[1] = drs[i][1];
                    dr[2] = drs[i][2];
                    dr[3] = drs[i][3];
                    dr[4] = drs[i][4];
                    dr[5] = drs[i][5];
                    dtLast.Rows.Add(dr);
                }

                //绑定画面
                TreeInit(dtLast);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //关闭数据库连接
                dataAccess.Close();
            }

        }
        //*******************************************************************
        /// <summary>
        /// 从一级节点遍历树
        /// </summary>
        /// <history>
        ///     完成信息：代国明      2010/07/14 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        public void TreeInit(DataTable dt)
        {
            //防止treeview绘制
            tv_tc_apparatus.BeginUpdate();

            //将treeview节点清楚
            tv_tc_apparatus.Nodes.Clear();

            //定义上级编码
            string apparatus_upcode = "";
            TreeNode tr0 = null;
            TreeNode tr = null;
            TreeNode tr1 = null;
            tr0 = new TreeNode("医疗器械");
            this.tv_tc_apparatus.Nodes.Add(tr0);

            //遍历新结果集
            foreach (DataRow dr in dt.Rows)
            {

                //如果为一级节点
                if (dr["apparatus_upcode"].ToString() == string.Empty || dr["apparatus_upcode"].ToString() == "")
                {
                    //为其赋值
                    tr = new TreeNode(dr["apparatus_code"].ToString().Trim() + "|" + dr["apparatus_name"].ToString());

                    //为其赋键值
                    tr.Name = dr["apparatus_id"].ToString();

                    //将主键值赋值给变量上级编码
                    apparatus_upcode = dr["apparatus_code"].ToString().Trim();

                    //添加到该节点上
                    tr0.Nodes.Add(tr);
                }

                //如果为二级节点
                else if (dr["apparatus_upcode"].ToString().Trim() == apparatus_upcode && dr["apparatus_type"].ToString() != "")
                {
                    tr1 = new TreeNode(dr["apparatus_code"].ToString() + "|" + dr["apparatus_name"].ToString() + "|" + dr["apparatus_type"].ToString());
                    tr1.Name = dr["apparatus_id"].ToString();

                    tr.Nodes.Add(tr1);
                }

            }
            tr0.Expand();
            //允许控制控件继续绘制
            this.tv_tc_apparatus.EndUpdate();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            MachineTypeForm mf = new MachineTypeForm();
            mf.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (this.tv_tc_apparatus.SelectedNode != null && this.tv_tc_apparatus.SelectedNode.Level == 2)
            {
                string[] str = this.tv_tc_apparatus.SelectedNode.Text.ToString().Split(new string[] { "|", "|", "|" }, StringSplitOptions.None);
                child_apparatus_name = str[1] + "|" + str[2];
                this.Close();
            }
            else
            {
                MessageBox.Show("只能选择最末级节点！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txt_apparatus_code_select.Text = "";
            this.txt_apparatus_name_select.Text = "";
            this.cmb_apparatus_type_Select.SelectedIndex = 0;
        }
    }
}
