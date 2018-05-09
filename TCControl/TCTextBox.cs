using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace TCControl
{
    public partial class TCTextBox : System.Windows.Forms.TextBox
    {


        #region "属性定义"
        //类型设定
        public enum Type
        {
            /// <summary>
            ///		普通
            /// </summary>
            General,
            /// <summary>
            ///		数字
            /// </summary>
            Numeric,
            /// <summary>
            ///		数字和字母
            /// </summary>
            NumberAndLetter,
            /// <summary>
            ///		百分比
            /// </summary>
            Rate,
            /// <summary>
            ///		日期
            /// </summary>
            DateTime,
            /// <summary>
            ///		左侧补零
            /// </summary>
            PadLeftNumber,
            /// <summary>
            ///		自定义正则表达式
            /// </summary>
            MatchDefine
        }

        //日期格式化设定
        public enum FormatType
        {
            /// <summary>
            ///	年
            /// </summary>
            yyyy,
            /// <summary>
            ///	年月
            /// </summary>
            yyyyMM,
            /// <summary>
            ///	年月日
            /// </summary>
            yyyyMMdd,
            /// <summary>
            ///	年月日小时分
            /// </summary>
            yyyyMMddHHmm,
            /// <summary>
            ///	年月日小时分秒
            /// </summary>
            yyyyMMddHHmmss,
            /// <summary>
            ///	小时分
            /// </summary>
            HHmm,
            /// <summary>
            ///	小时分秒
            /// </summary>
            HHmmss
        }

        //类型
        private Type typeSet = new Type();
        public Type TypeSet
        {
            get
            {
                return typeSet;
            }
            set
            {
                typeSet = value;
                this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
                if (typeSet != Type.General)
                {
                    if (typeSet == Type.MatchDefine && this.matchValue.Equals(string.Empty))
                    {
                        this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
                    }
                    else
                    {
                        this.ImeMode = System.Windows.Forms.ImeMode.Disable;
                    }
                }

            }
        }

        //日期格式化类型
        private FormatType dateTimeFormate = FormatType.yyyyMMdd;
        public FormatType DateTimeFormate
        {
            get
            {
                return dateTimeFormate;
            }
            set
            {
                dateTimeFormate = value;
            }
        }

        //最大长度
        private int maxByteLength = 0;
        public int MaxByteLength
        {
            get
            {
                return maxByteLength;
            }
            set
            {
                maxByteLength = value;
            }

        }

        //TypeSet 为Numeric时的整数位数
        private int precision = 0;
        public int Precision
        {
            get
            {
                return precision;
            }
            set
            {
                precision = value;
                //if (value != 0)
                //{
                //    if (this.Scale == 0)
                //    {
                //        if (this.MaxByteLength < value)
                //        {
                //            precision = this.Precision;
                //        }
                //        else
                //        {
                //            precision = value;
                //        }
                //    }
                //    else
                //    {
                //        if (this.MaxByteLength < this.Scale + value + 1)
                //        {
                //            precision = this.Precision;
                //        }
                //        else
                //        {
                //            precision = value;
                //        }
                //    }
                //}
                //else
                //{
                //    precision = value;
                //}
            }
        }

        //TypeSet 为Numeric时的小数位数
        private int scale = 0;
        public new int Scale
        {
            get
            {
                return scale;
            }
            set
            {
                scale = value;
                //if (value != 0)
                //{
                //    if (this.Precision == 0)
                //    {
                //        if (this.MaxByteLength < value+2)
                //        {
                //            scale = this.Scale;
                //        }
                //        else
                //        {
                //            scale = value;
                //        }
                //    }
                //    else
                //    {
                //        if (this.MaxByteLength < this.Precision + value + 1)
                //        {
                //            scale = this.Scale;
                //        }
                //        else
                //        {
                //            scale = value;
                //        }
                //    }
                //}
                //else
                //{
                //    scale = value;
                //}

            }

        }

        //TypeSet 为Numeric时 true：可以负数 false 正数
        private bool isAllowMinus = false;
        public bool IsAllowMinus
        {
            get
            {
                return isAllowMinus;
            }
            set
            {
                isAllowMinus = value;
            }
        }

        //TypeSet 为MatchDefine时 验证值的正则表达式
        private string matchValue = string.Empty;
        public string MatchValue
        {
            get
            {
                return matchValue;
            }
            set
            {
                matchValue = value;
            }
        }

        //文本框的值（与Text区别 数字是否格式化）
        //private string value = string .Empty;
        public string Value
        {
            get
            {
                if (this.typeSet == Type.Numeric)
                {

                    return this.Text.Replace(",", string.Empty);
                }
                else
                {
                    return this.Text;
                }
            }
            set
            {
                if (this.typeSet == Type.Numeric)
                {
                    if (value.Equals(string.Empty))
                    {
                        this.Text = string.Empty;
                        return;
                    }
                    if (IsNumeric(value, this.precision, this.scale, this.isAllowMinus))
                    {
                        this.Text = FormatNumeric(value);
                    }

                }
                else
                {
                    this.Text = value;
                }
            }
        }

        //数据的编码方式(默认中文)
        private string encodeing = "GB2312";
        public string Encodeing
        {
            get
            {
                return encodeing;
            }
            set
            {
                encodeing = value;
            }
        }

        private string textValue = string.Empty;
        private int selectSrart = 0;
        private int selectLength = 0;
        private bool noAllowCopy = true;
        private string TextValue
        {
            get
            {
                return textValue;
            }
            set
            {
                textValue = value;
            }
        }
        //最小值是否为零
        private bool padLeftFirstIsZero = false;
        public bool PadLeftFirstIsZero
        {
            get
            {
                return padLeftFirstIsZero;
            }
            set
            {
                padLeftFirstIsZero = value;
            }
        }


        #endregion

        #region "系统事件"
        protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
        {

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                //长度限定
                SetMaxByteLength();

                if (this.typeSet != Type.General)
                {
                    if (!(this.typeSet == Type.MatchDefine && this.matchValue.Equals(string.Empty)))
                    {
                        if (CheckIsAllowCopy(typeSet) == false)
                        {
                            this.TextValue = this.Text;
                            selectSrart = this.SelectionStart;
                            selectLength = this.SelectionLength;
                            noAllowCopy = false;
                        }
                    }
                }
            }

            base.OnMouseDown(e);

        }

        protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            switch (typeSet)
            {

                case Type.General:
                    //长度限定
                    GeneralKeyPress(e.KeyChar);

                    break;
                case Type.Numeric:

                    //长度限定
                    GeneralKeyPress(e.KeyChar);

                    if ("".Equals(e.KeyChar.ToString()))
                    {

                        if (CheckIsAllowCopy(typeSet) == false)
                        {
                            e.Handled = true;
                            return;
                        }
                    }
                    else
                    {
                        if (e.KeyChar.ToString().Equals("\b") || System.Char.IsControl(e.KeyChar) == true)
                        {
                            e.Handled = false;

                        }
                        else
                        {
                            if (IsNumeric(
                                this.Text.Remove(this.SelectionStart, this.SelectionLength).Insert(this.SelectionStart,
                                e.KeyChar.ToString()), this.Precision, this.Scale, isAllowMinus))
                            {
                                e.Handled = false;
                            }
                            else
                            {
                                e.Handled = true;
                                return;
                            }
                        }
                    }
                    break;
                case Type.NumberAndLetter:
                    //长度限定
                    GeneralKeyPress(e.KeyChar);

                    if ("".Equals(e.KeyChar.ToString()))
                    {

                        if (CheckIsAllowCopy(typeSet) == false)
                        {
                            e.Handled = true;
                            return;
                        }
                    }
                    else
                    {
                        if (e.KeyChar.ToString().Equals("\b") || System.Char.IsControl(e.KeyChar) == true)
                        {
                            e.Handled = false;

                        }
                        else
                        {
                            if (IsNumberAndLetter(e.KeyChar.ToString()))
                            {
                                e.Handled = false;

                            }
                            else
                            {
                                e.Handled = true;
                                return;
                            }
                        }
                    }

                    break;
                case Type.Rate:
                    //长度限定
                    GeneralKeyPress(e.KeyChar);
                    if ("".Equals(e.KeyChar.ToString()))
                    {

                        if (CheckIsAllowCopy(typeSet) == false)
                        {
                            e.Handled = true;
                            return;
                        }
                    }
                    else
                    {
                        if (e.KeyChar.ToString().Equals("\b") || System.Char.IsControl(e.KeyChar) == true)
                        {
                            e.Handled = false;

                        }
                        else
                        {
                            if (IsRate(e.KeyChar.ToString(), this.Scale))
                            {
                                e.Handled = false;
                            }
                            else
                            {
                                e.Handled = true;
                                return;
                            }
                        }
                    }
                    break;
                case Type.DateTime:
                    //长度限定
                    GeneralKeyPress(e.KeyChar);
                    if ("".Equals(e.KeyChar.ToString()))
                    {

                        if (CheckIsAllowCopy(typeSet) == false)
                        {
                            e.Handled = true;
                            return;
                        }
                    }
                    else
                    {
                        if (e.KeyChar.ToString().Equals("\b") || System.Char.IsControl(e.KeyChar) == true)
                        {
                            e.Handled = false;

                        }
                        else
                        {
                            if (IsDateTime(e.KeyChar.ToString(), this.DateTimeFormate))
                            {
                                e.Handled = false;
                            }
                            else
                            {
                                e.Handled = true;
                                return;
                            }
                        }

                    }
                    break;
                case Type.PadLeftNumber:
                    //长度限定
                    GeneralKeyPress(e.KeyChar);

                    if ("".Equals(e.KeyChar.ToString()))
                    {

                        if (CheckIsAllowCopy(typeSet) == false)
                        {
                            e.Handled = true;
                            return;
                        }
                    }
                    else
                    {
                        if (e.KeyChar.ToString().Equals("\b") || System.Char.IsControl(e.KeyChar) == true)
                        {
                            e.Handled = false;

                        }
                        else
                        {
                            if (IsAllowNumber(e.KeyChar.ToString()))
                            {
                                e.Handled = false;
                            }
                            else
                            {
                                e.Handled = true;
                                return;
                            }
                        }
                    }
                    break;
                case Type.MatchDefine:
                    //长度限定
                    GeneralKeyPress(e.KeyChar);

                    if (!this.MatchValue.Equals(string.Empty))
                    {
                        if ("".Equals(e.KeyChar.ToString()))
                        {

                            if (CheckIsAllowCopy(typeSet) == false)
                            {
                                e.Handled = true;
                                return;
                            }
                        }
                        else
                        {
                            if (e.KeyChar.ToString().Equals("\b") || System.Char.IsControl(e.KeyChar) == true)
                            {
                                e.Handled = false;

                            }
                            else
                            {
                                if (IsMatchDefine(e.KeyChar.ToString()))
                                {
                                    e.Handled = false;
                                }
                                else
                                {
                                    e.Handled = true;
                                    return;
                                }
                            }
                        }
                    }
                    break;
                default:
                    break;
            }

            if (this.MaxLength == 0)
            {
                e.Handled = true;
                return;
            }

            base.OnKeyPress(e);

        }

        protected override void OnValidating(System.ComponentModel.CancelEventArgs e)
        {

            switch (typeSet)
            {
                case Type.Numeric:
                    this.Text = FormatNumeric(this.Text);
                    break;
                case Type.DateTime:
                    FormatDate(this.Text, dateTimeFormate);
                    break;
                case Type.Rate:
                    if (this.Text != "100")
                    {
                        this.Text = FormatRate(this.Text);
                    }
                    break;
                case Type.PadLeftNumber:
                    PadLeftNumber(this.Text);
                    break;
                default:
                    break;
            }

        }

        protected override void OnEnter(EventArgs e)
        {
            if (this.ReadOnly == false)
            {
                switch (typeSet)
                {
                    case Type.Numeric:
                        this.Text = this.Text.Replace(",", string.Empty);
                        break;

                    case Type.DateTime:
                        this.Text = ReverseDate(this.Text);
                        break;

                    default:
                        break;
                }
            }
            base.OnEnter(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            switch (typeSet)
            {
                case Type.General:
                    return;

                default:
                    if (noAllowCopy == false)
                    {
                        this.Text = this.TextValue;
                        this.SelectionStart = selectSrart;
                        this.SelectionLength = selectLength;
                    }
                    noAllowCopy = true;
                    break;
            }

            base.OnTextChanged(e);

        }

        #endregion

        #region "自定义方法"

        #region "普通控件"
        private void SetInputMaxByteLength(string keyValue)
        {
            string textBoxValue = this.Text;
            Encoding endoding = Encoding.GetEncoding(this.Encodeing);

            if (endoding.GetByteCount(textBoxValue + keyValue) > maxByteLength)
            {
                this.MaxLength = textBoxValue.Length;
            }
            else
            {
                this.MaxLength = textBoxValue.Length + keyValue.Length;
            }
        }

        private void SetMaxByteLength()
        {
            System.Windows.Forms.TextBox txtRef = new System.Windows.Forms.TextBox();

            txtRef.Paste();

            string textBoxValue = this.Text + txtRef.Text;
            Encoding endoding = Encoding.GetEncoding(this.Encodeing);

            if (this.SelectionLength != 0)
            {
                textBoxValue = this.Text;
                int selectIndex = 0;


                for (int i = this.SelectionStart + this.SelectionLength - 1; i >= this.SelectionStart; i--)
                {
                    textBoxValue = textBoxValue.Remove(i, 1);
                }
                if (txtRef.Text.Length > 0)
                {
                    for (int i = this.SelectionStart; endoding.GetByteCount(textBoxValue) + endoding.GetByteCount(txtRef.Text[0].ToString()) <= MaxByteLength; i++)
                    {

                        textBoxValue = textBoxValue.Insert(i, txtRef.Text[0].ToString());

                        txtRef.Text = txtRef.Text.Remove(0, 1);

                        if (txtRef.Text.Length == 0)
                        {
                            break;
                        }
                    }
                }

                selectIndex = this.SelectionStart + this.SelectionLength;
                for (int i = 0; i < txtRef.Text.Length; i++)
                {
                    if (endoding.GetByteCount(textBoxValue) + endoding.GetByteCount(txtRef.Text[i].ToString()) <= MaxByteLength)
                    {
                        textBoxValue = textBoxValue.Insert(selectIndex, txtRef.Text[i].ToString());
                        selectIndex++;
                    }
                    else
                    {
                        break;
                    }
                }

                this.MaxLength = textBoxValue.Length;

            }
            else
            {


                int count = endoding.GetByteCount(textBoxValue);

                if (count <= MaxByteLength)
                {
                    this.MaxLength = MaxByteLength;
                }
                else
                {

                    textBoxValue = this.Text;
                    int startIndex = this.SelectionStart;
                    for (int i = 0; i < txtRef.Text.Length; i++)
                    {
                        if (endoding.GetByteCount(textBoxValue) + endoding.GetByteCount(txtRef.Text[i].ToString()) <= MaxByteLength)
                        {
                            textBoxValue = textBoxValue.Insert(startIndex, txtRef.Text[i].ToString());
                            startIndex++;
                        }
                        else
                        {
                            break;
                        }
                    }


                    this.MaxLength = textBoxValue.Length;

                }
            }
        }

        private void GeneralKeyPress(char keyChar)
        {
            if ("".Equals(keyChar.ToString()))
            {

                SetMaxByteLength();
            }
            else
            {
                if (System.Char.IsControl(keyChar) == false)
                {

                    SetInputMaxByteLength(keyChar.ToString());
                }
                else
                {
                    this.MaxLength = this.maxByteLength;
                }

            }
        }

        private bool CheckIsAllowCopy(Type typeSet)
        {

            System.Windows.Forms.TextBox copyTextBox = new System.Windows.Forms.TextBox();
            Encoding endoding = Encoding.GetEncoding(this.Encodeing);
            copyTextBox.Paste();

            if (copyTextBox.Text.Length != endoding.GetByteCount(copyTextBox.Text))
            {
                this.MaxLength = this.Text.Length;
                return false;
            }

            switch (typeSet)
            {
                case Type.Numeric:
                    if (!Regex.IsMatch(copyTextBox.Text, @"^[\x00-\xff]*$"))
                    {
                        this.MaxLength = this.Text.Length;
                        return false;

                    }

                    if (!IsNumeric(
                        this.Text.Remove(this.SelectionStart, this.SelectionLength).Insert(this.SelectionStart,
                        copyTextBox.Text), this.Precision, this.Scale, this.isAllowMinus))
                    {
                        this.MaxLength = this.Text.Length;
                        return false;
                    }
                    break;
                case Type.NumberAndLetter:
                    if (!Regex.IsMatch(copyTextBox.Text, @"^[\x00-\xff]*$"))
                    {
                        this.MaxLength = this.Text.Length;
                        return false;

                    }
                    if (!IsNumberAndLetter(copyTextBox.Text))
                    {
                        this.MaxLength = this.Text.Length;
                        return false;
                    }
                    break;
                case Type.Rate:
                    if (!Regex.IsMatch(copyTextBox.Text, @"^[\x00-\xff]*$"))
                    {
                        this.MaxLength = this.Text.Length;
                        return false;

                    }
                    if (!IsRate(copyTextBox.Text, this.Scale))
                    {
                        this.MaxLength = this.Text.Length;
                        return false;
                    }
                    break;
                case Type.DateTime:
                    if (!Regex.IsMatch(copyTextBox.Text, @"^[\x00-\xff]*$"))
                    {
                        this.MaxLength = this.Text.Length;
                        return false;

                    }
                    switch (this.dateTimeFormate)
                    {
                        case FormatType.yyyy:

                            if (!IsDateTime(copyTextBox.Text, this.dateTimeFormate))
                            {
                                this.MaxLength = this.Text.Length;
                                return false;
                            }
                            break;
                        case FormatType.yyyyMM:

                            if (!IsDateTime(copyTextBox.Text, this.dateTimeFormate))
                            {
                                this.MaxLength = this.Text.Length;
                                return false;
                            }
                            break;
                        case FormatType.yyyyMMdd:

                            if (!IsDateTime(copyTextBox.Text, this.dateTimeFormate))
                            {
                                this.MaxLength = this.Text.Length;
                                return false;
                            }
                            break;
                        case FormatType.yyyyMMddHHmm:

                            if (!IsDateTime(copyTextBox.Text, this.dateTimeFormate))
                            {
                                this.MaxLength = this.Text.Length;
                                return false;
                            }
                            break;
                        case FormatType.yyyyMMddHHmmss:

                            if (!IsDateTime(copyTextBox.Text, this.dateTimeFormate))
                            {
                                this.MaxLength = this.Text.Length;
                                return false;
                            }
                            break;
                        case FormatType.HHmm:
                            if (!IsDateTime(copyTextBox.Text, this.dateTimeFormate))
                            {
                                this.MaxLength = this.Text.Length;
                                return false;
                            }
                            break;
                        case FormatType.HHmmss:
                            if (!IsDateTime(copyTextBox.Text, this.dateTimeFormate))
                            {
                                this.MaxLength = this.Text.Length;
                                return false;
                            }
                            break;
                        default:

                            break;
                    }

                    break;
                case Type.PadLeftNumber:
                    if (!Regex.IsMatch(copyTextBox.Text, @"^[\x00-\xff]*$"))
                    {
                        this.MaxLength = this.Text.Length;
                        return false;

                    }
                    if (!IsAllowNumber(copyTextBox.Text))
                    {
                        this.MaxLength = this.Text.Length;
                        return false;
                    }
                    break;
                case Type.MatchDefine:

                    if (!Regex.IsMatch(copyTextBox.Text, @"^[\x00-\xff]*$"))
                    {
                        this.MaxLength = this.Text.Length;
                        return false;

                    }
                    if (!IsMatchDefine(copyTextBox.Text))
                    {
                        this.MaxLength = this.Text.Length;
                        return false;
                    }

                    break;
                default:
                    break;
            }

            this.MaxLength = this.maxByteLength;

            return true;
        }
        #endregion

        #region "数字控件"

        /// <summary>
        /// 判断是否为数值
        /// </summary>
        /// <param name="value">需要判断的字符串</param>
        /// <param name="precision">整数</param>
        /// <param name="scale">精度</param>
        /// <param name="isAllowMinus">是否允许负数</param>
        /// <returns>value 是数字为 true。其他场合 false。</returns>
        /// <remarks></remarks>
        private bool IsNumeric(string value, int precision, int scale, bool isAllowMinus)
        {

            string regString = string.Empty;
            String val = value; //this.Text.Remove (this.SelectionStart,this.SelectionLength).Insert (this.SelectionStart, value);

            if (val == null)
            { return false; }

            if (scale.Equals(0))
            {

                regString = @"\d{0," + precision + "}$";

            }
            else
            {
                if (precision.Equals(0))
                {
                    regString = @"[0](\.\d{0," + scale + @"})?$";
                }
                else
                {
                    regString = @"\d{0," + precision + @"}(\.\d{0," + scale + @"})?$";
                }
            }

            if (isAllowMinus)
            {
                regString = "-?" + regString;
            }

            return Regex.IsMatch(val, "^" + regString);

        }

        private string FormatNumeric(string value)
        {

            string txtValue = value;
            string formatString = "###,###";

            if (this.scale != 0)
            {
                formatString = formatString + "0.";
                formatString = formatString.PadRight(formatString.Length + this.scale, '0');
            }
            else
            {
                formatString = formatString + "0";
            }

            if (string.IsNullOrEmpty(txtValue) == false)
            {
                decimal decimalValue = 0;

                string[] stringArray = txtValue.Replace(",", string.Empty).Split('.');
                string decimalValueString = stringArray[0];

                string cdecimalText = string.Empty;


                if (stringArray.Length > 1)
                {
                    cdecimalText = txtValue.Replace(",", string.Empty).Substring(decimalValueString.Length).Replace(".", string.Empty);

                    if (cdecimalText.Length > this.scale)
                    {
                        cdecimalText = cdecimalText.Remove(this.scale);
                    }
                }

                if (decimal.TryParse(decimalValueString + "." + cdecimalText, out decimalValue))
                {
                    txtValue = decimalValue.ToString(formatString);
                }
                else
                {
                    txtValue = "0";
                }
            }
            return txtValue;
        }

        #endregion

        #region "数字和字母控件"
        private bool IsNumberAndLetter(string keyChar)
        {
            return Regex.IsMatch(keyChar, @"^[a-zA-Z0-9]*$");
        }
        #endregion

        #region "百分比控件"
        private bool IsRate(string keyChar, int scale)
        {
            string regString = string.Empty;
            String val = this.Text.Remove(this.SelectionStart, this.SelectionLength).Insert(this.SelectionStart, keyChar.Replace(",", string.Empty));

            if (val == null)
            { return false; }

            if (scale.Equals(0))
            {

                regString = @"([0-9]|[1-9][0-9]|100)$";

            }
            else
            {
                regString = @"([0-9]|[0-9]\.\d{0," + scale + @"}|[1-9][0-9]|[1-9][0-9]\.\d{0," + scale + "}|100)$";
            }


            return Regex.IsMatch(val, "^" + regString);
        }

        private string FormatRate(string value)
        {

            string txtValue = value;
            string formatString = string.Empty;
            if (this.scale != 0)
            {
                formatString = formatString + "0.";
                formatString = formatString.PadRight(formatString.Length + this.scale, '0');
            }
            else
            {
                formatString = formatString + "0";
            }

            if (string.IsNullOrEmpty(txtValue) == false)
            {
                decimal decimalValue = 0;

                string[] stringArray = txtValue.Split('.');
                string decimalValueString = stringArray[0];

                string cdecimalText = string.Empty;


                if (stringArray.Length > 1)
                {
                    cdecimalText = txtValue.Substring(decimalValueString.Length).Replace(".", string.Empty);

                    if (cdecimalText.Length > this.scale)
                    {
                        cdecimalText = cdecimalText.Remove(this.scale);
                    }
                }

                if (decimal.TryParse(decimalValueString + "." + cdecimalText, out decimalValue))
                {
                    txtValue = decimalValue.ToString(formatString);
                }
                else
                {
                    txtValue = "0";
                }
            }
            return txtValue;
        }
        #endregion

        #region "日期控件"

        private string ReverseDate(string dateString)
        {
            if (dateString == null)
            {
                return string.Empty;
            }

            if (dateString == string.Empty)
            {
                return string.Empty;
            }

            dateString = dateString.Replace("/", string.Empty).Replace(" ", string.Empty).Replace(":", string.Empty);

            return dateString;
        }

        private bool IsDateTime(string dateTime, FormatType formatText)
        {
            if (dateTime == null)
            {
                return false;
            }

            String val = this.Text.Remove(this.SelectionStart, this.SelectionLength).Insert(this.SelectionStart, dateTime);

            switch (formatText)
            {
                case FormatType.yyyy:
                    if (!Regex.IsMatch(val, @"^([1-9]\d{0,3})$"))
                    {
                        return false;
                    }
                    break;
                case FormatType.yyyyMM:
                    if (!Regex.IsMatch(val, @"^(?(\d{0,4})(([1-9]\d{0,3})|\d{4}(0|1|0[1-9]|1[0-2])))$"))
                    {
                        return false;
                    }
                    break;
                case FormatType.yyyyMMdd:

                    return IsYMDDate(val);

                case FormatType.yyyyMMddHHmm:
                    if (Regex.IsMatch(val, @"^\d{0,8}$"))
                    {
                        return IsYMDDate(val);
                    }
                    else if (Regex.IsMatch(val, @"^\d{9,12}$"))
                    {
                        if (IsYMDDate(val.Substring(0, 8)))
                        {
                            if (!Regex.IsMatch(val, @"^\d{8}(0|1|2|[0-1][0-9]|2[0-3]|[0-1][0-9][0-5]|2[0-3][0-5]|[0-1][0-9][0-5][0-9]|2[0-3][0-5][0-9])$"))
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }

                    break;
                case FormatType.yyyyMMddHHmmss:
                    if (Regex.IsMatch(val, @"^\d{0,8}$"))
                    {
                        return IsYMDDate(val);
                    }
                    else if (Regex.IsMatch(val, @"^\d{9,14}$"))
                    {
                        if (IsYMDDate(val.Substring(0, 8)))
                        {
                            if (!Regex.IsMatch(val, @"^\d{8}(0|1|2|[0-1][0-9]|2[0-3]|[0-1][0-9][0-5]|2[0-3][0-5]|[0-1][0-9][0-5][0-9]|2[0-3][0-5][0-9]|[0-1][0-9][0-5][0-9][0-5]|2[0-3][0-5][0-9][0-5]|[0-1][0-9][0-5][0-9][0-5][0-9]|2[0-3][0-5][0-9][0-5][0-9])$"))
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                    break;
                case FormatType.HHmm:
                    if (!Regex.IsMatch(val, @"^(0|1|2|[0-1][0-9]|2[0-3]|[0-1][0-9][0-5]|2[0-3][0-5]|[0-1][0-9][0-5][0-9]|2[0-3][0-5][0-9])$"))
                    {
                        return false;
                    }
                    break;
                case FormatType.HHmmss:
                    if (!Regex.IsMatch(val, @"^(0|1|2|[0-1][0-9]|2[0-3]|[0-1][0-9][0-5]|2[0-3][0-5]|[0-1][0-9][0-5][0-9]|2[0-3][0-5][0-9]|[0-1][0-9][0-5][0-9][0-5]|2[0-3][0-5][0-9][0-5]|[0-1][0-9][0-5][0-9][0-5][0-9]|2[0-3][0-5][0-9][0-5][0-9])$"))
                    {
                        return false;
                    }
                    break;

                default:
                    break;

            }

            return true;
        }

        private bool IsYMDDate(string val)
        {
            if (!Regex.IsMatch(val, @"^\d{0,4}$"))
            {
                if (!Regex.IsMatch(val, @"^\d{0,6}$"))
                {
                    if (Regex.IsMatch(val, @"^(\d{6}(0|1|2|3|0[1-9]|1[0-9]|2[0-9]|3[0-1]))$"))
                    {
                        switch (Regex.IsMatch(val, @"^(\d{6}[3])$"))
                        {
                            case true:
                                if (!Regex.IsMatch(val + 0, @"^([1-9]\d{3}((0[1-9]|1[012])(0[1-9]|1\d|2[0-8])|(0[1345
											    6789]|1[012])(29|30)|(0[13578]|1[02])31)|(([2-9]\d)(0[48
											    ]|[2468][048]|[13579][26])|(([2468][048]|[3579][26])00))
											    0229)$"))
                                {
                                    return false;
                                }
                                break;
                            case false:
                                if (Regex.IsMatch(val, @"^(\d{8})$"))
                                {
                                    if (!Regex.IsMatch(val, @"^([1-9]\d{3}((0[1-9]|1[012])(0[1-9]|1\d|2[0-8])|(0[1345
											    6789]|1[012])(29|30)|(0[13578]|1[02])31)|(([2-9]\d)(0[48
											    ]|[2468][048]|[13579][26])|(([2468][048]|[3579][26])00))
											    0229)$"))
                                    {
                                        return false;
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (!Regex.IsMatch(val, @"^\d{4}(0|1|0[1-9]|1[0-2])$"))
                    {
                        return false;
                    }
                }
            }
            else
            {
                if (!Regex.IsMatch(val, @"^[1-9]\d{0,3}$"))
                {
                    return false;
                }
            }

            return true;
        }

        public void FormatDate(string dateString, FormatType formatType)
        {
            if (dateString == null)
            {

                return;
            }

            if (dateString == string.Empty)
            {
                return;
            }

            string formatStr = dateString;
            switch (formatType)
            {
                case FormatType.yyyy:
                    if (!Regex.IsMatch(formatStr, @"^\d{4}$"))
                    {
                        formatStr = formatStr.PadLeft(4, '0');
                    }
                    break;
                case FormatType.yyyyMM:
                    if (Regex.IsMatch(formatStr, @"^\d{0,4}$"))
                    {
                        formatStr = formatStr.PadLeft(4, '0') + "01";
                    }
                    else if (Regex.IsMatch(formatStr, @"^\d{5}$"))
                    {
                        formatStr = formatStr.Substring(0, 4) + formatStr.Substring(4, 1).PadLeft(2, '0');
                    }
                    formatStr = formatStr.Insert(4, "/");
                    break;
                case FormatType.yyyyMMdd:
                    if (Regex.IsMatch(formatStr, @"^\d{0,4}$"))
                    {
                        formatStr = formatStr.PadLeft(4, '0') + "0101";
                    }
                    else if (Regex.IsMatch(formatStr, @"^\d{5}$"))
                    {
                        if (formatStr.Substring(4, 1).Equals("0"))
                        {
                            formatStr = formatStr.Substring(0, 4) + formatStr.Substring(4, 1).PadRight(2, '1') + "01";
                        }
                        else
                        {
                            formatStr = formatStr.Substring(0, 4) + formatStr.Substring(4, 1).PadLeft(2, '0') + "01";
                        }
                    }
                    else if (Regex.IsMatch(formatStr, @"^\d{6}$"))
                    {

                        formatStr = formatStr + "01";

                    }
                    else if (Regex.IsMatch(formatStr, @"^\d{7}$"))
                    {
                        if (formatStr.Substring(6, 1).Equals("0"))
                        {
                            formatStr = formatStr.Substring(0, 6) + formatStr.Substring(6, 1).PadRight(2, '1');
                        }
                        else
                        {
                            formatStr = formatStr.Substring(0, 6) + formatStr.Substring(6, 1).PadLeft(2, '0');
                        }
                    }
                    formatStr = formatStr.Insert(4, "/").Insert(7, "/");
                    break;
                case FormatType.yyyyMMddHHmm:
                    if (Regex.IsMatch(formatStr, @"^\d{0,4}$"))
                    {
                        formatStr = formatStr.PadLeft(4, '0') + "01010101";
                    }
                    else if (Regex.IsMatch(formatStr, @"^\d{5}$"))
                    {
                        if (formatStr.Substring(4, 1).Equals("0"))
                        {
                            formatStr = formatStr.Substring(0, 4) + formatStr.Substring(4, 1).PadRight(2, '1') + "010101";
                        }
                        else
                        {
                            formatStr = formatStr.Substring(0, 4) + formatStr.Substring(4, 1).PadLeft(2, '0') + "010101";
                        }
                    }
                    else if (Regex.IsMatch(formatStr, @"^\d{6}$"))
                    {

                        formatStr = formatStr + "010101";

                    }
                    else if (Regex.IsMatch(formatStr, @"^\d{7}$"))
                    {
                        if (formatStr.Substring(6, 1).Equals("0"))
                        {
                            formatStr = formatStr.Substring(0, 6) + formatStr.Substring(6, 1).PadRight(2, '1') + "0101";
                        }
                        else
                        {
                            formatStr = formatStr.Substring(0, 6) + formatStr.Substring(6, 1).PadLeft(2, '0') + "0101";
                        }
                    }
                    else if (Regex.IsMatch(formatStr, @"^\d{8}$"))
                    {

                        formatStr = formatStr + "0101";

                    }
                    else if (Regex.IsMatch(formatStr, @"^\d{9}$"))
                    {
                        if (formatStr.Substring(8, 1).Equals("0"))
                        {
                            formatStr = formatStr.Substring(0, 8) + formatStr.Substring(8, 1).PadRight(2, '1') + "01";
                        }
                        else
                        {
                            formatStr = formatStr.Substring(0, 8) + formatStr.Substring(8, 1).PadLeft(2, '0') + "01";
                        }
                    }
                    else if (Regex.IsMatch(formatStr, @"^\d{10}$"))
                    {

                        formatStr = formatStr + "01";

                    }
                    else if (Regex.IsMatch(formatStr, @"^\d{11}$"))
                    {
                        if (formatStr.Substring(10, 1).Equals("0"))
                        {
                            formatStr = formatStr.Substring(0, 10) + formatStr.Substring(10, 1).PadRight(2, '1');
                        }
                        else
                        {
                            formatStr = formatStr.Substring(0, 10) + formatStr.Substring(10, 1).PadLeft(2, '0');
                        }

                    }
                    formatStr = formatStr.Insert(4, "/").Insert(7, "/").Insert(10, " ").Insert(13, ":");
                    break;
                case FormatType.yyyyMMddHHmmss:
                    if (Regex.IsMatch(formatStr, @"^\d{0,4}$"))
                    {
                        formatStr = formatStr.PadLeft(4, '0') + "0101010101";
                    }
                    else if (Regex.IsMatch(formatStr, @"^\d{5}$"))
                    {
                        if (formatStr.Substring(4, 1).Equals("0"))
                        {
                            formatStr = formatStr.Substring(0, 4) + formatStr.Substring(4, 1).PadRight(2, '1') + "01010101";
                        }
                        else
                        {
                            formatStr = formatStr.Substring(0, 4) + formatStr.Substring(4, 1).PadLeft(2, '0') + "01010101";
                        }

                    }
                    else if (Regex.IsMatch(formatStr, @"^\d{6}$"))
                    {

                        formatStr = formatStr + "01010101";

                    }
                    else if (Regex.IsMatch(formatStr, @"^\d{7}$"))
                    {
                        if (formatStr.Substring(6, 1).Equals("0"))
                        {
                            formatStr = formatStr.Substring(0, 6) + formatStr.Substring(6, 1).PadRight(2, '1') + "010101";
                        }
                        else
                        {
                            formatStr = formatStr.Substring(0, 6) + formatStr.Substring(6, 1).PadLeft(2, '0') + "010101";
                        }

                    }
                    else if (Regex.IsMatch(formatStr, @"^\d{8}$"))
                    {

                        formatStr = formatStr + "010101";

                    }
                    else if (Regex.IsMatch(formatStr, @"^\d{9}$"))
                    {
                        if (formatStr.Substring(8, 1).Equals("0"))
                        {
                            formatStr = formatStr.Substring(0, 8) + formatStr.Substring(8, 1).PadRight(2, '1') + "0101";
                        }
                        else
                        {
                            formatStr = formatStr.Substring(0, 8) + formatStr.Substring(8, 1).PadLeft(2, '0') + "0101";
                        }

                    }
                    else if (Regex.IsMatch(formatStr, @"^\d{10}$"))
                    {

                        formatStr = formatStr + "0101";

                    }
                    else if (Regex.IsMatch(formatStr, @"^\d{11}$"))
                    {
                        if (formatStr.Substring(10, 1).Equals("0"))
                        {
                            formatStr = formatStr.Substring(0, 10) + formatStr.Substring(10, 1).PadRight(2, '1') + "01";
                        }
                        else
                        {
                            formatStr = formatStr.Substring(0, 10) + formatStr.Substring(10, 1).PadLeft(2, '0') + "01";
                        }

                    }
                    else if (Regex.IsMatch(formatStr, @"^\d{12}$"))
                    {

                        formatStr = formatStr + "01";

                    }
                    else if (Regex.IsMatch(formatStr, @"^\d{13}$"))
                    {
                        if (formatStr.Substring(12, 1).Equals("0"))
                        {
                            formatStr = formatStr.Substring(0, 12) + formatStr.Substring(12, 1).PadRight(2, '1');
                        }
                        else
                        {
                            formatStr = formatStr.Substring(0, 12) + formatStr.Substring(12, 1).PadLeft(2, '0');
                        }

                    }
                    formatStr = formatStr.Insert(4, "/").Insert(7, "/").Insert(10, " ").Insert(13, ":").Insert(16, ":");
                    break;
                case FormatType.HHmm:
                    if (Regex.IsMatch(formatStr, @"^\d{0,2}$"))
                    {
                        if (formatStr.Substring(0, 1).Equals("0"))
                        {
                            formatStr = formatStr.PadRight(2, '1') + "01";
                        }
                        else
                        {
                            formatStr = formatStr.PadLeft(2, '0') + "01";
                        }
                    }
                    else if (Regex.IsMatch(formatStr, @"^\d{3,4}$"))
                    {
                        if (formatStr.Substring(2, 1).Equals("0"))
                        {
                            formatStr = formatStr.Substring(0, 2) + formatStr.Substring(2, formatStr.Length - 2).PadRight(2, '1');
                        }
                        else
                        {
                            formatStr = formatStr.Substring(0, 2) + formatStr.Substring(2, formatStr.Length - 2).PadLeft(2, '0');
                        }
                    }
                    formatStr = formatStr.Insert(2, ":");
                    break;
                case FormatType.HHmmss:
                    if (Regex.IsMatch(formatStr, @"^\d{0,2}$"))
                    {
                        if (formatStr.Substring(0, 1).Equals("0"))
                        {
                            formatStr = formatStr.PadRight(2, '1') + "0101";
                        }
                        else
                        {
                            formatStr = formatStr.PadLeft(2, '0') + "0101";
                        }
                    }
                    else if (Regex.IsMatch(formatStr, @"^\d{3,4}$"))
                    {
                        if (formatStr.Substring(2, 1).Equals("0"))
                        {
                            formatStr = formatStr.Substring(0, 2) + formatStr.Substring(2, formatStr.Length - 2).PadRight(2, '1') + "01";
                        }
                        else
                        {
                            formatStr = formatStr.Substring(0, 2) + formatStr.Substring(2, formatStr.Length - 2).PadLeft(2, '0') + "01";
                        }
                    }
                    else if (Regex.IsMatch(formatStr, @"^\d{5,6}$"))
                    {
                        if (formatStr.Substring(4, 1).Equals("0"))
                        {
                            formatStr = formatStr.Substring(0, 4) + formatStr.Substring(4, formatStr.Length - 4).PadRight(2, '1');
                        }
                        else
                        {
                            formatStr = formatStr.Substring(0, 4) + formatStr.Substring(4, formatStr.Length - 4).PadLeft(2, '0');
                        }
                    }
                    formatStr = formatStr.Insert(2, ":").Insert(5, ":");
                    break;
                default:
                    break;
            }
            this.Text = formatStr;

        }

        #endregion

        #region "补零控件"
        private bool IsAllowNumber(string keyChar)
        {
            string regString = string.Empty;
            Encoding endoding = Encoding.GetEncoding(this.Encodeing);
            String val = this.Text.Remove(this.SelectionStart, this.SelectionLength);

            if (keyChar.Length > 0)
            {
                for (int i = this.SelectionStart; endoding.GetByteCount(val) + endoding.GetByteCount(keyChar[0].ToString()) <= MaxByteLength; i++)
                {

                    val = val.Insert(i, keyChar[0].ToString());

                    keyChar = keyChar.Remove(0, 1);

                    if (keyChar.Length == 0)
                    {
                        break;
                    }
                }
            }

            if (val == null)
            { return false; }


            regString = @"(\d{0," + this.MaxByteLength + "})$";

            return Regex.IsMatch(val, "^" + regString);
        }

        private void PadLeftNumber(string padLeftStr)
        {
            if (!this.Text.Equals(string.Empty))
            {
                if (int.Parse(this.Text) != 0 || PadLeftFirstIsZero)
                {
                    this.Text = padLeftStr.PadLeft(this.MaxByteLength, '0');
                }
                else
                {
                    this.Text = "0".PadLeft(this.MaxByteLength - 1, '0') + "1";
                }
            }
        }
        #endregion

        #region "自定义正则表达式控件"
        private bool IsMatchDefine(string matchString)
        {
            String val = this.Text.Remove(this.SelectionStart, this.SelectionLength).Insert(this.SelectionStart, matchString);
            return Regex.IsMatch(val, this.MatchValue);
        }
        #endregion

        #endregion
    }


}
