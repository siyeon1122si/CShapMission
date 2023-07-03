using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.Win32;

/*개별과제
카드뽑기 게임 ver2 만들기
1. 컴퓨터가 카드를 2장 뽑아서 보여준다.
2. 플레이어는 카드를 보고 베팅한다.
3. 플레이어의 카드가 컴퓨터의 카드 2장 사이에 존재한다면, 플레이어는 한번의 게임을 승리하여 베팅 점수의 2배를 얻는다.
4. 플레이어의 카드가 컴퓨터의 카드 2장 사이에 존재하지 않는 경우, 플레이어는 한번의 게임을 패배하여 베팅 점수만큼 잃는다.
5. 플레이어는 일정 점수를 획득하면 게임을 최종 승리하며, 0점 이하인 경우 게임을 최종 패배한다. 이 경우에 게임을 종료한다.
*/

namespace _230612Mission_Card
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int Coin = 1000;

            while (Coin < 3000 && Coin > 0)
            {
                // 컴퓨터의 카드 선택 {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("                                    컴퓨터가 카드를 고르는 중입니다");

                Console.Write(" · ");
                Thread.Sleep(600);
                Console.Write("· ");
                Thread.Sleep(600);
                Console.Write("· ");
                Thread.Sleep(600);



                System.Console.Clear(); // 콘솔 창 초기화

                Random AIrandom = new Random();  // 랜덤 생성

                int AICardrand1 = AIrandom.Next(1, 13); // 컴퓨터의 카드 랜덤1
                int AICardrand2 = AIrandom.Next(1, 13); // 컴퓨터의 카드 랜덤2

                int AIPatternrand1 = AIrandom.Next(1, 4); // 컴퓨터의 카드 패턴 랜덤1
                int AIPatternrand2 = AIrandom.Next(1, 4); // 컴퓨터의 카드 패턴 랜덤2


                string[] AICardChoice = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" }; // 13장의 카드 종류
                string[] AIPattern = { "♤", "◆", "♥", "♧" }; // 4개의 카드 패턴

                Console.WriteLine();
                Console.WriteLine(" [ 컴퓨터의 카드 1 ]          [ 컴퓨터의 카드 2 ] ");

                // 카드 출력 부분

                if (AICardrand1 < AICardrand2) //AI 카드1번이 2번보다 작으면 첫번째로 나오게 출력
                {
                    Console.WriteLine();

                    Console.WriteLine(" ┌──────────────┐         ┌──────────────┐ ");
                    Console.WriteLine(" │ {00}{01}          │         │ {02}{03}          │ ", AIPattern[AIPatternrand1], AICardChoice[AICardrand1], AIPattern[AIPatternrand2], AICardChoice[AICardrand2]);
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │          {00}{01} │         │          {02}{03} │ ", AIPattern[AIPatternrand1], AICardChoice[AICardrand1], AIPattern[AIPatternrand2], AICardChoice[AICardrand2]);
                    Console.WriteLine(" └──────────────┘         └──────────────┘ ");
                }
                else //AI 카드2번이 1번보다 작으면 첫번째로 나오게 출력
                {
                    Console.WriteLine();

                    Console.WriteLine(" ┌──────────────┐         ┌──────────────┐ ");
                    Console.WriteLine(" │ {00}{01}          │         │ {02}{03}          │ ", AIPattern[AIPatternrand2], AICardChoice[AICardrand2], AIPattern[AIPatternrand1], AICardChoice[AICardrand1]);
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │          {00}{01} │         │          {02}{03} │ ", AIPattern[AIPatternrand2], AICardChoice[AICardrand2], AIPattern[AIPatternrand1], AICardChoice[AICardrand1]);
                    Console.WriteLine(" └──────────────┘         └──────────────┘ ");
                }
                // } 컴퓨터의 카드 선택 



                // 기본 소지금액 선언 및 출력
                Console.WriteLine();

                Console.WriteLine(" 현재 소지 금액 : [ {0} ]", Coin);
                Console.WriteLine();

                // 베팅 시작
                Console.WriteLine(" 베팅을 시작하겠습니다 ! 베팅금액을 적어주세요.");

                Console.WriteLine();

                int BettingCoin = int.Parse(Console.ReadLine());  // 사용자로부터 입력된 문자열을 정수로 변환하는 역할


                if (BettingCoin <= Coin) // 베팅 코인이 현재 코인과 같거나 작을 때 출력
                {
                    Coin -= BettingCoin;
                    Console.WriteLine();
                    Console.WriteLine(" 베팅금액은 [ {0} ] 입니다. ", BettingCoin);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" 현재 소지 금액 : [ {0} ] ", Coin);
                    Console.WriteLine();
                    Console.WriteLine(" 베팅이 완료되었습니다.");
                }

                // 베팅 시작
                Console.ReadLine();
                System.Console.Clear();



                // 유저의 카드 선택 {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("                                     유저가 카드를 고르는 중입니다");

                Console.Write(" · ");
                Thread.Sleep(600);
                Console.Write("· ");
                Thread.Sleep(600);
                Console.Write("· ");
                Thread.Sleep(600);


                System.Console.Clear();

                Random userrandom = new Random();  // 랜덤 생성

                int MyCardrand = userrandom.Next(1, 13); // 유저의 카드 랜덤

                int MyPatternrand = userrandom.Next(1, 4); // 유저의 카드 패턴 랜덤


                string[] MyCardChoice = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" }; // 12장의 카드 종류
                string[] MyPattern = { "♤", "◆", "♥", "♧" }; // 4개의 카드 패턴

                Console.WriteLine();
                Console.WriteLine(" [ 유저의 카드 ] ");

                // 카드 출력 부분
                Console.WriteLine();

                Console.WriteLine(" ┌──────────────┐ ");
                Console.WriteLine(" │ {00}{01}          │ ", MyPattern[MyPatternrand], MyCardChoice[MyCardrand]);
                Console.WriteLine(" │              │ ");
                Console.WriteLine(" │              │ ");
                Console.WriteLine(" │              │ ");
                Console.WriteLine(" │              │ ");
                Console.WriteLine(" │              │ ");
                Console.WriteLine(" │              │ ");
                Console.WriteLine(" │              │ ");
                Console.WriteLine(" │              │ ");
                Console.WriteLine(" │              │ ");
                Console.WriteLine(" │          {00}{01} │ ", MyPattern[MyPatternrand], MyCardChoice[MyCardrand]);
                Console.WriteLine(" └──────────────┘ ");
                // } 유저의 카드 선택 




                // 결과 출력 ... {
                Console.WriteLine(" 결과를 보려면 아무키나 눌러주세요. ");
                Console.ReadLine();
                System.Console.Clear();

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("                                                결과는 ");

                Console.Write(" · ");
                Thread.Sleep(600);
                Console.Write("· ");
                Thread.Sleep(600);
                Console.Write("· ");
                Thread.Sleep(600);
                // } 결과 출력 ...
                System.Console.Clear();


                if (AICardrand1 > AICardrand2 && MyCardrand < AICardrand1 && MyCardrand > AICardrand2)  // AI 카드1 번이 2번보다 크면 더 앞에 나오게 설정
                {
                    Console.WriteLine(" [ 컴퓨터의 카드 1 ]         [ 유저의 카드 ]         [ 컴퓨터의 카드 2 ] ");

                    Console.WriteLine();

                    Console.WriteLine(" ┌──────────────┐         ┌──────────────┐          ┌──────────────┐ ");
                    Console.WriteLine(" │ {00}{01}          │         │ {02}{03}          │          │ {04}{05}          │ ", AIPattern[AIPatternrand2], AICardChoice[AICardrand2], MyPattern[MyPatternrand], MyCardChoice[MyCardrand], AIPattern[AIPatternrand1], AICardChoice[AICardrand1]);
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │          {00}{01} │         │          {02}{03} │          │          {04}{05} │ ", AIPattern[AIPatternrand2], AICardChoice[AICardrand2], MyPattern[MyPatternrand], MyCardChoice[MyCardrand], AIPattern[AIPatternrand1], AICardChoice[AICardrand1]);
                    Console.WriteLine(" └──────────────┘         └──────────────┘          └──────────────┘ ");


                    Console.WriteLine(" [ 유저의 카드 ] 가 컴퓨터의 카드 2장 사이에 있으므로 베팅에 성공하였습니다 ! ");
                    Coin = Coin + ( BettingCoin * 2);

                }
                else if (AICardrand1 < AICardrand2 && MyCardrand > AICardrand1 && MyCardrand < AICardrand2 )  // AI 카드1 번이 2번보다 작으면 더 앞에 나오게 설정
                {
                    Console.WriteLine(" [ 컴퓨터의 카드 1 ]         [ 유저의 카드 ]         [ 컴퓨터의 카드 2 ] ");

                    Console.WriteLine();

                    Console.WriteLine(" ┌──────────────┐         ┌──────────────┐          ┌──────────────┐ ");
                    Console.WriteLine(" │ {00}{01}          │         │ {02}{03}          │          │ {04}{05}          │ ", AIPattern[AIPatternrand1], AICardChoice[AICardrand1], MyPattern[MyPatternrand], MyCardChoice[MyCardrand], AIPattern[AIPatternrand2], AICardChoice[AICardrand2]);
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │          {00}{01} │         │          {02}{03} │          │          {04}{05} │ ", AIPattern[AIPatternrand1], AICardChoice[AICardrand1], MyPattern[MyPatternrand], MyCardChoice[MyCardrand], AIPattern[AIPatternrand2], AICardChoice[AICardrand2]);
                    Console.WriteLine(" └──────────────┘         └──────────────┘          └──────────────┘ ");


                    Console.WriteLine(" [ 유저의 카드 ] 가 컴퓨터의 카드 2장 사이에 있으므로 베팅에 성공하였습니다 ! ");
                    Coin = Coin + (BettingCoin * 2);

                }

                else // AI 카드 1번과 2번 사이에 유저의 카드가 없으면 베팅 실패
                {
                    Console.WriteLine("   [ 유저의 카드 ]        [ 컴퓨터의 카드 1 ]         [ 컴퓨터의 카드 2 ] ");

                    Console.WriteLine();

                    Console.WriteLine(" ┌──────────────┐         ┌──────────────┐          ┌──────────────┐ ");
                    Console.WriteLine(" │ {00}{01}          │         │ {02}{03}          │          │ {04}{05}          │ ", MyPattern[MyPatternrand], MyCardChoice[MyCardrand], AIPattern[AIPatternrand1], AICardChoice[AICardrand1], AIPattern[AIPatternrand2], AICardChoice[AICardrand2]);
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │              │         │              │          │              │ ");
                    Console.WriteLine(" │          {00}{01} │         │          {02}{03} │          │          {04}{05} │ ", MyPattern[MyPatternrand], MyCardChoice[MyCardrand], AIPattern[AIPatternrand1], AICardChoice[AICardrand1], AIPattern[AIPatternrand2], AICardChoice[AICardrand2]);
                    Console.WriteLine(" └──────────────┘         └──────────────┘          └──────────────┘ ");

                    Console.WriteLine(" [ 유저의 카드 ] 가 컴퓨터의 카드 2장 사이에 있지 않으므로 베팅에 실패하였습니다. ");
                    Coin -= BettingCoin;
                }
               
                Console.WriteLine();
                Console.WriteLine(" 현재 소지 금액 : [ {0} ] ", Coin);
                Console.ReadLine();
                System.Console.Clear();

            }

            if (Coin >= 3000) // 돈이 3000 이상이면 승리
            {
                Console.WriteLine("\n\n\n\n\n");
                Console.WriteLine("                                             [ ! 게임 최종 승리 ! ]\n\n\n\n\n ");
                Console.WriteLine("          ■■  ■■■■■                                                                   ■■■■■  ■■");
                Console.WriteLine("        ■    ■          ■■                                                           ■■          ■    ■");
                Console.WriteLine("      ■    ■                ■                                                       ■                ■    ■");
                Console.WriteLine("      ■          ■  ■        ■                                                   ■        ■  ■            ■");
                Console.WriteLine("      ■          ■  ■        ■                                                   ■        ■  ■            ■");
                Console.WriteLine("      ■          ■  ■          ■                                               ■          ■  ■            ■");
                Console.WriteLine("      ■    ♡♡♡      ♡♡♡      ■                                           ■      ♡♡♡      ♡♡♡      ■");
                Console.WriteLine("      ■            ■              ■                                           ■              ■              ■");
                Console.WriteLine("        ■          ■              ■                                           ■              ■            ■");
                Console.WriteLine("        ■                    ■■■                                               ■■■                      ■");
                Console.WriteLine("        ■                  ■      ■                                           ■      ■                    ■");
                Console.WriteLine("          ■              ■        ■                                           ■        ■                ■");
                Console.WriteLine("          ■■            ■        ■                                           ■        ■              ■■");
                Console.WriteLine("        ■    ■■      ■        ■                                               ■        ■        ■■    ■");
                Console.WriteLine("      ■        ■■■■■■    ■                                                   ■    ■■■■■■          ■");
                Console.WriteLine("       ■■■■■         ■■■                                                       ■■■          ■■■■■");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (Coin <= 0) // 돈이 0과 같거나 낮으면 패배
            {
                Console.WriteLine("\n\n\n\n\n");
                Console.WriteLine();
                Console.WriteLine("                                                       [ 패배 ] \n\n\n\n\n");
                Console.WriteLine("                   ■■■■■                                                             ■■■■■");
                Console.WriteLine("               ■■          ■■                                                     ■■          ■■");
                Console.WriteLine("             ■                  ■                                                 ■                  ■");
                Console.WriteLine("           ■                      ■                                             ■                      ■");
                Console.WriteLine("         ■           ■   ■        ■                                         ■        ■    ■        ■");
                Console.WriteLine("         ■           ■   ■          ■                                     ■          ■    ■        ■");
                Console.WriteLine("         ■           ■   ■          ■                                     ■          ■    ■          ■");
                Console.WriteLine("       ■       ♡♡♡       ♡♡♡    ■                                     ■    ♡♡♡        ♡♡♡    ■");
                Console.WriteLine("     ■                  ■■            ■                                 ■            ■■                ■");
                Console.WriteLine("     ■                                  ■                                 ■                                ■ ");
                Console.WriteLine("     ■          ■                      ■                                 ■                      ■        ■");
                Console.WriteLine("       ■        ■                      ■                                 ■                      ■      ■");
                Console.WriteLine("         ■■■■                      ■                                     ■                      ■■■");
                Console.WriteLine("       ■        ■■          ■■■■  ■                                 ■  ■■■■          ■■      ■");
                Console.WriteLine("     ■              ■      ■          ■                                 ■          ■      ■            ■");
                Console.WriteLine("     ■                ■■■■■■■■■                                     ■■■■■■■■■              ■");
                Console.WriteLine("       ■■■■■■■■                                                                         ■■■■■■■");
                Environment.Exit(0);
            }

        }
    }
}