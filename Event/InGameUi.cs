using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class InGameUI
    {
        private UIGauge monsterHpGauge;
        private UIGauge heroHpGauge;
        public UIButton BtnHeroSkill { get; private set; }

        public InGameUI()
        {
            this.monsterHpGauge = new UIGauge();
            this.heroHpGauge = new UIGauge();
            this.BtnHeroSkill = new UIButton();
        }
    }
}
