#include <stdio.h>

#if defined(_MSC_VER)
#define DLL_API __declspec(dllexport)
#else
#define DLL_API
#endif

extern "C"
{

DLL_API struct Test {
public:
	int a;

	void test(int val) {
		this->a = val;
	}
};

DLL_API void NativeFunc(int x)
{
	Test c;
	c.test(5);

	int b[] = { 2, 4 };
	int a = 5;
	printf("%d", a);
	a = x;
	printf("Hello world from native!\n");
	printf("Returning back to managed code...\n");
}

}

