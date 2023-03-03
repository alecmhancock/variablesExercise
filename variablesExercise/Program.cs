namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string petName = "Archer";

            int age = 3;
            // only Strings use "" don't forget to drop for other variables
            char lastIntial = 'H';

            bool isSleepy = true;

            double currentWeight = 55.4;

            decimal currentHeight = 38.24m;

            // implement breaklines for easier viewing
            Console.WriteLine($"My dog, {petName} {lastIntial} is going to the vet for a checkup.\n" +
                $"He's currently {age} years old, weighs {currentWeight} lbs, and is {currentHeight} inches tall.\n" +
                $"It is {isSleepy} that he is always sleepy, so he may need more exercise. ");

            // rewrite of previous userinput dialog
            //string answer;
            //bool yes = true;
            //bool no = false;
            //Console.WriteLine($"is this enough information?");
            //Console.ReadLine("");


            //if (answer = no) ;
            //Console.WriteLine($"Thanks for reading about {petName}!");

            //if (answer = yes) ;
            //Console.WriteLine("Please state your question.");
            //Console.ReadLine(answer);





        }
    }
}

