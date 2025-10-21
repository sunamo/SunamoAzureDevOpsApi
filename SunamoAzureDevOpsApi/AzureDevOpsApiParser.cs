// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoAzureDevOpsApi;

using SunamoAzureDevOpsApi._apis.git;
using System.Text;

public class AzureDevOpsApiParser
{
    public static string ParseRepositories(string jsonResponse, string urlClone)
    {
        var repositories = JsonConvert.DeserializeObject<Repositories>(jsonResponse);

        StringBuilder gitCloneCommands = new();

        foreach (var item in repositories.value)
        {
            gitCloneCommands.AppendLine("git clone " + string.Format(urlClone, item.name));
        }

        return gitCloneCommands.ToString();
    }
}