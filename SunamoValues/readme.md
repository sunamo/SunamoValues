# SunamoValues

A shared NuGet package providing constants, values, and enumerations used across multiple Sunamo packages. This library contains HTML attribute/tag constants, date/time constants, MIME type mappings, emoticon patterns, culture info helpers, and other commonly referenced values.

## Features

- **HTML Constants**: Tag names, attribute names, attribute values, starting/ending tags
- **Date/Time Constants**: Day and month names (EN/CS), Unix epoch values, format strings
- **MIME Types**: Comprehensive extension-to-MIME-type mappings
- **HTML Entities**: Full HTML entity name-to-character dictionary with encoding support
- **Culture Infos**: Czech culture info initialization
- **Emoticons**: Emoticon pattern collections
- **Status Prefixes**: Error, warning, success, info message prefixes
- **Git Constants**: Merge conflict markers
- **Numeric Constants**: Commonly used numeric values

## Installation

```
dotnet add package SunamoValues
```

## Target Frameworks

**TargetFrameworks:** `net10.0;net9.0;net8.0`

Uses C# 12.0 features (collection expressions) requiring .NET 8.0+.

## Links

- [NuGet](https://www.nuget.org/profiles/sunamo)
- [GitHub](https://github.com/sunamo/PlatformIndependentNuGetPackages)
- [Developer site](https://sunamo.cz)

Request for new features / bug report / etc: [Mail](mailto:radek.jancik@sunamo.cz) or on GitHub
