<p align="right">
  <a href="https://www.235u.net">
    <img src="ActinUranium.Web/wwwroot/img/logo.svg" alt="Actin Uranium logo" width="109">
  </a>
</p>

## State

![Website](https://img.shields.io/website?style=for-the-badge&url=https%3A%2F%2Fwww.235u.net)
![Mozilla HTTP Observatory Grade](https://img.shields.io/mozilla-observatory/grade/www.235u.net?publish&style=for-the-badge)
![GitHub language count](https://img.shields.io/github/languages/count/235u/ActinUranium.Web?style=for-the-badge)
![GitHub top language](https://img.shields.io/github/languages/top/235u/ActinUranium.Web?style=for-the-badge)

## Ideas

- Nachbau auch mit CMS (Umbraco / Orchard), Performance-Vergleich
- Time-Machine könnte für Referenzen (interne Entwicklung, Verweise zu externen Ressourcen) verwendet werden.
- Time-Machine-Funktionalität
  - Verlinkung zu bestimmten Versionen, statt Screenshots
  - Eine Multi-Tenancy-Funktionalität
- Business Lunch, Gesamtprojekt (Planung, Konstruktion etc.) als Schlagzeilen und Arbeiten
- Developer PC Build

## Observations

### Globalization and localization
Setting (via `Project Properties > Package > Assembly neutral language` or manually in `.csproj`)

```xml
<PropertyGroup>
  <NeutralLanguage>de</NeutralLanguage>
</PropertyGroup>
```

leads to strange (mixed) localization behaviour at runtime; localization works as expected while leaving this setting empty (or setting to `(None)` in the Properties GUI.

## Versioning

- 2019.01.25 22:39:11
- 2019.07.15.1730
- 2019.07

## Text-Bausteine

- Ich werde nicht nur Software entwickeln, sondern auch viel Software anwenden / einsetzen.

## Built with

In Form einer schönen Tabelle; eventuell als SVG

- <https://www.codingdojo.com/web-development-courses>
- <https://builtwith.com/>

## Referenzen

- Stack Overflow
- CSS Tricks
- Wikipedia
- Google Styles
- Pixabay
- Creative Market
- Font Awesome
- Microsoft
  - Design Guidelines
- Coding Guidelines
 - Google
  - Styles
  - Speed
 - MDN
 - W3C
 - Adobe

## Data Seeding

Nicht per Session - der Speicher würde explodieren.

