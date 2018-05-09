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
//***********************************************************************
//* 系统名称	    ：  长白ERP系统
//* 功能模块	    ：  系统信息
//* 功能画面		：  员工信息管理功能
//* 画面名称	    ：  InitStorageForm
//* 完成年月日      ：  2010/07/13
//* 作者		    ：  吴小科
//* Version		    ：  1.00
//* ---------------------------------------------------------------------
//* 前提		：SQL SERVER,.NetFramework3.0
//***********************************************************************
namespace InvoicingApp
{   //***********************************************************************
    /// <summary>
    ///员工信息管理功能
    /// </summary>
    /// <history>
    ///     完成信息：吴小科      2010/07/13 完成  
    ///     更新信息：
    /// </history>
    //***********************************************************************
    public partial class StaffForm : Form
    {   //数据库连接句柄
        DataAccess dataAccess = null;
        /// <summary>
        /// 员工姓名初始化
        /// </summary>
        public string staffName = string.Empty;
        public string staffCode = string.Empty;
        
        public StaffForm()
        {  
            InitializeComponent();
            this.dataGridView_staff.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 243, 251);
        }
        //***********************************************************************
        /// <summary>
        /// 画面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/07/13 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void StaffForm_Load(object sender, EventArgs e)
        {
            if (LoginUser.UserAuthority == "2")
            {
                btnInsert.Visible = false;
               
            }
            try
            {
                //打开数据库
                dataAccess = new DataAccess();
                dataAccess.Open();
                //获取操作类
                GetData getData = new GetData(dataAccess.Connection);
                //获取绑定数据表
                DataTable dtStaff = getData.GetSingleTable("tc_staff");
                //添加序列号
                int countNumber = 0;
                dtStaff.Columns.Add("num", typeof(int));
                for (int i = 0; i < dtStaff.Rows.Count; i++)
                {
                    dtStaff.Rows[i]["num"] = ++countNumber;

                }
                //绑定数据
                dataGridView_staff.DataSource = dtStaff;
            }
            catch (Exception ex)
            {
                MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {   //关闭数据库
                dataAccess.Close();
            }
        }


        //***********************************************************************
        /// <summary>
        /// 选择员工信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/07/16 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btn_Confirm_Click(object sender, EventArgs e)
        {   
            if (dataGridView_staff.SelectedRows != null && dataGridView_staff.SelectedRows.Count == 1)
            {
                //员工姓名赋值
                staffName = dataGridView_staff.SelectedRows[0].Cells["staff_name"].Value.ToString();
                staffCode = dataGridView_staff.SelectedRows[0].Cells["staff_code"].Value.ToString();
                this.Close();

            }
            else
            {
                MessageBox.Show("请选择一条记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }
        //***********************************************************************
        /// <summary>
        /// 查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/07/16 完成   
        ///    更新信息：吴小科      2010/07/22 修改
        /// </history>
        //***********************************************************************
        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach (Control control in groupBox1.Controls)
            {
                if (control is TextBox)
                {
                    if (Util.CheckRegex(control.Text.Trim()))
                    {
                        MessageBox.Show("不可以输入非法字符，请重新输入！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        control.Focus();
                        return;
                    }
                }
            }
            try
            {
                //设置查询条件参数
                SearchParameter sp = new SearchParameter();
                if (textBox_staffName.Text.Trim() != string.Empty)
                {   //查询条件参数赋值
                    sp.SetValue(":staff_name", textBox_staffName.Text);
                }
                if (textBox_staff_yxm.Text.Trim() != string.Empty)
                {   //查询条件参数赋值
                    sp.SetValue(":staff_yxm", textBox_staff_yxm.Text);
                }
                //打开数据库
                dataAccess = new DataAccess();
                dataAccess.Open();
                //获取操作类
                GetData getData = new GetData(dataAccess.Connection);
                //返回绑定数据表
                DataTable dtStaff = getData.GetSingleTableByCondition("tc_staff", sp);
                if (dtStaff == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //添加序列号
                int countNumber = 0;
                dtStaff.Columns.Add("num", typeof(int));
                for (int i = 0; i < dtStaff.Rows.Count; i++)
                {
                    dtStaff.Rows[i]["num"] = ++countNumber;

                }
                //绑定数据
                dataGridView_staff.DataSource = dtStaff;
                if (dataGridView_staff.Rows.Count == 0)
                {
                    MessageBox.Show("数据不存在，请查看输入的条件是否正确！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            finally
            {
                //关闭数据库
                dataAccess.Close();

            }
        }
        //***********************************************************************
        /// <summary>
        /// 关闭员工信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/07/24 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //***********************************************************************
        /// <summary>
        /// 双击选择员工信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/07/16 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void dataGridView_staff_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1 || e.ColumnIndex <= -1)//双击表头或列头时不起作用   
            {
                return;
            }

            if (dataGridView_staff.SelectedRows != null && dataGridView_staff.SelectedRows.Count == 1)
            {
                //员工姓名赋值
                staffName = dataGridView_staff.SelectedRows[0].Cells["staff_name"].Value.ToString();
                staffCode = dataGridView_staff.SelectedRows[0].Cells["staff_code"].Value.ToString();

                this.Close();

            }
            else
            {
                MessageBox.Show("请选择一条记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
          //***********************************************************************
        /// <summary>
        /// 数据重新加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/08/06 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void DataBanding()
        {
            try
            {
                //打开数据库
                dataAccess = new DataAccess();
                dataAccess.Open();
                //获取操作类
                GetData getData = new GetData(dataAccess.Connection);
                //获取绑定数据表
                DataTable dtStaff = getData.GetSingleTable("tc_staff");
                //添加序列号
                int countNumber = 0;
                dtStaff.Columns.Add("num", typeof(int));
                for (int i = 0; i < dtStaff.Rows.Count; i++)
                {
                    dtStaff.Rows[i]["num"] = ++countNumber;

                }
                //绑定数据
                dataGridView_staff.DataSource = dtStaff;
            }
            catch (Exception ex)
            {
                MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {   //关闭数据库
                dataAccess.Close();
            }
 
        }
        //***********************************************************************
        /// <summary>
        /// 添加员工信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/08/06 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnInsert_Click(object sender, EventArgs e)
        {
            EmpArchivesForm empArchives = new EmpArchivesForm();
            empArchives.ShowDialog();
            DataBanding();

        }
        //***********************************************************************
        /// <summary>
        /// 重置按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/08/09 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox_staffName.Text = "";
            textBox_staff_yxm.Text = "";
        }

        private void dataGridView_staff_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView_staff.Rows.Count; i++)
            {
                dataGridView_staff.Rows[i].Cells["num"].Value = i + 1;
            }
        }
    }
}
    
