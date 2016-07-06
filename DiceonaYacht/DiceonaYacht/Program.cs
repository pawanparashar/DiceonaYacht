using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceonaYacht
{
    class Program
    {
        static void Main(string[] args)
        {

            // Try Catch block to return Exception code in case of Exception
            try
            {
                int[] a = { 1, 1, 1, 1, 1 };
                int[] invalid = { 1, 1, 1, 1, 10 };
                DiceonaYacht DY = new DiceonaYacht();

                //Check if the given dices combintion is valid or not
                if (DY.CheckforvalidDictionarycount(a))
                {
                    // Get Suggestion based on dices combination
                    var result = DY.getSuggestion(a);
                }
                else
                {
                    Console.WriteLine("invalid dices combination");
                }

                //-------------------------------------------------------------------------------------------------
                // 


                // int[] b = { 4, 4, 4, 4, 5 };
                //int[] b = { 1, 1, 1, 2, 8 };

                //int[] b = { 1, 1, 1, 1, 8 };

                //int[] b = { 1, 1, 1, 8, 8 };

                //int[] b = { 1, 2, 3, 4, 7 };
                //int[] b = { 3, 4, 5, 6, 7 };

                //int[] b = { 1, 2, 1, 8, 8 };

                int[] b = { 1, 1, 1, 1, 1 };

                //Check if the given dices combintion is valid or not
                if (DY.CheckforvalidDictionarycount(b))
                {


                    //// Fours -Eights: Sum of all dice that match the title of the category.
                    //// For example {4,4,4,4,5} scores 16 for fours.
                    //var result = DY.getScore("Fours",b);

                    ////ThreeOfAKind: Sum of all dice as long as there are at least three dice that are the same, otherwise zero.
                    ////For example { 1,1,1,2,8} scores 13.
                    //var result = DY.getScore("ThreeOfAKind",b);

                    ////FourOfAKind: Sum of all dice as long as there are at least four dice that are the same, otherwise zero.
                    ////For example {1,1,1,1,8} scores 12.
                    //var result = DY.getScore("FourOfAKind", b);

                    ////FullHouse: If there are three of one kind and two of another score 25, otherwise score zero.
                    ////For example {1,1,1,8,8} scores 25.
                    //var result = DY.getScore("FullHouse", b);

                    ////SmallStraight: If there are four dice in sequence score 30, otherwise zero.
                    ////For example {1,2,3,4,7} scores 30.
                    //var result = DY.getScore("SmallStraight", b);

                    ////LargeStraight: If all five dice fall in sequence score 40, otherwise zero.
                    ////For example {3,4,5,6,7} scores 40.
                    //var result = DY.getScore("LargeStraight", b);

                    ////AllDifferent: If all five dice have unique values score 40, otherwise zero.
                    ////For example {1,2,4,6,8} scores 40.
                    //var result = DY.getScore("AllDifferent", b);

                    ////Chance: Sum of all dice.
                    ////For example {1,2,1,8,8} scores 20.
                    //var result = DY.getScore("Chance", b);

                    ////AllSame: If all five dice have the same value score 50,otherwise zero.
                    ////For example {1,1,1,1,1} scores 50.
                    //var result = DY.getScore("AllSame", b);




                }
                else
                {
                    Console.WriteLine("invalid dices combination");
                }





            }
            catch (Exception ex)
            {
                //Print the Exception 
                Console.WriteLine(ex.ToString());
            }
            
                
            
        }
    }
}
