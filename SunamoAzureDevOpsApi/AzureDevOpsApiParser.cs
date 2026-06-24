namespace SunamoAzureDevOpsApi;

using SunamoAzureDevOpsApi._apis.git;
using System.Text;

public class AzureDevOpsApiParser
{
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
