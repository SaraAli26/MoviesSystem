using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Domain.Entities
{
    public class Review
    {
        public int Id { get; set; }

        public int MovieId { get; set; }

        public string Subject { get; set; }

        public string Comment { get; set; }

        public DateTime Date { get; set; }

        public Movie Movie { get; set; }
    }

}
