# LarouexComponents

A Blazor component library created by Larouex Software Development for building reusable UI components.

## Installation

This package can be installed via NuGet Package Manager or by adding it to your project file:

```xml
<PackageReference Include="LarouexComponents" Version="1.0.0" />
```

## Components

### BrandingText

A simple, styled text component for displaying branding information.

#### Usage

```razor
@using LarouexComponents

<!-- Default usage -->
<BrandingText />

<!-- Custom text -->
<BrandingText Text="Your Custom Text Here" />

<!-- With additional CSS classes -->
<BrandingText Text="Styled Text" CssClass="large primary" />
```

#### Parameters

- `Text` (string): The text to display. Defaults to "Larouex Software Development"
- `CssClass` (string): Additional CSS classes to apply to the component

#### CSS Classes

The component includes several built-in CSS modifier classes:

- `small`: Smaller font size and padding
- `large`: Larger font size and padding
- `primary`: Blue accent color
- `success`: Green accent color
- `warning`: Yellow accent color
- `danger`: Red accent color

## Building the Project

To build the project and create a NuGet package:

```bash
dotnet build
dotnet pack
```

## Publishing to NuGet

To publish to NuGet (requires API key):

```bash
dotnet nuget push bin/Release/LarouexComponents.1.0.0.nupkg --source https://api.nuget.org/v3/index.json --api-key YOUR_API_KEY
```

## Development

This project is built with .NET 8 and Blazor components. The components are designed to be lightweight and easily customizable.

## License

MIT License - Copyright © Larouex Software Development 2025
