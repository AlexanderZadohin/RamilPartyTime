//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RamilPartyTime.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class City
    {
        public City()
        {
            this.UserApp = new HashSet<UserApp>();
        }
    
        public int id { get; set; }
        public string NameCity { get; set; }
    
        public virtual ICollection<UserApp> UserApp { get; set; }
    }
}