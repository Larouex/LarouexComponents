<!-- Use this file to provide workspace-specific custom instructions to Copilot. For more details, visit https://code.visualstudio.com/docs/copilot/copilot-customization#_use-a-githubcopilotinstructionsmd-file -->

# Copilot Instructions for LarouexComponents

This is a .NET Core Blazor component library project for creating reusable UI components that will be packaged and distributed via NuGet packages through GitHub Packages.

## 🎯 Project Goals

- **Primary Goal**: Create a comprehensive library of reusable Blazor UI components
- **Brand Consistency**: All components should reflect Larouex Software Development branding
- **Quality Focus**: Professional-grade components suitable for production use
- **Accessibility**: All components must be accessible and follow WCAG guidelines
- **Performance**: Lightweight components with minimal overhead
- **Developer Experience**: Easy to use with clear documentation and examples

## 🏗️ Architecture & Structure

### Component Organization

- Each component gets its own `.razor` and `.razor.css` file pair
- Components are organized by category (e.g., Forms, Navigation, Data Display)
- Use namespace `LarouexSoftwareDevelopment.LarouexComponents`
- Follow the naming convention: `[Category][ComponentName]` (e.g., `FormTextInput`, `NavigationBreadcrumb`)

### File Structure Standards

```
/Components/
  /Forms/
    TextInput.razor
    TextInput.razor.css
  /Navigation/
    Breadcrumb.razor
    Breadcrumb.razor.css
  /DataDisplay/
    DataTable.razor
    DataTable.razor.css
```

## 🎨 Style Guidelines

### CSS Standards

- **CSS Scoping**: Always use scoped CSS (`.razor.css` files)
- **BEM Methodology**: Use Block-Element-Modifier naming for CSS classes
- **Custom Properties**: Use CSS custom properties for theming
- **Responsive Design**: Mobile-first approach with breakpoints at 576px, 768px, 992px, 1200px
- **Color Palette**:
  - Primary: `#007bff` (Bootstrap blue)
  - Success: `#28a745` (Bootstrap green)
  - Warning: `#ffc107` (Bootstrap yellow)
  - Danger: `#dc3545` (Bootstrap red)
  - Secondary: `#6c757d` (Bootstrap gray)

### CSS Naming Convention

```css
.larouex-[component-name] {
  /* Block */
}
.larouex-[component-name]__[element] {
  /* Element */
}
.larouex-[component-name]--[modifier] {
  /* Modifier */
}
```

### Component Styling Rules

- All components must have the base class `larouex-[component-name]`
- Support theme modifiers: `primary`, `secondary`, `success`, `warning`, `danger`
- Support size modifiers: `small`, `large`, `extra-large`
- Include hover and focus states for interactive elements
- Use consistent spacing units: 4px, 8px, 12px, 16px, 20px, 24px, 32px

## 💻 Coding Standards

### C# & Razor Standards

- **Target Framework**: .NET 8.0
- **Nullable Reference Types**: Always enabled
- **File-scoped namespaces**: Use file-scoped namespace declarations
- **var keyword**: Use `var` only when type is obvious from right side
- **String interpolation**: Prefer over string concatenation
- **Async/await**: Use async methods where appropriate

### Parameter Standards

```csharp
/// <summary>
/// Brief description of the parameter
/// </summary>
[Parameter]
public string PropertyName { get; set; } = "default_value";

/// <summary>
/// Event callback description
/// </summary>
[Parameter]
public EventCallback<EventArgs> OnSomething { get; set; }
```

### Documentation Requirements

- **XML Documentation**: Required for all public parameters and methods
- **Component Summary**: Each component must have a `<summary>` tag
- **Parameter Documentation**: All `[Parameter]` properties must be documented
- **Usage Examples**: Include code examples in documentation

### Error Handling

- Use proper null checks for all parameters
- Provide meaningful default values
- Log errors appropriately using `ILogger<T>`
- Handle edge cases gracefully

## 🧪 Testing Standards

### Unit Testing Requirements

- **Testing Framework**: Use bUnit for Blazor component testing
- **Coverage Target**: Minimum 80% code coverage
- **Test Categories**:
  - Parameter validation tests
  - Rendering tests
  - Event handling tests
  - CSS class application tests
  - Accessibility tests

### Test Structure

