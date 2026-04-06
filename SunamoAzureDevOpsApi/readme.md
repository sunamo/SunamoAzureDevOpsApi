# SunamoAzureDevOpsApi

Utilities for working with Azure DevOps API.

## Overview

SunamoAzureDevOpsApi provides a client for connecting to Azure DevOps and a parser for generating git clone commands from API responses.

## Main Components

### AzureDevOpsApiClient

Client for interacting with Azure DevOps API. Connects using a Personal Access Token and retrieves repository information.

- `LoadRepositories()` - Loads list of repository names from an Azure DevOps organization.

### AzureDevOpsApiParser

Parser for Azure DevOps API JSON responses.

- `ParseRepositories(string jsonResponse, string cloneUrlTemplate)` - Parses a JSON response containing repositories and generates git clone commands using the provided URL template.

## Target Frameworks

- net10.0
- net9.0
- net8.0

## License

MIT
