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
    
    public partial class UserApp
    {
        public UserApp()
        {
            this.Chat = new HashSet<Chat>();
            this.Chat1 = new HashSet<Chat>();
            this.PartyUser = new HashSet<PartyUser>();
        }
    
        public int id { get; set; }
        public string Password { get; set; }
        public string PhotoProfile { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public Nullable<int> idCity { get; set; }
        public string PhoneNum { get; set; }
    
        public virtual ICollection<Chat> Chat { get; set; }
        public virtual ICollection<Chat> Chat1 { get; set; }
        public virtual City City { get; set; }
        public virtual ICollection<PartyUser> PartyUser { get; set; }
    }
}
