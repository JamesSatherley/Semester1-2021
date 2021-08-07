package nz.ac.massey.cs.pp.tutorial4.id19040618;

import java.util.Collections;
import java.util.Comparator;
import java.util.List;

public class ByLastNameComparator {
	public static List<student> sorter(List<student> list)
	{	
		Collections.sort(list, new Comparator<student>() 
		{
			@Override
			public int compare(student o1, student o2) 
			{
				return o1.getLname().compareTo(o2.getLname()); //compares two items from student (lname)
			}
		});
		return list;
	}
}
