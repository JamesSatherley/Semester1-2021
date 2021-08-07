public class SafeListDemo {
    public static void main(String[] args) {
        SafeList safelist = new SafeList(5);
        safelist.add(5);
        safelist.add("Hello");
        System.out.println(safelist.get(0));
        System.out.println(safelist.get(1));
        System.out.println(safelist.get(0).getClass());
    }
}
