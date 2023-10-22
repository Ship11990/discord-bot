using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantum_Bot.Commands
{
     public class TestCommands : BaseCommandModule
    {
        [Command("test")]
        public async Task MyFirstCommand(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync($"Hello{ctx.User.Username}");
        }

        [Command("add")]
        public async Task add(CommandContext ctx, int number1, int number2)
        {
            int result = number1 + number2;
            await ctx.Channel.SendMessageAsync(result.ToString());
        }
    }
}
