#include<stdio.h>
#include<time.h>

#define N1 100
#define N2 1000
#define N3 10000
#define N4 100000

int readArrayFromFile(const char *fileName, int arr[],int n){
    FILE *f = fopen(fileName,"r");
    
    if(!f){
        printf("Can't open file :",fileName);
    }
    for(int i = 0; i < n; i++){
        fscanf(f,"%d ",&arr[i]);
    }
    fclose(f);
    return 1;    
}

void selectionSort(int arr[], int n){
    for(int i = 0; i < n - 1; i++){
        int min = i;
        for(int j = i + 1; j < n; j++){
            if(arr[min] > arr[j]){
                min = j;
            }
        }
        if(min != i){
            int temp = arr[i];
            arr[i] = arr[min];
            arr[min] = temp;
        }
    }    
}

int main(){
    int arr1[N1];
    int arr2[N2];
    int arr3[N3];
    int arr4[N4];

    clock_t start,end;
    double time_taken;

    if(readArrayFromFile("./../best_case_100.txt",arr1,N1)){
        start = clock();
        selectionSort(arr1,N1);
        end = clock();
        time_taken = ((double) (end - start)/CLOCKS_PER_SEC * 1000);
        printf("Time taken by algo (best_case_100) : %lf",time_taken);
    }

    if(readArrayFromFile("./../avg_case_100.txt",arr1,N1)){
        start = clock();
        selectionSort(arr1,N1);
        end = clock();
        time_taken = ((double) (end - start)/CLOCKS_PER_SEC * 1000);
        printf("\nTime taken by algo (avg_case_100) : %lf",time_taken);
    }

    if(readArrayFromFile("./../worst_case_100.txt",arr1,N1)){
        start = clock();
        selectionSort(arr1,N1);
        end = clock();
        time_taken = ((double) (end - start)/CLOCKS_PER_SEC * 1000);
        printf("\nTime taken by algo (worst_case_100) :%lf",time_taken);
    }

    if(readArrayFromFile("./../best_case_1000.txt",arr2,N2)){
        start = clock();
        selectionSort(arr2,N2);
        end = clock();
        time_taken = ((double) (end - start)/CLOCKS_PER_SEC * 1000);
        printf("\nTime taken by algo (best_case_1000) :%lf",time_taken);
    }

    if(readArrayFromFile("./../avg_case_1000.txt",arr2,N2)){
        start = clock();
        selectionSort(arr2,N2);
        end = clock();
        time_taken = ((double) (end - start)/CLOCKS_PER_SEC * 1000);
        printf("\nTime taken by algo (avg_case_1000) :%lf",time_taken);
    }
    if(readArrayFromFile("./../worst_case_1000.txt",arr2,N2)){
        start = clock();
        selectionSort(arr2,N2);
        end = clock();
        time_taken = ((double) (end - start)/CLOCKS_PER_SEC * 1000);
        printf("\nTime taken by algo (worst_case_1000) :%lf",time_taken);
    }

    if(readArrayFromFile("./../best_case_10000.txt",arr3,N3)){
        start = clock();
        selectionSort(arr3,N3);
        end = clock();
        time_taken = ((double) (end - start)/CLOCKS_PER_SEC * 1000);
        printf("\nTime taken by algo (best_case_10000) :%lf",time_taken);
    }

    if(readArrayFromFile("./../avg_case_10000.txt",arr3,N3)){
        start = clock();
        selectionSort(arr3,N3);
        end = clock();
        time_taken = ((double) (end - start)/CLOCKS_PER_SEC * 1000);
        printf("\nTime taken by algo (avg_case_10000) :%lf",time_taken);
    }
    if(readArrayFromFile("./../worst_case_10000.txt",arr3,N3)){
        start = clock();
        selectionSort(arr3,N3);
        end = clock();
        time_taken = ((double) (end - start)/CLOCKS_PER_SEC * 1000);
        printf("\nTime taken by algo (worst_case_10000) :%lf",time_taken);
    }

    if(readArrayFromFile("./../best_case_100000.txt",arr4,N4)){ 
        start = clock();
        selectionSort(arr4,N4);
        end = clock();
        time_taken = ((double) (end - start)/CLOCKS_PER_SEC * 1000);
        printf("\nTime taken by algo (best_case_100000) :%lf",time_taken);
    }

    if(readArrayFromFile("./../avg_case_100000.txt",arr4,N4)){
        start = clock();
        selectionSort(arr4,N4);
        end = clock();
        time_taken = ((double) (end - start)/CLOCKS_PER_SEC * 1000);
        printf("\nTime taken by algo (avg_case_100000) :%lf",time_taken);
    }
    if(readArrayFromFile("./../worst_case_100000.txt",arr4,N4)){
        start = clock();
        selectionSort(arr4,N4);
        end = clock();
        time_taken = ((double) (end - start)/CLOCKS_PER_SEC * 1000);
        printf("\nTime taken by algo (worst_case_100000) :%lf",time_taken);
    }
}