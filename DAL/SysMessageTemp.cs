//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Langben.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class SysMessageTemp
    {
        public SysMessageTemp()
        {
            this.SysMessage = new HashSet<SysMessage>();
        }
    
        public string Id { get; set; }
        public string MessageName { get; set; }
        public string Content { get; set; }
        public string IsDefault { get; set; }
        public string MessageType { get; set; }
        public string Remark { get; set; }
        public string State { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string CreatePerson { get; set; }
    
        public virtual ICollection<SysMessage> SysMessage { get; set; }
    }
}
