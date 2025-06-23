#include<stdio.h>
#define Max 100

int arr[Max];
int top = -1;

void push(int val){
    if(top == Max - 1){
        printf("Stack Overflow");
    }
    else{
        arr[++top] = val;
    }
}

void pop(){
    if(top == -1){
        printf("Stack Underflow \n");
    }
    else{
       printf("Popped Element : %d\n ",arr[top--]);
    }
}

void peep(){
     if(top == -1){
        printf("Stack Underflow \n");
    }
    else{
       printf("top Element : %d\n ",arr[top]);
    }
}

void display(){
    if(top == -1){
        printf("Stack is Empty\n");
    }
    else{
        printf("Stack Elements : \n");
        for(int i = top; i >=0;  i--){
            printf("%d ",arr[i]);
        }
        printf("\n");
    }
}

int main(){
   while (1)
    {
        printf("Enter 1 - push , 2 - pop , 3 - display , 4 - peep , 5 - termination = ");
        int num;
        scanf("%d", &num);

        if (num == 1) {
            printf("Enter Element = ");
            int val;
            scanf("%d", &val);
            push(val);
        }
        else if (num == 2) {
            pop();
        }
        else if (num == 3) {
            display();
        }
        else if (num == 4) {
            peep();
        }
        else if (num == 5) {
            break;
        }
        else {
            printf("Enter Valid Input\n");
        }
    }
    return 0;
}