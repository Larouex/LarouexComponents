# 🚀 VS Code Debugging Setup for LarouexComponents

This document explains how to use VS Code's debugging capabilities to test and develop your Blazor components.

## 🎯 Quick Start

1. **Open the workspace** in VS Code
2. **Press F5** or click `Run > Start Debugging`
3. **Select "Launch LarouexComponents Demo"** from the dropdown
4. **Wait for the build** to complete
5. **Your browser** will automatically open to the demo application

## 🛠️ Available Debug Configurations

### 1. Launch LarouexComponents Demo

- **Purpose**: Full development experience with automatic browser launch
- **Use Case**: Primary configuration for testing components
- **Features**:
  - Automatic build
  - Browser auto-launch
  - Full debugging support
  - Hot reload enabled

### 2. Launch LarouexComponents Demo (No Browser)

- **Purpose**: Run the demo without opening a browser
- **Use Case**: When you want to manually navigate to the URL
- **Features**:
  - Automatic build
  - Console output visible
  - Manual browser navigation to `http://localhost:5000`

### 3. Attach to LarouexComponents Demo

- **Purpose**: Attach to an already running demo process
- **Use Case**: When the demo is already running and you want to debug
- **Features**:
  - No build required
  - Attach to existing process
  - Full debugging capabilities

## 🔧 VS Code Tasks Available

Access tasks via `Ctrl+Shift+P` → "Tasks: Run Task":

### build-demo

- Builds the demo project
- Used automatically by debug configurations
- Can be run manually for quick builds

### watch-demo

- Runs the demo with hot reload
- Background task that continues running
- Automatically rebuilds on file changes
- Perfect for rapid development

## 🐛 Debugging Features

### Breakpoints

- **C# Files**: Set breakpoints in any `.cs` file including `Program.cs`
- **Razor Files**: Set breakpoints in `.razor` files in the C# code sections
- **Component Logic**: Debug component parameters, events, and lifecycle methods

### Hot Reload

- **Razor Changes**: Automatically reflected in the browser
- **CSS Changes**: Styling updates appear immediately
- **C# Changes**: May require rebuild depending on the change

### Variable Inspection

- **Watch Window**: Monitor variable values in real-time
- **Locals**: View local variables in the current scope
- **Call Stack**: Navigate through the execution path

### Console Output

- **Application Logs**: View `Console.WriteLine()` and `ILogger` output
- **ASP.NET Core Logs**: Monitor server activity and requests
- **Error Messages**: Detailed error information and stack traces

## 📁 Project Structure for Debugging

```
.vscode/
├── launch.json          # Debug configurations
├── tasks.json           # Build and run tasks
└── extensions.json      # Recommended extensions

Demo/
├── Components/
│   ├── App.razor        # Main app - debuggable
│   ├── Routes.razor     # Routing - debuggable
│   ├── Layout/
│   │   └── MainLayout.razor  # Layout - debuggable
│   └── Pages/
│       └── Home.razor   # Main demo page - debuggable
├── Program.cs           # Startup code - debuggable
└── appsettings.json     # Configuration

LarouexComponents/
├── BrandingText.razor   # Your components - debuggable
├── ComponentEnums.cs    # Enums - debuggable
└── *.razor              # All component files
```

## 🎨 Component Testing Workflow

### 1. Add New Component

```csharp
// In your new component file
@namespace LarouexSoftwareDevelopment.LarouexComponents

<div class="my-new-component">
    @Text
</div>

@code {
    [Parameter] public string Text { get; set; } = "Default";
}
```

### 2. Add to Demo

```razor
<!-- In Demo/Components/Pages/Home.razor -->
<div class="demo-section">
    <h2>My New Component</h2>
    <div class="component-example">
        <MyNewComponent Text="Hello World" />
    </div>
</div>
```

### 3. Debug and Test

1. **Set breakpoints** in your component's `@code` section
2. **Press F5** to start debugging
3. **Interact** with the component in the browser
4. **Step through** the code execution
5. **Modify and reload** to test changes

## 🔍 Common Debugging Scenarios

### Component Parameter Issues

1. Set breakpoint in component's `OnParametersSet()` or `OnInitialized()`
2. Check parameter values in the debugger
3. Verify parameter binding in the parent component

### CSS/Styling Problems

1. Use browser DevTools (F12) to inspect rendered HTML
2. Check CSS class applications
3. Verify scoped CSS is working correctly

### Event Handling

1. Set breakpoints in event handler methods
2. Inspect event arguments and component state
3. Verify event callbacks are properly wired

### Lifecycle Issues

1. Set breakpoints in lifecycle methods:
   - `OnInitialized()`
   - `OnParametersSet()`
   - `OnAfterRender()`
2. Monitor component state changes
3. Check disposal in `IDisposable.Dispose()`

## ⚡ Performance Debugging

### Component Re-rendering

1. Override `ShouldRender()` method
2. Set breakpoint to see when component re-renders
3. Monitor parameter changes and state updates

### Memory Leaks

1. Use browser DevTools Memory tab
2. Monitor event handler subscriptions
3. Ensure proper disposal of resources

## 🛡️ Error Handling

### Build Errors

- Check **Problems** panel in VS Code
- Review **Terminal** output for detailed error messages
- Ensure all required packages are installed

### Runtime Errors

- **Blazor Error UI** will display unhandled exceptions
- Check **browser console** for JavaScript errors
- Review **VS Code Debug Console** for server-side errors

### Common Issues and Solutions

| Issue                   | Solution                                                 |
| ----------------------- | -------------------------------------------------------- |
| Component not found     | Check `@using` directives in `_Imports.razor`            |
| CSS not applied         | Verify scoped CSS file naming (`.razor.css`)             |
| Parameters not updating | Check parameter change detection and `StateHasChanged()` |
| Events not firing       | Verify event callback parameter binding                  |
| Build fails             | Clean solution: `dotnet clean` then `dotnet build`       |

## 📊 Monitoring and Logging

### Application Insights

- Configure logging in `appsettings.json`
- Use `ILogger<T>` for structured logging
- Monitor performance and errors

### Custom Logging

```csharp
@inject ILogger<MyComponent> Logger

@code {
    protected override void OnInitialized()
    {
        Logger.LogInformation("Component initialized with parameter: {Parameter}", SomeParameter);
    }
}
```

## 🚀 Advanced Debugging Tips

### 1. Conditional Breakpoints

- Right-click breakpoint → Add condition
- Example: `parameterValue == "specific-value"`

### 2. Expression Evaluation

- Use **Debug Console** to evaluate expressions
- Type expressions while debugging: `> parameterName`

### 3. Multi-target Debugging

- Debug both server-side C# and client-side Blazor
- Use browser DevTools for client-side debugging

### 4. Performance Profiling

- Use .NET diagnostic tools
- Monitor component render times
- Identify performance bottlenecks

## 📚 Additional Resources

- [Blazor Debugging Documentation](https://docs.microsoft.com/en-us/aspnet/core/blazor/debug)
- [VS Code C# Debugging](https://code.visualstudio.com/docs/languages/csharp)
- [ASP.NET Core Logging](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/logging)

---

## 🎉 You're Ready to Debug!

Press **F5** and start building amazing Blazor components with full debugging support! 🚀
