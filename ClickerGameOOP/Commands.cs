using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGameOOP
{
    class Commands
    {

        private ICommand[] CommandsArr;

        public Commands(ClickerGame game)
        {
            CommandsArr = new ICommand[]
            {
                new ExitCommand(),
                new ClickCommand(game),
                new UpgradeCommand(game),
                new SuperUpgradeCommand(game),
            };
        }

        public void Run(char commandChar)
        {
            var command = FindCommand(commandChar);
            if (command != null) command.Run();
        }

        private ICommand FindCommand(char commandChar)
        {
            foreach (var command in CommandsArr)
            {
                if (command.Character == commandChar) return command;
            }

            return null;
        }
    }
}
