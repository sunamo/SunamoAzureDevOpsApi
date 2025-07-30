namespace SunamoAzureDevOpsApi;

using SunamoAzureDevOpsApi._apis.git;
using System.Text;

public class AzureDevOpsApiParser
{
    public static string ParseRepositories(string s, string urlClone)
    {
        var myDeserializedClass = JsonConvert.DeserializeObject<Repositories>(s);

        StringBuilder sb = new();

        foreach (var item in myDeserializedClass.value)
        {
            sb.AppendLine("git clone " + string.Format(urlClone, item.name));
        }

        return sb.ToString();
    }
}