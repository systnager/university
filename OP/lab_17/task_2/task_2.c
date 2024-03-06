#include <stdio.h>
#include <windows.h>
int hasMoreThanTwoDuplicates(int arr[], int size) {
    for (int i = 0; i < size - 1; ++i) {
        int count = 1;
        for (int j = i + 1; j < size; ++j) {
            if (arr[i] == arr[j]) {
                count++;
                if (count > 2) {
                    return 1;
                }
            }
        }
    }
    return 0;
}

int main() {
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    int size = 9;

    int arr[] = {1, 2, 3, 2, 3, 5, 4, 3, 5};

    printf("������� �����: ");
    for (int i = 0; i < size; ++i) {
        printf("%d ", arr[i]);
    }
    printf("\n");

    int result = hasMoreThanTwoDuplicates(arr, size);

    if (result) {
        printf("����� ������ ����� ���� ��������� ��������.\n");
    }
    else {
        printf("����� �� ������ ����� ���� ��������� ��������.\n");
    }

    return 0;
}
