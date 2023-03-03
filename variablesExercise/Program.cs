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
        }
    }
}

// Trying to apply basic python knowledge here to create a user input dialog to end the program or ask a question
//will fix when more info regarding syntax and structure is known


    //namespace userInput
    //{
      //  public class Program
        //{
          //  static void Main(string[] args)
            //{
              /// <summary>
              ///  Console.WriteLine($"Do you have any questions?");
              /// </summary>
               // bool yes = true;
                //bool no = false;
                //string answer = Console.ReadLine("");
            //}
        //}
    //}
//}