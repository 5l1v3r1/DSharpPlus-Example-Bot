﻿using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;

namespace DSharpPlus_Example_Bot.Commands
{
    /// <summary>
    /// Commands that can only be used by the bot owner.
    /// The bot owner is the user who has created bots token.
    /// </summary>
    [RequireOwner]
    public sealed class OwnerCommands : BaseCommandModule
    {
        /// <summary>
        /// Prints out the latency between the bot and discord api servers.
        /// </summary>
        /// <param name="commandContext">CommandContext from the message that has executed this command.</param>
        /// <returns></returns>
        [Command("ping"), Description("Shows bot ping to discord api server")]
        public async Task PingAsync(CommandContext commandContext)
        {
            await commandContext.RespondAsync($"Bot latency to the discord api server: {commandContext.Client.Ping}");
        }
    }
}
