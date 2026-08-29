[![](https://img.shields.io/nuget/v/soenneker.extensions.datetime.nullable.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.datetime.nullable/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.datetime.nullable/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.datetime.nullable/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.extensions.datetime.nullable.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.datetime.nullable/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.datetime.nullable/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.datetime.nullable/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Extensions.DateTime.Nullable
Compares nullable `DateTime` values by calendar date while ignoring their time of day.

## Installation

```bash
dotnet add package Soenneker.Extensions.DateTime.Nullable
```

## Usage

```csharp
using Soenneker.Extensions.DateTime.Nullable;

DateTime? first = new DateTime(2026, 8, 29, 9, 15, 0);
DateTime? second = new DateTime(2026, 8, 29, 22, 45, 0);

bool sameDate = first.IsEqualTo(second); // true
bool bothMissing = ((DateTime?) null).IsEqualTo(null); // true
```

`IsEqualTo()` compares the `Date` properties only. Two null values are equal; null compared with a populated value is false. It does not convert time zones, so values representing the same instant can compare differently if their displayed calendar dates differ.
