using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using InvoicingUtil;

namespace DataAccesses
{
    public class SearchParameter
    {
        private System.Collections.Hashtable ht = new System.Collections.Hashtable();

        /// <summary>
        /// set search paramters
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="value">value</param>
        public void SetValue(string key, Object value)
        {
            if (!key.StartsWith(":CONDITION"))
            {
                if (value.GetType().Name == "String")
                {
                    ht.Add(key, Util.ChangeForSelString(value.ToString()));
                }
                else
                {
                    ht.Add(key, value);
                }
            }
            else
            {
                ht.Add(key, value);
            }
        }

        /// <summary>
        /// get search paramters
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>value</returns>
        public object GetValue(string key)
        {
            return ht[key].ToString().Trim();
        }

        /// <summary>
        /// check the paramters 
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>true:exists,false:not exists</returns>
        public bool Contains(string key)
        {
            return ht.Contains(key);
        }

        /// <summary>
        /// 清除所有数据
        /// </summary>
        public void Clear()
        {
            ht.Clear();
        }

        /// <summary>
        /// remove the data by key
        /// </summary>
        /// <param name="key">key</param>
        public void Remove(string key)
        {
            if (ht.Contains(key))
            {
                ht.Remove(key);
            }
        }

        /// <summary>
        /// 参数数量
        /// </summary>
        /// <returns>参数数量</returns>
        public int Count()
        {
            if (ht == null)
            {
                return 0;
            }
            else
            {
                return ht.Count;
            }
        }

        /// <summary>
        /// 取得参数的Key值
        /// </summary>
        /// <returns>Key名</returns>
        public ArrayList Keys()
        {
            ArrayList keys = new ArrayList(ht.Keys);
            
            return keys;
        }

        /// <summary>
        /// 直接取得HashTable，此处为取得key值准备
        /// </summary>
        public Hashtable GetHashTable
        {
            get
            {
                return ht;
            }
        }
    }
}
