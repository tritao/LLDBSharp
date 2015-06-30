
local CPPSHARP_DIR = "CppSharp/"
local NEWTONSOFT_DIR = "Newtonsoft.Json.6.0.8/lib/net45/",

solution "LLDBSharp"

  configurations { "Debug", "Release" }
  platforms { "x32", "x64" }
  flags { "Symbols" }

  project "LLDBBSharpGen"

    kind  "ConsoleApp"
    language "C#"

    files { "*.cs" }
    links
    {
      CPPSHARP_DIR .. "CppSharp",
      CPPSHARP_DIR .. "CppSharp.AST",
      CPPSHARP_DIR .. "CppSharp.Parser.CSharp",
      CPPSHARP_DIR .. "CppSharp.Generator",
    }

  project "LLDBSharp"

    kind  "SharedLib"
    language "C#"
    files { "LLDBSharp/*.cs" }
    flags { "Unsafe" }

  project "LLDBSharpExample"

    kind  "ConsoleApp"
    language "C#"
    flags { "Unsafe" }

    files { "Example.cs" }
    links { "LLDBSharp" }



