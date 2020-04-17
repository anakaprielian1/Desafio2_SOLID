using System;

namespace Full_GRASP_And_SOLID.Library
{

    //con esta clase se cumple con el principio de responsabilidad unica
    public class ConsolePrinter
    {
        public static void PrintTicket(Recipe recipe)
        {
            Console.WriteLine(recipe.GetRecipePrint());
        }
    }
}
