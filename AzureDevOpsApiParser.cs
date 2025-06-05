using SunamoAzureDevOpsApi._apis.git;
using SunamoPS;

namespace SunamoAzureDevOpsApi;

public class AzureDevOpsApiParser
{
    public static string ParseRepositories(string s, PowershellBuilder d, string urlClone)
    {

        //urlClone = "ssh://devops.skoda.vwgroup.com:22/projects/EOM-7/IAServices/_git/" + item.name;

        var myDeserializedClass = JsonConvert.DeserializeObject<Repositories>(s);

        //var d = PowershellBuilder.Create(TextBuilder.Create);
        foreach (var item in myDeserializedClass.value)
        {
            d.Git.Clone(string.Format(urlClone, item.name), "");
        }

        return d.ToString();
    }
}
