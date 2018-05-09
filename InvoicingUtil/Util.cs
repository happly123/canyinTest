using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
namespace InvoicingUtil
{
    public class Util
    {
        /// <summary>
        /// GetByteLength
        /// </summary>
        /// <param name="value">value</param>
        /// <returns>value byte length</returns>
        public static int GetByteLength(string value)
        {
            int byteLength = 0;
            byteLength = System.Text.Encoding.GetEncoding("GB2312").GetByteCount(value);
            return byteLength;
        }

        /// <summary>
        /// GetLeftString
        /// </summary>
        /// <param name="value">value</param>
        /// <param name="byteLength">byteLength</param>
        /// <returns>left value by length</returns>
        public static string GetLeftString(object value, int byteLength)
        {
            if (value == null)
            {
                return string.Empty;
            }
            if (value.Equals(string.Empty))
            {
                return string.Empty;
            }

            string tempValue = value.ToString();

            string returnValue = string.Empty;
            int length = 0;
            for (int i = 0; i < tempValue.Length; i++)
            {
                int charLength = GetByteLength(tempValue[i].ToString());
                if (length + charLength <= byteLength)
                {
                    length += charLength;
                    returnValue += tempValue[i].ToString();
                }
                else
                {
                    break;
                }

            }

            return returnValue;
        }


        /// <summary>
        /// 返回给定字符串的首字母
        /// </summary>
        /// <param name="IndexTxt">字符串</param>
        /// <returns>拼音首字母</returns>
        public static string IndexCode(String IndexTxt)
        {
            try
            {
                String _Temp = null;
                for (int i = 0; i < IndexTxt.Length; i++)
                    _Temp = _Temp + GetOneIndex(IndexTxt.Substring(i, 1));
                return _Temp;
            }
            catch
            {
                return "";
            }
        }


        /// <summary>
        /// 得到单个字符的首字母
        /// </summary>
        /// <param name="OneIndexTxt">单个字符串</param>
        /// <returns>拼音首字母</returns>
        public static string GetOneIndex(String OneIndexTxt)
        {
            if (Convert.ToChar(OneIndexTxt) >= 0 && Convert.ToChar(OneIndexTxt) < 256)
                return OneIndexTxt;
            else
            {
                Encoding gb2312 = Encoding.GetEncoding("gb2312");
                byte[] unicodeBytes = Encoding.Unicode.GetBytes(OneIndexTxt);
                byte[] gb2312Bytes = Encoding.Convert(Encoding.Unicode, gb2312, unicodeBytes);
                return GetX(Convert.ToInt32(
                String.Format("{0:D2}", Convert.ToInt16(gb2312Bytes[0]) - 160)
                + String.Format("{0:D2}", Convert.ToInt16(gb2312Bytes[1]) - 160)
                ));
            }

        }


