using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class GameLauncher
    {
        public InGameUI inGameUI;
        private Hero hero;
        private Monster monster;

        public GameLauncher()
        {
            this.inGameUI = new InGameUI();

            //add event
            EventDispatcher.GetInstance().AddEventHandler("MONSTER_DIE", (sender, e) =>
            {
                Console.WriteLine("sender : {0}, e : {1}", sender, e);
                var eventArgs = (GameEvent.MonsterEventArgs)e;
                Console.WriteLine("id : {0}, hp : {1}", eventArgs.info.id, eventArgs.info.hp);
            });
            this.hero = new Hero();
            this.monster = new Monster();
            hero.Init("Gildong");
            var info = new MonsterInfo();
            info.id = 1;
            info.hp = 100;
            monster.Init("Orc", info);

            //event
            //btn event
            this.inGameUI.BtnHeroSkill.OnClickEventHandler += BtnHeroSkill_OnClickEventHandler;
        }

        private void BtnHeroSkill_OnClickEventHandler(object sender, EventArgs e)
        {
            Console.WriteLine("{0}, {1}", sender, e);
            this.hero.ActiveSkill();
            this.monster.TakeDamage(5);
        }

        public void Init()
        {
            Console.WriteLine("게임 준비완료");
            this.Start();
        }

        public void Start()
        {
            Console.WriteLine("게임이 실행됨");

            //사용자가 눌렀다
            this.inGameUI.BtnHeroSkill.Click();
        }
    }
}
