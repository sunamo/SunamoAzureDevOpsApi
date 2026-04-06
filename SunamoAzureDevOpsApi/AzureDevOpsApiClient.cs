namespace SunamoAzureDevOpsApi;

using Microsoft.TeamFoundation.SourceControl.WebApi;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;

/// <summary>
/// Client for interacting with Azure DevOps API.
/// </summary>
/// <param name="organization">Azure DevOps organization name.</param>
/// <param name="personalAccessToken">Personal Access Token for authentication.</param>
public class AzureDevOpsApiClient(string organization, string personalAccessToken)
{
    /// <summary>
    /// Loads list of repository names from Azure DevOps.
    /// </summary>
    /// <returns>List of repository names.</returns>
    public async Task<List<string>> LoadRepositories()
    {
        var connection = new VssConnection(new Uri($"https://dev.azure.com/{organization}"), new VssBasicCredential(string.Empty, personalAccessToken));

        var gitClient = connection.GetClient<GitHttpClient>();

        var repositories = await gitClient.GetRepositoriesAsync();

        return repositories.Select(repository => repository.Name).ToList();
    }
}
