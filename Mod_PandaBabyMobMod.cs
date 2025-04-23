using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;

namespace Mod_PandaBabyMobMod
{
    [BepInPlugin("panda.babymob.mod", "Panda's Baby Mob Mod", "1.0.0.0")]
    internal class Mod_PandaBabyMobMod : BaseUnityPlugin
    {
        private void OnStartCore()
        {
            string pathToExcelFile = Path.GetDirectoryName(((BaseUnityPlugin)this).Info.Location) + "/BabyMob.xlsx";
            SourceManager sources = Core.Instance.sources;
            ModUtil.ImportExcel(pathToExcelFile, "Chara", sources.charas);
        }
    }
}
