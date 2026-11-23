namespace SunamoAzureDevOpsApi._apis.git;

/// <summary>
/// Represents the project type.
/// </summary>
public class Project
{
    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    public required string Id { get; set; }
    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    public required string Description { get; set; }
    /// <summary>
    /// Gets or sets the url.
    /// </summary>
    public required string Url { get; set; }
    /// <summary>
    /// Gets or sets the state.
    /// </summary>
    public required string State { get; set; }
    /// <summary>
    /// Gets or sets the revision.
    /// </summary>
    public int Revision { get; set; }
    /// <summary>
    /// Gets or sets the visibility.
    /// </summary>
    public required string Visibility { get; set; }
    /// <summary>
    /// Gets or sets the last update time.
    /// </summary>
    public DateTime LastUpdateTime { get; set; }
}

/// <summary>
/// Represents the repositories type.
/// </summary>
public class Repositories
{
    /// <summary>
    /// Gets or sets the value.
    /// </summary>
    public required List<Value> Value { get; set; }
    /// <summary>
    /// Gets or sets the count.
    /// </summary>
    public int Count { get; set; }
}

/// <summary>
/// Represents the value type.
/// </summary>
public class Value
{
    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    public required string Id { get; set; }
    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// Gets or sets the url.
    /// </summary>
    public required string Url { get; set; }
    /// <summary>
    /// Gets or sets the project.
    /// </summary>
    public required Project Project { get; set; }
    /// <summary>
    /// Gets or sets the default branch.
    /// </summary>
    public required string DefaultBranch { get; set; }
    /// <summary>
    /// Gets or sets the size.
    /// </summary>
    public int Size { get; set; }
    /// <summary>
    /// Gets or sets the remote url.
    /// </summary>
    public required string RemoteUrl { get; set; }
    /// <summary>
    /// Gets or sets the ssh url.
    /// </summary>
    public required string SshUrl { get; set; }
    /// <summary>
    /// Gets or sets the web url.
    /// </summary>
    public required string WebUrl { get; set; }
    /// <summary>
    /// Gets or sets the is disabled.
    /// </summary>
    public bool IsDisabled { get; set; }
}
