#include <stdio.h>
#include <windows.h>
#include <ctype.h>

void playSound(char symbol) {
    int duration = 100;

    if (symbol == '.') {
        Beep(1000, duration);
    }
    else if (symbol == '-') {
        Beep(1000, duration * 3);
    }
    Sleep(100);
}
void encodeMessage(char* message) {
    char* morseCode[] = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..",
                         ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.",
                         "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

    while (*message) {
        if (isalpha(*message)) {
            int index = toupper(*message) - 'A';
            printf("%s ", morseCode[index]);

            for (int i = 0; morseCode[index][i] != '\0'; i++) {
                playSound(morseCode[index][i]);
            }
        }
        else if (*message == ' ') {
            printf("/ ");
            Sleep(300);
        }
        message++;
    }
}

int main() {
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    char message[1000];

    printf("Введіть повідомлення для кодування в азбуці Морзе:\n");
    fgets(message, sizeof(message), stdin);
    message[strcspn(message, "\n")] = '\0';

    printf("Результат кодування в азбуці Морзе:\n");
    encodeMessage(message);

    return 0;
}
