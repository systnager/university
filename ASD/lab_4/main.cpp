#include <iostream>
#include <cstdio>
#include <cstdlib>
#include <cstring>
#include <cmath>


#define MAX_SIZE 100

struct Stack {
    double items[MAX_SIZE];
    int top;
};

void initialize(struct Stack* stack) {
    stack->top = -1;
}

int isEmpty(struct Stack* stack) {
    return stack->top == -1;
}

int isFull(struct Stack* stack) {
    return stack->top == MAX_SIZE - 1;
}

void push(struct Stack* stack, double value) {
    if (isFull(stack)) {
        printf("stack overflow\n");
        return;
    }
    stack->items[++stack->top] = value;
}

double pop(struct Stack* stack) {
    if (isEmpty(stack)) {
        printf("stack empty\n");
        return -1;
    }
    return stack->items[stack->top--];
}

double evaluateRPN(char expression[]) {
    struct Stack stack;
    initialize(&stack);

    char* token = strtok(expression, " ");
    while (token != NULL) {
        if (isdigit(token[0])) {
            push(&stack, atof(token)); // Перетворення рядка в число
        } else {
            double operand2 = pop(&stack);
            double operand1 = pop(&stack);
            if (strcmp(token, "+") == 0) {
                push(&stack, operand1 + operand2);
            } else if (strcmp(token, "-") == 0) {
                push(&stack, operand1 - operand2);
            } else if (strcmp(token, "*") == 0) {
                push(&stack, operand1 * operand2);
            } else if (strcmp(token, "/") == 0) {
                push(&stack, operand1 / operand2);
            } else if (strcmp(token, "^") == 0) {
                push(&stack, pow(operand1, operand2));
            } else if (strcmp(token, "sqrt") == 0) {
                push(&stack, sqrt(operand2));
            }
        }
        token = strtok(NULL, " ");
    }

    return pop(&stack);
}

struct Node {
    int data;
    struct Node* prev;
    struct Node* next;
};

struct Node* createEmptyList() {
    return NULL;
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

void removeFromFront(struct Node** head_ref) {
    if (*head_ref == NULL)
        return;
    struct Node* temp = *head_ref;
    *head_ref = (*head_ref)->next;
    if (*head_ref != NULL)
        (*head_ref)->prev = NULL;
    free(temp);
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

void removeNode(struct Node** head_ref, struct Node* del) {
    if (*head_ref == NULL || del == NULL)
        return;
    if (*head_ref == del)
        *head_ref = del->next;
    if (del->next != NULL)
        del->next->prev = del->prev;
    if (del->prev != NULL)
        del->prev->next = del->next;
    free(del);
}

struct Node* search(struct Node* head, int key) {
    struct Node* current = head;
    while (current != NULL) {
        if (current->data == key)
            return current;
        current = current->next;
    }
    return NULL;
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
    char expression[100];
    printf("enter your expression: ");
    fgets(expression, 100, stdin);
    double result = evaluateRPN(expression);
    printf("result: %.2f\n", result);
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
