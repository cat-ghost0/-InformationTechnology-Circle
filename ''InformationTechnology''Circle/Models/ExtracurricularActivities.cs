//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace @__InformationTechnology__Circle.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ExtracurricularActivities
    {
        public int ID_EA { get; set; }
        public string Specialization { get; set; }
        public int Teacher { get; set; }
        public System.DateTime Date { get; set; }
        public System.DateTime Time { get; set; }
        public string Class { get; set; }
        public int User { get; set; }
    
        public virtual Teacher Teacher1 { get; set; }
        public virtual User User1 { get; set; }
    }
}