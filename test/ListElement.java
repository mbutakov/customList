package test;

import lombok.Builder;
import lombok.Getter;
import lombok.Setter;

@Getter
@Setter
public class ListElement<T> {

    private T value;
    private ListElement<T> next;
    private ListElement<T> prev;
}
