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
/// <summary>
/// EN: Represents an Azure DevOps project
/// CZ: Reprezentuje Azure DevOps projekt
/// </summary>
public class Project
{
    /// <summary>
    /// EN: Project identifier / CZ: Identifikátor projektu
    /// </summary>
    public required string Id { get; set; }

    /// <summary>
    /// EN: Project name / CZ: Název projektu
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// EN: Project description / CZ: Popis projektu
    /// </summary>
    public required string Description { get; set; }

    /// <summary>
    /// EN: Project API URL / CZ: API URL projektu
    /// </summary>
    public required string Url { get; set; }

    /// <summary>
    /// EN: Project state / CZ: Stav projektu
    /// </summary>
    public required string State { get; set; }

    /// <summary>
    /// EN: Project revision number / CZ: Číslo revize projektu
    /// </summary>
    public int Revision { get; set; }

    /// <summary>
    /// EN: Project visibility (public/private) / CZ: Viditelnost projektu (veřejný/soukromý)
    /// </summary>
    public required string Visibility { get; set; }

    /// <summary>
    /// EN: Last update timestamp / CZ: Časová značka poslední aktualizace
    /// </summary>
    public DateTime LastUpdateTime { get; set; }
}

/// <summary>
/// EN: Container for repository list response
/// CZ: Kontejner pro odpověď se seznamem repozitářů
/// </summary>
public class Repositories
{
    /// <summary>
    /// EN: List of repositories / CZ: Seznam repozitářů
    /// </summary>
    public required List<Value> Value { get; set; }

    /// <summary>
    /// EN: Total count of repositories / CZ: Celkový počet repozitářů
    /// </summary>
    public int Count { get; set; }
}

/// <summary>
/// EN: Represents an Azure DevOps repository
/// CZ: Reprezentuje Azure DevOps repozitář
/// </summary>
public class Value
{
    /// <summary>
    /// EN: Repository identifier / CZ: Identifikátor repozitáře
    /// </summary>
    public required string Id { get; set; }

    /// <summary>
    /// EN: Repository name / CZ: Název repozitáře
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// EN: Repository API URL / CZ: API URL repozitáře
    /// </summary>
    public required string Url { get; set; }

    /// <summary>
    /// EN: Associated project / CZ: Přidružený projekt
    /// </summary>
    public required Project Project { get; set; }

    /// <summary>
    /// EN: Default branch name / CZ: Název výchozí větve
    /// </summary>
    public required string DefaultBranch { get; set; }

    /// <summary>
    /// EN: Repository size in bytes / CZ: Velikost repozitáře v bajtech
    /// </summary>
    public int Size { get; set; }

    /// <summary>
    /// EN: Remote URL for cloning / CZ: Remote URL pro klonování
    /// </summary>
    public required string RemoteUrl { get; set; }

    /// <summary>
    /// EN: SSH URL for cloning / CZ: SSH URL pro klonování
    /// </summary>
    public required string SshUrl { get; set; }

    /// <summary>
    /// EN: Web URL for browsing / CZ: Web URL pro prohlížení
    /// </summary>
    public required string WebUrl { get; set; }

    /// <summary>
    /// EN: Indicates if repository is disabled / CZ: Indikuje zda je repozitář zakázán
    /// </summary>
    public bool IsDisabled { get; set; }
}
