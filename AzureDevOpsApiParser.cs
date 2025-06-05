namespace SunamoAzureDevOpsApi;

using SunamoAzureDevOpsApi._apis.git;
using SunamoPS;

public class AzureDevOpsApiParser
{
    public static string ParseRepositories(string s, PowershellBuilder d, string urlClone)
    {
        var myDeserializedClass = JsonConvert.DeserializeObject<Repositories>(s);

        foreach (var item in myDeserializedClass.value)
        {
            d.Git.Clone(string.Format(urlClone, item.name), "");
        }

        return d.ToString();
    }
}