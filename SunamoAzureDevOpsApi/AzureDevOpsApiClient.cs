namespace SunamoAzureDevOpsApi;

using Microsoft.TeamFoundation.SourceControl.WebApi;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;

/// <summary>
/// Azure dev ops api client.
/// </summary>
/// <param name="organization">The organization.</param>
/// <param name="personalAccessToken">The personal access token.</param>
/// <returns>The azure dev ops api client result.</returns>
public class AzureDevOpsApiClient(string organization, string personalAccessToken)
{
    /// <summary>
    /// Load repositories.
    /// </summary>
    /// <returns>The load repositories result.</returns>
    public async Task<List<string>> LoadRepositories()
    {
        var connection = new VssConnection(new Uri($"https://dev.azure.com/{organization}"), new VssBasicCredential(string.Empty, personalAccessToken));

        var gitClient = connection.GetClient<GitHttpClient>();

        var repositories = await gitClient.GetRepositoriesAsync();

        return repositories.Select(repository => repository.Name).ToList();
    }
}
