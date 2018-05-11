﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerMonitor.SiteDb
{
    interface DBInit
    {

        //设置数据库名称
        void SetDBFilename(string Filename);
        // 初始化数据库
        void InitDB(string DBFilename);
    }
}