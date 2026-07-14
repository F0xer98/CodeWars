/* 
 * Problem: [count lowercase letters in a string]
 * Link: [https://www.codewars.com/kata/56a946cd7bd95ccab2000055]
 * Rank: [8kyu]
 */

public class CountLowercase{
    public static void CountLowerCase(){
        // Your task is simply to count the total number of lowercase letters in a string.
        
        // So, to solve this problem
        // 1. Have an user input
        // 2. For each char in the string user wrote, test if its lowercase
        // 3. For each lowercase char, add +1 in a counter
        // 4. Return the amount of lowercase char
        
        string usrInput = "";
        int count = 0;

        usrInput = Console.ReadLine();

        foreach (char ch in usrInput){
            if (Char.IsLower(ch)){
                count++;
            }
        }
        Console.WriteLine("The amount of lower case characters is: " + count);
    }
}