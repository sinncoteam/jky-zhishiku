﻿/*----------------------------------------------------------------
// Copyright (C) 2016 联康洪 版权所有。 
//
// 文件名：Role.cs
// 文件功能描述： 领域层实体定义(Model)
//
// 
// 创建标识：   dxk -- 2017/1/12 14:43:09 
//
// 修改标识：   
// 修改描述：   
//----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JFB.Systems.Domain.Model;

namespace JFB.Systems.Domain.Info
{
    public class RoleInfo:  Role
    {
        public string IsvalidName
        {
            get
            {
                if (Isvalid == 1)
                {
                    return "正常";
                }
                return "禁用";
            }
        }
    }
}