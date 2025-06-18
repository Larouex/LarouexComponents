# Development Standards & Guidelines

This document outlines the comprehensive development standards for LarouexComponents to ensure consistency, quality, and maintainability across all components.

## 🏗️ Component Template

Use this template when creating new components:

### Component File Structure
```
/[ComponentName]/
  [ComponentName].razor
  [ComponentName].razor.css
  [ComponentName]Tests.cs (in test project)
  README.md (for complex components)
```

### Component Template (`ComponentName.razor`)
```razor
@namespace LarouexSoftwareDevelopment.LarouexComponents
@using Microsoft.AspNetCore.Components
@using Microsoft.AspNetCore.Components.Web

<div class="larouex-component-name @CssClass @GetThemeClass() @GetSizeClass()" 
     @attributes="AdditionalAttributes">
    
    @if (!string.IsNullOrEmpty(Title))
    {
        <h3 class="larouex-component-name__title">@Title</h3>
    }
    
    <div class="larouex-component-name__content">
        @ChildContent
    </div>
    
</div>

@code {
    /// <summary>
    /// The title to display above the component
    /// </summary>
    [Parameter]
    public string? Title { get; set; }

    /// <summary>
    /// Additional CSS classes to apply to the component
    /// </summary>
    [Parameter]
    public string CssClass { get; set; } = string.Empty;

    /// <summary>
    /// The theme variant of the component
    /// </summary>
    [Parameter]
    public ComponentTheme Theme { get; set; } = ComponentTheme.Primary;

    /// <summary>
    /// The size variant of the component
    /// </summary>
    [Parameter]
    public ComponentSize Size { get; set; } = ComponentSize.Medium;

    /// <summary>
    /// Child content to be rendered inside the component
    /// </summary>
    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    /// <summary>
    /// Additional attributes to be applied to the root element
    /// </summary>
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    /// <summary>
    /// Event callback fired when the component is clicked
    /// </summary>
    [Parameter]
    public EventCallback<MouseEventArgs> OnClick { get; set; }

    private string GetThemeClass() => Theme switch
    {
        ComponentTheme.Primary => "larouex-component-name--primary",
        ComponentTheme.Secondary => "larouex-component-name--secondary",
        ComponentTheme.Success => "larouex-component-name--success",
        ComponentTheme.Warning => "larouex-component-name--warning",
        ComponentTheme.Danger => "larouex-component-name--danger",
        _ => "larouex-component-name--primary"
    };

    private string GetSizeClass() => Size switch
    {
        ComponentSize.Small => "larouex-component-name--small",
        ComponentSize.Medium => "",
        ComponentSize.Large => "larouex-component-name--large",
        ComponentSize.ExtraLarge => "larouex-component-name--xl",
        _ => ""
    };

    private async Task HandleClick(MouseEventArgs args)
    {
        await OnClick.InvokeAsync(args);
    }
}
```

### CSS Template (`ComponentName.razor.css`)
```css
/* Base component styles */
.larouex-component-name {
    --larouex-spacing: 16px;
    --larouex-border-radius: 8px;
    --larouex-transition: all 0.3s ease;
    
    display: block;
    padding: var(--larouex-spacing);
    border-radius: var(--larouex-border-radius);
    transition: var(--larouex-transition);
    font-family: -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, sans-serif;
}

/* Element styles */
.larouex-component-name__title {
    margin: 0 0 calc(var(--larouex-spacing) * 0.5) 0;
    font-size: 1.25rem;
    font-weight: 600;
    color: var(--larouex-text-color, #2c3e50);
}

.larouex-component-name__content {
    color: var(--larouex-text-color, #495057);
}

/* Size modifiers */
.larouex-component-name--small {
    --larouex-spacing: 12px;
    font-size: 0.875rem;
}

.larouex-component-name--large {
    --larouex-spacing: 24px;
    font-size: 1.125rem;
}

.larouex-component-name--xl {
    --larouex-spacing: 32px;
    font-size: 1.25rem;
}

/* Theme modifiers */
.larouex-component-name--primary {
    --larouex-bg-color: #f8f9fa;
    --larouex-border-color: #007bff;
    --larouex-accent-color: #007bff;
    
    background-color: var(--larouex-bg-color);
    border-left: 4px solid var(--larouex-border-color);
}

.larouex-component-name--secondary {
    --larouex-bg-color: #f8f9fa;
    --larouex-border-color: #6c757d;
    --larouex-accent-color: #6c757d;
    
    background-color: var(--larouex-bg-color);
    border-left: 4px solid var(--larouex-border-color);
}

.larouex-component-name--success {
    --larouex-bg-color: #f8fff9;
    --larouex-border-color: #28a745;
    --larouex-accent-color: #28a745;
    
    background-color: var(--larouex-bg-color);
    border-left: 4px solid var(--larouex-border-color);
}

.larouex-component-name--warning {
    --larouex-bg-color: #fffdf8;
    --larouex-border-color: #ffc107;
    --larouex-accent-color: #ffc107;
    
    background-color: var(--larouex-bg-color);
    border-left: 4px solid var(--larouex-border-color);
}

.larouex-component-name--danger {
    --larouex-bg-color: #fff8f8;
    --larouex-border-color: #dc3545;
    --larouex-accent-color: #dc3545;
    
    background-color: var(--larouex-bg-color);
    border-left: 4px solid var(--larouex-border-color);
}

/* Interactive states */
.larouex-component-name:hover {
    transform: translateY(-1px);
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.15);
}

.larouex-component-name:focus-within {
    outline: 2px solid var(--larouex-accent-color, #007bff);
    outline-offset: 2px;
}

/* Accessibility */
@media (prefers-reduced-motion: reduce) {
    .larouex-component-name {
        transition: none;
    }
}

/* Responsive design */
@media (max-width: 576px) {
    .larouex-component-name {
        --larouex-spacing: 12px;
    }
}
```

