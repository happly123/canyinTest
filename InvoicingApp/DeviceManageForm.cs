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
    public partial class DeviceManageForm : Form
    {
        public DeviceManageForm()
        {
            InitializeComponent();
            this.dgvDevice.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 243, 251);
        }

        /// <summary>
        /// 选择记录的行号
        /// </summary>
        int countNum = 0;
        /// <summary>
        /// 数据库连接句柄
        /// </summary>
        DataAccess dataAccess = null;
        /// <summary>
        /// 画面状态
        /// </summary>
        DataType dataType = DataType.None;

        /// <summary>
        /// 实体集
        /// </summary>
        EntityDevice entityDevice;

        DataTable dtPrint;

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
            /// 插入
            /// </summary>
            Insert = 0x0002,
            /// <summary>
            /// 默认
            /// </summary>
            None = 0x0003

        }
        //*******************************************************************
        /// <summary>
        /// 设置按钮，文本框状态
        /// </summary>
        /// <history>
        ///     完成信息：赵毅男      2010/11/5 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void SetButtonState()
        {
            switch (dataType)
            {
                case DataType.None:

                    txtCode.ReadOnly = true;
                    txtName.ReadOnly = true;
                    txtType.ReadOnly = true;
                    txtMake.ReadOnly = true;
                    txtSetPlace.ReadOnly = true;
                    txtUseMethod.ReadOnly = true;
                    txtUser.BackColor = Color.FromArgb(236, 233, 216);
                    txtRemarks.ReadOnly = true;

                    dtpBuyDate.Enabled = false;
                    dtpUseDate.Enabled = false;

                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCommit.Enabled = false;
                    btnCancel.Enabled = false;
                    break;
                case DataType.Insert:

                    txtCode.ReadOnly = false;
                    txtCode.Text = "";
                    txtName.ReadOnly = false;
                    txtName.Text = "";
                    txtType.ReadOnly = false;
                    txtType.Text = "";
                    txtMake.ReadOnly = false;
                    txtMake.Text = "";
                    txtSetPlace.ReadOnly = false;
                    txtSetPlace.Text = "";
                    txtUseMethod.ReadOnly = false;
                    txtUseMethod.Text = "";
                    txtUser.BackColor = Color.FromArgb(255, 255, 255);
                    txtUser.Text = "双击选择维护或使用人...";
                    txtRemarks.ReadOnly = false;
                    txtRemarks.Text = "";

                    dtpBuyDate.Enabled = true;
                    dtpBuyDate.Value = DateTime.Now.Date;
                    dtpUseDate.Enabled = true;
                    dtpUseDate.Value = DateTime.Now.Date;

                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCommit.Enabled = true;
                    btnCancel.Enabled = true;

                    break;
                case DataType.Update:

                    txtCode.ReadOnly = false;
                    txtName.ReadOnly = false;
                    txtType.ReadOnly = false;
                    txtMake.ReadOnly = false;
                    txtSetPlace.ReadOnly = false;
                    txtUseMethod.ReadOnly = false;
                    txtUser.BackColor = Color.FromArgb(255, 255, 255);
                    txtRemarks.ReadOnly = false;

                    dtpBuyDate.Enabled = true;
                    dtpUseDate.Enabled = true;

                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCommit.Enabled = true;
                    btnCancel.Enabled = true;
                    break;

                default:

                    txtCode.ReadOnly = true;
                    txtName.ReadOnly = true;
                    txtType.ReadOnly = true;
                    txtMake.ReadOnly = true;
                    txtSetPlace.ReadOnly = true;
                    txtUseMethod.ReadOnly = true;
                    txtUser.BackColor = Color.FromArgb(236, 233, 216);
                    txtRemarks.ReadOnly = true;

                    dtpBuyDate.Enabled = false;
                    dtpUseDate.Enabled = false;

                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCommit.Enabled = false;
                    btnCancel.Enabled = false;
                    break;
            }
        }

        private void DataGridFlush()
        {
            dataType = DataType.None;
            SetButtonState();
            if (dgvDevice == null || dgvDevice.SelectedRows.Count == 0)
            {
                txtCode.Text = "";
                txtName.Text = "";
                txtType.Text = "";
                txtMake.Text = "";
                txtSetPlace.Text = "";
                txtUseMethod.Text = "";
                txtUser.Text = "";
                txtRemarks.Text = "";

                dtpBuyDate.Value = DateTime.Now.Date;
                dtpUseDate.Value = DateTime.Now.Date;
            }
            else
            {
                txtCode.Text = dgvDevice.SelectedRows[0].Cells["device_code"].Value.ToString();
                txtName.Text = dgvDevice.SelectedRows[0].Cells["device_name"].Value.ToString();
                txtType.Text = dgvDevice.SelectedRows[0].Cells["device_type"].Value.ToString();
                txtMake.Text = dgvDevice.SelectedRows[0].Cells["device_made"].Value.ToString();
                txtSetPlace.Text = dgvDevice.SelectedRows[0].Cells["device_address"].Value.ToString();
                txtUseMethod.Text = dgvDevice.SelectedRows[0].Cells["device_application"].Value.ToString();
                txtUser.Text = dgvDevice.SelectedRows[0].Cells["staff_name"].Value.ToString();
                txtRemarks.Text = dgvDevice.SelectedRows[0].Cells["device_remarks"].Value.ToString();

                dtpBuyDate.Value = DateTime.Parse(dgvDevice.SelectedRows[0].Cells["device_date"].Value.ToString()).Date;
                dtpUseDate.Value = DateTime.Parse(dgvDevice.SelectedRows[0].Cells["device_usedate"].Value.ToString()).Date;
            }


        }

        //*******************************************************************
        /// <summary>
        /// 绑定画面
        /// </summary>
        /// <history>
        ///     完成信息：赵毅男      2010/11/8 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void BandingDgv()
        {
            try
            {
                dataType = DataType.None;
                //打开数据库连接
                dataAccess = new DataAccess();
                dataAccess.Open();

                //取得操作类
                GetData getData = new GetData(dataAccess.Connection);

                DataTable dt = getData.GetSingleTable("TC_DEVICE");

                if (dt == null)
                {
                    MessageBox.Show("数据库连接出错，请查看数据库是否开启！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //添加序列号
                int countNumber = 0;
                dt.Columns.Add("index", typeof(int));
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["index"] = ++countNumber;

                }

                dgvDevice.DataSource = dt;

                if (dgvDevice != null && dgvDevice.Rows.Count > 0 && countNum != 0)
                {
                    dgvDevice.Rows[0].Selected = false;
                    dgvDevice.Rows[countNum].Selected = true;
                    dgvDevice.FirstDisplayedScrollingRowIndex = countNum;
                }
                dtPrint = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作数据时发生错误，请检查数据库是否正常开启！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                //关闭数据库连接
                dataAccess.Close();
            }
        }

        private void FacilityManageForm_Load(object sender, EventArgs e)
        {
            SetButtonState();
            BandingDgv();
            txtCodeSelect.Focus();

        }

        private void dgvDevice_SelectionChanged(object sender, EventArgs e)
        {
            DataGridFlush();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //判断非法字符
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

            try
            {
                dataType = DataType.None;
                SearchParameter sp = new SearchParameter();

                if (!txtCodeSelect.Text.Trim().Equals(string.Empty))
                {
                    sp.SetValue(":device_code", txtCodeSelect.Text.Trim());
                }

                if (!txtNameSelect.Text.Trim().Equals(string.Empty))
                {
                    sp.SetValue(":device_name", txtNameSelect.Text.Trim());
                }

                if (!txtTypeSelect.Text.Trim().Equals(string.Empty))
                {
                    sp.SetValue(":device_type", txtTypeSelect.Text.Trim());
                }

                //打开数据库连接
                dataAccess = new DataAccess();
                dataAccess.Open();

                //取得操作类
                GetData getData = new GetData(dataAccess.Connection);

                DataTable dt = getData.GetSingleTableByCondition("TC_DEVICE", sp);

                if (dt == null)
                {
                    MessageBox.Show("数据库连接出错，请查看数据库是否开启！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //添加序列号
                int countNumber = 0;
                dt.Columns.Add("index", typeof(int));
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["index"] = ++countNumber;

                }

                dgvDevice.DataSource = dt;

                dtPrint = dt;

                //没有数据
                if (dt.Rows.Count == 0)
                {

                    //给出提示
                    MessageBox.Show("数据不存在，请查看输入的条件是否正确！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //取得数据赋值文本框
                    DataGridFlush();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("操作数据时发生错误，请检查数据库是否正常开启！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                //关闭数据库连接
                dataAccess.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCodeSelect.Text = "";
            txtNameSelect.Text = "";
            txtTypeSelect.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dataType = DataType.Insert;
            SetButtonState();
            txtCode.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //如过画面中不存在数据，提示
            if (dgvDevice.SelectedRows.Count < 1)
            {
                MessageBox.Show("请选择一条要修改的记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dataType = DataType.Update;
            SetButtonState();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dataType = DataType.None;
            SetButtonState();
            DataGridFlush();
            dgvDevice.Focus();

        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            foreach (Control control in groupBox2.Controls)
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

            if (txtCode.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("设备编号不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCode.Focus();
                return;
            }

            if (txtName.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("设备名称不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
                return;
            }

            if (txtType.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("规格型号不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtType.Focus();
                return;
            }

            if (dtpUseDate.Value.Date < dtpBuyDate.Value.Date)
            {
                MessageBox.Show("启用时间不得早于购置时间！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpBuyDate.Focus();
                return;
            }

            try
            {

                //如果是添加
                if (dataType == DataType.Insert)
                {
                    if (txtUser.Text.Trim().Equals("双击选择维护或使用人..."))
                    {
                        MessageBox.Show("请双击选择使用或维护人员！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUser.Focus();
                        return;
                    }

                    entityDevice = new EntityDevice();
                    entityDevice.Device_code = txtCode.Text.Trim();
                    entityDevice.Device_name = txtName.Text.Trim();
                    entityDevice.Device_type = txtType.Text.Trim();
                    entityDevice.Device_made = txtMake.Text.Trim();
                    entityDevice.Device_date = dtpBuyDate.Value.Date;
                    entityDevice.Device_usedate = dtpUseDate.Value.Date;
                    entityDevice.Device_address = txtSetPlace.Text.Trim();
                    entityDevice.Device_application = txtUseMethod.Text.Trim();
                    entityDevice.Staff_name = txtUser.Text.Trim();
                    entityDevice.Device_remarks = txtRemarks.Text.Trim();

                    //打开数据库连接
                    dataAccess = new DataAccess();
                    dataAccess.Open();

                    //取得操作类
                    GetData getData = new GetData(dataAccess.Connection);

                    if (getData.InsertIsOnly("tc_device", "device_code", Util.ChangeForSqlString(txtCode.Text.Trim())))
                    {
                        MessageBox.Show("您输入的设备编号已经存在！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCode.Focus();
                        return;
                    }

                    //取得结果符
                    int result = getData.InsertDeviceRow(entityDevice);

                    if (result == 0)
                    {
                        MessageBox.Show("数据已经保存成功！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("操作添加时发生错误，请检查数据库！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (dataType == DataType.Update)
                {
                    if (dgvDevice.SelectedRows != null && dgvDevice.SelectedRows.Count != 0)
                    {
                        countNum = dgvDevice.SelectedRows[0].Index;
                    }

                    //赋值实体类
                    entityDevice = new EntityDevice();
                    entityDevice.Device_id = int.Parse(dgvDevice.SelectedRows[0].Cells["device_id"].Value.ToString());
                    entityDevice.Device_code = txtCode.Text.Trim();
                    entityDevice.Device_name = txtName.Text.Trim();
                    entityDevice.Device_type = txtType.Text.Trim();
                    entityDevice.Device_made = txtMake.Text.Trim();
                    entityDevice.Device_date = dtpBuyDate.Value.Date;
                    entityDevice.Device_usedate = dtpUseDate.Value.Date;
                    entityDevice.Device_address = txtSetPlace.Text.Trim();
                    entityDevice.Device_application = txtUseMethod.Text.Trim();
                    entityDevice.Staff_name = txtUser.Text.Trim();
                    entityDevice.Device_remarks = txtRemarks.Text.Trim();

                    //打开数据库连接
                    dataAccess = new DataAccess();
                    dataAccess.Open();

                    //打开事务
                    dataAccess.BeginTransaction();

                    //取得操作类
                    GetData getData = new GetData(dataAccess.Connection, dataAccess.Transaction);

                    if (getData.UpdateIsOnly("tc_device", "device_id", entityDevice.Device_id.ToString(), "device_code", Util.ChangeForSqlString(txtCode.Text.Trim())))
                    {
                        MessageBox.Show("您输入的设备编号已经存在！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCode.Focus();
                        return;
                    }

                    //取得结果符
                    int result = getData.UpdateDeviceTable(entityDevice);

                    //提交事务
                    dataAccess.Commit();

                    if (result == 0)
                    {
                        MessageBox.Show("数据已经保存成功！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("操作修改时发生错误，请检查数据库！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                if (dataAccess.Transaction != null)
                {

                    //回滚
                    dataAccess.Rollback();
                }

                MessageBox.Show("操作数据时发生错误，请检查数据库是否正常开启！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (dataAccess.Connection != null)
                {
                    dataAccess.Close();
                }

            }

            //设置按钮状态
            dataType = DataType.None;
            SetButtonState();
            BandingDgv();
        }

        private void txtUser_DoubleClick(object sender, EventArgs e)
        {
            if (dataType == DataType.Insert || dataType == DataType.Update)
            {
                StaffForm staffForm = new StaffForm();
                staffForm.ShowDialog();
                if (!staffForm.staffName.Equals(string.Empty))
                {
                    txtUser.Text = staffForm.staffName;
                }
            }
        }

        private void dgvDevice_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvDevice.Rows.Count; i++)
            {
                dgvDevice.Rows[i].Cells["index"].Value = i + 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //如过画面中不存在数据，提示
            if (dgvDevice.SelectedRows.Count < 1)
            {
                MessageBox.Show("请选择一条要删除的记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //设置按钮状态
            dataType = DataType.None;
            SetButtonState();

            //结果符
            countNum = 0;

            //弹出提示，确认删除
            if (MessageBox.Show("您确定要删除该数据吗？", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {

                    //初始化参数类
                    SearchParameter sp = new SearchParameter();

                    //设置主键
                    sp.SetValue(":DEVICE_ID", dgvDevice.SelectedRows[0].Cells["device_id"].Value.ToString());

                    //打开数据库
                    dataAccess = new DataAccess();
                    dataAccess.Open();

                    //打开事务
                    dataAccess.BeginTransaction();

                    //取得操作类
                    GetData getData = new GetData(dataAccess.Connection, dataAccess.Transaction);

                    //取得结果符
                    int result = getData.DeleteRow("tc_device", sp);

                    //提交事务
                    dataAccess.Commit();

                    //判断结果符，0：成功；-1：失败
                    if (result == 0)
                    {

                        //加载画面
                        BandingDgv();
                        MessageBox.Show("数据已经被成功删除！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("数据删除时发生错误，请检查数据库！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {

                    //回滚
                    dataAccess.Rollback();
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    if (dataAccess.Connection != null)
                        //关闭数据库连接
                        dataAccess.Close();

                }

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvDevice == null || dgvDevice.Rows.Count < 1)
            {
                MessageBox.Show("没有可以打印的数据！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DevicePrint devicePrint = new DevicePrint(dtPrint);
            devicePrint.ShowDialog();
        }

    }
}
