#include <stdio.h>

int main() {
    int x, y = 10;
    int m[] = { 1, 2, 3, 4, 5 };

    int* ptr = &y;
    printf("Value of variable y using pointer: %d\n", *ptr);
    
    x = *ptr;
    printf("Value of variable x after x = *ptr: %d\n", x);

    y = 7;
    printf("Value of pointer ptr: %p\n", (void*)ptr);

    *ptr += 5;
    printf("Value of variable y after *ptr += 5: %d\n", y);

    return 0;
}
