# LLDBSharp
LLDB C# bindings generated with CppSharp

# LLDB shared library binaries

LLDB MSVC shared library binary: https://dl.dropboxusercontent.com/u/194502/dev/liblldb.dll.7z

LLDB OSX shared library binary: https://dl.dropboxusercontent.com/u/194502/liblldb.dylib

# Building LLDB shared library

```
cd llvm/tools/lldb
mkdir build && cd build
cmake .. -G Ninja -DLLVM_TARGETS_TO_BUILD="X86" -DCMAKE_OSX_ARCHITECTURES="i386" -DLLDB_DISABLE_PYTHON=True
ninja
```

