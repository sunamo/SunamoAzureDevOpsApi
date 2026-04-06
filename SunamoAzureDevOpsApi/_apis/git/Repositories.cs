// variables names: ok
namespace SunamoAzureDevOpsApi._apis.git;

/// <summary>
/// Represents an Azure DevOps project.
/// </summary>
public class Project
{
    /// <summary>
    /// Project identifier.
    /// </summary>
    public required string Id { get; set; }

    /// <summary>
    /// Project name.
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Project description.
    /// </summary>
    public required string Description { get; set; }

    /// <summary>
    /// Project API URL.
    /// </summary>
    public required string Url { get; set; }

    /// <summary>
    /// Project state.
    /// </summary>
    public required string State { get; set; }

    /// <summary>
    /// Project revision number.
    /// </summary>
    public int Revision { get; set; }

    /// <summary>
    /// Project visibility (public or private).
    /// </summary>
    public required string Visibility { get; set; }

    /// <summary>
    /// Last update timestamp.
    /// </summary>
    public DateTime LastUpdateTime { get; set; }
}

/// <summary>
/// Container for repository list response.
/// </summary>
public class Repositories
{
    /// <summary>
    /// List of repositories.
    /// </summary>
    public required List<Value> Value { get; set; }

    /// <summary>
    /// Total count of repositories.
    /// </summary>
    public int Count { get; set; }
}

/// <summary>
/// Represents an Azure DevOps repository.
/// </summary>
public class Value
{
    /// <summary>
    /// Repository identifier.
    /// </summary>
    public required string Id { get; set; }

    /// <summary>
    /// Repository name.
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Repository API URL.
    /// </summary>
    public required string Url { get; set; }

    /// <summary>
    /// Associated project.
    /// </summary>
    public required Project Project { get; set; }

    /// <summary>
    /// Default branch name.
    /// </summary>
    public required string DefaultBranch { get; set; }

    /// <summary>
    /// Repository size in bytes.
    /// </summary>
    public int Size { get; set; }

    /// <summary>
    /// Remote URL for cloning.
    /// </summary>
    public required string RemoteUrl { get; set; }

    /// <summary>
    /// SSH URL for cloning.
    /// </summary>
    public required string SshUrl { get; set; }

    /// <summary>
    /// Web URL for browsing.
    /// </summary>
    public required string WebUrl { get; set; }

    /// <summary>
    /// Indicates whether the repository is disabled.
    /// </summary>
    public bool IsDisabled { get; set; }
}
