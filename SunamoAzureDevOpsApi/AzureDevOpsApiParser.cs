namespace SunamoAzureDevOpsApi;

using SunamoAzureDevOpsApi._apis.git;
using System.Text;

/// <summary>
/// EN: Parser for Azure DevOps API responses
/// CZ: Parser pro odpovědi z Azure DevOps API
/// </summary>
public class AzureDevOpsApiParser
{
    /// <summary>
    /// EN: Parses JSON response containing repositories and generates git clone commands
    /// CZ: Parsuje JSON odpověď obsahující repozitáře a generuje git clone příkazy
    /// </summary>
    /// <param name="jsonResponse">EN: JSON response from Azure DevOps API / CZ: JSON odpověď z Azure DevOps API</param>
    /// <param name="urlClone">EN: URL template for git clone command (use {0} for repository name) / CZ: URL šablona pro git clone příkaz (použijte {0} pro název repozitáře)</param>
    /// <returns>EN: String containing git clone commands for all repositories / CZ: Řetězec obsahující git clone příkazy pro všechny repozitáře</returns>
    public static string ParseRepositories(string jsonResponse, string urlClone)
    {
        var repositories = JsonConvert.DeserializeObject<Repositories>(jsonResponse);

        if (repositories == null)
        {
            return string.Empty;
        }

        StringBuilder gitCloneCommands = new();

        foreach (var repository in repositories.Value)
        {
            gitCloneCommands.AppendLine("git clone " + string.Format(urlClone, repository.Name));
        }

        return gitCloneCommands.ToString();
    }
}