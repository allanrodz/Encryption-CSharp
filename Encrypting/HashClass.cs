﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Encrypting
{
    class HashClass
    {
        public string Passhash(string data)
        {

            SHA1 sha = SHA1.Create();
            byte[] hashdata = sha.ComputeHash(Encoding.Default.GetBytes(data));
            StringBuilder returnValue = new StringBuilder();


            for(int i = 0; i < hashdata.Length; i++)
            {
                returnValue.Append(hashdata[i].ToString());

            }

            return returnValue.ToString();
        }

    }
}