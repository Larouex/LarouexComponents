# 📦 GitHub Packages Setup Guide

This guide explains how to publish and consume the LarouexComponents package using GitHub Packages.

## 🚀 Publishing the Package (Automatic via GitHub Actions)

### Prerequisites

1. **GitHub Repository**: Your code must be in a GitHub repository
2. **GitHub Actions**: The workflow file is already set up in `.github/workflows/publish.yml`

### How it Works

The package is automatically published when you:

- Push to the `main` or `master` branch
- Create a version tag (e.g., `v1.0.0`)

### Manual Version Update

To release a new version:

1. Update the version in `LarouexComponents.csproj`:
   ```xml
   <PackageVersion>1.0.1</PackageVersion>
   ```
2. Commit and push:
   ```bash
   git add .
   git commit -m "Version 1.0.1"
   git push
   ```
3. Optionally create a tag:
   ```bash
   git tag v1.0.1
   git push --tags
   ```

## 📥 Consuming the Package

### Step 1: Configure NuGet Source

Create or update `nuget.config` in your consuming project:

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
    <clear />
    <add key="nuget.org" value="https://api.nuget.org/v3/index.json" />
    <add key="github" value="https://nuget.pkg.github.com/Larouex/index.json" />
  </packageSources>
  <packageSourceCredentials>
    <github>
      <add key="Username" value="YOUR_GITHUB_USERNAME" />
      <add key="ClearTextPassword" value="YOUR_GITHUB_TOKEN" />
    </github>
  </packageSourceCredentials>
</configuration>
```

### Step 2: Install the Package

```bash
dotnet add package LarouexSoftwareDevelopment.LarouexComponents
```

### Step 3: Use in Your Blazor App

1. Add the using statement to `_Imports.razor`:

   ```csharp
   @using LarouexSoftwareDevelopment.LarouexComponents
   ```

2. Use the component in your pages:
   ```html
   <BrandingText Text="Welcome to my app!" />
   <BrandingText Text="Success message" CssClass="success" />
   <BrandingText Text="Large warning" CssClass="large warning" />
   ```

## 🔑 GitHub Token Requirements

For **consuming** packages, you need a GitHub Personal Access Token with:

- `read:packages` permission

For **publishing** packages (done automatically via GitHub Actions), the workflow uses:

- `GITHUB_TOKEN` (automatically provided by GitHub Actions)

## 🛠️ Manual Publishing (Alternative)

If you prefer to publish manually:

1. Create a GitHub Personal Access Token with `write:packages` permission
2. Set up authentication:
   ```bash
   dotnet nuget add source "https://nuget.pkg.github.com/Larouex/index.json" \
     --name "github" \
     --username "Larouex" \
     --password "YOUR_GITHUB_TOKEN"
   ```
3. Build and pack:
   ```bash
   dotnet pack --configuration Release
   ```
4. Push to GitHub Packages:
   ```bash
   dotnet nuget push ./bin/Release/*.nupkg \
     --source "github" \
     --api-key YOUR_GITHUB_TOKEN
   ```

## 📋 Package Information

- **Package ID**: `LarouexSoftwareDevelopment.LarouexComponents`
- **Current Version**: `1.0.0`
- **Target Framework**: `.NET 8.0`
- **Repository**: https://github.com/Larouex/LarouexComponents
- **Package URL**: https://github.com/Larouex/LarouexComponents/packages

## 🔍 Troubleshooting

### Common Issues

1. **Authentication Failed**

   - Verify your GitHub token has the correct permissions
   - Make sure the token isn't expired
   - Check that username matches your GitHub username

2. **Package Not Found**

   - Ensure the package has been published successfully
   - Check GitHub Actions logs for errors
   - Verify you have read access to the repository

3. **Version Conflicts**
   - Clear NuGet cache: `dotnet nuget locals all --clear`
   - Update package version in your project

### Getting Help

- Check GitHub Actions logs in the repository
- Review GitHub Packages documentation
- Open an issue in the repository
