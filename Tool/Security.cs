﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Configuration;
using Encrypt;

namespace Tool
{
    public class Security
    {
        public static string MD5Encrypt(string text, Encoding encoding)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] result = encoding.GetBytes(text);
            result = md5.ComputeHash(result);
            StringBuilder ret = new StringBuilder();
            foreach (byte b in result) ret.AppendFormat("{0:X2}", b);
            return ret.ToString();
        }


        public static string MD5Encrypt(string text)
        {
            return MD5Encrypt(text, Encoding.UTF8);
        }

        /// <summary>
        /// 获取连接字符串
        /// </summary>
        public static string ConnectionString
        {
            get
            {
                string _connectionString = ConfigurationManager.ConnectionStrings["Entities"].ConnectionString; ;

                _connectionString = new SymmetricMethod().Decrypto(_connectionString);

                return _connectionString;
            }
        }
 
    }
}
