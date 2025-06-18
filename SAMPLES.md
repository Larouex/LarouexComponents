## Sample Usage

Here are some examples of how to use the `BrandingText` component in your Blazor applications:

### Basic Usage

```razor
@page "/sample"
@using LarouexComponents

<h1>LarouexComponents Demo</h1>

<!-- Default branding text -->
<BrandingText />

<!-- Custom text -->
<BrandingText Text="Welcome to My Application" />

<!-- With additional styling -->
<BrandingText Text="Success Message" CssClass="success" />
<BrandingText Text="Warning Message" CssClass="warning" />
<BrandingText Text="Error Message" CssClass="danger" />

<!-- Different sizes -->
<BrandingText Text="Small Text" CssClass="small" />
<BrandingText Text="Large Text" CssClass="large" />

<!-- Combined styles -->
<BrandingText Text="Large Success Message" CssClass="large success" />
```

### In a Layout or Shared Component

```razor
<!-- _Layout.razor or MainLayout.razor -->
<header class="app-header">
    <BrandingText CssClass="large primary" />
</header>
```

### As a Footer

```razor
<footer class="app-footer">
    <BrandingText Text="© 2025 Larouex Software Development" CssClass="small" />
</footer>
```
