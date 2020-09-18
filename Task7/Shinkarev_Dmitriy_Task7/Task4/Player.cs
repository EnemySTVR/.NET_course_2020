using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Task4
{
    class Player : GameObject
    {
        private Playground _pg;
        public Player(int x, int y, Playground pg)
            : base(x, y)
        {
            // Конечно, круто провернуть всё это через события, но для простоты сделаем так:
            // Копируем в _pg ссылку на наш playground для того, чтобы оповещать его о наших перемещениях и взаимодействовать с другими обьектами.
            _pg = pg;
            // И добавляем на playground нашего player'a
            _pg.AddObject(this);
        }

        /*      В методах ниже проверяем возможность перемещения по полю.
                Проверяем свободны ли целевые координаты:

                Если не свободны смотрим, чем занято.
                Если бонус, то получаем профит, удаляем бонус и идем.
                Если не бонус, то не идем.
                Если враг, то гейм овер.

                Если координаты свободны, то идем: 
                Удаляем игрока в текущих координатах из playground.
                Меняем коордитаты игрока.
                Добавляем игрока в новых координатах на playground.
            */
        public void MoveUp()
        {
            
        }
        public void MoveDown()
        {

        }
        public void MoveLeft()
        {

        }
        public void MoveRight()
        {

        }
    }
}
