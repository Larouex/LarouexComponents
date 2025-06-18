# 📁 Project Structure Guide

This document outlines the complete file organization structure for LarouexComponents to maintain consistency and clarity.

## 🏗️ Current Project Structure

```
LarouexComponents/
├── .github/                           # GitHub-specific files
│   ├── workflows/                     # GitHub Actions workflows
│   │   └── build-and-publish.yml     # CI/CD pipeline
│   └── copilot-instructions.md        # AI coding assistant instructions
├── .vscode/                           # VS Code configuration
│   └── tasks.json                     # Build/pack/clean tasks
├── Components/                        # [Future] Organized component folders
│   ├── Forms/                         # Form-related components
│   ├── Navigation/                    # Navigation components
│   ├── DataDisplay/                   # Data display components
│   ├── Feedback/                      # User feedback components
│   └── Layout/                        # Layout components
├── Tests/                             # [Future] Unit tests
│   └── LarouexComponents.Tests/       # Test project
├── wwwroot/                           # Static web assets
│   ├── background.png                 # Default background image
│   └── exampleJsInterop.js           # JavaScript interop example
├── bin/                               # Build output (git ignored)
├── obj/                               # Build temp files (git ignored)
├── BrandingText.razor                 # Main branding component
├── BrandingText.razor.css             # Component-scoped styles
├── ComponentEnums.cs                  # Shared enums for components
├── ExampleJsInterop.cs               # JavaScript interop example
├── _Imports.razor                     # Global using statements
├── LarouexComponents.csproj           # Project file with NuGet config
├── Packages.sln                      # Solution file
├── nuget.config                       # NuGet package sources
├── .editorconfig                      # Code formatting rules
├── .gitignore                         # Git ignore patterns
├── CHANGELOG.md                       # Version history
├── DEVELOPMENT_STANDARDS.md           # Development guidelines
├── GITHUB_SETUP.md                    # GitHub configuration guide
├── PROJECT_COMPLETE.md                # Project completion summary
├── README.md                          # Main documentation
└── SAMPLES.md                         # Usage examples
```

## 📋 Recommended Future Structure

As the project grows, organize components by category:

### Component Categories

```
Components/
├── Forms/                             # Input and form controls
│   ├── TextInput/
│   │   ├── TextInput.razor
│   │   ├── TextInput.razor.css
│   │   └── README.md
│   ├── Button/
│   ├── Checkbox/
│   ├── Select/
│   └── FormGroup/
├── Navigation/                        # Navigation elements
│   ├── Breadcrumb/
│   ├── Menu/
│   ├── Tabs/
│   └── Pagination/
├── DataDisplay/                       # Data presentation
│   ├── Table/
│   ├── Card/
│   ├── List/
│   └── Badge/
├── Feedback/                          # User feedback
│   ├── Alert/
│   ├── Toast/
│   ├── Modal/
│   └── Loading/
├── Layout/                            # Layout components
│   ├── Container/
│   ├── Grid/
│   ├── Sidebar/
│   └── Header/
└── Branding/                          # Brand-specific components
    ├── BrandingText/
    ├── Logo/
    └── Footer/
```

## 📁 File Naming Conventions

### Component Files
- **Component**: `ComponentName.razor`
- **Styles**: `ComponentName.razor.css`
- **Tests**: `ComponentNameTests.cs`
- **Documentation**: `README.md` (in component folder)

### Supporting Files
- **Enums**: `ComponentEnums.cs`, `[Feature]Enums.cs`
- **Interfaces**: `I[ComponentName].cs`
- **Base Classes**: `[ComponentName]Base.cs`
- **Utilities**: `[Feature]Utilities.cs`

### Documentation Files
- **Main docs**: `README.md`, `CHANGELOG.md`
- **Guides**: `[TOPIC]_GUIDE.md` (e.g., `TESTING_GUIDE.md`)
- **Standards**: `[AREA]_STANDARDS.md` (e.g., `CSS_STANDARDS.md`)

## 🎯 Component Organization Rules

### Individual Component Structure
Each component should have its own folder containing:

