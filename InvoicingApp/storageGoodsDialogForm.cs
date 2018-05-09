//***********************************************************************
//* 系统名称	    ：  长白ERP系统
//* 功能模块	    ：  系统信息
//* 功能画面		：  入库产品记录管理
//* 画面名称	    ：  storageGoodsDialogForm
//* 完成年月日      ：  2010/07/23
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
using System.Text.RegularExpressions;
using DataAccesses;
using InvoicingUtil;

namespace InvoicingApp
{
    //***********************************************************************
    /// <summary>
    ///入库产品记录管理功能
    /// </summary>
    /// <history>
    ///     完成信息：代国明      2010/07/23 完成  
    ///     更新信息：
    /// </history>
    //***********************************************************************
    public partial class storageGoodsDialogForm : Form
    {
        /// <summary>
        /// 数据库连接句柄
        /// </summary>
        DataAccess dataAccess = null;

        /// <summary>
        /// 入库编号
        /// </summary>
        public string inputCode = string.Empty;

        /// <summary>
        /// 产品编号初始化
        /// </summary>
        public string goodCode = string.Empty;

        /// <summary>
        /// 产品名称初始化
        /// </summary>
        public string goodName = string.Empty;
        /// <summary>
        /// 生产日期
        /// </summary>
        public DateTime makeTime;
        /// <summary>
        /// 入库日期
        /// </summary>
        public DateTime instorageDate;
        /// <summary>
        /// 供货商名称初始化
        /// </summary>
        public string supplierName = string.Empty;

        /// <summary>
        /// 销售数量初始化
        /// </summary>
        public int outputStorage1 = 0;

        /// <summary>
        /// 选择记录的行号
        /// </summary>
        int countNum = 0;

        /// <summary>
        /// 库存数量临时表实体类
        /// </summary>
        public EntityTemp_storage tempStorageEntity = null;

        /// <summary>
        /// 获取临时数据源表
        /// </summary>
        private DataTable dtDgvStorageGoods = null;

        public storageGoodsDialogForm(string strLable)
        {
            InitializeComponent();
            dgvStorageGoods.AutoGenerateColumns = false;
            label2.Text = strLable;
            this.dgvStorageGoods.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 243, 251);
        }

