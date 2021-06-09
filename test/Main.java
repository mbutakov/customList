package test;

public class Main {
		
	
	public static void main(String[] args) {
		CList<Integer> list = new CList<Integer>();
		list.add(33);
		list.add(3333);
		list.add(444);
		list.print();
		System.out.println("=====");
		list.printBack();
		System.out.println("=====");
		System.out.println(list.getElement(1).getValue());
		System.out.println("=====");
		list.popFront();
		list.print();
		System.out.println("=====");
		list.popBack();
		list.print();
		System.out.println("=====");
		list.add(111);
		list.add(222);
		list.add(333);
		list.print();
		System.out.println("=====");
	}
}
