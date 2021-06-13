package Test1;

import static org.junit.jupiter.api.Assertions.*;

class SquareTest {

    @org.junit.jupiter.api.Test
    void getArea() {
        var square = new Square(7);
        assertEquals(49, square.GetArea());
    }
}