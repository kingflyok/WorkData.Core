﻿// ------------------------------------------------------------------------------
// Copyright  吴来伟个人 版权所有。
// 项目名：Domain.Core
// 文件名：BaseUser.cs
// 创建标识：吴来伟 2017-12-19 11:33
// 创建描述：
//
// 修改标识：吴来伟2017-12-19 11:33
// 修改描述：
//  ------------------------------------------------------------------------------

using System.Collections.Generic;
using WorkData.Code.Entities;
using WorkData.Code.Repositories;
using WorkData.Code.WorkDataIdentity;
using WorkData.Domain.Permissions.UserRoles;

namespace WorkData.Domain.Permissions.Users
{
    /// <summary>
    /// BaseUser
    /// </summary>
    public class BaseUser : BaseUserIdentity<string>, IAggregateRoot, IEntity<string>
    {
        /// <summary>
        /// Id
        /// </summary>
        public override string Id { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        #region Relation

        public IList<UserRole> UserRoles { get; set; }

        public BaseUserMember BaseUserMember { get; set; }

        #endregion Relation
    }
}