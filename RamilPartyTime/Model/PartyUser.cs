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
    
    public partial class PartyUser
    {
        public int id { get; set; }
        public Nullable<int> idUser { get; set; }
        public Nullable<int> idParty { get; set; }
    
        public virtual PartyEvent PartyEvent { get; set; }
        public virtual UserApp UserApp { get; set; }
    }
}
