using System;
using System.Collections.Generic;
using System.Text;
using osu.GameModes.Edit.AiMod;
using osu.GameplayElements.HitObjects;

namespace StatStars
{
    /// <summary>
    /// statementreply's star difficulty algorithm
    /// </summary>
    public class StatStars : AiModRuleset
    {
        public override AiModType Type
        {
            get { return AiModType.Meta; }
        }

        protected override void RunAllRules(List<HitObjectBase> hitObjects)
        {
            //Do your processing in here
            Reports.Add(new AiReport(Severity.Info, "statstars: zzz"));
        }
    }
}
