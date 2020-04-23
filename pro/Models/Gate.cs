using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pro.Models
{
    public class Gate
    {
        public Gate()
        {
            PersonnelsMovements = new Collection<PersonnelsMovement>();
        }
        [Key]
        public int Id { get; set; }

        [StringLength(128)]
        public string Label { get; set; }
        //giriş ise true, çıkış ise false
        public bool IsEnterPort { get; set; }

        public ICollection<PersonnelsMovement> PersonnelsMovements { get; set; }
    }
}
