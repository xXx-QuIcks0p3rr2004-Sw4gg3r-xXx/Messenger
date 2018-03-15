using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetDLL
{
    public class Command
    {
        public string Identifier { get; private set; }

        public string[] Arguments { get; private set; }

        public Command(string identifier, params object[] args)
        {
            Identifier = identifier;
            Arguments = new string[args.Length];
            for (int i = 0; i < Arguments.Length; i++)
            {
                Arguments[i] = args[i].ToString();
            }
        }

        public override string ToString()
        {
            return Identifier + "[!]" + String.Join("[!]", Arguments);
        }

        public static Command SplitToCommand(string commandString)
        {
            string[] splitted = commandString.Split(new string[] { "[!]" }, StringSplitOptions.None);
            if (splitted.Length == 0) return null;
            string identifier = splitted[0];
            string[] args = new string[splitted.Length - 1];
            for(int i = 1; i < splitted.Length; i++)
            {
                args[i - 1] = splitted[i];
            }
            return new Command(identifier, args);
        }
    }
}
