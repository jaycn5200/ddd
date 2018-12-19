using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Core.Entity
{
   public class RolePermissionEntity
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 角色编号
        /// </summary>
        public int RoleId { get; set; }
        /// <summary>
        /// 权限编号
        /// </summary>
        public int PermissionId { get; set; }

        public RoleEntity Role { get; set; }

        public PermissionEntity Permission { get; set; }
    }
    }

