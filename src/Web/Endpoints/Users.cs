using Aqua_Diary_API.Infrastructure.Identity;

namespace Aqua_Diary_API.Web.Endpoints;

public class Users : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .MapIdentityApi<ApplicationUser>();
    }
}