        /// <summary>
        /// 根据区位得到首字母（不会用到）
        /// </summary>
        public static string GetX(int GBCode)
        {
            if (GBCode >= 1601 && GBCode < 1637) return "A";
            if (GBCode >= 1637 && GBCode < 1833) return "B";
            if (GBCode >= 1833 && GBCode < 2078) return "C";
            if (GBCode >= 2078 && GBCode < 2274) return "D";
            if (GBCode >= 2274 && GBCode < 2302) return "E";
            if (GBCode >= 2302 && GBCode < 2433) return "F";
            if (GBCode >= 2433 && GBCode < 2594) return "G";
            if (GBCode >= 2594 && GBCode < 2787) return "H";
            if (GBCode >= 2787 && GBCode < 3106) return "J";
            if (GBCode >= 3106 && GBCode < 3212) return "K";
            if (GBCode >= 3212 && GBCode < 3472) return "L";
            if (GBCode >= 3472 && GBCode < 3635) return "M";
            if (GBCode >= 3635 && GBCode < 3722) return "N";
            if (GBCode >= 3722 && GBCode < 3730) return "O";
            if (GBCode >= 3730 && GBCode < 3858) return "P";
            if (GBCode >= 3858 && GBCode < 4027) return "Q";
            if (GBCode >= 4027 && GBCode < 4086) return "R";
            if (GBCode >= 4086 && GBCode < 4390) return "S";
            if (GBCode >= 4390 && GBCode < 4558) return "T";
            if (GBCode >= 4558 && GBCode < 4684) return "W";
            if (GBCode >= 4684 && GBCode < 4925) return "X";
            if (GBCode >= 4925 && GBCode < 5249) return "Y";
            if (GBCode >= 5249 && GBCode <= 5589) return "Z";
            if (GBCode >= 5601 && GBCode <= 8794)
            {
                String CodeData = "cjwgnspgcenegypbtwxzdxykygtpjnmjqmbsgzscyjsyyfpggbzgydywjkgaljswkbjqhyjwpdzlsgmr"
                + "ybywwccgznkydgttngjeyekzydcjnmcylqlypyqbqrpzslwbdgkjfyxjwcltbncxjjjjcxdtqsqzycdxxhgckbphffss"
                + "pybgmxjbbyglbhlssmzmpjhsojnghdzcdklgjhsgqzhxqgkezzwymcscjnyetxadzpmdssmzjjqjyzcjjfwqjbdzbjgd"
                + "nzcbwhgxhqkmwfbpbqdtjjzkqhylcgxfptyjyyzpsjlfchmqshgmmxsxjpkdcmbbqbefsjwhwwgckpylqbgldlcctnma"
                + "eddksjngkcsgxlhzaybdbtsdkdylhgymylcxpycjndqjwxqxfyyfjlejbzrwccqhqcsbzkymgplbmcrqcflnymyqmsqt"
                + "rbcjthztqfrxchxmcjcjlxqgjmshzkbswxemdlckfsydsglycjjssjnqbjctyhbftdcyjdgwyghqfrxwckqkxebpdjpx"
                + "jqsrmebwgjlbjslyysmdxlclqkxlhtjrjjmbjhxhwywcbhtrxxglhjhfbmgykldyxzpplggpmtcbbajjzyljtyanjgbj"
                + "flqgdzyqcaxbkclecjsznslyzhlxlzcghbxzhznytdsbcjkdlzayffydlabbgqszkggldndnyskjshdlxxbcghxyggdj"
                + "mmzngmmccgwzszxsjbznmlzdthcqydbdllscddnlkjyhjsycjlkohqasdhnhcsgaehdaashtcplcpqybsdmpjlpcjaql"
                + "cdhjjasprchngjnlhlyyqyhwzpnccgwwmzffjqqqqxxaclbhkdjxdgmmydjxzllsygxgkjrywzwyclzmcsjzldbndcfc"
                + "xyhlschycjqppqagmnyxpfrkssbjlyxyjjglnscmhcwwmnzjjlhmhchsyppttxrycsxbyhcsmxjsxnbwgpxxtaybgajc"
                + "xlypdccwqocwkccsbnhcpdyznbcyytyckskybsqkkytqqxfcwchcwkelcqbsqyjqcclmthsywhmktlkjlychwheqjhtj"
                + "hppqpqscfymmcmgbmhglgsllysdllljpchmjhwljcyhzjxhdxjlhxrswlwzjcbxmhzqxsdzpmgfcsglsdymjshxpjxom"
                + "yqknmyblrthbcftpmgyxlchlhlzylxgsssscclsldclepbhshxyyfhbmgdfycnjqwlqhjjcywjztejjdhfblqxtqkwhd"
                + "chqxagtlxljxmsljhdzkzjecxjcjnmbbjcsfywkbjzghysdcpqyrsljpclpwxsdwejbjcbcnaytmgmbapclyqbclzxcb"
                + "nmsggfnzjjbzsfqyndxhpcqkzczwalsbccjxpozgwkybsgxfcfcdkhjbstlqfsgdslqwzkxtmhsbgzhjcrglyjbpmljs"
                + "xlcjqqhzmjczydjwbmjklddpmjegxyhylxhlqyqhkycwcjmyhxnatjhyccxzpcqlbzwwwtwbqcmlbmynjcccxbbsnzzl"
                + "jpljxyztzlgcldcklyrzzgqtgjhhgjljaxfgfjzslcfdqzlclgjdjcsnclljpjqdcclcjxmyzftsxgcgsbrzxjqqcczh"
                + "gyjdjqqlzxjyldlbcyamcstylbdjbyregklzdzhldszchznwczcllwjqjjjkdgjcolbbzppglghtgzcygezmycnqcycy"
                + "hbhgxkamtxyxnbskyzzgjzlqjdfcjxdygjqjjpmgwgjjjpkjsbgbmmcjssclpqpdxcdyykypcjddyygywchjrtgcnyql"
                + "dkljczzgzccjgdyksgpzmdlcphnjafyzdjcnmwescsglbtzcgmsdllyxqsxsbljsbbsgghfjlwpmzjnlyywdqshzxtyy"
                + "whmcyhywdbxbtlmswyyfsbjcbdxxlhjhfpsxzqhfzmqcztqcxzxrdkdjhnnyzqqfnqdmmgnydxmjgdhcdycbffallztd"
                + "ltfkmxqzdngeqdbdczjdxbzgsqqddjcmbkxffxmkdmcsychzcmljdjynhprsjmkmpcklgdbqtfzswtfgglyplljzhgjj"
                + "gypzltcsmcnbtjbhfkdhbyzgkpbbymtdlsxsbnpdkleycjnycdykzddhqgsdzsctarlltkzlgecllkjljjaqnbdggghf"
                + "jtzqjsecshalqfmmgjnlyjbbtmlycxdcjpldlpcqdhsycbzsckbzmsljflhrbjsnbrgjhxpdgdjybzgdlgcsezgxlblg"
                + "yxtwmabchecmwyjyzlljjshlgndjlslygkdzpzxjyyzlpcxszfgwyydlyhcljscmbjhblyjlycblydpdqysxktbytdkd"
                + "xjypcnrjmfdjgklccjbctbjddbblblcdqrppxjcglzcshltoljnmdddlngkaqakgjgyhheznmshrphqqjchgmfprxcjg"
                + "dychghlyrzqlcngjnzsqdkqjymszswlcfqjqxgbggxmdjwlmcrnfkkfsyyljbmqammmycctbshcptxxzzsmphfshmclm"
                + "ldjfyqxsdyjdjjzzhqpdszglssjbckbxyqzjsgpsxjzqznqtbdkwxjkhhgflbcsmdldgdzdblzkycqnncsybzbfglzzx"
                + "swmsccmqnjqsbdqsjtxxmbldxcclzshzcxrqjgjylxzfjphymzqqydfqjjlcznzjcdgzygcdxmzysctlkphtxhtlbjxj"
                + "lxscdqccbbqjfqzfsltjbtkqbsxjjljchczdbzjdczjccprnlqcgpfczlclcxzdmxmphgsgzgszzqjxlwtjpfsyaslcj"
                + "btckwcwmytcsjjljcqlwzmalbxyfbpnlschtgjwejjxxglljstgshjqlzfkcgnndszfdeqfhbsaqdgylbxmmygszldyd"
                + "jmjjrgbjgkgdhgkblgkbdmbylxwcxyttybkmrjjzxqjbhlmhmjjzmqasldcyxyqdlqcafywyxqhz";
                String _gbcode = GBCode.ToString();
                int pos = (Convert.ToInt16(_gbcode.Substring(0, 2)) - 56) * 94 + Convert.ToInt16(_gbcode.Substring(_gbcode.Length - 2, 2));
                return CodeData.Substring(pos - 1, 1);
            }
            return " ";
        }

