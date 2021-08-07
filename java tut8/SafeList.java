public class SafeList extends SimpleList{
    public SafeList(int initialSize) {
        super(initialSize);
    }

    public void add(Object o) {
        if (get(0) == null || get(0).getClass() == o.getClass()) {
            super.add(o);
        }
    }
}
