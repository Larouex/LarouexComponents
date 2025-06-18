# GitHub Setup Guide for LarouexComponents

This guide will help you set up GitHub to host your LarouexComponents NuGet package.

## Prerequisites

1. A GitHub account
2. Git installed on your machine
3. GitHub CLI (optional but recommended)

## Step-by-Step Setup

### 1. Create a GitHub Repository

1. Go to [GitHub.com](https://github.com) and sign in
2. Click the "+" button and select "New repository"
3. Name your repository (e.g., `larouex-components`)
4. Set it to **Private** (for private packages) or **Public**
5. Don't initialize with README (we already have one)
6. Click "Create repository"

### 2. Update Repository URL in Project

Edit `LarouexComponents.csproj` and update the `RepositoryUrl`:

```xml
<RepositoryUrl>https://github.com/YOUR_GITHUB_USERNAME/larouex-components</RepositoryUrl>
```

Replace `YOUR_GITHUB_USERNAME` with your actual GitHub username.

### 3. Configure NuGet.config

Edit the `nuget.config` file and replace:

- `YOUR_GITHUB_USERNAME` with your GitHub username
- `YOUR_GITHUB_TOKEN` with a Personal Access Token (see step 7)

### 4. Initialize Git Repository

Run these commands in your project directory:

```bash
git init
git add .
git commit -m "Initial commit: LarouexComponents Blazor library"
git branch -M main
git remote add origin https://github.com/YOUR_GITHUB_USERNAME/larouex-components.git
git push -u origin main
```

### 5. Enable GitHub Packages

1. Go to your repository on GitHub
2. Click on "Settings" tab
3. Scroll down to "Features" section
4. Ensure "Packages" is enabled

### 6. Set Repository Permissions for Packages

1. In your repository, go to "Settings" → "Actions" → "General"
2. Scroll to "Workflow permissions"
3. Select "Read and write permissions"
4. Check "Allow GitHub Actions to create and approve pull requests"
5. Click "Save"

### 7. Create Personal Access Token (Optional)

For consuming private packages, you'll need a Personal Access Token:

1. Go to GitHub → Settings → Developer settings → Personal access tokens → Tokens (classic)
2. Click "Generate new token (classic)"
3. Give it a name like "NuGet Package Access"
4. Select these scopes:
   - `read:packages`
   - `write:packages`
   - `delete:packages` (optional)
5. Click "Generate token"
6. **Copy the token immediately** (you won't see it again)

### 8. Using the Package in Other Projects

#### For Public Packages:

Add to your project's `nuget.config`:

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
    <add key="github" value="https://nuget.pkg.github.com/YOUR_GITHUB_USERNAME/index.json" />
  </packageSources>
</configuration>
```

#### For Private Packages:

You'll need authentication. Add credentials to `nuget.config`:

```xml
<packageSourceCredentials>
  <github>
    <add key="Username" value="YOUR_GITHUB_USERNAME" />
    <add key="ClearTextPassword" value="YOUR_PERSONAL_ACCESS_TOKEN" />
  </github>
</packageSourceCredentials>
```

### 9. Install the Package

In any Blazor/ASP.NET Core project:

```bash
dotnet add package LarouexSoftwareDevelopment.LarouexComponents --source https://nuget.pkg.github.com/YOUR_GITHUB_USERNAME/index.json
```

## Automatic Publishing

The GitHub Actions workflow will automatically:

1. **Build** the project on every push/PR
2. **Test** the project (if tests exist)
3. **Create NuGet package**
4. **Publish to GitHub Packages** on pushes to main/master or version tags

## Versioning

To release a new version:

1. Update the `<PackageVersion>` in `LarouexComponents.csproj`
2. Update `CHANGELOG.md` with new changes
3. Commit and push to main branch
4. OR create a version tag: `git tag v1.0.1 && git push origin v1.0.1`

## Troubleshooting

### Common Issues:

1. **"Package already exists"**: Increment the version number
2. **"Unauthorized"**: Check your Personal Access Token permissions
3. **"Package source not found"**: Verify the GitHub username in URLs

### Package Not Visible:

- Private packages are only visible to repository collaborators
- Check repository permissions and package visibility settings

## Security Notes

- Never commit Personal Access Tokens to your repository
- Use GitHub Secrets for sensitive information in Actions
- Consider using fine-grained Personal Access Tokens for better security

## Next Steps

1. Complete the GitHub setup following this guide
2. Push your code to GitHub
3. The first package will be automatically published
4. Start using your components in other projects!

For more information, see [GitHub Packages Documentation](https://docs.github.com/en/packages/working-with-a-github-packages-registry/working-with-the-nuget-registry).
