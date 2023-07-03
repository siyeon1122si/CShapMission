#include <iostream>
#include <stdlib.h>
#include <time.h>
#include <conio.h>  // _getch 함수 사용을 위한 헤더 파일

void Game();
void swapElements(int puzzle[][6], int y1, int x1, int y2, int x2);

const int Star = -1;

int main()
{
    Game();
}

void Game()
{
    int puzzle[6][6] = { 0, };  // 퍼즐을 저장하는 2차원 배열
    int puzzle_clear[6][6] = { 0, };  // 퍼즐 클리어 배열

    int userInput = 0;          // 입력 받는 퍼즐의 크기

    int emptyX = 0;             // 빈 칸 X좌표
    int emptyY = 0;             // 빈 칸 Y좌표

    int index = 0;

    srand(time(NULL));

    printf(" 플레이할 크기를 정해주세요.( 3 ~ 6 ) : ");
    scanf_s("%d", &userInput);

    if (userInput >= 3 && userInput <= 6 )
    {
        // 퍼즐 초기화
        for (int y = 0; y < userInput; y++)
        {
            for (int x = 0; x < userInput; x++)
            {
                puzzle[y][x] = index + 1;
                
                puzzle_clear[y][x] = index + 1;  // 퍼즐 클리어 초기화

                index++;
            }
        }


        // 퍼즐 섞기
        for (int y = 0; y < userInput; y++)
        {
            for (int x = 0; x < userInput; x++)
            {
                int randX = rand() % userInput;
                int randY = rand() % userInput;

                swapElements(puzzle, y, x, randY, randX);

            }
        }

        emptyX = userInput - 1;
        emptyY = userInput - 1;


        // 퍼즐 게임 시작
		while (1)
		{
            int clearCount = 0;

			system("cls");


			for (int y = 0; y < userInput; y++)
			{
				for (int x = 0; x < userInput; x++)
				{
                    if  ( puzzle[y][x] == userInput * userInput ) // '-1'을 맨 오른쪽 아래에 위치
                    {
                        emptyX = x;
                        emptyY = y;

                        printf(" * ");
                    }
                  
					else
					{
						printf("%2d ", puzzle[y][x]);  // 숫자 또는 '-1'
					}

                    if ( puzzle_clear[y][x] == puzzle[y][x] )
                    {
                        clearCount += 1;
                    }
				}
				printf("\n");
			}

            // 승리 조건 및 대사
             if ( clearCount == userInput * userInput )
            {
                printf("축하합니다! 승리하셨습니다.\n");
                break;
            }

            char input = _getch();

            // 입력된 키에 따라 퍼즐을 이동

            if (input == 'd') // 오른쪽으로 이동
            {
                if (emptyX < userInput - 1)
                {
                    swapElements(puzzle, emptyY, emptyX, emptyY, emptyX + 1);
                    emptyX++;
                }
            }
            else if (input == 'a') // 왼쪽으로 이동
            {
                if (emptyX > 0)
                {
                    swapElements(puzzle, emptyY, emptyX, emptyY, emptyX - 1);
                    emptyX--;
                }
            }
            else if (input == 'w') // 위로 이동
            {
                if (emptyY > 0)
                {
                    swapElements(puzzle, emptyY, emptyX, emptyY - 1, emptyX);
                    emptyY--;
                }
            }
            else if (input == 's') // 아래로 이동
            {
                if (emptyY < userInput - 1)
                {
                    swapElements(puzzle, emptyY, emptyX, emptyY + 1, emptyX);
                    emptyY++;
                }
            }
        }
    }
    else
    {
        printf(" 올바른 값을 입력해주세요.");
    }
}

// 퍼즐의 두 칸을 교환하는 함수
void swapElements(int puzzle[][6], int y1, int x1, int y2, int x2)
{
    int temp = puzzle[y1][x1];
    puzzle[y1][x1] = puzzle[y2][x2];
    puzzle[y2][x2] = temp;
}


