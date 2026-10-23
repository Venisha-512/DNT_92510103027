# Practical 7 - Feedback Management Module (ASP.NET Core MVC)

**Course:** 01CE1523 - .NET Technologies
**Author:** Venisha Makadia (92510103027), Batch B
**Aim:** Develop Feedback Management Module using MVC Layout, Partial View & Validation (HTML Helpers, Validation, Layouts)

## Concepts covered
- **Layout:** `Views/Shared/_Layout.cshtml` (header, nav, footer, `RenderBody`, `RenderSection`)
- **Partial views:** `_FeedbackCard.cshtml` (one card per feedback), `_ValidationScriptsPartial.cshtml`
- **HTML helpers:** `BeginForm`, `LabelFor`, `TextBoxFor`, `DropDownListFor`, `RadioButtonFor`, `TextAreaFor`, `CheckBoxFor`, `ValidationMessageFor`, `ValidationSummary`
- **Validation:** Data Annotations on the model (server side) + jQuery unobtrusive validation (client side), anti-forgery token on POST
- In-memory data store, no database needed

## Run
```
cd p7
dotnet run
```
(.NET 8 SDK) or open `p7/p7.csproj` in Visual Studio 2022 and press F5. Client-side validation scripts load from cdnjs, so an internet connection is needed for the instant (browser-side) messages; server-side validation works offline.

## Output
Screenshots are in `screenshots/`; the full report is `92510103027_pr7_DNT.pdf`.
