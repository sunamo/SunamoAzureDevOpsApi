namespace SunamoAzureDevOpsApi;

using SunamoAzureDevOpsApi._apis.git;
using System.Text;

/// <summary>
/// Represents the azure dev ops api parser type.
/// </summary>
public class AzureDevOpsApiParser
{
    /// <summary>
    /// Parse repositories.
    /// </summary>
    /// <param name="jsonResponse">The json response.</param>
    /// <param name="cloneUrlTemplate">The clone url template.</param>
    /// <returns>The parse repositories result.</returns>
    public static string ParseRepositories(string jsonResponse, string cloneUrlTemplate)
    {
        var repositories = JsonConvert.DeserializeObject<Repositories>(jsonResponse);

        if (repositories is null)
        {
            return string.Empty;
        }

        StringBuilder gitCloneCommands = new();

        foreach (var repository in repositories.Value)
        {
            gitCloneCommands.AppendLine($"git clone {string.Format(cloneUrlTemplate, repository.Name)}");
        }

        return gitCloneCommands.ToString();
    }
}
