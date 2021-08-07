package nz.ac.massey.cs.pp.tutorial5.tests;

import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.*;

import nz.ac.massey.cs.pp.tutorial5.ExtendedArrayList;


class ExtendedArrayListTest {

	ExtendedArrayList<String> list;
	
	@BeforeEach
	void setup() {
		list = new ExtendedArrayList<>();
	} // Before each test runs creates new list
	
	@Test
	void testBack() {
		list.add("String");
		assertEquals(list.back(), "String");
		assertEquals(list.size(), 1);
	} // tests if expected outcome is what it should be and after if expected outcome maintains arraylist integrity
	
	@Test
	void testBackEmpty() {
		assertNull(list.back());
	} // tests if when function is called with empty list, expected outcome is null
	
	@Test
	void testPopBack() {
		list.add("String");
		assertEquals(list.popBack(), "String");
		assertEquals(list.popBack(), null);
	} // tests if expected outcome is what it should be and after if expected outcome maintains arraylist integrity
	
	@Test
	void testPopBackEmpty() {
		assertNull(list.popBack());
	} // tests if when function is called with empty list, expected outcome is null
	
	@Test
	void TestRemove() {
		list.add("String");
		assertTrue(list.remove() == true);
		assertTrue(list.remove() == false);
	} // tests if expected outcome is what it should be and after if expected outcome maintains arraylist integrity
	
	@Test
	void TestRemoveEmpty() {
		assertTrue(list.remove() == false);
	} // tests if when function is called with empty list, expected outcome is true
	
	@Test
	void testGenericsWork() {
		ExtendedArrayList<Integer> list2 = new ExtendedArrayList<>();
		list2.add(10);
		assertTrue(list2.get(0) == 10);
		assertTrue(list2.get(0) instanceof Integer);
	} // tests generics via creating a new int arraylist
	
	@AfterEach
	void tearDown() {
		list = null;
	} // teardown after each test
}
