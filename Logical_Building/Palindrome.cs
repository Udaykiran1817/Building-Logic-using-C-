//Palindrome is when a string is similar when it is reversed and checked. Eg: "madam" is a Palindrome word, because when the word is reversed it is still madam. In the above program built , we have used a simple if condition to check if the string is a palindrome or not. although the input word has empty spaces, special characters, or any thing other than letters por numbers, it eliminates all and checkes whether the input string is palindrome or not.

using System; //for console.writeline() function

public class Palindrome   //for class definition
{
    public static void Main(string[] args) //for main function
    {
        Console.WriteLine("Enter any String: "); //for user input
        string letter = Console.ReadLine(); //for reading the input from user
        int left = 0; //for left pointer in the input string
        int right = letter.Length - 1; //for right pointer in the input string specifies the last index of the string by length -1 
        
        while(left < right) //for loop to check palindrome left pointer less than right
        {
            while(left < right && !char.IsLetterOrDigit(letter[left])) left++; //for skipping the non-alphanumeric characters from the left side.
            while(left < right && !char.IsLetterOrDigit(letter[right])) right --; //for skipping the non-alphanumeric characters from the right side.
            
            if(char.ToLower(letter[left]) != char.ToLower(letter[right])) //for checking the palindrome condition with To.Lower method to make all letters into lower case
            {
                Console.WriteLine("String isnt a Palindrome!"); //for printing the output
                left++; //for incrementing the left pointer
                right--; //for decrementing the right pointer
                break; //for breaking the loop
            }
            
            else { //for else condition
                Console.WriteLine("String is Palindrome!"); //for printing the output if it satisfies palindrome
                break; //for breaking the loop
            }
        }
        
    }
}