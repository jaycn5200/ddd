using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Test.Core.Entity
{
  public  class PermissionEntity:BaseEntity
    {
        /// <summary>
        /// 权限名称
        /// </summary>
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        /// <summary>
        /// 权限描述
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Description { get; set; }

    }
}
