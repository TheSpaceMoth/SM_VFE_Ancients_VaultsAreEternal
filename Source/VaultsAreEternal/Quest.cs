using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VFEAncients;

namespace VaultsAreEternal
{
    public class CompQuestOnHackedDetonate : CompQuestOnHacked
    {
        //public CompProperties_Quest Props => this.props as CompProperties_Quest;

        public override void ReceiveCompSignal(string signal)
        {
            base.ReceiveCompSignal(signal);

            if (signal == "Hackend")
            {
                // Hacking is complete, assume that the above spawned the quest right, and detonate!
                this.parent.Kill();
            }
        }

        public override void PostExposeData()
        {
            base.PostExposeData();
        }

        public override void PostDraw()
        {
            base.PostDraw();
        }

        public override void CompTick()
        {
            base.CompTick();
        }
    }
}
