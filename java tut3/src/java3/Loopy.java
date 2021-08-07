package java3;
import java.util.Scanner;

public class Loopy {

	public static void main (String[] args) {
		
        System.out.println("Enter in a sentence:");
		Scanner input = new Scanner(System.in);  // asks for user input and saves it
        String sentence = input.nextLine();

        for(int i=0; i<sentence.length(); i++)
        {
			char letter = sentence.charAt(i); // for loop loops through every item in list
			if(Character.isUpperCase(letter)) 
			{
		        System.out.println(letter);  // prints letter if the letter is upper case
			}
        }
        System.out.println("Enter in a sentence:");
        String new_sentence = input.nextLine();  // asks for new user input and saves it as a new sentence
        System.out.println(toggleStringCase(new_sentence)); // calls toggleStringCase
        input.close();
	}
	
	private static char toggleCase(char c) {
		if(c > 96 && c < 123) 
		{
			return c = (char) (c - 32); // tests if char is between certain numbers which are a-z
		}else if(c > 64 && c < 91) 
		{
			return c = (char) (c + 32); // if not, tests if char is between certain numbers which are A-Z
		}else if (c == 32)
		{
			return c;                   // otherwise checks if char is a spacebar as that should be left in
		}else
		{                               // if not it tells the use the erroring char and returns it back to the final string
	        System.out.printf("The character following this statement is not a-z or A-Z: " + c + "\n");
			return c;
		}
	}
	
	private static String toggleStringCase(String str) {
		String to_return = "";
		for(int i=0; i<str.length(); i++)
        {	
			char letter = str.charAt(i); // for each letter in the string given it will return if the highered or lowered
			char returned = toggleCase(letter); // version. Then will add to a string and return a full string.
			to_return = to_return + returned;
			
        }
		return to_return;
	}	
}

// I have done this in the requested order. I am aware I could have included the first for loop
// simply in the toggleStringCase() function with ease. I did it in the order it was ask hence
// the inefficiency. I was not sure if I was meant to do this or not :)