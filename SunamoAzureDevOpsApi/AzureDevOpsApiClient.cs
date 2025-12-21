namespace SunamoAzureDevOpsApi;

using Microsoft.TeamFoundation.SourceControl.WebApi;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AzureDevOpsApiClient(string organization, string personalAccessToken)
{
    public async Task<List<string>> LoadRepositories()
    {
        // EN: Connect to Azure DevOps
        // CZ: Připojení k Azure DevOps
        var connection = new VssConnection(new Uri($"https://dev.azure.com/{organization}"), new VssBasicCredential(string.Empty, $"{personalAccessToken}"));

        // EN: Get Git client
        // CZ: Získání klienta Git
        var gitClient = connection.GetClient<GitHttpClient>();

        // EN: Get list of repositories
        // CZ: Získání seznamu repozitářů
        var repositories = await gitClient.GetRepositoriesAsync();

        return repositories.Select(repository => repository.Name).ToList();
    }
}