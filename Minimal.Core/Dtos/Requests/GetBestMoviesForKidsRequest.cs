using MediatR;
using System.Collections.Generic;

namespace Minimal.Core.Dtos.Requests
{
    public class GetBestMoviesForKidsRequest : IRequest<BaseResponseDto<List<MovieDto>>>
    {
    }
}