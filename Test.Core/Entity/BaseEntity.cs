using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Core.Entity
{
   public class BaseEntity
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 软删除
        /// </summary>
        public bool IsDelete { get; set; } = false;
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; } = DateTime.Now;



    }
}
