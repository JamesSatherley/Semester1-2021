package tut7;

import java.util.*;
import java.util.stream.IntStream;
import java.util.stream.Stream;
import java.util.stream.Collectors;
import java.util.stream.DoubleStream;
import java.util.function.Function;
import java.util.function.Predicate;


public class javaStreamsTemplate {

//static int size = ????;
//static double[] myList = new Random().doubles(size).toArray();

static void timeSumSequential() {
	    System.out.println(" Summing sequentially:");
	    Op.timeOp(() -> {
	    // your code to compute sum of square roots
	    // System.out.printf("  Sum is %,.8f.%n", theSum);
	    });
}
	  
static void timeSumParallel() {
	    System.out.println(" Summing in parallel:");
	    Op.timeOp(() -> {
	    	// your code to compute sum of square roots in parallel
	    // System.out.printf("  Sum is %,.8f.%n", theParallelSum);
	    });
}
  
public static int factorialUsingStreams(int n) {
    return IntStream.rangeClosed(1, n).reduce(1, (int x, int y) -> x * y);
}
	
public static void main(String[] args) {

	//IntStream odds = IntStream.iterate(1, x -> x + 2);
	//DoubleStream powers = DoubleStream.iterate(2, x -> Math.pow(x, 2));
	//IntStream repeats = IntStream.iterate(0, x -> x + 1).map(x -> x * 10 + x * 100 + x);
	//IntStream facts = IntStream.iterate(0, x -> x + 1).map(x -> factorialUsingStreams(x));
	//DoubleStream primes = DoubleStream.iterate(1, i -> 1+Math.sqrt(i)).filter(i -> IntStream.rangeClosed(2, (int)Math.sqrt(i)).allMatch(j -> i%j != 0));
	
	//odds.limit(10).forEach(System.out::println); 
	//powers.limit(10).forEach(System.out::println);
	//repeats.limit(10).forEach(System.out::println);
	//facts.limit(10).forEach(System.out::println);
	//primes.limit(10).forEach(System.out::println);

	//timeSumSequential();
	//timeSumParallel();
	  }
}



