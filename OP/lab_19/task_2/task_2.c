#include <stdio.h>

int main() {
    int arr[] = { 1, 2, 3, 4, 5 };

    int size_bytes = sizeof(arr);
    printf("Size of the array in bytes: %d\n", size_bytes);

    int elements_count = sizeof(arr) / sizeof(arr[0]);
    printf("Number of elements in the array: %d\n", elements_count);

    printf("Address of the first element of the array: %p\n", (void*)&arr[0]);
    printf("Address of the last element of the array: %p\n", (void*)&arr[elements_count - 1]);

    int i = 0, temp;
    while (i < elements_count / 2) {
        temp = arr[i];
        arr[i] = arr[elements_count - i - 1];
        arr[elements_count - i - 1] = temp;
        i++;
    }

    printf("Array after reversing its elements: ");
    i = 0;
    while (i < elements_count) {
        printf("%d ", arr[i]);
        i++;
    }
    printf("\n");

    return 0;
}
