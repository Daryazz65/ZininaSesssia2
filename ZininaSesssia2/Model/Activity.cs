//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZininaSesssia2.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Activity
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public System.DateTime DateTimeStart { get; set; }
        public int IdDisciplineDepartment { get; set; }
    
        public virtual DisciplineDepartment DisciplineDepartment { get; set; }
        public virtual User User { get; set; }
    }
}