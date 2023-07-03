using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission_230615
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StoneMoveGame game = new StoneMoveGame();
            game.Map();

        }
        //static void CursorPosition(int x, int y) // 화면 안깜빡이게 하는거
        //{
        //    Console.SetCursorPosition(x, y);
        //}

        
    }
}
