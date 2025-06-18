<!-- Use this file to provide workspace-specific custom instructions to Copilot. For more details, visit https://code.visualstudio.com/docs/copilot/copilot-customization#_use-a-githubcopilotinstructionsmd-file -->

# Copilot Instructions for LarouexComponents

This is a .NET Core Blazor component library project for creating reusable UI components that will be packaged and distributed via NuGet.

## Project Guidelines

- Follow Blazor component best practices
- Use parameter validation and documentation
- Implement proper CSS scoping for components
- Ensure components are accessible and responsive
- Keep components lightweight and focused on single responsibilities
- Use semantic HTML where possible
- Follow Microsoft's Blazor coding conventions

## Component Development

- Each component should have its own .razor file and corresponding .razor.css file
- Use `[Parameter]` attributes for component properties
- Add XML documentation comments for all public parameters
- Include proper null checks and default values
- Use CSS custom properties for theming when appropriate

## Package Management

- Update version numbers in the .csproj file for releases
- Maintain proper NuGet package metadata
- Include comprehensive README documentation
- Follow semantic versioning principles

## Testing

- Consider adding unit tests for component logic
- Test components in different Blazor hosting models
- Verify CSS scoping works correctly
- Test parameter binding and event handling