```
ComponentName/
├── ComponentName.razor              # Main component file
├── ComponentName.razor.css          # Scoped styles
├── ComponentName.razor.cs           # Code-behind (if needed)
├── ComponentNameTests.cs            # Unit tests
├── README.md                        # Component documentation
└── Examples/                        # Usage examples
    ├── BasicExample.razor
    └── AdvancedExample.razor
```

### Shared Resources
```
Shared/
├── Enums/
│   ├── ComponentEnums.cs
│   ├── ThemeEnums.cs
│   └── SizeEnums.cs
├── Extensions/
│   ├── ComponentExtensions.cs
│   └── EnumExtensions.cs
├── Utilities/
│   ├── CssClassBuilder.cs
│   └── ComponentHelpers.cs
└── Constants/
    ├── CssClasses.cs
    └── DefaultValues.cs
```

## 📦 Package Organization

### NuGet Package Structure
```
LarouexSoftwareDevelopment.LarouexComponents/
├── lib/
│   └── net8.0/
│       └── LarouexComponents.dll
├── content/
│   └── wwwroot/
├── contentFiles/
│   └── any/
│       └── any/
│           └── wwwroot/
└── [Content_Types].xml
```

### Multiple Package Strategy (Future)
```
LarouexSoftwareDevelopment.LarouexComponents.Core/      # Base components
LarouexSoftwareDevelopment.LarouexComponents.Forms/     # Form components
LarouexSoftwareDevelopment.LarouexComponents.Data/      # Data components
LarouexSoftwareDevelopment.LarouexComponents.Charts/    # Chart components
```

## 🧪 Testing Structure

```
Tests/
├── LarouexComponents.Tests/
│   ├── Components/
│   │   ├── Forms/
│   │   │   ├── TextInputTests.cs
│   │   │   └── ButtonTests.cs
│   │   └── Navigation/
│   │       └── BreadcrumbTests.cs
│   ├── Shared/
│   │   ├── EnumTests.cs
│   │   └── UtilityTests.cs
│   ├── TestHelpers/
│   │   ├── ComponentTestBase.cs
│   │   └── TestDataBuilder.cs
│   └── LarouexComponents.Tests.csproj
├── LarouexComponents.IntegrationTests/
│   ├── ComponentIntegrationTests.cs
│   └── LarouexComponents.IntegrationTests.csproj
└── LarouexComponents.E2ETests/
    ├── PlaywrightTests.cs
    └── LarouexComponents.E2ETests.csproj
```

## 📚 Documentation Structure

```
docs/                                  # [Future] Documentation site
├── components/                        # Component documentation
│   ├── forms/
│   ├── navigation/
│   └── data-display/
├── guides/                           # Development guides
│   ├── getting-started.md
│   ├── theming.md
│   └── accessibility.md
├── api/                              # API reference
└── examples/                         # Live examples
```

## 🔧 Configuration Files

### Project Root Configuration
- `.editorconfig` - Code formatting rules
- `.gitignore` - Git ignore patterns
- `nuget.config` - NuGet package sources
- `Directory.Build.props` - Shared MSBuild properties
- `global.json` - .NET SDK version

### GitHub Configuration
- `.github/workflows/` - CI/CD pipelines
- `.github/ISSUE_TEMPLATE/` - Issue templates
- `.github/PULL_REQUEST_TEMPLATE.md` - PR template
- `.github/copilot-instructions.md` - AI assistant rules

### VS Code Configuration
- `.vscode/tasks.json` - Build tasks
- `.vscode/launch.json` - Debug configuration
- `.vscode/settings.json` - Workspace settings
- `.vscode/extensions.json` - Recommended extensions

## 📋 Migration Plan

To migrate to the organized structure:

1. **Phase 1**: Move existing components to category folders
2. **Phase 2**: Create shared utilities and enums
3. **Phase 3**: Implement testing structure
4. **Phase 4**: Add documentation site
5. **Phase 5**: Consider package splitting

This structure ensures scalability, maintainability, and consistency as the component library grows.
