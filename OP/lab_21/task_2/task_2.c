#include <stdio.h>
#include <string.h>
#include <windows.h>

int main() {
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    char sentence[1000];
    int commas = 0;
    int length;

    printf("Введіть речення: ");
    fgets(sentence, sizeof(sentence), stdin);

    length = strlen(sentence);
    for (int i = 0; i < length; i++) {
        if (sentence[i] == ',') {
            commas++;
        }
    }

    if (sentence[length - 2] == '.') {
        printf("Речення закінчується крапкою.\n");
    }
    else {
        printf("Речення не закінчується крапкою.\n");
    }

    printf("Кількість ком у реченні: %d\n", commas);

    return 0;
}
