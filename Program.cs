var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Serve a simple Hello World HTML page at the home route
app.MapGet("/", () => Results.Content("""
    <!DOCTYPE html>
    <html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Hello World</title>
        <style>
            body {
                font-family: Arial, sans-serif;
                display: flex;
                flex-direction: column;
                justify-content: center;
                align-items: center;
                height: 100vh;
                margin: 0;
                background: #1F2A44;
                color: #ffffff;
            }
            h1 { font-size: 3rem; margin-bottom: 0.5rem; }
            p  { font-size: 1.2rem; color: #9bb4d4; }
        </style>
    </head>
    <body>
        <h1>Hello Mohammed  World 👋</h1>
        <p>My first .NET app on Azure Web App using Github Action </p>
    </body>
    </html>
    """, "text/html"));

app.Run();
