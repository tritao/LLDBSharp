
local CPPSHARP_DIR = "CppSharp/"
local NEWTONSOFT_DIR = "Newtonsoft.Json.6.0.8/lib/net45/"

action = _ACTION or ""
builddir = path.getabsolute("./" .. action);
libdir = path.join(builddir, "lib", "%{cfg.buildcfg}_%{cfg.platform}");

solution "LLDBSharp"

  configurations { "Debug", "Release" }
  platforms { "x32", "x64" }
  flags { "Symbols" }

  location (builddir)
  objdir (path.join(builddir, "obj"))
  targetdir (libdir)

  if os.isdir(CPPSHARP_DIR) then

  project "LLDBSharp.Gen"

    kind  "ConsoleApp"
    language "C#"

    files { "LLDBSharpGen.cs" }
    links
    {
      "System.Core",
      path.join(CPPSHARP_DIR, "CppSharp"),
      path.join(CPPSHARP_DIR, "CppSharp.AST"),
      path.join(CPPSHARP_DIR, "CppSharp.Parser.CSharp"),
      path.join(CPPSHARP_DIR, "CppSharp.Generator")
    }

  end

  project "LLDBSharp"

    kind  "SharedLib"
    language "C#"
    files { "LLDBSharp/*.cs" }
    flags { "Unsafe" }

  project "LLDBSharp.Example"

    kind  "ConsoleApp"
    language "C#"
    flags { "Unsafe" }

    files { "Example.cs", "XcodeToolchain.cs" }
    links { "System.Core", "LLDBSharp" }

  project "NativeLib"
    kind  "SharedLib"
    language "C++"

    files { "tests/Native.cpp" }
    links { "c" }

  project "Managed"
    kind  "ConsoleApp"
    language "C#"

    files { "tests/Managed.cs" }
    links { "System" }