        //*******************************************************************
        /// <summary>
        /// 取得数据源
        /// </summary>
        /// <param name="dt">数据源表</param>
        /// <history>
        ///     完成信息：代国明      2010/07/23 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void GetDgvStorageGoods(DataTable dt)
        {
            //定义出库统计数据源表
            dtDgvStorageGoods = new DataTable();

            //添加各个数据列
            dtDgvStorageGoods.Columns.Add("goods_name", typeof(string));
            dtDgvStorageGoods.Columns.Add("supplier_name", typeof(string));
            dtDgvStorageGoods.Columns.Add("剩余数量", typeof(string));
            dtDgvStorageGoods.Columns.Add("input_code", typeof(string));
            dtDgvStorageGoods.Columns.Add("goods_code", typeof(string));
            dtDgvStorageGoods.Columns.Add("input_instorage_date", typeof(string));
            dtDgvStorageGoods.Columns.Add("goods_reg_mark", typeof(string));
            dtDgvStorageGoods.Columns.Add("goods_type", typeof(string));
            dtDgvStorageGoods.Columns.Add("goods_validity", typeof(string));
            dtDgvStorageGoods.Columns.Add("input_count", typeof(string));
            dtDgvStorageGoods.Columns.Add("output_count", typeof(string));
            dtDgvStorageGoods.Columns.Add("lose_count", typeof(string));
            dtDgvStorageGoods.Columns.Add("index", typeof(int));
            dtDgvStorageGoods.Columns.Add("input_maketime", typeof(string));

            //遍历数据源
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dtDgvStorageGoods.NewRow();

                dr["goods_name"] = dt.Rows[i]["goods_name"].ToString();

                dr["supplier_name"] = dt.Rows[i]["supplier_name"].ToString();
                dr["剩余数量"] = dt.Rows[i]["剩余数量"].ToString();
                dr["input_code"] = dt.Rows[i]["input_code"].ToString();
                dr["goods_code"] = dt.Rows[i]["goods_code"].ToString();
                dr["goods_reg_mark"] = dt.Rows[i]["goods_reg_mark"].ToString();
                dr["goods_type"] = dt.Rows[i]["goods_type"].ToString();
                dr["goods_validity"] = dt.Rows[i]["goods_validity"].ToString();
                dr["input_count"] = dt.Rows[i]["input_count"].ToString();
                dr["output_count"] = dt.Rows[i]["output_count"].ToString();
                dr["lose_count"] = dt.Rows[i]["lose_count"].ToString();

                if (dt.Rows[i]["input_instorage_date"].ToString().Equals(string.Empty))
                {
                    dr["input_instorage_date"] = "";
                }
                else
                {
                    dr["input_instorage_date"] = DateTime.Parse(dt.Rows[i]["input_instorage_date"].ToString()).ToString("yyyy-MM-dd");
                }
                if (dt.Rows[i]["input_maketime"].ToString().Equals(string.Empty))
                {
                    dr["input_maketime"] = "";
                }
                else
                {
                    dr["input_maketime"] = DateTime.Parse(dt.Rows[i]["input_maketime"].ToString()).ToString("yyyy-MM-dd");
                }

                dr["index"] = i + 1;

                dtDgvStorageGoods.Rows.Add(dr);
            }
        }

        //***********************************************************************
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/20 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void storageGoodsDialogForm_Load(object sender, EventArgs e)
        {
            BindingDgv();
        }

        //***********************************************************************
        /// <summary>
        /// 查找按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/20 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnFind_Click(object sender, EventArgs e)
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

                //初始化参数类
                SearchParameter sp = new SearchParameter();

                //条件不为空，添加参数
                if (txt_goods_name.Text.Trim() != string.Empty)
                {
                    sp.SetValue(":TC_GOODS.GOODS_NAME", txt_goods_name.Text);
                }

                if (txt_input_code.Text.Trim() != string.Empty)
                {
                    sp.SetValue(":TC_INPUT_STORAGE.INPUT_CODE", txt_input_code.Text);
                }

                sp.SetValue(":(ISNULL(TC_INPUT_STORAGE.INPUT_STANDARD_COUNT, 0)-ISNULL(DERIVEDTBL_2.LOSE_COUNT, 0)-ISNULL(DERIVEDTBL_1.OUTPUT_COUNT,0))!", 0);

                //打开数据库连接
                dataAccess = new DataAccess();
                dataAccess.Open();

                //取得操作类
                GetData getData = new GetData(dataAccess.Connection);

                //根据条件检索单表
                DataTable dtStorageGoods = getData.GetTableBySqlStr(Constants.SqlStr.TC_INPUT_STORAGE_LEFTJOIN_TC_OUTPUT_STORAGE_LEFTJOIN_TC_GOODS, sp);

                //如果为NULL，报错
                if (dtStorageGoods == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (dtStorageGoods.Rows.Count > 0)
                {
                    GetDgvStorageGoods(dtStorageGoods);
                    //dtStorageGoods.Columns.Add("index", typeof(int));
                    //for (int i = 0; i < dtStorageGoods.Rows.Count; i++)
                    //{
                    //    dtStorageGoods.Rows[i]["index"] = i + 1;
                    //}

                    dgvStorageGoods.DataSource = dtDgvStorageGoods;
                }

                if (dgvStorageGoods != null && dgvStorageGoods.Rows.Count > 0 && countNum != 0)
                {
                    dgvStorageGoods.Rows[0].Selected = false;
                    dgvStorageGoods.Rows[countNum].Selected = true;
                }

                //没有数据
                if (dtStorageGoods.Rows.Count == 0)
                {

                    //给出提示
                    MessageBox.Show("数据不存在，请查看输入的条件是否正确！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        /// 绑定数据
        /// </summary>        
        /// <history>
        ///    完成信息：代国明      2010/07/20 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        public void BindingDgv()
        {
            try
            {

                //初始化参数类
                SearchParameter sp = new SearchParameter();

                sp.SetValue(":(ISNULL(TC_INPUT_STORAGE.INPUT_STANDARD_COUNT, 0)-ISNULL(DERIVEDTBL_2.LOSE_COUNT, 0)-ISNULL(DERIVEDTBL_1.OUTPUT_COUNT,0))!", 0);

                //打开数据库连接
                dataAccess = new DataAccess();
                dataAccess.Open();

                //取得操作类
                GetData getData = new GetData(dataAccess.Connection);

                //根据条件检索单表
                DataTable dtStorageGoods = getData.GetTableBySqlStr(Constants.SqlStr.TC_INPUT_STORAGE_LEFTJOIN_TC_OUTPUT_STORAGE_LEFTJOIN_TC_GOODS, sp);

                //如果为NULL，报错
                if (dtStorageGoods == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (dtStorageGoods.Rows.Count > 0)
                {
                    GetDgvStorageGoods(dtStorageGoods);
                    //dtStorageGoods.Columns.Add("index", typeof(int));
                    //for (int i = 0; i < dtStorageGoods.Rows.Count; i++)
                    //{
                    //    dtStorageGoods.Rows[i]["index"] = i + 1;
                    //}

                    dgvStorageGoods.DataSource = dtDgvStorageGoods;
                }

                if (dgvStorageGoods != null && dgvStorageGoods.Rows.Count > 0 && countNum != 0)
                {
                    dgvStorageGoods.Rows[0].Selected = false;
                    dgvStorageGoods.Rows[countNum].Selected = true;
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
        /// 确认按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/20 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnCommit_Click(object sender, EventArgs e)
        {

            //如果选择多条数据删除，提示
            if (dgvStorageGoods.SelectedRows.Count > 1)
            {
                MessageBox.Show("只能选择一条要添加记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //如过画面中不存在数据，提示
            if (dgvStorageGoods.SelectedRows.Count < 1)
            {
                MessageBox.Show("请选择一条要添加记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //实际剩余数量
            int storagecount = Convert.ToInt32(dgvStorageGoods.SelectedRows[0].Cells["剩余数量"].Value.ToString());



            if (Convert.ToInt32(nud_output_count.Value) == 0)
            {
                MessageBox.Show(label2.Text.Replace(":","")+"不能为0！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                nud_output_count.Select();
                return;
            }
            else
            {
                if (Convert.ToInt32(nud_output_count.Value) > 0 && Convert.ToInt32(nud_output_count.Value) <= storagecount)
                {
                    outputStorage1 = Convert.ToInt32(nud_output_count.Value);
                }
                else
                {
                    MessageBox.Show("请核对数量后，再进行确认！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nud_output_count.Select();
                    return;
                }
            }



            //添加销售数量后，更新库存表
            UpdateStorageDetails(outputStorage1);

            //入库编号
            inputCode = dgvStorageGoods.SelectedRows[0].Cells["input_code"].Value.ToString();

            //产品名称
            goodName = dgvStorageGoods.SelectedRows[0].Cells["goods_name"].Value.ToString();

            //供货商名字
            supplierName = dgvStorageGoods.SelectedRows[0].Cells["supplier_name"].Value.ToString();

            //供货商名字
            makeTime =DateTime.Parse(dgvStorageGoods.SelectedRows[0].Cells["input_maketime"].Value.ToString());

            //入库日期
            instorageDate = DateTime.Parse(dgvStorageGoods.SelectedRows[0].Cells["input_instorage_date"].Value.ToString());
            this.Close();
        }

        //***********************************************************************
        /// <summary>
        ///添加销售数量后，更新库存表
        /// </summary>       
        /// <history>
        ///    完成信息：代国明      2010/07/20 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        void UpdateStorageDetails(int outputStorage1)
        {
            //取得树体类
            tempStorageEntity = new EntityTemp_storage();

            //赋值实体类
            tempStorageEntity.Goods_code = dgvStorageGoods.SelectedRows[0].Cells["goods_code"].Value.ToString();
            tempStorageEntity.Count = -outputStorage1;
        }

        //***********************************************************************
        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/20 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //***********************************************************************
        /// <summary>
        /// 双击dataGridView事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/20 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void dgvStorageGoods_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1 || e.ColumnIndex <= -1)//双击表头或列头时不起作用   
            {
                return;
            }

            btnCommit_Click(sender, e);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txt_input_code.Text = "";
            txt_goods_name.Text = "";
        }

        private void dgvStorageGoods_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvStorageGoods.Rows.Count; i++)
            {
                dgvStorageGoods.Rows[i].Cells["index"].Value = i + 1;
            }
        }

        private void nud_output_count_KeyUp(object sender, KeyEventArgs e)
        {
            if (nud_output_count.Value.ToString().Length > 4)
            {
                nud_output_count.Value = 9999;

            }
        }

    }
}
