using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Contract.DTO
{
  public  class BaseDto
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        public DateTime CreateTime { get; set; }

    }
}
