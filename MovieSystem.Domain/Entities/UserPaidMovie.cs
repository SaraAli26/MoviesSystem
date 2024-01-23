using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Domain.Entities
{
    public class UserPaidMovie
    {
        [Key]
        public int Id { get; set; }

        public int MovieId { get; set; }

        public Movie Movie { get; set; }
    }

}
