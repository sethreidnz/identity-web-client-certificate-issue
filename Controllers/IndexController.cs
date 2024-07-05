using Microsoft.AspNetCore.Mvc;
using Microsoft.Graph;

namespace MultiOrgApp.Controllers;

public class IndexController(GraphServiceClient graphServiceClient) : Controller
{
    public async Task<IActionResult> Index()
    {
        // You can add any logic here that needs to run before the view is rendered
        var requestBody = new Microsoft.Graph.Me.CheckMemberGroups.CheckMemberGroupsPostRequestBody
        {
            GroupIds = new List<string> { "" }
        };
        await graphServiceClient.Me.CheckMemberGroups.PostAsCheckMemberGroupsPostResponseAsync(requestBody);
        return View();
    }
}