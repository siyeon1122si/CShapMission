#include <iostream>
#include <stdio.h>
#include<conio.h>

void Desc001();
void ArrayFunc(int* ptrArray, int arraySize);
void ArrayFunc2(int array_[], int arraySize);
void Desc007();


int main()
{
    Desc007();
}



// 배열 받기
void Desc001()
{
    int numbers[10] = { 0 , };
    for (int i = 0; i < 10; i++)
    {
        numbers[i] = (i + 1) * 10;
    }
    for (int i = 0; i < 10; i++)
    {
        printf("%d ", numbers[i]);
    }
    printf("\n");

    int* ptrNumber = &numbers[2];

    //역참조 ( 배열의 5번째 값에 접근하려고 할 때 )
    numbers[4];           // 이 형태가 배열을 사용한 역참조
    *(ptrNumber + 4);     // 이 형태가 포인터를 사용한 역참조

    printf("3번째 자리에 있는 값 + 1 - > %d \n", *(ptrNumber + 1));

    printf("numbers 가 들고 있는 값 - > %p\n", numbers);     // numbers의 값과
    printf("numbers[0] 의 주소 값 - > %p \n", &numbers[0]); // numbers[0]의 주소 값은 같다.
    printf("\n\n");

    printf("numbers의 Size : %d \n", sizeof(numbers));

    ArrayFunc(numbers, 10);  // 배열 받기 방법 1
    ArrayFunc2(numbers,10);  // 배열 받기 방법 2
}

void ArrayFunc(int* ptrArray, int arraySize) // 배열 받는 함수 
{
    printf("int형 포인터의 자체적인 크기가 몇이지? -> %d \n", sizeof(ptrArray));
    for (int i = 0; i < arraySize; i++)
    {
        printf("ptrArray[%d]  역참조 값 : %d \n",i, *(ptrArray+i));
    }
} // 방법 1

void ArrayFunc2(int myarray[],int arraySize) // 배열 받는 함수
{
    printf(" 함수에서 찍어 본 numbers의 Size : %d \n",sizeof(myarray));

    for (int i = 0; i < arraySize; i++)
    {
        printf("array[%d]의 값 : %d \n",i,myarray[i]);
    }
} // 방법 2
// 배열 받기



// 정렬 실습
void Desc002()
{
    // 선택 숫자 배열
    int number[5] = { 21 , 59 , 36 , 99 , 17 };
    int i, j, smallestIndex, temp;

    // 선택 정렬을 수행하기 위해 배열 요소를 반복한다.
    for (int i = 0; i < 5; i++)
    {
        smallestIndex = i;      // 현재 인덱스를 가장 작은 값의 인덱스로 초기화한다.

        for (j = i + 1; j < 5; j++) // 남은 정렬되지 않은 부분에서 가장 작은 값을 찾는다.
        {
            if (number[j] < number[smallestIndex]) // 부호를 반대로 하면 내림차순이 된다.
            {
                smallestIndex = j;   // 해당 인덱스를 가장 작은 값의 인덱스로 갱신합니다.
            }
        }

        // { 비교 후 교환
        temp = number[i];
        number[i] = number[smallestIndex];
        number[smallestIndex] = temp;
        // } 비교 후 교환
    }
    
    // { 출력
    for (i = 0; i < 5; i++)
    {
        printf("%d ", number[i]);
    }
    // } 출력
} // 선택 정렬 실습

void Desc003()
{  
    int number[5] = { 21 , 59 , 36 , 99 , 17 };
    int Count = 0;
    int temp = 0;

    while (Count < 4)  // 최대 4번의 패스를 수행
    {
        for (int j = 0; j < 4; j++)  // 한 번의 패스에서 인접한 두 요소를 비교하여 정렬
        {
            if (number[j] > number[j + 1])  // 현재 요소가 다음 요소보다 큰 경우
            {                               
                temp = number[j];
                number[j] = number[j + 1];
                number[j+1]=temp;
            }
        }
        Count += 1;
    }
    
    // { 출력
    for (int i=0; i < 5; i++)
    {
        printf("%d ", number[i]);
    }
    // } 출력
} // 버블 정렬 실습

