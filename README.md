# blazor-example-love-calculator

Example application with
* Server Side Rendering with Blazor
* Client Side Rendering with Blazor (WASM)

Test URLs:

Server-Side-Rendering: https://blazor-example-lc-ssr.appspot.com

SPA: https://storage.googleapis.com/blazor-example-lc-spa-static/index.html

## Deployment SSR

- Cd to `
- Run `dotnet publish -c Release`
- Run `gcloud init` for deployment to gcp
- Run `gcloud app deploy bin\Release\netcoreapp2.1\publish\app.yaml`

## Deployment SPA

As these are only static files without server-side logic they can be uploaded into static webspace.

- Cd to `LoveCalculatorClientSide`
- Run `dotnet publish -c Release`
- Upload the content of `bin\Release\netstandard2.0\publish\LoveCalculatorClientSide\dist`

Hint: basehref might need fixing or removing.

