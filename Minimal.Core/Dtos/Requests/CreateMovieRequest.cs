using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minimal.Core.Dtos.Requests
{
    public class CreateMovieRequest : IRequest<BaseResponseDto<bool>>
    {
        public string Name { get; set; }
        public double Rating { get; set; }

    }
}
