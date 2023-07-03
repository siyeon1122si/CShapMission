using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _230612_실습
{
    public class practice
    {
        public void Play()
        {
            Random random = new Random();

            int point = 100;
            char userInputChar = '0';

            int randomChoice = random.Next(65, 90);
            char choice = (char)randomChoice;

            Console.WriteLine(" 알파벳을 맞춰보아용 ");
            Console.WriteLine();
            Console.WriteLine(" A B C D E F G H I J K L M N O P Q R S T U V W X Y Z ");
            Console.WriteLine();


            while (true)
            {
                // 유저 입력 받기 {
                string userInputStr = string.Empty;
                userInputStr = Console.ReadLine();
                userInputChar = userInputStr[0];
                // } 유저 입력받기

                System.Console.Clear();
                Console.WriteLine(" A B C D E F G H I J K L M N O P Q R S T U V W X Y Z ");
                Console.WriteLine();

                if (userInputChar < choice)
                {
                    Console.WriteLine(" 뒤→ ");
                    Console.WriteLine();
                    point -= 5;
                }
                else if (userInputChar > choice)
                {
                    Console.WriteLine(" ←앞 ");
                    Console.WriteLine();
                    point -= 5;
                }
                else if ( userInputChar == choice )
                {
                    Console.WriteLine(" 정답입니다 !");
                    Console.WriteLine();

                    if (point >= 80)
                    {
                        Console.WriteLine(" [ 점수 {0} ] 당신은 상위 1% 입니다 !! 추카포카 !!", point);
                    }
                    else if (point < 80 && point >= 50)
                    {
                        Console.WriteLine(" [ 점수 {0} ] 상위 10% 입니다 ", point);
                    }
                    else if (point < 50 && point >= 20)
                    {
                        Console.WriteLine(" [ 점수 {0} ] 상위 30% 입니다 ", point);
                    }
                    else if (point < 20 && point > 0)
                    {
                        Console.WriteLine(" [ 점수 {0} ] 하위 80%입니다 ㅋ", point);
                    }
                    else
                    {
                        Console.WriteLine(" [ 점수 {0} ] 지셨어용 ㅋ", point);
                    }
                    break;
                }                
                else
                {
                    Console.WriteLine(" 다시 입력하세요 ");
                    Console.WriteLine();
                }
                
            }


        }
        


    }
}
