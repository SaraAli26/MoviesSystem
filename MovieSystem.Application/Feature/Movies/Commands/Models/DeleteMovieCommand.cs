using MediatR;
using MovieSystem.Application.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Application.Feature.Movies.Commands.Models
{
    public class DeleteMovieCommand : IRequest<Response<string>>
    {
        public int MovieId { get; set; }
    }
}
