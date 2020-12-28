using MediatR;
using System.Collections.Generic;

namespace Minimal.Core.Dtos.Requests
{
    public class GetAllMoviesRequest : IRequest<BaseResponseDto<List<MovieDto>>>
    {
    }
}