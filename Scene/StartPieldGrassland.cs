using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGameProject.Scene
{
    public class StartPieldGrassland : BaseScene
    {
        private ConsoleKey input;

        public override void Render()
        {
            Console.WriteLine("푸르른 초원이 펼쳐진 평야이다.");
            Console.WriteLine("당신의 모험이 첫 발을 디뎠다.");
            Console.WriteLine("앞으로 다가올 모험에 두근거림을 품고 걸음을 내딛는다.");
            Console.WriteLine();
            Console.WriteLine("저 멀리 마을이 보인다.");
            Console.WriteLine();
            Console.WriteLine("1. 마을로 들어간다.");
            Console.WriteLine("선택지를 눌러 진행하십시오...");
        }

        public override void Input()
        {
            input = Console.ReadKey(true).Key;
        }

        public override void Update()
        {
            
        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Util.PressAnyKey("마을로 들어갑니다.");
                    Game.ChangeScene("Town");
                    break;
            }
        }
    }
}
