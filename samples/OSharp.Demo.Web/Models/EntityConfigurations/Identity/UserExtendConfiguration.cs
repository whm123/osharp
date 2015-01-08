﻿// -----------------------------------------------------------------------
//  <copyright file="UserExtendConfiguration.cs" company="OSharp开源团队">
//      Copyright (c) 2015 OSharp. All rights reserved.
//  </copyright>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2015-01-08 2:01</last-date>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using OSharp.Core.Data.Entity;


namespace OSharp.Demo.Web.Models.EntityConfigurations.Identity
{
    public class UserExtendConfiguration : EntityConfigurationBase<UserExtend, int>
    {
        public UserExtendConfiguration()
        {
            HasRequired(m => m.User).WithRequiredDependent(n => n.Extend);
        }
    }
}