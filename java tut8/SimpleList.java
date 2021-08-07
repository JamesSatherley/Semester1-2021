/* Generics and Inheritance.
 
   The problem with this class is that any type of Object can be added into the list.
   Complete the code for the SimpleList methods, then, using principles of generics and inheritance, 
   create a class SafeList that extends this SimpleList class to provide type safety, 
   by making sure only one type of Object can ever be used with the list. 
   Create a second class SafeListDemo, with a main method that constructs a new SafeList 
   and exercises each of the methods in your SafeList class.

For this question, upload your three files:

SimpleList.java
SafeList.java
SafeListDemo.java
*/

public class SimpleList {

	    private Object[] array;
	    private int size = 0;
	    
	    public SimpleList(int initialSize) {
	    	array = new Object[initialSize];
	    }

	    public int getSize() {
	    	return size;
	    }
	    
	    public Object get(int index) { 
	    	return array[index];
	    }
	    
	    public boolean remove(int index) {
			if (array == null || index < 0 || index >= array.length) {
				return false;
			}

			Object[] anotherArray = new Object[array.length - 1];

			for (int i = 0, k = 0; i < array.length; i++) {
				if (i != index) {
					anotherArray[k++] = array[i];
				}
			}
			array = anotherArray;
			return true;
		}
	    
	    public void add(Object o) {
			Object[] anotherArray = new Object[array.length + 1];
			int index = -1;
			for (int i = 0, k = 0; i < array.length; i++) {
				if (array[i] == null && index == -1)
				{
					index = i;
					k++;
				}
				anotherArray[k++] = array[i];
			}
			anotherArray[index] = o;
			array = anotherArray;
	    }
	    
	    public Object get() {
	    	return array.getClass();
	    }
}
