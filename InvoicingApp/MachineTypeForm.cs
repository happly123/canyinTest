//***********************************************************************
//* 系统名称	    ：  长白ERP系统
//* 功能模块	    ：  系统信息
//* 功能画面		：  器械分类
//* 画面名称	    ：  MachineTypeForm
//* 完成年月日      ：  2010/07/14
//* 作者		    ：  代国明
//* Version		    ：  1.00
//* ---------------------------------------------------------------------
//* 前提		：SQL SERVER,.NetFramework3.0
//***********************************************************************
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
    //***********************************************************************
    /// <summary>
    ///器械分类功能
    /// </summary>
    /// <history>
    ///     完成信息：代国明      2010/07/14 完成  
    ///     更新信息：
    /// </history>
    //***********************************************************************
    public partial class MachineTypeForm : Form
    {
        /// <summary>
        /// 数据库连接句柄
        /// </summary>
        DataAccess dataAccess = null;

        /// <summary>
        /// 画面状态
        /// </summary>
        DataType dataType = DataType.None;

        /// <summary>
        /// 结果符，默认-1
        /// </summary>
        int result = -1;

        /// <summary>
        /// TreeView节点选中标识
        /// </summary>
        string flag = null;

        /// <summary>
        /// 器械分类实体类
        /// </summary>
        EntityApparatus entityApparatus = null;

        TreeNode trNode = null;

        Boolean bs = true;

        public MachineTypeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 画面状态枚举
        /// </summary>
        public enum DataType
        {
            /// <summary>
            /// 更新
            /// </summary>
            Update = 0x0001,

            /// <summary>
            /// 添加
            /// </summary>
            Insert = 0x0002,

            /// <summary>
            /// 无状态
            /// </summary>
            None = 0x0003,

            /// <summary>
            /// 成功
            /// </summary>
            Success = 0x004,

        }

        //*******************************************************************
        /// <summary>
        /// 设置按钮，文本框状态
        /// </summary>
        /// <history>
        ///     完成信息：代国明      2010/07/14 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void setButtonState()
        {
            switch (dataType)
            {
                case DataType.None:
                case DataType.Success:
                    txt_apparatus_name.ReadOnly = true;
                    txt_apparatus_code.ReadOnly = true;
                    cmb_apparatus_type.Enabled = false;

                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    break;
                case DataType.Insert:
                    txt_apparatus_name.ReadOnly = false;
                    txt_apparatus_code.ReadOnly = false;
                    cmb_apparatus_type.Enabled = true;

                    //添加时，同时清空文本框
                    txt_apparatus_code.Text = "";
                    txt_apparatus_name.Text = "";
                    cmb_apparatus_type.SelectedIndex = 0;

                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    break;
                case DataType.Update:
                    txt_apparatus_name.ReadOnly = false;
                    txt_apparatus_code.ReadOnly = true;
                    cmb_apparatus_type.Enabled = true;

                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    break;
                default:
                    txt_apparatus_name.ReadOnly = true;
                    txt_apparatus_code.ReadOnly = true;
                    cmb_apparatus_type.Enabled = false;

                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    break;
            }
        }

        private TreeNode FindNode(TreeNode tnParent, string strValue, string strValue1, string strValue2)
        {
            if (tnParent == null) return null;

            //截取选中字符串     
            string[] arraystring = tnParent.Text.ToString().Split(new string[] { "|", "|", "|" }, StringSplitOptions.None);

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
                        MessageBox.Show("不可以输入非法字符，请重新输入！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                tnRet = FindNode(tn, txt_apparatus_code_select.Text.Trim(), txt_apparatus_name_select.Text.Trim(), cmb_apparatus_type_Select.SelectedItem.ToString().Trim());
                if (tnRet != null)
                {                    
                    tnRet.Expand();
                    break;
                }
            }

            if (bs)
            {
                MessageBox.Show("数据不存在，请查看输入的条件是否正确！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            tv_tc_apparatus.SelectedNode = null;

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
            BaindingTree();
        }

        private void BaindingTree()
        {
            //下拉列表初始化
            cmb_apparatus_type_Select.SelectedIndex = 0;

            //下拉列表初始化
            cmb_apparatus_type.SelectedIndex = 0;

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

                //设定按钮状态
                dataType = DataType.None;
                setButtonState();

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

        //***********************************************************************
        /// <summary>
        /// 修改按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/14 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            if (tv_tc_apparatus.SelectedNode == null)
            {
                MessageBox.Show("请选择想要更新的节点！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (tv_tc_apparatus.SelectedNode.Level == 0)
            {
                MessageBox.Show("根节点不可更新，请重新选择！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //设定按钮状态
            dataType = DataType.Update;
            setButtonState();

            if (tv_tc_apparatus.SelectedNode.Level == 1)
            {
                cmb_apparatus_type.Enabled = false;
            }

            if (tv_tc_apparatus.SelectedNode.Level == 2)
            {
                cmb_apparatus_type.Enabled = true;
            }
        }

        //***********************************************************************
        /// <summary>
        /// 确定按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/14 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (Control control in groupBox2.Controls)
            {
                if (control is TextBox)
                {
                    if (Util.CheckRegex(control.Text.Trim()) && !((TextBox)control).ReadOnly)
                    {
                        MessageBox.Show("不可以输入非法字符！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        control.Focus();
                        return;
                    }
                }
            }
            
            if(txt_apparatus_code.Text.Trim() == string.Empty)
            {
                MessageBox.Show("分类编号不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_apparatus_code.Focus();
                return;
            }

            if(txt_apparatus_name.Text.Trim() == string.Empty)
            {
                MessageBox.Show("分类名称不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_apparatus_name.Focus();
                return;
            }

            if (tv_tc_apparatus.SelectedNode == null)
            {
                MessageBox.Show("请选择想要添加或更新的节点！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                tv_tc_apparatus.Focus();
                return;
            }           

            trNode = new TreeNode();
            trNode.Name = this.tv_tc_apparatus.SelectedNode.Name;

            if (dataType == DataType.Update)
            {
                string[] arraystring = this.tv_tc_apparatus.SelectedNode.Text.ToString().Split(new string[] { "|", "|", "|" }, StringSplitOptions.None);

                //取得数据赋值文本框
                txt_apparatus_code.Text = arraystring[0].ToString();

                flag = this.tv_tc_apparatus.SelectedNode.Name.ToString();

                //取得实体类
                entityApparatus = new EntityApparatus();

                //赋值实体类
                entityApparatus.Apparatus_id = Convert.ToInt32(this.tv_tc_apparatus.SelectedNode.Name.ToString().Trim());
                entityApparatus.Apparatus_code = txt_apparatus_code.Text.ToString().Trim();
                entityApparatus.Apparatus_name = txt_apparatus_name.Text.ToString().Trim();
                entityApparatus.Apparatus_yxm = Util.IndexCode(txt_apparatus_name.Text.ToString().Trim());

                if (this.tv_tc_apparatus.SelectedNode.Level == 2)
                {
                    if (cmb_apparatus_type.SelectedIndex != 0)
                    {
                        entityApparatus.Apparatus_type = cmb_apparatus_type.SelectedItem.ToString().Trim();
                    }
                    else
                    {
                        MessageBox.Show("请选择管理类别，重新选择！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmb_apparatus_type.Focus();
                        return;
                    }
                }
                else
                {                    
                    this.cmb_apparatus_type.Enabled = false;
                }
            }
            else if (dataType == DataType.Insert)
            {
                foreach (TreeNode tr in this.tv_tc_apparatus.Nodes)
                {
                    foreach (TreeNode tr1 in tr.Nodes)
                    {
                        string[] arraystring1 = tr1.Text.ToString().Split(new string[] { "|", "|", "|" }, StringSplitOptions.None);
                        if (txt_apparatus_code.Text.Trim() == arraystring1[0].Trim())
                        {
                            MessageBox.Show("您输入的分类编号已经存在，请更改分类编号后再保存！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_apparatus_code.Focus();
                            return;
                        }

                        foreach (TreeNode tr2 in tr1.Nodes)
                        {
                            string[] arraystring2 = tr2.Text.ToString().Split(new string[] { "|", "|", "|" }, StringSplitOptions.None);
                            if (txt_apparatus_code.Text.Trim() == arraystring2[0].Trim())
                            {
                                MessageBox.Show("您输入的分类编号已经存在，请更改分类编号后再保存！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txt_apparatus_code.Focus();
                                return;
                            }
                        }
                    }
                }

                //取得实体类
                entityApparatus = new EntityApparatus();

                //取得树节点的编号长度加 2
                string[] arraystring = this.tv_tc_apparatus.SelectedNode.Text.ToString().Split(new string[] { "|", "|", "|" }, StringSplitOptions.None);

                int length = arraystring[0].Length + 2;

                if (this.tv_tc_apparatus.SelectedNode.Level == 0)
                {
                    if (txt_apparatus_code.Text.Length == 4)
                    {
                        //赋值实体类
                        entityApparatus.Apparatus_code = txt_apparatus_code.Text.ToString().Trim();
                        entityApparatus.Apparatus_name = txt_apparatus_name.Text.Trim();
                        cmb_apparatus_type.Enabled = false;

                        //赋值实体类
                        entityApparatus.Apparatus_yxm = Util.IndexCode(txt_apparatus_name.Text.ToString().Trim());
                    }
                    else
                    {
                        MessageBox.Show("您输入的分类编号应为四位！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_apparatus_code.Focus();
                        return;
                    }
                }
                else
                {
                    //判断所添主键长度和值是否符合规范
                    if (txt_apparatus_code.Text.ToString().Length == length && txt_apparatus_code.Text.StartsWith(arraystring[0].ToString()))
                    {
                        //赋值实体类
                        entityApparatus.Apparatus_code = txt_apparatus_code.Text.ToString().Trim();
                        entityApparatus.Apparatus_name = txt_apparatus_name.Text.Trim();

                        if (this.tv_tc_apparatus.SelectedNode.Level == 1)
                        {
                            if (cmb_apparatus_type.SelectedIndex != 0)
                            {
                                entityApparatus.Apparatus_type = cmb_apparatus_type.SelectedItem.ToString().Trim();
                            }
                            else
                            {
                                MessageBox.Show("请选择管理类别，重新选择！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cmb_apparatus_type.Focus();
                                return;
                            }
                        }
                        else if (this.tv_tc_apparatus.SelectedNode.Level == 0)
                        {
                            cmb_apparatus_type.Enabled = false;
                        }

                        //判断所选节点是否有父亲节点
                        if (this.tv_tc_apparatus.SelectedNode.Level != 0)
                        {
                            //赋值实体类
                            entityApparatus.Apparatus_upcode = arraystring[0].ToString().Trim();
                        }

                        //赋值实体类
                        entityApparatus.Apparatus_yxm = Util.IndexCode(txt_apparatus_name.Text.ToString().Trim());

                    }
                    else
                    {
                        MessageBox.Show("分类编号必须以上级编号开始的2位数字！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_apparatus_code.Focus();
                        return;
                    }

                }
            }

            try
            {
                result = -1;

                //如果是添加
                if (dataType == DataType.Insert)
                {

                    //打开数据库连接
                    dataAccess = new DataAccess();
                    dataAccess.Open();

                    //取得操作类
                    GetData getData = new GetData(dataAccess.Connection);

                    //取得结果符
                    result = getData.InsertApparatusRow(entityApparatus);
                }

                //如果是更新
                else if (dataType == DataType.Update)
                {

                    //打开数据库连接
                    dataAccess = new DataAccess();
                    dataAccess.Open();

                    //打开事务
                    dataAccess.BeginTransaction();

                    //取得操作类
                    GetData getData = new GetData(dataAccess.Connection, dataAccess.Transaction);

                    //取得结果符
                    result = getData.UpdateApparatusTable(entityApparatus);

                    

                    //提交事务
                    dataAccess.Commit();
                }

                if (result == 0)
                {

                    MessageBox.Show("数据已经保存成功！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("数据已经保存失败！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                if (dataAccess.Transaction != null)
                {

                    //回滚
                    dataAccess.Rollback();
                }

                //提示错误
                MessageBox.Show("数据添加时发生错误，请检查数据库！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);           
            }
            finally
            {

                //关闭数据库连接
                dataAccess.Close();
               
                //if (result == -1)
                //{
                //    MessageBox.Show("数据添加时发生错误，请检查数据库！", "添加失败：;", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}

                //加载数据
                BaindingTree();

                foreach (TreeNode tn in this.tv_tc_apparatus.Nodes)
                {
                    GetSelectNode(tn);
                }

                foreach (TreeNode tr in this.tv_tc_apparatus.Nodes)
                {
                    tr.Expand();
                    foreach (TreeNode tr1 in tr.Nodes)
                    {
                        if (tr1.Name == trNode.Name)
                        {
                            tr1.Expand();
                        }
                    }
                }

            }

            //设置按钮状态
            dataType = DataType.None;
            setButtonState();
        }

        //***********************************************************************
        /// <summary>
        /// 自动选中修改后的节点
        /// </summary>
        /// <param name="t"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/14 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        public void GetSelectNode(TreeNode t)
        {
            if (t.Name == flag)
            {
                this.tv_tc_apparatus.SelectedNode = t;
            }
            if (t.LastNode != null)
            {
                foreach (TreeNode tr in t.Nodes)
                {
                    GetSelectNode(tr);
                }
            }
        }

        //***********************************************************************
        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/14 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //截取字符串
            SubStr();

            //设置按钮状态
            if (this.cmb_apparatus_type.SelectedIndex != 0)
            {
                dataType = DataType.Success;
                setButtonState();
                //btnAdd.Enabled = false;
            }
            else
            {
                dataType = DataType.Success;
                setButtonState();
            }


        }

        //***********************************************************************
        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/14 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //截取选中字符串     
            string[] arraystring = null;
            if (this.tv_tc_apparatus.SelectedNode == null)
            {
                MessageBox.Show("请选择一个节点后，再点击增加按钮！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                //截取选中字符串     
                arraystring = this.tv_tc_apparatus.SelectedNode.Text.ToString().Split(new string[] { "|", "|", "|" }, StringSplitOptions.None);
            }

            //选中节点
            if (arraystring.Length == 3)
            {
                MessageBox.Show("不能在最末级增加节点，请重新选择节点后再增加！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (this.tv_tc_apparatus.SelectedNode.Level == 0)
            {
                //设置按钮状态
                dataType = DataType.Insert;
                setButtonState();
                txt_apparatus_code.Text = "";
                this.cmb_apparatus_type.Enabled = false;
            }
            else
            {
                //设置按钮状态
                dataType = DataType.Insert;
                setButtonState();
                string nodeCode = string.Empty;
                nodeCode = tv_tc_apparatus.SelectedNode.Text.Split('|')[0];

                txt_apparatus_code.Text = nodeCode;
            }
            txt_apparatus_code.Focus();
        }

        //***********************************************************************
        /// <summary>
        /// 删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/14 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //设置按钮状态
            dataType = DataType.None;
            setButtonState();

            //结果符
            result = -1;

            //如果选择节点不为空
            if (this.tv_tc_apparatus.SelectedNode != null)
            {
                //如果选择不是最后一级节点，提示
                if (this.tv_tc_apparatus.SelectedNode.LastNode != null)
                {
                    MessageBox.Show("只能删除最末级节点，请重新选择要删除的节点！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //如果选择节点不为空
                if (this.tv_tc_apparatus.SelectedNode.ToString() == null)
                {
                    MessageBox.Show("请选择一条要删除的记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //弹出提示，确认删除
                if (MessageBox.Show("您确定要删除该数据吗？", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        //初始化参数类
                        SearchParameter sp = new SearchParameter();

                        //设置主键
                        sp.SetValue(":APPARATUS_ID", this.tv_tc_apparatus.SelectedNode.Name.ToString());

                        //打开数据库
                        dataAccess = new DataAccess();
                        dataAccess.Open();

                        //打开事务
                        dataAccess.BeginTransaction();

                        //取得操作类
                        GetData getData = new GetData(dataAccess.Connection, dataAccess.Transaction);

                        //取得结果符
                        result = getData.DeleteRow("TC_APPARATUS", sp);

                        //提交事务
                        dataAccess.Commit();
                    }
                    catch (Exception ex)
                    {
                        //回滚
                        dataAccess.Rollback();
                        MessageBox.Show(ex.Message);

                    }
                    finally
                    {
                        //关闭数据库连接
                        dataAccess.Close();

                        //判断结果符，0：成功；-1：失败
                        if (result == 0)
                        {
                            MessageBox.Show("数据已经被成功删除！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.tv_tc_apparatus.SelectedNode.Remove();                            
                        }
                        else
                        {
                            MessageBox.Show("数据删除时发生错误，请检查数据库！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }

                }

            }
            else
            {
                MessageBox.Show("请选择一条要删除的记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //***********************************************************************
        /// <summary>
        /// 选中TreeView，随时更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/14 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void tv_tc_apparatus_AfterSelect(object sender, TreeViewEventArgs e)
        {
            SubStr();
            dataType = DataType.None;
            setButtonState();

            if (this.tv_tc_apparatus.SelectedNode.Level == 0)
            {
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }

        }

        //***********************************************************************
        /// <summary>
        /// 截取字符串
        /// </summary>        
        /// <history>
        ///    完成信息：代国明      2010/07/14 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        public void SubStr()
        {
            if (this.tv_tc_apparatus.SelectedNode != null)
            {
                //截取选中字符串     
                string[] arraystring = this.tv_tc_apparatus.SelectedNode.Text.ToString().Split(new string[] { "|", "|", "|" }, StringSplitOptions.None);

                //判断选中字符串的长度
                if (arraystring.Length == 2)
                {
                    //为文本框赋值
                    this.txt_apparatus_code.Text = arraystring[0].ToString();
                    this.txt_apparatus_name.Text = arraystring[1].ToString();
                    cmb_apparatus_type.SelectedIndex = 0;
                }
                else if (arraystring.Length == 3)
                {
                    this.txt_apparatus_code.Text = arraystring[0].ToString();
                    this.txt_apparatus_name.Text = arraystring[1].ToString();
                    this.cmb_apparatus_type.SelectedItem = arraystring[2].ToString();
                }
            }
            else
            {
                MessageBox.Show("请选择想要增加、更新、删除的节点！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txt_apparatus_code_select.Text = "";
            this.txt_apparatus_name_select.Text = "";
            //this.cmb_apparatus_type.SelectedIndex = 0;
            cmb_apparatus_type_Select.SelectedIndex = 0;
        }

    }
}
