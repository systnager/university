#include <cstdio>

#define MAX_VERTICES 20

struct Graph {
    int vertices;
    int matrix[MAX_VERTICES][MAX_VERTICES];
};

void initGraph(struct Graph *g, int vertices) {
    g->vertices = vertices;
    for (int i = 0; i < vertices; ++i) {
        for (int j = 0; j < vertices; ++j) {
            g->matrix[i][j] = 0;
        }
    }
}

void addEdge(struct Graph *g, int src, int dest, int weight) {
    g->matrix[src][dest] = weight;
}

void DFS(struct Graph *g, int vertex, bool visited[]) {
    visited[vertex] = true;
    printf("%d ", vertex);

    for (int i = 0; i < g->vertices; ++i) {
        if (g->matrix[vertex][i] && !visited[i]) {
            DFS(g, i, visited);
        }
    }
}

void BFS(struct Graph *g, int startVertex) {
    bool visited[MAX_VERTICES] = {false};
    int queue[MAX_VERTICES];
    int front = -1, rear = -1;

    visited[startVertex] = true;
    queue[++rear] = startVertex;

    while (front != rear) {
        int currentVertex = queue[++front];
        printf("%d ", currentVertex);

        for (int i = 0; i < g->vertices; ++i) {
            if (g->matrix[currentVertex][i] && !visited[i]) {
                visited[i] = true;
                queue[++rear] = i;
            }
        }
    }
}

void DFSWithCost(struct Graph *g, int vertex, int dest, bool visited[], int pathCost[], int currentCost) {
    visited[vertex] = true;
    pathCost[vertex] = currentCost;

    if (vertex == dest) {
        return;
    }

    for (int i = 0; i < g->vertices; ++i) {
        if (g->matrix[vertex][i] && !visited[i]) {
            DFSWithCost(g, i, dest, visited, pathCost, currentCost + g->matrix[vertex][i]);
        }
    }
}


int isReachableDFS(struct Graph *g, int src, int dest) {
    bool visited[MAX_VERTICES] = {false};
    int pathCost[MAX_VERTICES] = {0};
    DFSWithCost(g, src, dest, visited, pathCost, 0);
    if (visited[dest]) {
        return pathCost[dest];
    } else {
        return -1;
    }
}


int main() {
    struct Graph g;
    initGraph(&g, 19);
    addEdge(&g, 0, 1, 135);
    addEdge(&g, 0, 10, 128);
    addEdge(&g, 0, 13, 73);
    addEdge(&g, 1, 0, 135);
    addEdge(&g, 1, 2, 38);
    addEdge(&g, 1, 6, 115);
    addEdge(&g, 1, 7, 80);
    addEdge(&g, 2, 0, 38);
    addEdge(&g, 2, 3, 73);
    addEdge(&g, 3, 2, 73);
    addEdge(&g, 3, 4, 110);
    addEdge(&g, 4, 3, 110);
    addEdge(&g, 4, 5, 104);
    addEdge(&g, 5, 4, 104);
    addEdge(&g, 6, 1, 115);
    addEdge(&g, 7, 1, 80);
    addEdge(&g, 7, 8, 100);
    addEdge(&g, 8, 7, 100);
    addEdge(&g, 8, 9, 68);
    addEdge(&g, 9, 8, 68);
    addEdge(&g, 10, 0, 128);
    addEdge(&g, 10, 11, 175);
    addEdge(&g, 10, 12, 109);
    addEdge(&g, 11, 10, 175);
    addEdge(&g, 12, 10, 109);
    addEdge(&g, 13, 0, 78);
    addEdge(&g, 13, 14, 115);
    addEdge(&g, 13, 15, 181);
    addEdge(&g, 13, 17, 146);
    addEdge(&g, 14, 13, 115);
    addEdge(&g, 15, 13, 181);
    addEdge(&g, 15, 16, 130);
    addEdge(&g, 16, 15, 130);
    addEdge(&g, 17, 13, 146);
    addEdge(&g, 17, 18, 105);
    addEdge(&g, 18, 17, 105);

    printf("DFS from edge 0: ");
    bool visitedDFS[MAX_VERTICES] = {false};
    DFS(&g, 0, visitedDFS);

    printf("\nBFS from edge 0: ");
    BFS(&g, 0);
    int a, b;
    printf("\n\nenter start edge: ");
    scanf("%d", &a);
    printf("enter destination edge: ");
    scanf("%d", &b);
    printf("%d", isReachableDFS(&g, a, b));


    return 0;
}
