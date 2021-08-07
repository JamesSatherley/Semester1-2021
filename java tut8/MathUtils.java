/* MathUtils.java 
   Provides static mathematical utility functions.
*/

public class MathUtils
{
//Returns the factorial of the argument given 
	public static int factorial(int n) throws IllegalArgumentException
	{
		int fac = 1;

		if (n > 12)
		{
			throw new IllegalArgumentException("Number greater than 12");
		} else if (n < 1) {
			throw new IllegalArgumentException("Number less than 1");
		}
		for (int i=n; i>0; i--)
          fac *= i;
		return fac;
	} 
}