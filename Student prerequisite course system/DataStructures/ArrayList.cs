using System;

public class ArrayList<T>
{
    //private
    T[] arr;
    int size;
    int capacity;
    void Expand()
    {
        T[] tmp = new T[capacity * 2];
        Array.ConstrainedCopy(arr, 0, tmp, 0, capacity);
        arr = tmp;
        capacity *= 2;
    }
    void CheckIndex(int index)
    {
        if (index >= size || index < 0)
        {
            throw new IndexOutOfRangeException();
        }
    }
    void CheckSizeCapacity()
    {
        if (size == capacity)
        {
            Expand();
        }
    }
    //public
    ArrayList()
    {
        size = 0;
        capacity = 5;
        arr = new T[5];
    }
    ArrayList(int IntialCapacity)
    {
        size = 0;
        capacity = IntialCapacity;
        arr = new T[IntialCapacity];
    }
    public int Size
    {
        get => size;
        set => size = value;
    }
    public void Append(T value)
    {
        CheckSizeCapacity();
        arr[size] = value;
        size++;
    }
    public void PopBack()
    {
        if (size > 0) size--;
    }
    public void InsertAt(int index, T value)
    {
        CheckIndex(index);
        CheckSizeCapacity();
        for(int i = index; i < size; i++)
        {
            arr[i + 1] = arr[i];
        }
        arr[index] = value;
        size++;
    }
    public void DeleteAt(int index)
    {
        CheckIndex(index);
        for (int i = size - 1; i > index; i++)
        {
            arr[i - 1] = arr[i];
        }
        size--;
    }
    public T this[int index]
    {
        get
        {
            CheckIndex(index);
            return arr[index];
        }
        set
        {
            CheckIndex(index);
            arr[index] = value;
        }
    }
}
