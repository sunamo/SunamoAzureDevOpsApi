namespace SunamoAzureDevOpsApi;

using SunamoAzureDevOpsApi._apis.git;
using System.Text;

/// <summary>
/// Parser for Azure DevOps API responses.
/// </summary>
public class AzureDevOpsApiParser
{
    /// <summary>
    /// Parses JSON response containing repositories and generates git clone commands.
    /// </summary>
    /// <param name="jsonResponse">JSON response from Azure DevOps API.</param>
    /// <param name="cloneUrlTemplate">URL template for git clone command (use {0} for repository name).</param>
    /// <returns>String containing git clone commands for all repositories.</returns>
    public static string ParseRepositories(string jsonResponse, string cloneUrlTemplate)
    {
        var repositories = JsonConvert.DeserializeObject<Repositories>(jsonResponse);

        if (repositories == null)
        {
            return string.Empty;
        }

        StringBuilder gitCloneCommands = new();

        foreach (var repository in repositories.Value)
        {
            gitCloneCommands.AppendLine("git clone " + string.Format(cloneUrlTemplate, repository.Name));
        }

        return gitCloneCommands.ToString();
    }
}
