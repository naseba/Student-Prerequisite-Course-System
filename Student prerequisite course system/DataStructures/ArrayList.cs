using System;

public class ArrayList<T>
{
    //private
    T[] arr;
    int size;
    int capacity;
    void Expand()
    {
        Resize(capacity * 2);
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
    public ArrayList()
    {
        size = 0;
        capacity = 5;
        arr = new T[5];
    }
    public ArrayList(int IntialCapacity)
    {
        size = 0;
        capacity = IntialCapacity;
        arr = new T[IntialCapacity];
    }
    public void Resize(int NewSize)
    {
        T[] tmp = new T[NewSize];
        Array.ConstrainedCopy(arr, 0, tmp, 0, Math.Min(size, NewSize));
        arr = tmp;
        capacity = NewSize;
    }
    public int Size
    {
        get => size;
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
