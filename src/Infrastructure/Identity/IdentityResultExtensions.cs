﻿using Aqua_Diary_API.Application.Common.Models;
using Microsoft.AspNetCore.Identity;

namespace Aqua_Diary_API.Infrastructure.Identity;

public static class IdentityResultExtensions
{
    public static Result ToApplicationResult(this IdentityResult result)
    {
        return result.Succeeded
            ? Result.Success()
            : Result.Failure(result.Errors.Select(e => e.Description));
    }
}