```csharp
[Test]
public void ComponentName_Should_RenderCorrectly_When_DefaultParametersUsed()
{
    // Arrange
    // Act
    // Assert
}
```

### Testing Rules

- Each component must have corresponding test file: `[ComponentName]Tests.cs`
- Test parameter validation for required parameters
- Test CSS class applications for all modifiers
- Test event callbacks and state changes
- Include snapshot tests for consistent rendering

## 📝 Documentation Standards

### README Structure

- Clear description of component purpose
- Installation instructions
- Basic usage examples
- Advanced usage scenarios
- API reference (parameters, events, CSS classes)
- Accessibility notes
- Browser compatibility

### Code Comments

- Use meaningful variable and method names that reduce need for comments
- Comment complex logic and business rules
- Include TODO comments for future enhancements
- Use regions to organize large code files

### Changelog Maintenance

- Follow [Keep a Changelog](https://keepachangelog.com/) format
- Document all changes in appropriate categories: Added, Changed, Deprecated, Removed, Fixed, Security
- Include version numbers and dates
- Link to relevant issues or pull requests

## 📦 Package Management Rules

### Versioning Strategy

- Follow [Semantic Versioning](https://semver.org/): MAJOR.MINOR.PATCH
- **MAJOR**: Breaking changes to component APIs
- **MINOR**: New components or backwards-compatible features
- **PATCH**: Bug fixes and small improvements

### Release Process

1. Update version in `LarouexComponents.csproj`
2. Update `CHANGELOG.md` with changes
3. Update documentation if needed
4. Commit changes with descriptive message
5. Create version tag: `git tag v1.2.3`
6. Push to trigger automatic publishing

### Package Metadata Requirements

- Keep package description up-to-date
- Maintain relevant tags
- Update repository URL when changed
- Include release notes reference

## 🔄 Git Workflow Rules

### Commit Message Format

```
type(scope): brief description

Longer description if needed

- List specific changes
- Reference issues: Fixes #123
```

### Types

- `feat`: New feature/component
- `fix`: Bug fix
- `docs`: Documentation changes
- `style`: Code style changes (formatting, etc.)
- `refactor`: Code refactoring
- `test`: Adding or updating tests
- `chore`: Build process or auxiliary tool changes

### Branch Strategy

- `main`: Production-ready code
- `develop`: Integration branch for new features
- `feature/[component-name]`: New component development
- `fix/[issue-description]`: Bug fixes

## 🚀 Performance Guidelines

### Component Performance

- Minimize re-renders using `ShouldRender()` when appropriate
- Use `@key` directive for list items
- Avoid heavy computations in component rendering
- Implement virtual scrolling for large datasets

### CSS Performance

- Use CSS containment where appropriate
- Minimize use of complex selectors
- Prefer CSS transforms over changing layout properties
- Use `will-change` property sparingly

## ♿ Accessibility Requirements

### WCAG Compliance

- Target WCAG 2.1 AA compliance
- Include proper ARIA labels and roles
- Ensure keyboard navigation support
- Maintain color contrast ratios (4.5:1 minimum)

### Accessibility Checklist

- [ ] Semantic HTML structure
- [ ] Proper heading hierarchy
- [ ] Alt text for images
- [ ] Form labels and descriptions
- [ ] Focus management
- [ ] Screen reader testing

## 🔧 Development Tools

### Required Extensions

- C# Dev Kit
- Blazor syntax highlighting
- IntelliCode

### Build Configuration

- Use the provided VS Code tasks for build/pack/clean
- Always build in Release mode for packages
- Run tests before committing

## 📋 Quality Gates

### Pre-commit Checklist

- [ ] All tests pass
- [ ] Code builds without warnings
- [ ] Documentation updated
- [ ] Accessibility verified
- [ ] Performance impact assessed
- [ ] Version number updated (if needed)

### Code Review Requirements

- All public APIs must be reviewed
- Breaking changes require explicit approval
- Documentation must be complete
- Tests must be included

---

## 🎯 Component Development Workflow

1. **Plan**: Define component requirements and API
2. **Create**: Implement component with proper structure
3. **Style**: Apply consistent styling and theming
4. **Test**: Write comprehensive tests
5. **Document**: Create usage examples and API docs
6. **Review**: Peer review for quality and standards
7. **Release**: Follow versioning and release process

**Remember**: Every component should be production-ready, well-documented, accessible, and consistent with the Larouex Software Development brand.
