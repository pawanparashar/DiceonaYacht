using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceonaYacht
{
    class DiceonaYacht
    {

        enum Category
        {
            Ones =1, Twos, Threes, Fours, Fives, Sixes, Sevens, Eights, ThreeOfAKind,

            FourOfAKind, FullHouse, SmallStraight, LargeStraight, AllDifferent, Chance, AllSame
        };


        public int getScore(string category,int[] dices)
        {
            Dictionary<int, int> Counter = new Dictionary<int, int>();

            foreach(int temp in dices)
            {
                if (Counter.ContainsKey(temp))
                {
                    Counter[temp]++;
                }
                else
                {
                    Counter.Add(temp, 1);
                }
            }

            switch (category)
            {
                case "ones":
                    return Ones(Counter);
                case "Twos":
                    return Twos(Counter);
                case "Threes":
                    return Threes(Counter);
                case "Fours":
                    return Fours(Counter);
                case "Fives":
                    return Fives(Counter);
                case "Sixes":
                    return Sixes(Counter);
                case "Sevens":
                    return Sevens(Counter);
                case "Eights":
                    return Eights(Counter);
                case "ThreeOfAKind":
                    return ThreeOfAKind(Counter);
                case "FourOfAKind":
                    return FourOfAKind(Counter);
                case "FullHouse":
                    return FullHouse(Counter);
                case "SmallStraight":
                    return SmallStraight(dices);
                case "LargeStraight":
                    return LargeStraight(dices);
                case "AllDifferent":
                    return AllDifferent(Counter);
                case "Chance":
                    return Chance(Counter);
                case "AllSame":
                    return AllSame(Counter);
                default:
                    return 0;
            }

            
            
            
            
            


        }

        public string getSuggestion(int[] dices)
        {
            // Try Catch block to return Exception code in case of Exception
            try
            {
               
                Dictionary<int, int> Counter = new Dictionary<int, int>();

                // Compute the values and numbers of times it is repeated in Dictionary
                foreach (int temp in dices)
                {
                    if (Counter.ContainsKey(temp))
                    {
                        Counter[temp]++;
                    }
                    else
                    {
                        Counter.Add(temp, 1);
                    }
                }

                int max = 0;
                string maxstring = "";
                int tempmax = 0;
                
                
                
                
                // get the value into max temp and compare with current max
                // in case current max is greater than max, set max as temp max
                // set max string to function called to set temp max
                tempmax = Ones(Counter);
                if (tempmax > max)
                {
                    max = tempmax;
                    maxstring = "Ones";
                    
                }
                // get the value into max temp and compare with current max
                // in case current max is greater than max, set max as temp max
                // set max string to function called to set temp max
                tempmax = Twos(Counter);
                if (tempmax > max)
                {
                    max = tempmax;
                    maxstring = "Twos";
                }
                // get the value into max temp and compare with current max
                // in case current max is greater than max, set max as temp max
                // set max string to function called to set temp max
                tempmax = Threes(Counter);
                if (tempmax > max)
                {
                    max = tempmax;
                    maxstring = "Threes";
                }
                // get the value into max temp and compare with current max
                // in case current max is greater than max, set max as temp max
                // set max string to function called to set temp max
                tempmax = Fours(Counter);
                if (tempmax > max)
                {
                    max = tempmax;
                    maxstring = "Fours";
                }
                // get the value into max temp and compare with current max
                // in case current max is greater than max, set max as temp max
                // set max string to function called to set temp max
                tempmax = Fives(Counter);
                if (tempmax > max)
                {
                    max = tempmax;
                    maxstring = "Fives";
                }
                // get the value into max temp and compare with current max
                // in case current max is greater than max, set max as temp max
                // set max string to function called to set temp max
                tempmax = Sixes(Counter);
                if (tempmax > max)
                {
                    max = tempmax;
                    maxstring = "Sixes";
                }
                // get the value into max temp and compare with current max
                // in case current max is greater than max, set max as temp max
                // set max string to function called to set temp max
                tempmax = Sevens(Counter);
                if (tempmax > max)
                {
                    max = tempmax;
                    maxstring = "Sevens";
                }
                // get the value into max temp and compare with current max
                // in case current max is greater than max, set max as temp max
                // set max string to function called to set temp max
                tempmax = Eights(Counter);
                if (tempmax > max)
                {
                    max = tempmax;
                    maxstring = "Eights";
                }
                // get the value into max temp and compare with current max
                // in case current max is greater than max, set max as temp max
                // set max string to function called to set temp max
                tempmax = ThreeOfAKind(Counter);
                if (tempmax > max)
                {
                    max = tempmax;
                    maxstring = "ThreeOfAKind";
                }
                // get the value into max temp and compare with current max
                // in case current max is greater than max, set max as temp max
                // set max string to function called to set temp max
                tempmax = FourOfAKind(Counter);
                if (tempmax > max)
                {
                    max = tempmax;
                    maxstring = "FourOfAKind";
                }
                // get the value into max temp and compare with current max
                // in case current max is greater than max, set max as temp max
                // set max string to function called to set temp max
                tempmax = FullHouse(Counter);
                if (tempmax > max)
                {
                    max = tempmax;
                    maxstring = "FullHouse";
                }
                // get the value into max temp and compare with current max
                // in case current max is greater than max, set max as temp max
                // set max string to function called to set temp max
                tempmax = SmallStraight(dices);
                if (tempmax > max)
                {
                    max = tempmax;
                    maxstring = "SmallStraight";
                }
                // get the value into max temp and compare with current max
                // in case current max is greater than max, set max as temp max
                // set max string to function called to set temp max
                tempmax = LargeStraight(dices);
                if (tempmax > max)
                {
                    max = tempmax;
                    maxstring = "LargeStraight";
                }
                // get the value into max temp and compare with current max
                // in case current max is greater than max, set max as temp max
                // set max string to function called to set temp max
                tempmax = AllDifferent(Counter);
                if (tempmax > max)
                {
                    max = tempmax;
                    maxstring = "AllDifferent";
                }
                // get the value into max temp and compare with current max
                // in case current max is greater than max, set max as temp max
                // set max string to function called to set temp max
                tempmax = Chance(Counter);
                if (tempmax > max)
                {
                    max = tempmax;
                    maxstring = "Chance";
                }
                // get the value into max temp and compare with current max
                // in case current max is greater than max, set max as temp max
                // set max string to function called to set temp max
                tempmax = AllSame(Counter);
                if (tempmax > max)
                {
                    max = tempmax;
                    maxstring = "AllSame";
                }

                return maxstring;

                

            }
            catch (Exception ex)
            {
                //return the error code 
                return ex.ToString();
            }
        }

        public bool CheckforvalidDictionarycount(int[] dices)
        {
            // Try Catch block to return Exception code in case of Exception
            try
            {
                bool flag;
                int count = 0;
                // Compute the values and numbers of times it is repeated in Dictionary
                foreach (int temp in dices)
                {
                    count++;
                    // check each elements in case it is more than 8 or less than 1
                    // if yes it is invalid dices combination hence return false
                   if(temp >8 || temp < 1)
                    {
                        return false;
                    }
                }
                // return true once all the dices combinations are checked for the condition
                return count == 5 ? true : false;



            }
            catch (Exception ex)
            {
                //return the error code 
                return false;
            }
        }


        public int Ones(Dictionary<int,int> Counter)
        {
            // Try Catch block to return Exception code in case of Exception
            try
            {
                // check if the Dictionary is empty and in case of empty return 0
                // Else return the Key number of times it is repeated mutipled by 1
                if (Counter.Count != 0)
                    return Counter[1] * 1;
                else
                    return 0;
            }
            catch(Exception ex)
            {
                //return the error code 
                return ex.HResult;
            }
        }

        public int Twos(Dictionary<int, int> Counter)
        {
            // Try Catch block to return Exception code in case of Exception
            try
            {
                // check if the Dictionary is empty and in case of empty return 0
                // Else return the Key number of times it is repeated mutipled by 2
                if (Counter.Count != 0)
                    return Counter[2] * 2;
                else
                    return 0;
            }
            catch (Exception ex)
            {
                //return the error code 
                return ex.HResult;
            }
        }

        public int Threes(Dictionary<int, int> Counter)
        {
            // Try Catch block to return Exception code in case of Exception
            try
            {
                // check if the Dictionary is empty and in case of empty return 0
                // Else return the Key number of times it is repeated mutipled by 3
                if (Counter.Count != 0)
                    return Counter[3] * 3;
                else
                    return 0;
            }
            catch (Exception ex)
            {
                //return the error code 
                return ex.HResult;
            }
        }

        public int Fours(Dictionary<int, int> Counter)
        {
            // Try Catch block to return Exception code in case of Exception
            try
            {
                // check if the Dictionary is empty and in case of empty return 0
                // Else return the Key number of times it is repeated mutipled by 4
                if (Counter.Count != 0)
                    return Counter[4] * 4;
                else
                    return 0;
            }
            catch (Exception ex)
            {
                //return the error code 
                return ex.HResult;
            }
        }

        public int Fives(Dictionary<int, int> Counter)
        {
            // Try Catch block to return Exception code in case of Exception
            try
            {
                // check if the Dictionary is empty and in case of empty return 0
                // Else return the Key number of times it is repeated mutipled by 5
                if (Counter.Count != 0)
                    return Counter[5] * 5;
                else
                    return 0;
            }
            catch (Exception ex)
            {
                //return the error code 
                return ex.HResult;
            }
        }

        public int Sixes(Dictionary<int, int> Counter)
        {
            // Try Catch block to return Exception code in case of Exception
            try
            {
                // check if the Dictionary is empty and in case of empty return 0
                // Else return the Key number of times it is repeated mutipled by 6
                if (Counter.Count != 0)
                    return Counter[6] * 6;
                else
                    return 0;
            }
            catch (Exception ex)
            {
                //return the error code 
                return ex.HResult;
            }
        }

        public int Sevens(Dictionary<int, int> Counter)
        {
            // Try Catch block to return Exception code in case of Exception
            try
            {
                // check if the Dictionary is empty and in case of empty return 0
                // Else return the Key number of times it is repeated mutipled by 7
                if (Counter.Count != 0)
                    return Counter[7] * 7;
                else
                    return 0;
            }
            catch (Exception ex)
            {
                //return the error code 
                return ex.HResult;
            }
        }

        public int Eights(Dictionary<int, int> Counter)
        {
            // Try Catch block to return Exception code in case of Exception
            try
            {
                // check if the Dictionary is empty and in case of empty return 0
                // Else return the Key number of times it is repeated mutipled by 8
                if (Counter.Count != 0)
                    return Counter[8] * 8;
                else
                    return 0;
            }
            catch (Exception ex)
            {
                //return the error code 
                return ex.HResult;
            }
        }

        public int ThreeOfAKind(Dictionary<int, int> Counter)
        {
            // Try Catch block to return Exception code in case of Exception
            try
            {
                int sum = 0;
                bool flag = false;

                foreach (KeyValuePair<int, int> temp in Counter)
                {
                    sum += (temp.Key * temp.Value);
                    //Check for repeated number of times are greater than or equal to 3
                    // in case of yes, set the flag to true
                    if (temp.Value >= 3)
                    {
                        flag = true;
                    }
                }
                // return sum of all the dices in cases of flag is set
                // else return 0 as per as requirment 
                return flag == true ? sum : 0;
            }
            catch (Exception ex)
            {
                //return the error code 
                return ex.HResult;
            }


          
        }

        public int FourOfAKind(Dictionary<int, int> Counter)
        {
            // Try Catch block to return Exception code in case of Exception
            try
            {
                int sum = 0;
                bool flag = false;

                foreach (KeyValuePair<int, int> temp in Counter)
                {
                    sum += (temp.Key * temp.Value);
                    //Check for repeated number of times are greater than or equal to 4
                    // in case of yes, set the flag to true
                    if (temp.Value >= 4)
                    {
                        flag = true;
                    }
                }
                // return sum of all the dices in cases of flag is set
                // else return 0 as per as requirment 
                return flag == true ? sum : 0;
            }
            catch (Exception ex)
            {
                //return the error code 
                return ex.HResult;
            }

           

        }

        public int FullHouse(Dictionary<int, int> Counter)
        {
            // Try Catch block to return Exception code in case of Exception
            try
            {
                int sum = 0;
                bool flag3 = false, flag2 = false;

                foreach (KeyValuePair<int, int> temp in Counter)
                {
                    sum += (temp.Key * temp.Value);
                    // Set flag3 in cases any value-number of repeated times is 3
                    if (temp.Value == 3)
                    {
                        flag3 = true;
                    }
                    // Set flag2 in cases any value-number of repeated times is 2
                    if (temp.Value == 2)
                    {
                        flag2 = true;
                    }


                }
                // check if both flags are true
                //in case of yes, return 25 as per as requirment
                // else return 0 as per as requirment
                return flag2 & flag3 == true ? 25 : 0;
            }
            catch (Exception ex)
            {
                //return the error code 
                return ex.HResult;
            }

           
           

        }

        public int SmallStraight(int[] dices)
        {

            // Try Catch block to return Exception code in case of Exception
            try
            {
                bool flag = false;
                int checker = 0;
                for (int i = 0; i < dices.Length - 1; i++)
                {
                    //in case difference between next value and current value is not 1
                    // values are not large straight, set the flag to true
                    if (dices[i + 1] - dices[i] != 1)
                    {
                        // one time difference is neglected 
                        checker++;
                        if (checker == 2)
                        {
                            flag = true;
                            break;
                        }
                    }
                }
                // in case flag is true, return 0 as per as requirment
                // else return 30 as given dice combination is small straight
                return flag == true ? 0 : 30;

            }
            catch (Exception ex)
            {
                //return the error code 
                return ex.HResult;
            }

        }

        public int LargeStraight(int[] dices)
        {
            // Try Catch block to return Exception code in case of Exception
            try
            {
                bool flag = false;
                for (int i = 0; i < dices.Length - 1; i++)
                {
                    //in case difference between next value and current value is not 1
                    // values are not large straight, set the flag to true
                    if (dices[i + 1] - dices[i] != 1)
                    {
                        flag = true;
                        break;
                    }
                }
                // in case flag is true, return 0 as per as requirment
                // else return 40 as given dice combination is large straight
                return flag == true ? 0 : 40;

            }
            catch (Exception ex)
            {
                //return the error code 
                return ex.HResult;
            }

           

        }

        public int AllDifferent(Dictionary<int, int> Counter)
        {

            // Try Catch block to return Exception code in case of Exception
            try
            {
                int sum = 0;
                bool flag = false;

                foreach (KeyValuePair<int, int> temp in Counter)
                {
                    sum += (temp.Key * temp.Value);
                    if (temp.Value > 1)
                    {
                        // if any values are more than once, it means the all the dices combinations are not different
                        flag = true;
                    }
                }
                //in case flag is true it means all the values are not different
                // so return 0
                // in case of flag is false , all the values are different , hence return 40 as per as requirment 
                return flag == true ? 0 : 40;


            }
            catch (Exception ex)
            {
                //return the error code 
                return ex.HResult;
            }

            

        }

        public int Chance(Dictionary<int, int> Counter)
        {
            // Try Catch block to return Exception code in case of Exception
            try
            {
                int sum = 0;
                foreach (KeyValuePair<int, int> temp in Counter)
                {
                    sum += (temp.Key * temp.Value);

                }
                // return sum of all the values as per as requirment 
                return sum;
            }
            catch (Exception ex)
            {
                //return the error code 
                return ex.HResult;
            }

            

        }

        public int AllSame(Dictionary<int, int> Counter)
        {
            // Try Catch block to return Exception code in case of Exception
            try
            {
                foreach (KeyValuePair<int, int> temp in Counter)
                {
                    if (temp.Value == 5)
                    {
                        // in case dictionary size is one, then it means only one values for all the five times
                        //so return 50 as per as requirment
                        return 50;
                    }

                }
                // in cases Dictionary is having more than one value that means it has two different vakues
                //so return 0 as per as requirment
                return 0;
            }
            catch (Exception ex)
            {
                //return the error code 
                return ex.HResult;
            }

           

        }

 






    }
}
