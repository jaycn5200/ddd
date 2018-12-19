using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Test.Core.Entity
{
   public class AdminUserEntity:BaseEntity
    {
        /// <summary>
        /// 手机号
        /// </summary>
        [Required]
        [MaxLength(11)]
        [Phone]
        public string PhoneNumber { get; set; }
        /// <summary>
        /// 加密密码
        /// </summary>
        [MaxLength(50)]
        [Required]
        public string PasswordHash { get; set; }
        /// <summary>
        /// 随机加密盐
        /// </summary>
        public string PasswordSalt { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}
