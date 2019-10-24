using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Speech.Synthesis;
using System.IO;


namespace Brandon_Crandall
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //STACK
            // Creates and initializes a new Stack. Stacks are first in last out.
            Stack myStack = new Stack();
            myStack.Push("cow ");
            myStack.Push("brown ");
            myStack.Push("now ");
            myStack.Push("How ");

            // Displays the count and values of the Stack.
            Console.WriteLine("Creating my stack");
            Console.WriteLine("Count: {0}", myStack.Count);
            Console.Write("Values:");
            PrintValues(myStack);
            Console.ReadLine();

            // Removes an element from the Stack.
            Console.WriteLine("Poping the value off the top of the stack", myStack.Pop());
            Console.WriteLine("Count: {0}", myStack.Count);
            Console.Write("Values:");
            PrintValues(myStack);
            Console.ReadLine();

            // Views the first element in the Stack but does not remove it.
            Console.WriteLine("(Peek at the top value in stack) {0}", myStack.Peek());
            Console.ReadLine();

            // Checks to see if the stack contains the given value.
            Console.WriteLine("Check if the stack contains 'How': {0}", myStack.Contains("How"));
            Console.ReadLine();

            
            // Clears the Stack.
            myStack.Clear();
            Console.WriteLine("Clearing the stack");
            Console.WriteLine("Count: {0}", myStack.Count);
            Console.Write("Values:");
            PrintValues(myStack);
            Console.ReadLine();
            

            void PrintValues(IEnumerable myCollection)
            {
                foreach (Object obj in myCollection)
                    Console.Write("{0}", obj);
                Console.WriteLine();
            }
            */

            /*
            //Text to Speech

            // Initialize a new instance of the SpeechSynthesizer.  
            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Set a value for the speaking rate.  
            synth.Rate = 2;

            // Set the volume of the SpeechSynthesizer's ouput.  
            synth.Volume = 100;

            // Configure the audio output.   
            synth.SetOutputToDefaultAudioDevice();

            //Change the gender of the voice.
            synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);

            // Speak a string.  
            Console.WriteLine("Trust me the computer is saying something :)");
            synth.Speak("Trust me the computer is saying something :)");

            synth.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Senior);
            Console.WriteLine("No its not :(");
            synth.Speak("No its not :(");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            */


            /*
            //Creating a file, moving and deleting
            string path = @"c:\temp\MyTest.txt";

            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello World");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }
            }

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);

                }
            }

            //Shows file path
            var info = new FileInfo(path);
            Console.WriteLine(path);
            Console.ReadLine();


            //Move a file
            string destination = @"c:\temp1\MyTest.txt";
            File.Move(path, destination);


            // If file found, delete it  
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("file deleted.");
            }
            else Console.WriteLine("file not found");
            */



        }

    }
}

