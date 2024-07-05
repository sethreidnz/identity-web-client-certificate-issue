using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Graph;

namespace MultiOrgApp.Pages;

public class IndexModel : PageModel
{
    private readonly GraphServiceClient _graphServiceClient;

    public IndexModel(GraphServiceClient graphServiceClient)
    {
        _graphServiceClient = graphServiceClient;
    }

    public async Task OnGet()
    {
        // You can add any logic here that needs to run before the view is rendered
        var requestBody = new Microsoft.Graph.Me.CheckMemberGroups.CheckMemberGroupsPostRequestBody
        {
            GroupIds = new List<string> { "123" }
        };
        var members = await _graphServiceClient.Me.CheckMemberGroups.PostAsCheckMemberGroupsPostResponseAsync(requestBody);
        
    }
}
