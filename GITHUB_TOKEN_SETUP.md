# 🔑 GitHub Personal Access Token Setup

## Creating a GitHub Personal Access Token for Packages

1. **Go to GitHub.com** and sign in to your account

2. **Navigate to Settings**:

   - Click your profile picture (top right)
   - Click "Settings"

3. **Go to Developer Settings**:

   - Scroll down in the left sidebar
   - Click "Developer settings"

4. **Create Personal Access Token**:

   - Click "Personal access tokens"
   - Click "Tokens (classic)"
   - Click "Generate new token"
   - Click "Generate new token (classic)"

5. **Configure the Token**:

   - **Note**: Enter "LarouexComponents Package Publishing"
   - **Expiration**: Choose your preferred expiration (recommend 90 days or 1 year)
   - **Scopes**: Select these permissions:
     - ✅ `write:packages` (Upload packages to GitHub Package Registry)
     - ✅ `read:packages` (Download packages from GitHub Package Registry)
     - ✅ `delete:packages` (Delete packages from GitHub Package Registry)
     - ✅ `repo` (Full control of private repositories - needed for package publishing)

6. **Generate and Copy**:
   - Click "Generate token"
   - **IMPORTANT**: Copy the token immediately - you won't see it again!
   - The token will look like: `ghp_xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx`

## 🔐 Security Note

- Keep this token secure - treat it like a password
- Don't commit it to your repository
- Store it in a secure location (password manager recommended)

## Next Steps

Once you have your token, you'll need to:

1. Replace `YOUR_GITHUB_TOKEN` in the nuget.config file with your actual token
2. Push your code to GitHub
3. Build and publish the package
