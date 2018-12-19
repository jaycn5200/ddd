using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Core.Entity
{
   public class AdminUserRoleEntity
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
        /// 管理员编号
        /// </summary>
        public int AdminUserId { get; set; }

        public RoleEntity Role { get; set; }

        public AdminUserEntity AdminUser { get; set; }
    }
}
