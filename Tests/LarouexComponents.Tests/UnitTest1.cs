using Bunit;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using LarouexSoftwareDevelopment.LarouexComponents;

namespace LarouexComponents.Tests;

/// <summary>
/// Test class for BrandingText component
/// Demonstrates comprehensive testing patterns for Blazor components
/// </summary>
[TestFixture]
public class BrandingTextTests : Bunit.TestContext
{
    [SetUp]
    public void Setup()
    {
        // Add any required services for dependency injection
        Services.AddLogging();
    }

    [Test]
    public void BrandingText_Should_RenderCorrectly_When_DefaultParametersUsed()
    {
        // Arrange & Act
        var component = RenderComponent<BrandingText>();

        // Assert
        Assert.That(component.Find(".larouex-branding-text"), Is.Not.Null, "Component should render with base CSS class");
        Assert.That(component.Markup, Does.Contain("Larouex Software Development"), "Should display default branding text");
    }

    [Test]
    public void BrandingText_Should_DisplayCustomText_When_TextParameterProvided()
    {
        // Arrange
        var customText = "Custom Branding Text";

        // Act
        var component = RenderComponent<BrandingText>(parameters => parameters
            .Add(p => p.Text, customText));

        // Assert
        Assert.That(component.Markup, Does.Contain(customText), "Should display custom text");
        Assert.That(component.Markup, Does.Not.Contain("Larouex Software Development"), "Should not display default text");
    }

    [Test]
    public void BrandingText_Should_ApplyCustomCssClass_When_CssClassProvided()
    {
        // Arrange
        var customClass = "my-custom-class";

        // Act
        var component = RenderComponent<BrandingText>(parameters => parameters
            .Add(p => p.CssClass, customClass));

        // Assert
        Assert.That(component.Markup, Does.Contain(customClass), "Should include custom CSS class");
        Assert.That(component.Find(".larouex-branding-text"), Is.Not.Null, "Should still have base CSS class");
    }

    [Test]
    public void BrandingText_Should_CombineTextAndCssClass_When_BothProvided()
    {
        // Arrange
        var customText = "Test Branding";
        var customClass = "test-class";

        // Act
        var component = RenderComponent<BrandingText>(parameters => parameters
            .Add(p => p.Text, customText)
            .Add(p => p.CssClass, customClass));

        // Assert
        Assert.That(component.Markup, Does.Contain(customText), "Should display custom text");
        Assert.That(component.Markup, Does.Contain(customClass), "Should include custom CSS class");
        Assert.That(component.Find(".larouex-branding-text"), Is.Not.Null, "Should have base CSS class");
    }

    [Test]
    public void BrandingText_Should_HandleEmptyText_Gracefully()
    {
        // Arrange & Act
        var component = RenderComponent<BrandingText>(parameters => parameters
            .Add(p => p.Text, ""));

        // Assert
        Assert.That(component.Find(".larouex-branding-text"), Is.Not.Null, "Component should still render");
        Assert.That(component.Markup, Does.Not.Contain("Larouex Software Development"), "Should not show default text");
    }

    [Test]
    public void BrandingText_Should_HandleNullText_Gracefully()
    {
        // Arrange & Act
        var component = RenderComponent<BrandingText>(parameters => parameters
            .Add(p => p.Text, (string)null!));

        // Assert
        Assert.That(component.Find(".larouex-branding-text"), Is.Not.Null, "Component should still render");
        // The component should handle null gracefully without throwing
    }

    [Test]
    public void BrandingText_Should_SanitizeHtmlContent_When_HtmlInText()
    {
        // Arrange
        var htmlText = "<script>alert('xss')</script>Safe Text";

        // Act
        var component = RenderComponent<BrandingText>(parameters => parameters
            .Add(p => p.Text, htmlText));

        // Assert
        // Blazor automatically escapes HTML content, so script tags should be escaped
        Assert.That(component.Markup, Does.Not.Contain("<script>"), "HTML should be escaped for security");
        Assert.That(component.Markup, Does.Contain("Safe Text"), "Safe text should still be displayed");
    }

    [Test]
    public void BrandingText_Should_RenderAccessibleHtml()
    {
        // Act
        var component = RenderComponent<BrandingText>();

        // Assert
        var element = component.Find(".larouex-branding-text");
        Assert.That(element, Is.Not.Null, "Component should render");
        Assert.That(element.TagName.ToLower(), Is.EqualTo("div"), "Should use semantic div element");
    }

    [Test]
    public void BrandingText_Should_PreserveWhitespace_InText()
    {
        // Arrange
        var textWithSpaces = "Text   with   multiple   spaces";

        // Act
        var component = RenderComponent<BrandingText>(parameters => parameters
            .Add(p => p.Text, textWithSpaces));

        // Assert
        Assert.That(component.Markup, Does.Contain(textWithSpaces), "Should preserve whitespace in text");
    }

    [Test]
    public void BrandingText_Should_HandleLongText_Without_Breaking()
    {
        // Arrange
        var longText = new string('A', 1000); // 1000 character string

        // Act & Assert
        Assert.DoesNotThrow(() =>
        {
            var component = RenderComponent<BrandingText>(parameters => parameters
                .Add(p => p.Text, longText));
            Assert.That(component.Find(".larouex-branding-text"), Is.Not.Null);
        }, "Component should handle long text without throwing");
    }

    [Test]
    public void BrandingText_Should_HandleSpecialCharacters_InText()
    {
        // Arrange
        var specialText = "Special chars: !@#$%^&*()_+-=[]{}|;':\",./<>?`~";

        // Act
        var component = RenderComponent<BrandingText>(parameters => parameters
            .Add(p => p.Text, specialText));

        // Assert
        Assert.That(component.Markup, Does.Contain("Special chars"), "Should handle special characters");
        Assert.That(component.Find(".larouex-branding-text"), Is.Not.Null, "Component should render successfully");
    }
}