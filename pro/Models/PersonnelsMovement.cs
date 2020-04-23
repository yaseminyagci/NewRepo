using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace pro.Models
{
    public class PersonnelsMovement
    {
        [Key]
        public int Id { get; set; }

        public DateTime ActionDate { get; set; }

        [ForeignKey("User")]
        [StringLength(128)]
        public string UserId { get; set; }

        [ForeignKey("Gate")]
        public int GateId { get; set; }
        public Gate Gate { get; set; }

        [ForeignKey("WorkTimeWeek")]
        public int WorkTimeWeekId { get; set; }
        public WorkTimeWeek WorkTimeWeek { get; set; }
    }
}
