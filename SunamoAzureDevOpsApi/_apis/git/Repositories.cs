// variables names: ok
namespace SunamoAzureDevOpsApi._apis.git;

public class Project
{
    public required string Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required string Url { get; set; }
    public required string State { get; set; }
    public int Revision { get; set; }
    public required string Visibility { get; set; }
    public DateTime LastUpdateTime { get; set; }
}

public class Repositories
{
    public required List<Value> Value { get; set; }
    public int Count { get; set; }
}

public class Value
{
    public required string Id { get; set; }
    public required string Name { get; set; }
    public required string Url { get; set; }
    public required Project Project { get; set; }
    public required string DefaultBranch { get; set; }
    public int Size { get; set; }
    public required string RemoteUrl { get; set; }
    public required string SshUrl { get; set; }
    public required string WebUrl { get; set; }
    public bool IsDisabled { get; set; }
}
