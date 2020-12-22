using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minimal.Core.Dtos.Requests
{
    public class GetBestMoviesForKidsRequest : IRequest<BaseResponseDto<List<MovieDto>>>
    {
    }
}
