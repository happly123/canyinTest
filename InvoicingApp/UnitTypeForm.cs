//***********************************************************************
//* 系统名称	    ：  长白ERP系统
//* 功能模块	    ：  系统信息
//* 功能画面		：  计量单位
//* 画面名称	    ：  UnitTypeForm
//* 完成年月日      ：  2010/07/15
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
using InvoicingUtil;
using DataAccesses;

namespace InvoicingApp
{
    //***********************************************************************
    /// <summary>
    ///计量单位
    /// </summary>
    /// <history>
    ///     完成信息：代国明      2010/07/15 完成  
    ///     更新信息：
    /// </history>
    //***********************************************************************
    public partial class UnitTypeForm : Form
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
        /// 数据表
        /// </summary>
        DataTable dtUnit = null;

        /// <summary>
        /// 结果符，默认-1
        /// </summary>
        int result = -1;

        /// <summary>
        /// 选择记录的行号
        /// </summary>
        int countNum = 0;

        /// <summary>
        /// 计量单位实体类
        /// </summary>
        EntityUnit unitEntity = null;

        public UnitTypeForm()
        {
            InitializeComponent();

            this.dgvUnit.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 243, 251);
        }

        //*******************************************************************
        /// <summary>
        /// 取得格式化数据源
        /// </summary>
        /// <param name="dt">数据源表</param>
        /// <returns>格式化完成的表</returns>
        /// <history>
        ///     完成信息：代国明      2010/07/15 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private DataTable GetUnitTable(DataTable dt)
        {
            dt = new DataTable();

            dt.Columns.Add("unit_code", typeof(string));
            dt.Columns.Add("unit_name", typeof(string));
            dt.Columns.Add("unit_yxm", typeof(string));

            return dt;
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

        }

        //*******************************************************************
        /// <summary>
        /// 设置按钮，文本框状态
        /// </summary>
        /// <history>
        ///     完成信息：代国明      2010/07/15 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void setButtonState()
        {
            switch (dataType)
            {
                case DataType.None:
                    this.txt_unit_name.ReadOnly = true;

                    this.btnAdd.Enabled = true;
                    this.btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    this.btnSave.Enabled = false;
                    this.btnExit.Enabled = false;
                    break;
                case DataType.Insert:
                    this.txt_unit_name.ReadOnly = false;

                    //添加时，同时清空文本框                    
                    this.txt_unit_name.Text = "";
                    this.txt_unit_yxm.Text = "";

                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = true;
                    btnExit.Enabled = true;
                    break;
                case DataType.Update:
                    this.txt_unit_name.ReadOnly = false;


                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = true;
                    btnExit.Enabled = true;
                    break;
                default:
                    this.txt_unit_name.ReadOnly = true;


                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnSave.Enabled = false;
                    btnExit.Enabled = false;
                    break;
            }
        }

        //*******************************************************************
        /// <summary>
        /// 绑定画面
        /// </summary>
        /// <history>
        ///     完成信息：代国明      2010/07/15 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void BandingDgvUnit()
        {
            try
            {

                //打开数据库连接
                dataAccess = new DataAccess();
                dataAccess.Open();

                //取得操作类
                GetData getData = new GetData(dataAccess.Connection);

                //取得单表数据
                dtUnit = getData.GetSingleTable("tc_unit");

                dtUnit.Columns.Add("index");

                for (int i = 0; i < dtUnit.Rows.Count; i++)
                {
                    dtUnit.Rows[i]["index"] = i + 1;
                }

                //绑定画面
                dgvUnit.DataSource = dtUnit;

                if (dgvUnit != null && dgvUnit.Rows.Count > 0 && countNum != 0)
                {
                    dgvUnit.Rows[0].Selected = false;
                    dgvUnit.Rows[countNum].Selected = true;
                    dgvUnit.FirstDisplayedScrollingRowIndex = countNum;
                }
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

        //***********************************************************************
        /// <summary>
        /// 画面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/15 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void UnitTypeForm_Load(object sender, EventArgs e)
        {
            //绑定画面
            BandingDgvUnit();

            //设定按钮状态
            dataType = DataType.None;
            setButtonState();
        }

        //***********************************************************************
        /// <summary>
        /// 选择画面数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/15 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void dgvUnit_SelectionChanged(object sender, EventArgs e)
        {

            //设定按钮状态
            dataType = DataType.None;
            setButtonState();

            //判断画面数据不为空
            if (dgvUnit != null && dgvUnit.SelectedRows.Count != 0)
            {

                //取得数据赋值文本框
                this.txt_unit_name.Text = dgvUnit.SelectedRows[0].Cells["unit_name"].Value.ToString();
            }
        }

        //***********************************************************************
        /// <summary>
        /// 触发Text更改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/15 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void txt_unit_name_TextChanged(object sender, EventArgs e)
        {
            //为文本框赋值
            txt_unit_yxm.Text = Util.IndexCode(txt_unit_name.Text.ToString().Trim());
        }

        //***********************************************************************
        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/15 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txt_unit_name.Focus();

            //设定按钮状态
            dataType = DataType.Insert;
            setButtonState();
        }

        //***********************************************************************
        /// <summary>
        /// 修改按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/15 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //如果选择多条数据，提示
            if (dgvUnit.SelectedRows.Count > 1)
            {
                MessageBox.Show("只能选择一条要修改的记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //如过画面中不存在数据，提示
            if (dgvUnit.SelectedRows.Count < 1)
            {
                MessageBox.Show("请选择一条要修改的记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            //设定按钮状态
            dataType = DataType.Update;
            setButtonState();
        }

        //***********************************************************************
        /// <summary>
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/15 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnSave_Click(object sender, EventArgs e)
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

            if (this.txt_unit_name.Text.Trim() == string.Empty)
            {
                MessageBox.Show("计量单位不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txt_unit_name.Focus();
                return;
            }            

            try
            {

                result = -1;

                //如果是添加
                if (dataType == DataType.Insert)
                {
                    //取得实体类
                    unitEntity = new EntityUnit();

                    //赋值实体类                   
                    unitEntity.Unit_name = this.txt_unit_name.Text.ToString().Trim();
                    unitEntity.Unit_yxm = this.txt_unit_yxm.Text.ToString().Trim();

                    //打开数据库连接
                    dataAccess = new DataAccess();
                    dataAccess.Open();

                    MakePrimaryKey mpk = new MakePrimaryKey(dataAccess.Connection, dataAccess.Transaction);
                    unitEntity.Unit_code = mpk.MakeCode("计量单位");

                    //取得操作类
                    GetData getData = new GetData(dataAccess.Connection);

                    if (getData.InsertIsOnly("tc_unit", "unit_name", txt_unit_name.Text.ToString()))
                    {
                        MessageBox.Show("您输入的计量单位已经存在！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_unit_name.Focus();
                        return;
                    }

                    //取得结果符
                    result = getData.InsertUnitRow(unitEntity);

                    if (result == 0)
                    {
                        MessageBox.Show("数据已经保存成功！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("操作添加时发生错误，请检查数据库！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

                //如果是更新
                else if (dataType == DataType.Update)
                {

                    countNum = dgvUnit.SelectedRows[0].Index;
                    //取得树体类
                    unitEntity = new EntityUnit();

                    //赋值实体类
                    unitEntity.Unit_code = dgvUnit.SelectedRows[0].Cells["unit_code"].Value.ToString();
                    unitEntity.Unit_name = txt_unit_name.Text.ToString().Trim();
                    unitEntity.Unit_yxm = txt_unit_yxm.Text.ToString().Trim();

                    //打开数据库连接
                    dataAccess = new DataAccess();
                    dataAccess.Open();

                    //打开事务
                    dataAccess.BeginTransaction();

                    //取得操作类
                    GetData getData = new GetData(dataAccess.Connection, dataAccess.Transaction);

                    if (getData.UpdateIsOnly("tc_unit", "unit_code", unitEntity.Unit_code, "unit_name", txt_unit_name.Text.ToString()))
                    {
                        MessageBox.Show("您输入的计量单位已经存在！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_unit_name.Focus();
                        return;
                    }

                    //取得结果符
                    result = getData.UpdateUnitTable(unitEntity);

                     if (result == 0)
                    {
                        MessageBox.Show("数据已经保存成功！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("操作添加时发生错误，请检查数据库！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    //提交事务
                    dataAccess.Commit();
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

                //设置按钮状态
                dataType = DataType.None;
                setButtonState();

                //重新加载画面
                BandingDgvUnit();

            }
        }

        //***********************************************************************
        /// <summary>
        /// 删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/15 完成   
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
            countNum = 0;

            //如果选择多条数据删除，提示
            if (dgvUnit.SelectedRows.Count > 1)
            {
                MessageBox.Show("只能选择一条要删除的记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //如过画面中不存在数据，提示
            if (dgvUnit.SelectedRows.Count < 1)
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
                    sp.SetValue(":UNIT_CODE", dgvUnit.SelectedRows[0].Cells["unit_code"].Value.ToString());

                    //打开数据库
                    dataAccess = new DataAccess();
                    dataAccess.Open();

                    //打开事务
                    dataAccess.BeginTransaction();

                    //取得操作类
                    GetData getData = new GetData(dataAccess.Connection, dataAccess.Transaction);

                    //取得结果符
                    result = getData.DeleteRow("TC_UNIT", sp);

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

                        //加载画面
                        BandingDgvUnit();
                    }
                    else
                    {
                        MessageBox.Show("数据删除时发生错误，请检查数据库！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

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
        ///    完成信息：代国明      2010/07/15 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnExit_Click(object sender, EventArgs e)
        {
            //设置按钮状态
            dataType = DataType.None;
            setButtonState();

            //判断画面数据不为空
            if (dgvUnit != null && dgvUnit.SelectedRows.Count != 0)
            {

                //取得画面数据赋值文本框                
                this.txt_unit_name.Text = dgvUnit.SelectedRows[0].Cells["unit_name"].Value.ToString();
            }
            dgvUnit.Focus();
        }

        private void dgvUnit_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvUnit.Rows.Count; i++)
            {
                dgvUnit.Rows[i].Cells["index"].Value = i + 1;
            }
        }

    }
}