        //注册加密狗方法,DLL模式
        [DllImport("Rockey3.dll")]
        public static extern uint RY3_Find(string strVendorID, ref int iCount);
        [DllImport("Rockey3.dll")]
        public static extern uint RY3_SHA1(uint handle, byte[] pBuf, int len, byte[] pSHA1);
        [DllImport("Rockey3.dll")]
        public static extern uint RY3_Open(ref uint hHandle, int iIndex);

        //<summary>
        //检验狗,check dog return boolean
        //</summary>
        public static bool checkDog()
        {
            string R3_VENDOR = "AAD5178E";
            int iCount = 0;
            uint res = RY3_Find(R3_VENDOR, ref iCount);

            if (res == 0x00000000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //<summary>
        //通过hash算法得到密码,输入字符串,得到hash值
        //</summary>
        public static string GetHashCode(string str)
        {

            //输入加密狗的ID
            string R3_VENDOR = "AAD5178E";
            int iCount = 0;
            uint hHandle = 0;
            byte[] pSHA1 = new byte[20];
            byte[] pBuf = new byte[128];
            StringBuilder sb = new StringBuilder();
            pBuf = Encoding.UTF8.GetBytes(str);

            //创建加密狗对象
            //RY3Com ry3 = new RY3Com();
            //通过ID找到对应加密狗
            //ry3.RY3Com_Find(R3_VENDOR);
            RY3_Find(R3_VENDOR, ref iCount);
            //打开找到的第一只狗
            RY3_Open(ref hHandle, 1);
            //通过HASH算法返回密码值
            RY3_SHA1(hHandle, pBuf, 128, pSHA1);
            str = Encoding.Default.GetString(pSHA1);
            foreach (byte b in pSHA1)
            {
                sb.Append(Convert.ToString(b, 16).ToUpper().PadLeft(2, '0'));
            }

            return sb.ToString();

        }

        public static bool CheckRegex(string str)
        {
            Regex regExp = new Regex("[~!@#$%^&*=+[\\]{}''\"><`|￥\\》《]");
            return regExp.IsMatch(str);
        }

        public static bool CheckCompanyName(string str)
        {
            if (!str.Contains('\\'))
            {
                
                Regex regExp = new Regex("[/:\"|[\\]*?<>]");
                return regExp.IsMatch(str);
            }
            else
            {
                return true;
            }
        }
        //public static bool CheckID(string str)
        //{
        //    Regex regExp = new Regex(@"(^\d{15}$)|(\d{17}(?:\d|x|X)$)");
        //    return !regExp.IsMatch(str);
        //}

        /// <summary>
        /// 转义字符处理
        /// </summary>
        /// <param name="value">字符串</param>
        /// <returns>转义后的字符串</returns>
        public static string ChangeForSqlString(string value)
        {
            string returnValue = string.Empty;

            for (int i = 0; i < value.Length; i++)
            {
                //if (value[i].ToString().IndexOf("%") != -1 ||
                //    value[i].ToString().IndexOf("_") != -1 ||
                //    value[i].ToString().IndexOf("/") != -1 ||
                //    value[i].ToString().IndexOf("％") != -1 ||
                //    value[i].ToString().IndexOf("＿") != -1)
                //{
                //    returnValue = returnValue + "/" + value[i].ToString();
                //}
                //else 
                if (value[i].ToString().IndexOf("'") != -1)
                {
                    returnValue = returnValue + "'" + value[i].ToString();
                }
                else
                {
                    returnValue = returnValue + value[i].ToString();
                }
            }
            return returnValue;
        }

        public static string ChangeForSelString(string value)
        {
            string returnValue = string.Empty;

            for (int i = 0; i < value.Length; i++)
            {
                if (value[i].ToString().IndexOf("%") != -1 ||
                    value[i].ToString().IndexOf("_") != -1 ||
                    value[i].ToString().IndexOf("/") != -1 ||
                    value[i].ToString().IndexOf("％") != -1 ||
                    value[i].ToString().IndexOf("＿") != -1 ||
                    value[i].ToString().IndexOf("[") != -1)
                {
                    returnValue = returnValue + "[" + value[i].ToString() + "]";
                }
                else if (value[i].ToString().IndexOf("'") != -1)
                {
                    returnValue = returnValue + "'" + value[i].ToString();
                }
                else
                {
                    returnValue = returnValue + value[i].ToString();
                }
            }

            return returnValue;
        }

        /// <summary>
        /// 身份证号码验证
        /// </summary>
        /// <param name="id">身份证号码</param>
        /// <returns></returns>
        public static bool CheckIdCard(string id)
        {
            if (id.Length == 15)
            {
                bool check = CheckIdCard15(id);
                return check;
            }
            else if (id.Length == 18)
            {
                bool check = CheckIdCard18(id);
                return check;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 15位身份证验证
        /// </summary>
        /// <param name="id">身份证号码</param>
        /// <returns></returns>
        private static bool CheckIdCard15(string id)
        {
            long n = 0;

            if (long.TryParse(id, out n) == false || n < Math.Pow(10, 14))
            {
                return false;//数字验证
            }

            string address = "11x22x35x44x53x12x23x36x45x54x13x31x37x46x61x14x32x41x50x62x15x33x42x51x63x21x34x43x52x64x65x71x81x82x91";

            if (address.IndexOf(id.Remove(2)) == -1)
            {
                return false;//省份验证
            }

            string birthday = id.Substring(6, 6).Insert(4, "-").Insert(2, "-");

            DateTime time = new DateTime();

            if (DateTime.TryParse(birthday, out time) == false)
            {
                return false;//生日验证
            }

            return true;//符合15位身份验证
        }

        /// <summary>
        /// 18位身份证验证
        /// </summary>
        /// <param name="id">身份证号码</param>
        /// <returns></returns>
        private static bool CheckIdCard18(string id)
        {
            long n = 0;

            if (long.TryParse(id.Remove(17), out n) == false || n < Math.Pow(10, 16) || long.TryParse(id.Replace('x', '0').Replace('X', '0'), out n) == false)
            {
                return false;//数字验证
            }

            string address = "11x22x35x44x53x12x23x36x45x54x13x31x37x46x61x14x32x41x50x62x15x33x42x51x63x21x34x43x52x64x65x71x81x82x91";

            if (address.IndexOf(id.Remove(2)) == -1)
            {
                return false;//省份验证
            }

            string birthday = id.Substring(6, 8).Insert(6, "-").Insert(4, "-");

            DateTime time = new DateTime();

            if (DateTime.TryParse(birthday, out time) == false)
            {
                return false;//生日验证
            }

            string[] arrVarifyCode = ("1,0,x,9,8,7,6,5,4,3,2").Split(',');

            string[] Wi = ("7,9,10,5,8,4,2,1,6,3,7,9,10,5,8,4,2").Split(',');

            char[] Ai = id.Remove(17).ToCharArray();

            int sum = 0;

            for (int i = 0; i < 17; i++)
            {
                sum += int.Parse(Wi[i]) * int.Parse(Ai[i].ToString());
            }

            int y = -1;

            Math.DivRem(sum, 11, out y);

            if (arrVarifyCode[y] != id.Substring(17, 1).ToLower())
            {
                return false;//校验码验证
            }

            return true;//符合GB11643-1999标准
        }
    }
}
