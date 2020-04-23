using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pro.Models
{
    public class WorkTimeWeek
    {
        public WorkTimeWeek()
            {
                PersonnelsMovements = new Collection<PersonnelsMovement>();

            }
            [Key]
            public int Id { get; set; }

            public int Iso8601WeekNo { get; set; }

            public DateTime WeekHeader { get; set; }

            public ICollection<PersonnelsMovement> PersonnelsMovements { get; set; }

        
    }
}
