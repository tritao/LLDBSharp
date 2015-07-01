#include <stdio.h>

#if defined(_MSC_VER)
#define DLL_API __declspec(dllexport)
#else
#define DLL_API
#endif

extern "C"
{

DLL_API void NativeFunc()
{
	printf("Hello world from native!\n");
	printf("Returning back to managed code...\n");
}

}

