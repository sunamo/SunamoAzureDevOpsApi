// variables names: ok
namespace SunamoAzureDevOpsApi;

using Microsoft.TeamFoundation.SourceControl.WebApi;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// EN: Client for interacting with Azure DevOps API
/// CZ: Klient pro komunikaci s Azure DevOps API
/// </summary>
/// <param name="organization">EN: Azure DevOps organization name / CZ: Název organizace v Azure DevOps</param>
/// <param name="personalAccessToken">EN: Personal Access Token for authentication / CZ: Osobní přístupový token pro autentizaci</param>
public class AzureDevOpsApiClient(string organization, string personalAccessToken)
{
    /// <summary>
    /// EN: Loads list of repository names from Azure DevOps
    /// CZ: Načte seznam názvů repozitářů z Azure DevOps
    /// </summary>
    /// <returns>EN: List of repository names / CZ: Seznam názvů repozitářů</returns>
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