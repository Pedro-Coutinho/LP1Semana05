using System;
using System.Text;

namespace UpperUnion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Check if there's no arguments
            if (args == null){
                Console.WriteLine("NO ARGUMENTS");
                return;
            }
            
            //Sort the array
            Array.Sort(args);

            //Instantiate String Builder
            StringBuilder output = new StringBuilder();

            //Cycle through arguments
            for(int i = 0; i < args.Length ; i++){
                //Check if it isn't the first argument
                if(i != 0)
                    //Append the hyphen
                    output.Append("-");
                
                //Turn the string to upper case
                args[i] = args[i].ToUpper();
                //Append the string
                output.Append(args[i]);
            }

            //Print the output
            Console.WriteLine(output.ToString());
        }
    }
}
