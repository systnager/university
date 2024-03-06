#include <stdio.h>
#include <string.h>
#include <ctype.h>
#include <windows.h>
void removeSpaces(char* str) {
    int count = 0;
    int _count = 0;
    for (int i = 0; str[i]; i++) {
        if (str[i] != ' ') {
            str[count++] = str[i];
        }
        else {
            _count++;
        }
    }
    str[count] = '\0';
    printf("Перетворений текст: %s\n", str);
    printf("Кількість вилучених пробілів: %d\n", _count);
}

int main() {
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    char inputString[1000];

    printf("Введіть рядок символів: ");
    fgets(inputString, sizeof(inputString), stdin);
    inputString[strcspn(inputString, "\n")] = '\0';
    removeSpaces(inputString);
    return 0;
}