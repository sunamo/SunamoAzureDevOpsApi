// variables names: ok
// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy
namespace SunamoAzureDevOpsApi._apis.git;

/*
 Pokud je celý váš JSON v malých písmenech (camelCase), nemusíte psát atributy ke každé vlastnosti. Můžete říct serializátoru, aby automaticky mapoval C# PascalCase na JSON camelCase.

Při deserializaci v kódu:

C#

var options = new JsonSerializerOptions
{
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
};

var user = JsonSerializer.Deserialize<UserProfile>(jsonString, options);
 * */

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class Project
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Url { get; set; }
    public string State { get; set; }
    public int Revision { get; set; }
    public string Visibility { get; set; }
    public DateTime LastUpdateTime { get; set; }
}

public class Repositories
{
    public List<Value> Value { get; set; }
    public int Count { get; set; }
}

public class Value
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
    public Project Project { get; set; }
    public string DefaultBranch { get; set; }
    public int Size { get; set; }
    public string RemoteUrl { get; set; }
    public string SshUrl { get; set; }
    public string WebUrl { get; set; }
    public bool IsDisabled { get; set; }
}
