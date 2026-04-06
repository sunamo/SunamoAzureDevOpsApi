// variables names: ok
namespace SunamoAzureDevOpsApi.Tests;

public class UnitTest1
{
    [Fact]
    public void ParseRepositories_WithValidJson_ReturnsGitCloneCommands()
    {
        var jsonResponse = @"{
            ""Value"": [
                {
                    ""Id"": ""abc-123"",
                    ""Name"": ""MyRepo"",
                    ""Url"": ""https://dev.azure.com/org/_apis/git/repositories/abc-123"",
                    ""Project"": {
                        ""Id"": ""proj-1"",
                        ""Name"": ""TestProject"",
                        ""Description"": ""A test project"",
                        ""Url"": ""https://dev.azure.com/org/_apis/projects/proj-1"",
                        ""State"": ""wellFormed"",
                        ""Revision"": 1,
                        ""Visibility"": ""private"",
                        ""LastUpdateTime"": ""2024-01-01T00:00:00Z""
                    },
                    ""DefaultBranch"": ""refs/heads/main"",
                    ""Size"": 1024,
                    ""RemoteUrl"": ""https://dev.azure.com/org/TestProject/_git/MyRepo"",
                    ""SshUrl"": ""git@ssh.dev.azure.com:v3/org/TestProject/MyRepo"",
                    ""WebUrl"": ""https://dev.azure.com/org/TestProject/_git/MyRepo"",
                    ""IsDisabled"": false
                }
            ],
            ""Count"": 1
        }";
        var cloneUrlTemplate = "https://dev.azure.com/org/project/_git/{0}";

        var result = AzureDevOpsApiParser.ParseRepositories(jsonResponse, cloneUrlTemplate);

        Assert.Contains("git clone https://dev.azure.com/org/project/_git/MyRepo", result);
    }

    [Fact]
    public void ParseRepositories_WithMultipleRepositories_ReturnsAllCloneCommands()
    {
        var jsonResponse = @"{
            ""Value"": [
                {
                    ""Id"": ""1"",
                    ""Name"": ""RepoAlpha"",
                    ""Url"": ""https://test"",
                    ""Project"": { ""Id"": ""1"", ""Name"": ""Proj"", ""Description"": ""d"", ""Url"": ""https://test"", ""State"": ""wellFormed"", ""Revision"": 1, ""Visibility"": ""private"", ""LastUpdateTime"": ""2024-01-01T00:00:00Z"" },
                    ""DefaultBranch"": ""refs/heads/main"", ""Size"": 0, ""RemoteUrl"": ""https://test"", ""SshUrl"": ""git@test"", ""WebUrl"": ""https://test"", ""IsDisabled"": false
                },
                {
                    ""Id"": ""2"",
                    ""Name"": ""RepoBeta"",
                    ""Url"": ""https://test"",
                    ""Project"": { ""Id"": ""1"", ""Name"": ""Proj"", ""Description"": ""d"", ""Url"": ""https://test"", ""State"": ""wellFormed"", ""Revision"": 1, ""Visibility"": ""private"", ""LastUpdateTime"": ""2024-01-01T00:00:00Z"" },
                    ""DefaultBranch"": ""refs/heads/main"", ""Size"": 0, ""RemoteUrl"": ""https://test"", ""SshUrl"": ""git@test"", ""WebUrl"": ""https://test"", ""IsDisabled"": false
                }
            ],
            ""Count"": 2
        }";
        var cloneUrlTemplate = "https://dev.azure.com/org/_git/{0}";

        var result = AzureDevOpsApiParser.ParseRepositories(jsonResponse, cloneUrlTemplate);

        Assert.Contains("git clone https://dev.azure.com/org/_git/RepoAlpha", result);
        Assert.Contains("git clone https://dev.azure.com/org/_git/RepoBeta", result);
    }

    [Fact]
    public void ParseRepositories_WithNullDeserialization_ReturnsEmptyString()
    {
        var result = AzureDevOpsApiParser.ParseRepositories("null", "https://test/{0}");

        Assert.Equal(string.Empty, result);
    }

    [Fact]
    public void ParseRepositories_WithEmptyRepositoryList_ReturnsEmptyString()
    {
        var jsonResponse = @"{ ""Value"": [], ""Count"": 0 }";

        var result = AzureDevOpsApiParser.ParseRepositories(jsonResponse, "https://test/{0}");

        Assert.Equal(string.Empty, result);
    }
}
