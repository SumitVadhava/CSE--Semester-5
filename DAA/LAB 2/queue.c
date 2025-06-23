#include<stdio.h>
#define Max 100

int arr[Max];
int front = -1,rear = -1;

void enqueue(int val){
    if(rear == Max - 1){
        printf("Queue is Overflow");
    }
    else{
        if(front == -1){
            front = 0;
            arr[++rear] = val;
        }
        else{
            arr[++rear] = val;
        }
    }
}

void dequeue(){
    if(front > rear){
        printf("Queue is underflow");
    }
    else{
        printf("Dequeued ELement : %d\n",arr[front++]);
    }
}

void peek(){
     if(front == -1 || front > rear){
        printf("Queue is Empty");
    }
    else{
        printf("peeked ELement : %d\n",arr[front]);
    }
}

void display(){
    if(front == -1 || front > rear){
        printf("Queue is Empty");
    }
    else{
        printf("Queue Elements :\n");

        for(int i = front; i <= rear; i++){
            printf("%d ",arr[i]);
        }
        printf("\n");
    }
}

int main(){
    while (1)
    {
         printf("Enter 1 - enqueue , 2 - dequeue , 3 - display , 4 - peek , 5 - termination = ");
         int num;
         scanf("%d",&num);
         
        if(num == 1){
            printf("Enter Element = ");
            int val;
            scanf("%d",&val);
            enqueue(val);
        }
        else if(num == 2){
            dequeue();
        }
        else if(num == 3){
            display();
        }
        else if(num == 4){
            peek();
        }
        else if (num == 5)
        {
            break;
        } 
        else{
            printf("Enter Vaild Input");
        }
    }
    return 0;
}