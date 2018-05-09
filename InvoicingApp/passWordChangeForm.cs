using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InvoicingUtil;
using System.Runtime.InteropServices;
using DataAccesses;

namespace InvoicingApp
{
    public partial class passWordChangeForm : Form
    {
        public passWordChangeForm()
        {
            InitializeComponent();
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            //判断非法字符
            foreach (Control control in this.Controls)
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

            //密码不能为空
            if (txtOldPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("原密码不能为空！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOldPassword.Focus();
                return;
            }
            //密码不能为空
            if (txtNewPassword1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("新密码不能为空！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewPassword1.Focus();
                return;
            }
            if (txtNewPassword2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("确认密码不能为空！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewPassword2.Focus();
                return;
            }
            if (txtNewPassword1.Text != txtNewPassword2.Text)
            {
                MessageBox.Show("请检查您两次输入的新密码是否一致！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewPassword2.Focus();
                return;
            }


            EntityAuthority entity = new EntityAuthority();
            //entity.Authority_user_code = LoginUser.UserCode;
            //entity.Authority_password = txtOldPassword.Text;
            SearchParameter sp = new SearchParameter();
            sp.SetValue(":authority_user_code", LoginUser.UserCode);

            try
            {
                sp.SetValue(":authority_password", Util.GetHashCode(txtOldPassword.Text));
            }
            catch (COMException comex)
            {
                MessageBox.Show("加密狗未找到，请插入加密狗！", "长白ERP系统", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataAccess dataAccess = new DataAccess();
            int result = -1;
            DataTable dt = null;
            GetData getData = null;
            try
            {

                dataAccess.Open();

                getData = new GetData(dataAccess.Connection);
                dt = getData.GetSingleTableByConditionUnLike("tc_authority", sp);
                if (dt == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("请检查原密码是否正确！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtOldPassword.Focus();
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                dataAccess.Close();
            }

            entity.Authority_user_code = dt.Rows[0]["Authority_user_code"].ToString();
            entity.Id = Convert.ToInt32(dt.Rows[0]["authority_id"].ToString());
            try
            {
                entity.Authority_password = Util.GetHashCode(txtNewPassword1.Text);
            }
            catch (COMException comex)
            {
                MessageBox.Show("加密狗未找到，请插入加密狗！", "长白ERP系统", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            entity.Authority_level = LoginUser.UserAuthority;
            entity.Staff_code = dt.Rows[0]["staff_code"].ToString();
            try
            {
                dataAccess.Open();
                getData = new GetData(dataAccess.Connection, dataAccess.Transaction);
                //取得结果符
                result = getData.UpdateAuthorityTable(entity);
                //提交事务
                dataAccess.Commit();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                dataAccess.Close();
            }
            if (result == 0)
            {
                MessageBox.Show("密码修改成功！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("密码修改时发生错误，请检查数据库！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }



}
