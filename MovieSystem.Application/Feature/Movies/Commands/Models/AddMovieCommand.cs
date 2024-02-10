using MediatR;
using MovieSystem.Application.Base;
using MovieSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Application.Feature.Movies.Commands.Models
{
    public class AddMovieCommand : IRequest<Response<string>>
    {
        public string Name { get; set; }

        public string Poster { get; set; }

        public string Video { get; set; }

        public bool Type { get; set; }

        public int CategoryId { get; set; }

    }
}
