<p align="right">
  <a href="https://www.235u.net">
    <img src="ActinUranium.Web/wwwroot/img/logo.svg" alt="Actin Uranium logo" width="109">
  </a>
</p>

## State

### Monitoring

![Website](https://img.shields.io/website?style=for-the-badge&url=https%3A%2F%2Fwww.235u.net)
![Uptime Robot ratio (30 days)](https://img.shields.io/uptimerobot/ratio/m783489721-6dbd879caf5b391ffe19c142?style=for-the-badge)
![Mozilla HTTP Observatory Grade](https://img.shields.io/mozilla-observatory/grade/www.235u.net?publish&style=for-the-badge)
![Codacy grade](https://img.shields.io/codacy/grade/86622d802de64d499eb5dea26ba742aa?style=for-the-badge)
![Maintenance](https://img.shields.io/maintenance/yes/2019?style=for-the-badge)

### Other

![GitHub language count](https://img.shields.io/github/languages/count/235u/ActinUranium.Web?style=for-the-badge)
![GitHub top language](https://img.shields.io/github/languages/top/235u/ActinUranium.Web?style=for-the-badge)
![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/235u/ActinUranium.Web?style=for-the-badge)
![GitHub repo size](https://img.shields.io/github/repo-size/235u/ActinUranium.Web?style=for-the-badge)
![GitHub](https://img.shields.io/github/license/235u/ActinUranium.Web?style=for-the-badge)

## Ideas

Was man alles machen könnte:

* Nachbau auch mit CMS (Umbraco / Orchard), Performance-Vergleich
* Time-Machine könnte für Referenzen (interne Entwicklung, Verweise zu externen Ressourcen) verwendet werden
* Time-Machine-Funktionalität
  * Verlinkung zu bestimmten Versionen, statt Screenshots
  * Eine Multi-Tenancy-Funktionalität
* Business Lunch, Gesamtprojekt (Planung, Konstruktion etc.) als Schlagzeilen und Arbeiten
* Developer PC Build

## Observations

### Globalization and localization
Setting (via `Project Properties > Package > Assembly neutral language` or manually in `.csproj`)

```xml
<PropertyGroup>
  <NeutralLanguage>de</NeutralLanguage>
</PropertyGroup>
```

leads to strange (mixed) localization behaviour at runtime; localization works as expected while leaving this setting empty (or setting to `(None)` in the Properties GUI).

## Versioning

Doch SemVer?

* 2019.01.25 22:39:11
* 2019.07.15.1730
* 2019.07

## Text-Bausteine

Ich werde nicht nur Software entwickeln, sondern auch viel Software anwenden / einsetzen.

## Built with

In Form einer schönen Tabelle; eventuell als SVG

* <https://www.codingdojo.com/web-development-courses>
* <https://builtwith.com/>

## Referenzen

Verweise zu:

* Stack Overflow
* CSS Tricks
* Wikipedia
* Google Styles
* Pixabay
* Creative Market
* Font Awesome
* Microsoft / Design Guidelines
* Coding Guidelines: Google / Styles /Speed
* MDN
* W3C
* Adobe

## Data Seeding

Nicht per Session - der Speicher würde explodieren.
