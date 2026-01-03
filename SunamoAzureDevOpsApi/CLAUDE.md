# INSTRUKCE PRO PŘEJMENOVÁNÍ PROMĚNNÝCH

**VŠECHNY instrukce pro pojmenování proměnných samopopisnými názvy najdeš v:**

```
E:\vs\Projects\PlatformIndependentNuGetPackages\CLAUDE.md
```

Přečti si ten soubor před jakoukoliv prací na přejmenování proměnných v tomto projektu!

**KRITICKÉ pravidla (zkrácená verze, plná verze v hlavním CLAUDE.md):**
- ❌ NIKDY nepřidávej komentář `// variables names: ok` - to dělá pouze uživatel
- ❌ NIKDY nepoužívaj doménově specifické názvy (`columnCount`, `rowSize`) pro univerzální parametry → použij `groupSize`, `chunkSize`
- ❌ NIKDY nepoužívaj jednoslovné názvy (`s`, `v`, `l`) → použij `text`, `value`, `list`
- ❌ NIKDY nepoužívaj `item` pro parametry metod → vyhrazeno pro foreach
- ✅ VŽDY maž nepoužívané parametry z hlaviček metod
- ✅ VŽDY dbej na konzistenci v rámci jednoho souboru

Balíčky
<PackageReference Include="Newtonsoft.Json" Version="13.0.4" />
<PackageReference Include="Microsoft.Extensions.Logging.Abstractions" Version="10.0.1" Pack="True" />

potřebuji kvůli importům:

using Microsoft.TeamFoundation.SourceControl.WebApi;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;

