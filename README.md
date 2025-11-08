# ScriptsValidator

## Description

When working across different development environments,  
file formats can easily become inconsistent — especially with text encodings and line endings.

This repository provides a sample Unity tool  
for automatically unifying those formats across your project.

You’re encouraged to modify and adapt the implementation  
to fit your own workflow or project needs.

That said, using proper configuration tools such as `.editorconfig`  
is still highly recommended to prevent such inconsistencies in the first place.

## Installation & Setup

This project uses **[ReadJEnc](https://github.com/hnx8/ReadJEnc)**, a pure C# library for character encoding detection
and conversion.  
Since Unity does not directly support NuGet, you’ll first need to install
**[NuGetForUnity](https://github.com/GlitchEnzo/NuGetForUnity)**.

1. Install **NuGetForUnity** in your project.
2. Open **NuGet > Manage NuGet Packages** from the Unity menu.
3. Search for **ReadJEnc** and install it.

The ReadJEnc library is compiled into a DLL file named `Hnx8.ReadJEnc`.  
If your project uses assembly definitions, make sure to explicitly add a reference to this DLL.

After installing ReadJEnc, download the latest Unity package from the
**[latest Release](https://github.com/foriver4725/ScriptsValidator/releases)** page  
and import it into your project.

Once compilation is complete, you can open the tool from  
**Tools > Scripts Validator (Open Window)** in the Unity Editor.

---

> **Note:**  
> ReadJEnc is particularly effective at detecting file encodings that include Japanese text.  
> Depending on the primary language used in your project, you may not need this library  
> — or you might prefer to replace it with a different encoding detection library.
>
> Also, ReadJEnc is an external library maintained by a third party.  
> Please review its license and terms of use before including it in your project.
