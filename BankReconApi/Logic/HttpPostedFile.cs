﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankReconApi.Logic
{
    public class HttpPostedFile
    {
        public HttpPostedFile(string name, string filename, byte[] file)
        {
            
        }

        public string Name { get; private set; }
        public string Filename { get; private set; }
        public byte[] File { private set; get; }
    }
}