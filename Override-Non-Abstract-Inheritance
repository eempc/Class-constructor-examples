//https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/knowing-when-to-use-override-and-new-keywords

using System;

namespace ConsoleApp1 {

    public class TextInput {
        public string someString;

        public virtual void Add(char c) {
            someString += c;
        }

        public string GetValue() {
            return someString;
        }
    }

    public class NumericInput : TextInput {
        public override void Add(char c) {
            if (Char.IsDigit(c)) someString += c;
        }
    }

    class Program {
        static void Main(string[] args) {
            TextInput input = new NumericInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');
            Console.WriteLine(input.GetValue());
            Console.ReadKey();
        }
    }
}
