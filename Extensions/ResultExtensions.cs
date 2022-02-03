using AutoMapper;
using hello_asp_identity.Contracts.V1.Responses;
using hello_asp_identity.Domain.Errors;
using hello_asp_identity.Domain.Results;
using Microsoft.AspNetCore.Mvc;

namespace hello_asp_identity.Extensions;

public static class ResultExtensions
{

    // for non-generic results
    public static IActionResult MatchResponse<T>(this Result a, T customResponse, IMapper mapper)
    {
        if (a.Failed())
        {
            if (a.GetOriginError() is NotFoundError)
            {
                return new NotFoundResult();
            }
            return new BadRequestObjectResult(new ErrorResponse<ErrorModelResponse>(mapper.Map<List<ErrorModelResponse>>(a.Errors)));

        }
        return new OkObjectResult(new Response<T>(mapper.Map<T>(customResponse)));
    }

    //for generic results
    public static IActionResult MatchResponse<T>(this Result<T> a, IMapper mapper)
    {
        // a.Then only used as introduction to this method
        // actually it is kind of pointless here

        // a.Then(...) can here not infere the base - type
        // that because it has to be specified here
        return a.Then<IActionResult>(a =>
        {
            if (a.Failed())
            {
                if (a.GetOriginError() is NotFoundError)
                {
                    return new NotFoundResult();
                }
                return new BadRequestObjectResult(new ErrorResponse<ErrorModelResponse>(mapper.Map<List<ErrorModelResponse>>(a.Errors)));

            }
            return new OkObjectResult(new Response<RegisterResponse>(mapper.Map<RegisterResponse>(a.Value)));
        });
    }
}