//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EducationalPracticeWpf
{
    using System;
    using System.Collections.Generic;
    
    public partial class Activity
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public Nullable<System.DateTime> LoginTime { get; set; }
        public Nullable<System.DateTime> LogoutTime { get; set; }
        public string Comments { get; set; }
    
        public virtual Users Users { get; set; }
    }
}
