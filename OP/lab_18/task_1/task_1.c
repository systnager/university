#include <stdio.h>

void displayArray(int arr[], int size, int index) {
    if (index >= size) {
        return;
    }

    printf("%d ", arr[index]);
    displayArray(arr, size, index + 1);
}

int main() {
    int arr[] = { 1, 4, 3, 5, 6, 4, 2 };
    int size = sizeof(arr) / sizeof(arr[0]);

    printf("Array elements: ");
    displayArray(arr, size, 0);
    printf("\n");

    return 0;
}
