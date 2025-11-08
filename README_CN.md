# ScriptsValidator

## 概述

在不同的开发环境中编写程序时，  
文件格式（尤其是编码和换行符）往往会出现不一致的情况。

本仓库提供了一个 **Unity 示例工具**，  
用于在整个项目中自动统一这些文件格式。

你可以根据自己的项目需求和工作流程，  
自由修改和扩展此实现。

另外，建议仍然使用诸如 `.editorconfig` 等配置工具，  
从根本上防止此类格式差异的发生。

---

## 安装与设置

本项目使用了 **[ReadJEnc](https://github.com/hnx8/ReadJEnc)**，  
这是一个用于检测和转换字符编码的纯 C# 库。

由于 Unity 并不直接支持 NuGet，  
你需要先安装 **[NuGetForUnity](https://github.com/GlitchEnzo/NuGetForUnity)**。

1. 在项目中安装 **NuGetForUnity**。
2. 通过 Unity 菜单打开 **NuGet > Manage NuGet Packages**。
3. 搜索并安装 **ReadJEnc**。

ReadJEnc 会被编译为一个名为 `Hnx8.ReadJEnc.dll` 的文件。  
如果你的项目使用了 `.asmdef`（程序集定义文件），  
请确保显式添加对该 DLL 的引用。

完成 ReadJEnc 安装后，  
从 **[最新的 Release](https://github.com/foriver4725/ScriptsValidator/releases)** 页面下载 Unity 包并导入项目。

编译完成后，你可以在 Unity 菜单中通过  
**Tools > Scripts Validator (Open Window)** 打开此工具。

---

> **注意：**  
> ReadJEnc 在检测包含日语文本的文件编码方面表现尤为出色。  
> 如果你的项目主要使用其他语言，  
> 可能并不需要使用该库，或者可以选择替换为其它编码检测库。
>
> 此外，ReadJEnc 是由第三方维护的外部库，  
> 在将其集成到项目之前，请务必阅读并遵守其许可协议和使用条款。

---

## 使用方法与功能

在执行转换之前，请先指定以下两项：
- **搜索根目录**（递归扫描的文件夹）
- **目标文件扩展名**（要包含在搜索中的文件类型）

当前支持的扩展名如下：  
`.cs`, `.shader`, `.hlsl`, `.txt`, `.md`

接着，选择目标的 **编码格式** 和 **换行符样式**，  
然后点击 **Run Conversion** 按钮以开始转换。

此操作**无法撤销**，  
因此执行前会显示确认对话框。

正如前文所述，本工具是一个 **示例实现**。  
请根据项目的规模或开发流程，自由调整其行为。

对于大型项目，  
建议将搜索范围扩展到 `Assets/` 目录之外的其他文件夹。

工具会依次处理检测到的每个文件：  
需要转换的文件会被修改，  
发生错误的文件会被立即跳过，  
并且每个文件的处理结果都会输出到日志中，  
方便你追踪和确认具体的更改内容。

---

## 许可协议

本仓库采用 **MIT License** 授权。  
详情请参阅 [LICENSE](./LICENSE)。

---

## 致谢

- [ReadJEnc](https://github.com/hnx8/ReadJEnc)
- [NuGetForUnity](https://github.com/GlitchEnzo/NuGetForUnity)
