using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace TaskManager.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime EnterDate { get; set; }
        public string JobType { get; set; }
        public string JobDuration { get; set; }
    }
}
