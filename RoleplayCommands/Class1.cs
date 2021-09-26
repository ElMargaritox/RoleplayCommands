using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.API.Collections;
using Rocket.Core.Plugins;
using Logger = Rocket.Core.Logging.Logger;

namespace RoleplayCommands
{
    public class Class1 : RocketPlugin
    {
        public static Class1 Instance;
        protected override void Load()
        {
            base.Load();
            Instance = this;
            Logger.Log("Plugin By: Margarita --EnvyHosting--");


        }

        protected override void Unload()
        {
            base.Unload();

        }

        public override TranslationList DefaultTranslations
        {
            get
            {
                return new TranslationList
                {

                    {"message_me", "<color=#26ff00><i>*{0} {1} *</color)(/i>"},
                    {"message_do", "<i><color=#26ff00> * {0} </color>* <color=#FFFFFF>({1}) </i></color>"},
                    {"message_anon", "<color=#101010><b>[Anonymous]:</color> <color=#ff0000> {0} </b></color>"},
                    {"message_twt", "<color=#00acee><b>[TWEET]</color> <color=#26ff00>@ {0} :</b></color> <color=#FFFFFF> {1} </color>" },
                    {"message_ooc", "<color=#ff0000><b>[OOC]</color> <color=#FFFFFF> {0} :</b> {1} </color>"},
                    {"message_policia", "EDITALO VOS EL 0 ES EL JUGADOR Y EL 1 EL TEXTO"}
                };
            }

        }
    }
}
