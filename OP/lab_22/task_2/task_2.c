#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <string.h>
#include <stdlib.h>

#define MAX_LENGTH 100

int isPalindrome(char* word) {
    int len = strlen(word);
    for (int i = 0; i < len / 2; i++) {
        if (word[i] != word[len - i - 1]) {
            return 0;
        }
    }
    return 1;
}

int main() {
    char inputString[MAX_LENGTH];
    printf("Enter a string with words: ");
    fgets(inputString, sizeof(inputString), stdin);

    if (inputString[strlen(inputString) - 1] == '\n') {
        inputString[strlen(inputString) - 1] = '\0';
    }

    char* token;
    char* words[MAX_LENGTH];
    int wordCount = 0;

    token = strtok(inputString, " ");
    while (token != NULL) {
        words[wordCount++] = token;
        token = strtok(NULL, " ");
    }

    printf("Words that are palindromes:\n");
    for (int i = 0; i < wordCount; i++) {
        if (isPalindrome(words[i])) {
            printf("%s\n", words[i]);
        }
    }

    printf("\nNumber of repetitions for each word:\n");
    int count[MAX_LENGTH] = { 0 };
    for (int i = 0; i < wordCount; i++) {
        for (int j = 0; j < wordCount; j++) {
            if (strcmp(words[i], words[j]) == 0) {
                count[i]++;
            }
        }
        printf("%s: %d\n", words[i], count[i]);
    }
    char* mostRepeatedWord = NULL;
    int maxCount = 0;
    for (int i = 0; i < wordCount; i++) {
        if (count[i] > maxCount) {
            maxCount = count[i];
            mostRepeatedWord = words[i];
        }
    }
    if (mostRepeatedWord != NULL) {
        printf("\nWord repeated the maximum number of times: %s\n", mostRepeatedWord);
    }
    else {
        printf("\nNo words are repeated\n");
    }

    printf("\nString of unique words (without repetitions):\n");
    for (int i = 0; i < wordCount; i++) {
        int isUnique = 1;
        for (int j = i + 1; j < wordCount; j++) {
            if (strcmp(words[i], words[j]) == 0) {
                isUnique = 0;
                break;
            }
        }
        if (isUnique) {
            printf("%s ", words[i]);
        }
    }

    printf("\nWords in alphabetical order:\n");
    char* temp;
    for (int i = 0; i < wordCount - 1; i++) {
        for (int j = i + 1; j < wordCount; j++) {
            if (strcmp(words[i], words[j]) > 0) {
                temp = words[i];
                words[i] = words[j];
                words[j] = temp;
            }
        }
    }
    for (int i = 0; i < wordCount; i++) {
        printf("%s ", words[i]);
    }
    printf("\n");


    return 0;
}