void Desc004()
{
    int number[5] = { 21 , 59 , 36 , 99 , 17 };
    int Count = 0;
    int temp = 0;

    while (Count < 4)//전체
    {
        for (int j = Count; j > 0; j--)//비교할 범위
        {
            if (number[j] > number[j - 1])  
            {
                temp = number[j];
                number[j] = number[j - 1];
                number[j - 1] = temp;
            }
        }
        Count += 1;
    }

    // { 출력
    for (int i = 0; i < 5; i++)
    {
        printf("%d ", number[i]);
    }
    // } 출력
} // 삽입 정렬 실습
// 정렬 실습



// 다차원 배열 사용 전과 후
void Desc005()
{
    // 다차원 배열 사용 전
    
    char char_[25] = { 0, };

    for (int i = 0; i < 25; i++)
    {
        char_[i] = '*';
    }

    // 출력 부분
    for (int i = 0; i < 25; i++)
    {
        printf("%c ", char_[i]);

        if (i % 5 == 4)
        {
            printf("\n");
        }
    }
    printf("\n");
}

void Desc006()
{
    // 다차원 배열

    char char_[25] = { 0, }; // 이 배열을 다차원 배열로 한다면

    char char2_[5][5] = { 0, };  // 25개의 배열이 5개씩 5개 짤려있다는 말

    for (int i = 0; i < 25; i++)
    {
        char_[i] = '*';
    }

    for (int y = 0; y < 5; y++)
    {
        for (int x = 0; x < 5; x++)
        {

            // { 가운데에 0을 추가할 때 ( 방법 1 )
            if (x == 2 && y == 2)   
            {
                char2_[2][2] = '0';
                continue;
            }
            // } 가운데에 0을 추가할 때 ( 방법 1 )
            char2_[y][x] = '*';
        }
    }
    
    char2_[2][2] = '0';   // 가운데에 0을 추가할 때 ( 방법 2 )

    for (int y = 0; y < 5; y++)
    {
        for (int x = 0; x < 5; x++)
        {
            printf("%c ", char2_[y][x]);
        }
        printf("\n");  // 줄바꿈을 해줘야 행과 열이 바르게 나온다.
    }
}
// 다차원 배열 사용 전과 후

// w , a , s , d 로 0 움직이기
void Desc007()
{
    char char2_[5][5] = { 0, }; 
    int posX= 2; 
    int posY = 2;  

    char2_[2][2] = '0';   // 가운데에 0을 추가할 때 

    while (1)
    {
        char input = _getch();
        system("cls");

        switch (input)
        {
        case 'd' :
			if (posX < 4)
			{
                //char2_[posY][posX] = '*';
				posX++;
                ;
			}
            break;

        case 'a' :
			if (posX > 0)
			{
                
				posX--;
               
			}
            break;

        case 'w' :
			if (posY > 0)
			{
				posY--;
                
			}
            break;

        case 's' :
			if (posY < 4)
			{
				posY++;
            }
            break;

        default:
            break;
        }

        for (int y = 0; y < 5; y++)
        {
            for (int x = 0; x < 5; x++)
            {
                if (x == posX && y == posY)
                {
                    char2_[y][x] = '0';
                }
                else {

                char2_[y][x] = '*';
                }
            }
        }
		for (int y = 0; y < 5; y++)
		{
			for (int x = 0; x < 5; x++)
			{
				printf("%c ", char2_[y][x]);
			}
			printf("\n");
		}
    }
}
// w , a , s , d 로 0 움직이기


// 23_06_09 동적 할당
void Desc008()
{
    int userInput = -1;
    printf(" 원하는 크기만큼 배열을 만들겠음. 크기를 입력하시오 :");
    scanf_s("%d", &userInput);

    // new 동적 할당

    int* numbers = new int[userInput];    // 힙에 배열을 할당했다.

    for (int i = 0; i < userInput; i++)
    {
        numbers[i] = i + 1;
    }

    for (int i = 0; i < userInput; i++)
    {
        printf(" i값 : %d \n", numbers[i]);
    }

    // 프로그램 종료 시
    delete[] numbers;   // 이 코드를 사용하지 않으면 컴퓨터를 종료할때까지 힙 메모리에 계속 님는다.
}
// 23_06_09 동적 할당









