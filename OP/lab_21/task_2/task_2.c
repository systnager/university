#include <stdio.h>
#include <string.h>
#include <windows.h>

int main() {
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    char sentence[1000];
    int commas = 0;
    int length;

    printf("������ �������: ");
    fgets(sentence, sizeof(sentence), stdin);

    length = strlen(sentence);
    for (int i = 0; i < length; i++) {
        if (sentence[i] == ',') {
            commas++;
        }
    }

    if (sentence[length - 2] == '.') {
        printf("������� ���������� �������.\n");
    }
    else {
        printf("������� �� ���������� �������.\n");
    }

    printf("ʳ������ ��� � ������: %d\n", commas);

    return 0;
}
