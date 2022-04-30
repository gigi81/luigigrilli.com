// See https://aka.ms/new-console-template for more information
using Statiq.App;
using Statiq.Docs;

await Bootstrapper
    .Factory
    .CreateDocs(args)
    .RunAsync();
