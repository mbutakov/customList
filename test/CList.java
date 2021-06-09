package test;

import lombok.Data;
import lombok.Getter;
import lombok.Setter;
import lombok.var;

@Getter
@Setter
public class CList<T> {

	private int size;
	private ListElement<T> head;
	private ListElement<T> last;
	private ListElement<T> prev;

	public void add(T element) {
		sizeIncrease();
		ListElement<T> l = new ListElement<T>();
		l.setValue(element);
		if (last != null) {
			getLast().setNext(l);
			getLast().setPrev(prev);
			prev = getLast();
			return;
		}
		last = l;
		head = last;
		prev = last;
	}

	public void sizeIncrease() {
		size++;
	}

	public void sizeDecrease() {
		size--;
	}

	public void remove(int index) {
//		ListElement<T> element = getElement(index);
//		if (element == null) {
//			throw new IndexOutOfBoundsException();
//		}
//		if (element.getPrev() != null)
//		{
//			element.getPrev().setNext(element.getNext());
//		}
//		else
//		{
//			head = element.getNext();
//		}
//
//		if (element.getNext() != null)
//		{
//			element.getNext().setPrev(element.getPrev());
//		} else
//		{
//			last = element.getPrev();
//		}
//
//		element.setNext(null);
//		element.setPrev(null);
//		
//		sizeDecrease();
	
	}

	public void print() {
		ListElement<T> current = head;
		while (current.getNext() != null) {
			System.out.println(current.getValue());
			current = current.getNext();
		}
		if (current.getNext() == null) {
			System.out.println(current.getValue());
		}
	}

	public void printBack() {
		ListElement<T> last = getLast();
		while (last.getPrev() != null) {
			System.out.println(last.getValue());
			last = last.getPrev();
		}
		if (last.getPrev() == null) {
			System.out.println(last.getValue());
		}
	}

	public ListElement<T> popFront() {
		sizeDecrease();
		try {
			return getLast();
		} finally {
			getLast().getPrev().setNext(null);
			;
		}
	}

	public ListElement<T> popBack() {
		sizeDecrease();
		try {
			return head;
		} finally {
			head.getNext().setPrev(null);
			head = head.getNext();
		}
	}

	public ListElement<T> getElement(int index) {
		if (index >= size) {
			throw new IndexOutOfBoundsException();
		}
		ListElement<T> current = head;
		for (int i = 0; i < getSize(); i++) {
			if (i == index) {
				return current;
			}
			current = current.getNext();
		}

		return current;

	}

	public ListElement<T> getLast() {
		ListElement<T> current = last;
		while (current.getNext() != null) {
			current = current.getNext();
		}
		return current;

	}

}
