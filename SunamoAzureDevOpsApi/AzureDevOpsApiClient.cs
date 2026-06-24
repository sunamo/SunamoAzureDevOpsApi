namespace SunamoAzureDevOpsApi;

using Microsoft.TeamFoundation.SourceControl.WebApi;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;

public class AzureDevOpsApiClient(string organization, string personalAccessToken)
{
    public async Task<List<string>> LoadRepositories()
    {
        var connection = new VssConnection(new Uri($"https://dev.azure.com/{organization}"), new VssBasicCredential(string.Empty, personalAccessToken));

        var gitClient = connection.GetClient<GitHttpClient>();

        var repositories = await gitClient.GetRepositoriesAsync();

        return repositories.Select(repository => repository.Name).ToList();
    }
}
