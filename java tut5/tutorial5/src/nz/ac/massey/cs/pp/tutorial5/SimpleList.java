package nz.ac.massey.cs.pp.tutorial5;

/**
 * This is the class template you must implement. This means to replace all TODOs 
 * by meaningful code until all tests in SimpleListTests succeed. 
 * 
 * This is an example of test driven development (test first, then write your code to pass the test ). 
 * The specifications are defined by the test cases.
 * 
 * RULES:
 * 1. You are NOT allowed to change the definition of the single instance variable
 * 2. You are NOT allowed to add instance variables
 */


public class SimpleList<E> {
	private Object[] array;
	private int size = 0; // Tracks how many elements are stored
	
	public SimpleList() { 
		this(10);
	} // calls overloaded constructor
	
	public SimpleList(int num) { 
		array = new Object[num];
	} // generates array of length 10
	
	public void add(E element) {
		Object[] arrayReplacement = new Object[this.size()+1];
		
		for (int i = 0; i < this.size; i++) 
		{
			arrayReplacement[i] = this.array[i];
		}
		arrayReplacement[this.size] = element;
		array = arrayReplacement;
	} // adds element to array; creates a new array of size + 1, for each item in orginal array adds to new array, then adds extra element to the end of new array
	
	public void remove(int index) {
		Object[] arrayReplacement = new Object[this.size()];
		int j = 0;
		
		for (int i = 0; i < this.size; i++) 
		{
			if (i != index) 
			{
				arrayReplacement[j] = this.array[i];
				j++;
			}
		}
		this.array = arrayReplacement;
	} // removes element at index from array. generates knew array with size this.size, for each item in array it will add item to new array, unless the item is at index of input
	
	@SuppressWarnings("unchecked")
	public E get(int index) {
		if (index >= 0 && index <= this.size()) {
			return (E) array[index];
		} 
		return null;
	} // gets element of index casting to E if the index is 0 or above and below or equal to size
	
	public int size() {
		int counter = 0;
		for (int i = 0; i < this.array.length; i++) 
		{
			if (this.array[i] != null) 
			{
				counter += 1;
			} 
			this.size = counter;
		}
		return counter;
	} // gets size via counting items in list that are not equal to null. returns counter
}
