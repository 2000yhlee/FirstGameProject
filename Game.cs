using FirstGameProject.Scene;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGameProject
{
    class Game
    {
        // 게임 동작 
        private static Dictionary<string, BaseScene> sceneDic;
        private static BaseScene curScene;

        private static bool gameOver;        

        public static void Run()
        {
            Start();

            while (gameOver == false)
            {
                Console.Clear();
                curScene.Render();
                Console.WriteLine();
                curScene.Input();
                Console.WriteLine();
                curScene.Update();
                Console.WriteLine();
                curScene.Render();
            }

            End();
        }

        private static void Start()
        {
            gameOver = false;

            sceneDic = new Dictionary<string, BaseScene>();
            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("")
            sceneDic.Add("")
            sceneDic.Add("")
            sceneDic.Add("")
            sceneDic.Add("")
            sceneDic.Add("")

            curScene = sceneDic["Title"];
        }

        private static void ChangeScene(string sceneName)
        {
            curScene = sceneDic[sceneName];
        }

        private static void End()
        {

        }
            

    }
}
