using MathLibrary2;
using StringLib;

namespace MathLibrary {
    internal class Program {

     
        static void Main(string[] args) {

            

            var sl = new StringLibrary();
            var newstr = sl.Concat("Hello," , "World");
            Console.WriteLine(newstr);

            var answer = MathLib.Add(11, 22);
            Console.WriteLine(answer);
        }
    }
}
