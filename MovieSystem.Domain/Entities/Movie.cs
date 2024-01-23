using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Domain.Entities
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Poster { get; set; }

        public string Video { get; set; }

        public bool Type { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }

}
