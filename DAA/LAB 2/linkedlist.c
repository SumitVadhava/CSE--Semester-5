#include<stdio.h>
#include<stdlib.h>

struct Node{
    int data;
    struct Node* next;
};

struct Node * head = NULL;

void insertEnd(int val){
    struct Node* newNode = (struct Node*)malloc(sizeof(struct Node));
    newNode->data = val;
    newNode->next = NULL;

    if(head == NULL){
        head = newNode;
    }
    else{
        struct Node* temp = head;
        
        while (temp->next != NULL)
        {
            temp = temp->next;
        }
        temp->next = newNode;
    }

}

void deleteEnd(){
    if(head == NULL){
        printf("LinkedList is Empty");
    }
    else{
        struct Node* temp = head;
         while (temp->next->next != NULL)
        {
            temp = temp->next;
        }
        temp->next = NULL;
    }
}

void display(){
    struct Node* temp = head;

    while (temp != NULL)
    {
       printf("%d ",temp->data);
        temp = temp->next;
    }
    printf("\n");
    
}

int main(){
    while (1)
    {
         printf("Enter 1 - insertEnd , 2 - deleteEnd , 3 - display , 4 - termination = ");
         int num;
         scanf("%d",&num);
         
        if(num == 1){
            printf("Enter Element = ");
            int val;
            scanf("%d",&val);
            insertEnd(val);
        }
        else if(num == 2){
            deleteEnd();
        }
        else if(num == 3){
            display();
        }
        else if(num == 4){
            break;
        }
        else{
            printf("Enter Vaild Input\n");
        }
    }
 
}