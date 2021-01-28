using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectOOPOdev
{
    class GamgeManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun başarılı bir şekilde eklendi: " + game.GameName);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Oyun başarılı bir şekilde silindi: " + game.GameName);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun başarılı bir şekilde Güncellendi: " + game.GameName);
        }
    }
}
