package Test1;

class Square {
    private int _size;

    public Square(int size) {
        _size = size;
    }

    public int GetArea()
    {
        return _size * _size;
    }
}
