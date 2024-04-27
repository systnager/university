#include <iostream>
#include <cstdio>
#include <cstdlib>
#include <cstring>

using namespace std;

struct Node {
    int data;
    struct Node* prev;
    struct Node* next;
};

struct Node* createEmptyList() {
    return NULL;
}

void push(struct Node** head_ref, int new_data) {
    struct Node* new_node = (struct Node*)malloc(sizeof(struct Node));
    new_node->data = new_data;
    new_node->prev = NULL;
    new_node->next = *head_ref;
    if (*head_ref != NULL)
        (*head_ref)->prev = new_node;
    *head_ref = new_node;
}

int pop(struct Node** head_ref) {
    if (*head_ref == NULL) {
        printf("Error: stack underflow\n");
        return -1;
    }
    int popped_data = (*head_ref)->data;
    struct Node* temp = *head_ref;
    *head_ref = (*head_ref)->next;
    if (*head_ref != NULL)
        (*head_ref)->prev = NULL;
    free(temp);
    return popped_data;
}

void addToFront(struct Node** head_ref, int new_data) {
    struct Node* new_node = (struct Node*)malloc(sizeof(struct Node));
    new_node->data = new_data;
    new_node->prev = NULL;
    new_node->next = *head_ref;
    if (*head_ref != NULL)
        (*head_ref)->prev = new_node;
    *head_ref = new_node;
}

void addToEnd(struct Node** head_ref, int new_data) {
    struct Node* new_node = (struct Node*)malloc(sizeof(struct Node));
    struct Node* last = *head_ref;
    new_node->data = new_data;
    new_node->next = NULL;
    if (*head_ref == NULL) {
        new_node->prev = NULL;
        *head_ref = new_node;
        return;
    }
    while (last->next != NULL)
        last = last->next;
    last->next = new_node;
    new_node->prev = last;
}

void removeFromEnd(struct Node** head_ref) {
    if (*head_ref == NULL)
        return;
    struct Node* last = *head_ref;
    while (last->next != NULL)
        last = last->next;
    if (last->prev != NULL)
        last->prev->next = NULL;
    else
        *head_ref = NULL;
    free(last);
}

void printList(struct Node* head) {
    struct Node* temp = head;
    while (temp != NULL) {
        printf("%d ", temp->data);
        temp = temp->next;
    }
    printf("\n");
}

void deleteList(struct Node** head_ref) {
    struct Node* current = *head_ref;
    struct Node* next;
    while (current != NULL) {
        next = current->next;
        free(current);
        current = next;
    }
    *head_ref = NULL;
}

void task_1() {
    struct Node* list = createEmptyList();
    int qwe = 1;
    while (qwe) {
        int choice;
        printf("\nChoice action\n1-create list\n2-add element\n3-remove element\n4-print list\n5-delete list\nanything else - quit");
        scanf("%d", &choice);
        if (choice == 1) {
            addToEnd(&list, 1);
            addToEnd(&list, 2);
            addToEnd(&list, 3);
            addToEnd(&list, 4);
            addToEnd(&list, 5);
            addToEnd(&list, 6);
            addToEnd(&list, 7);
            addToEnd(&list, 8);
            addToFront(&list, 9);
            addToFront(&list, 0);
        } else if (choice == 2) {
            int number;
            printf("enter new number value");
            scanf("%d", &number);
            addToEnd(&list, number);
        } else if (choice == 3) {
            removeFromEnd(&list);
        } else if (choice == 4) {
            printf("list: ");
            printList(list);
        } else if (choice == 5) {
            deleteList(&list);
        } else {
            printf("Bye");
            qwe = 0;
        }
    }
}

void task_2() {
    char expression[] = "7 5 2 - 4 * +";
    struct Node* stack = createEmptyList();

    char* token = strtok(expression, " ");
    while (token != NULL) {
        if (isdigit(token[0]) || (token[0] == '-' && isdigit(token[1]))) {
            push(&stack, atoi(token));
        } else {
            int operand2 = pop(&stack);
            int operand1 = pop(&stack);
            if (strcmp(token, "+") == 0) {
                push(&stack, operand1 + operand2);
            } else if (strcmp(token, "-") == 0) {
                push(&stack, operand1 - operand2);
            } else if (strcmp(token, "*") == 0) {
                push(&stack, operand1 * operand2);
            } else if (strcmp(token, "/") == 0) {
                push(&stack, operand1 / operand2);
            }
        }
        token = strtok(NULL, " ");
    }

    int result = pop(&stack);
    printf("Result: %d\n", result);
}

int main() {
    printf("Choice task\n1 - first task\n2 - second task\n");
    int choice;
    scanf("%d", &choice);
    if (choice == 1) {
        task_1();
    } else if (choice == 2) {
        task_2();
    } else {
        printf("Invalid input. Bye");
    }
    return 0;
}
