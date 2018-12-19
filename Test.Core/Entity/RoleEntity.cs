using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Test.Core.Entity
{
  public  class RoleEntity:BaseEntity
    {
        /// <summary>
        /// 角色名称
        /// </summary>
        [Required]
        public string Name { get; set; }
    }
}