### Enums File (`ComponentEnums.cs`)
```csharp
namespace LarouexSoftwareDevelopment.LarouexComponents;

/// <summary>
/// Defines the available theme variants for components
/// </summary>
public enum ComponentTheme
{
    Primary,
    Secondary,
    Success,
    Warning,
    Danger
}

/// <summary>
/// Defines the available size variants for components
/// </summary>
public enum ComponentSize
{
    Small,
    Medium,
    Large,
    ExtraLarge
}
```

## 🧪 Test Template

### Unit Test Template (`ComponentNameTests.cs`)
```csharp
using Bunit;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using LarouexSoftwareDevelopment.LarouexComponents;

namespace LarouexComponents.Tests;

[TestFixture]
public class ComponentNameTests : TestContext
{
    [SetUp]
    public void Setup()
    {
        // Add any required services
        Services.AddLogging();
    }

    [Test]
    public void ComponentName_Should_RenderCorrectly_When_DefaultParametersUsed()
    {
        // Arrange & Act
        var component = RenderComponent<ComponentName>();

        // Assert
        Assert.That(component.Find(".larouex-component-name"), Is.Not.Null);
        Assert.That(component.Markup, Does.Contain("larouex-component-name--primary"));
    }

    [Test]
    public void ComponentName_Should_ApplyCustomCssClass_When_CssClassProvided()
    {
        // Arrange
        var customClass = "custom-class";

        // Act
        var component = RenderComponent<ComponentName>(parameters => parameters
            .Add(p => p.CssClass, customClass));

        // Assert
        Assert.That(component.Markup, Does.Contain(customClass));
    }

    [TestCase(ComponentTheme.Primary, "larouex-component-name--primary")]
    [TestCase(ComponentTheme.Success, "larouex-component-name--success")]
    [TestCase(ComponentTheme.Warning, "larouex-component-name--warning")]
    [TestCase(ComponentTheme.Danger, "larouex-component-name--danger")]
    public void ComponentName_Should_ApplyCorrectThemeClass_When_ThemeSet(ComponentTheme theme, string expectedClass)
    {
        // Arrange & Act
        var component = RenderComponent<ComponentName>(parameters => parameters
            .Add(p => p.Theme, theme));

        // Assert
        Assert.That(component.Markup, Does.Contain(expectedClass));
    }

    [Test]
    public void ComponentName_Should_TriggerOnClick_When_Clicked()
    {
        // Arrange
        var clicked = false;
        var component = RenderComponent<ComponentName>(parameters => parameters
            .Add(p => p.OnClick, EventCallback.Factory.Create<MouseEventArgs>(this, () => clicked = true)));

        // Act
        component.Find(".larouex-component-name").Click();

        // Assert
        Assert.That(clicked, Is.True);
    }
}
```

## 📋 Quality Checklist

### Pre-Commit Checklist
- [ ] Component follows naming conventions
- [ ] All parameters have XML documentation
- [ ] CSS classes follow BEM methodology
- [ ] Component supports all required themes and sizes
- [ ] Accessibility attributes are present
- [ ] Unit tests cover all public functionality
- [ ] No compiler warnings
- [ ] README updated (if new component)
- [ ] CHANGELOG updated (if applicable)

### Code Review Checklist
- [ ] Component API is intuitive and consistent
- [ ] Performance impact is minimal
- [ ] Error handling is appropriate
- [ ] Documentation is complete and accurate
- [ ] Tests are comprehensive and meaningful
- [ ] CSS is responsive and accessible
- [ ] Breaking changes are justified and documented

## 🔧 Useful Commands

### Development Commands
```bash
# Build the project
dotnet build

# Run tests
dotnet test

# Pack for NuGet
dotnet pack --configuration Release

# Install bUnit for testing
dotnet add package bunit --version 1.15.5

# Install NUnit for testing
dotnet add package NUnit --version 3.13.3
dotnet add package NUnit3TestAdapter --version 4.4.2
```

### Git Commands for Component Development
```bash
# Create new feature branch
git checkout -b feature/new-component-name

# Add and commit changes
git add .
git commit -m "feat(components): add ComponentName with theme support"

# Update version and changelog before release
# Edit LarouexComponents.csproj and CHANGELOG.md
git add .
git commit -m "chore(release): bump version to 1.1.0"
git tag v1.1.0
git push origin main --tags
```

This comprehensive set of standards ensures that every component in the LarouexComponents library maintains consistent quality, style, and functionality while providing clear guidelines for contributors.
