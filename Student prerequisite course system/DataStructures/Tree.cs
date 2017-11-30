using System;

public class Tree<T>
{
    //private
    ArrayList<ArrayList<int>> AdjacencyList;
    void CheckNodes(int node)
    {
        if(node < 0 || node >= AdjacencyList.Size)
        {
            throw new IndexOutOfRangeException();
        }
    }
    //public
    public Tree()
    {
        AdjacencyList = new ArrayList<ArrayList<int>>();
    }
    public Tree(int IntialSize)
    {
        AdjacencyList = new ArrayList<ArrayList<int>>(IntialSize);
    }
    public void Connect(int FirstNode, int SecondNode)
    {

    }
}
