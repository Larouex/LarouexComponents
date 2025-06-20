# LarouexComponents Demo

This is a Blazor Server demo application that showcases all the components in the LarouexComponents library.

## Running the Demo

### Option 1: Using VS Code Debugging (Recommended)

1. Open the workspace in VS Code
2. Press `F5` or go to `Run > Start Debugging`
3. Select "Launch LarouexComponents Demo" from the configuration dropdown
4. The application will build and launch automatically in your default browser

### Option 2: Using the Command Line

```bash
cd Demo
dotnet run
```

Then navigate to `http://localhost:5000` in your browser.

### Option 3: Using VS Code Tasks

You can also run the demo using the VS Code task system:

1. Press `Ctrl+Shift+P` (or `Cmd+Shift+P` on Mac)
2. Type "Tasks: Run Task"
3. Select "watch-demo" to run with hot reload

## Available Configurations

The following debug configurations are available:

- **Launch LarouexComponents Demo**: Builds and runs the demo with browser auto-launch
- **Launch LarouexComponents Demo (No Browser)**: Builds and runs the demo without opening a browser
- **Attach to LarouexComponents Demo**: Attaches to an already running demo process

## Development Features

- **Hot Reload**: The demo supports hot reload for rapid development
- **Component Testing**: Interactive demo page with live configuration options
- **Breakpoint Debugging**: Full debugging support with breakpoints in both C# and Razor files
- **Error Handling**: Comprehensive error display and logging

## Demo Features

The demo application includes:

1. **Component Showcase**: Visual examples of all available components
2. **Interactive Testing**: Live controls to modify component properties
3. **Code Examples**: Copy-pasteable code snippets for each component
4. **Theme Variations**: Examples of all supported themes and sizes
5. **Responsive Design**: Mobile-friendly layout

## Project Structure

```
Demo/
├── Components/
│   ├── App.razor              # Main application component
│   ├── Routes.razor           # Routing configuration
│   ├── _Imports.razor         # Global using statements
│   ├── Layout/
│   │   └── MainLayout.razor   # Main layout template
│   └── Pages/
│       └── Home.razor         # Demo homepage with components
├── wwwroot/                   # Static files
├── Program.cs                 # Application startup
├── appsettings.json          # Configuration
└── LarouexComponents.Demo.csproj
```

## Debugging Tips

1. **Set Breakpoints**: You can set breakpoints in any `.razor` or `.cs` file
2. **Hot Reload**: Changes to Razor files will be reflected immediately
3. **Console Logging**: Use `Console.WriteLine()` or the `ILogger` for debugging output
4. **Browser DevTools**: Use F12 in the browser for client-side debugging
5. **Component Inspector**: Inspect the rendered HTML to understand component output

## Troubleshooting

If you encounter issues:

1. **Build Errors**: Make sure both the main LarouexComponents project and Demo project build successfully
2. **Port Conflicts**: The demo runs on port 5000 by default. Change the port in `Program.cs` if needed
3. **Component Not Found**: Ensure the `@using LarouexSoftwareDevelopment.LarouexComponents` directive is present
4. **Hot Reload Issues**: Restart the debugging session if hot reload stops working

## Adding New Components

When you add new components to the main library:

1. Build the main LarouexComponents project
2. Add examples to `Demo/Components/Pages/Home.razor`
3. Test the component in the interactive section
4. Document the component usage with code examples
