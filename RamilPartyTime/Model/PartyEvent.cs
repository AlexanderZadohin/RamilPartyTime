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
    
    public partial class PartyEvent
    {
        public PartyEvent()
        {
            this.PartyUser = new HashSet<PartyUser>();
        }
    
        public int id { get; set; }
        public string NameEvent { get; set; }
        public Nullable<System.DateTime> DateEvent { get; set; }
        public string ImageEvent { get; set; }
    
        public virtual ICollection<PartyUser> PartyUser { get; set; }
    }
}
