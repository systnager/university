#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#include <windows.h>

void reverseString(char* str) {
    if (str == NULL)
        return;

    char* start = str;
    char* end = str + strlen(str) - 1;

    while (start < end) {
        char temp = *start;
        *start = *end;
        *end = temp;

        start++;
        end--;
    }
}

int countNumbers(char* str) {
    int count = 0;

    while (*str) {
        if (isdigit(*str)) {
            count++;

            while (isdigit(*str)) {
                str++;
            }
        }
        else {
            str++;
        }
    }

    return count;
}

int isVowel(char c) {
    c = tolower(c);
    return (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u');
}

void removeWordsStartingWithVowel(char* str) {
    char* start = str;
    char* end = str;

    while (*end) {
        while (*end && !isspace(*end)) {
            end++;
        }

        if (start != end && isVowel(*start)) {
            while (start < end) {
                *start = *(start + 1);
                start++;
            }
        }

        if (*end) {
            start = ++end;
        }
    }
}

int main() {
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    char inputString[1000];
    printf("������ ����� - 'a', 'e', 'i', 'o', 'u'\n�����! �������� ��������� ������ ���� � ���������!\n");
    printf("������ ��������� �����: ");
    fgets(inputString, sizeof(inputString), stdin);
    inputString[strcspn(inputString, "\n")] = '\0';
    printf("\n��������� ������ �����: ");
    reverseString(inputString);
    printf("%s\n", inputString);
    int numbersCount = countNumbers(inputString);
    printf("\nʳ������ ����� � �����: %d\n", numbersCount);
    removeWordsStartingWithVowel(inputString);
    printf("\n����� ��� ���, �� ����������� � �������� ����:\n%s\n", inputString);

    return 0;
}
