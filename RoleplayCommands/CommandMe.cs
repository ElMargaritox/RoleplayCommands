﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using SDG.Unturned;
using UnityEngine;

namespace RoleplayCommands
{
    class CommandMe : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "me";

        public string Help => string.Empty;

        public string Syntax => string.Empty;

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string>();

        public void Execute(IRocketPlayer caller, string[] command)
        {
            UnturnedPlayer player = (UnturnedPlayer)caller;


            if(command.Length < 1)
            {
                UnturnedChat.Say(player, "Use /me <texto>"); return;
            }

            string mensaje = string.Join(" ", command);

            ChatManager.serverSendMessage(Class1.Instance.Translate("message_me", player.CharacterName, mensaje.Replace(",", "")).Replace('(', '<').Replace(')', '>'), Color.white, null, null, EChatMode.GLOBAL, "https://i.imgur.com/SSWIvgh.png", true);

        }
    }
}
