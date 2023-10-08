using System;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Filters;
using Serilog.Sinks.SystemConsole.Themes;

namespace Logging.Config;

public static class SerilogConfigurationSetup
{
  public static void WithConfiguration(this LoggerConfiguration loggerConfig, IServiceProvider provider, IConfiguration config)
  {
    var assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
    loggerConfig
        .ReadFrom.Configuration(config)
        .Enrich.FromLogContext()
        .Enrich.WithProperty("Assembly", assemblyName!)
        .Enrich.FromLogContext()
        .WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level}] {SourceContext}{NewLine}{Message:1j}{NewLine}{Exception}{NewLine}", theme: AnsiConsoleTheme.Literate)
}

