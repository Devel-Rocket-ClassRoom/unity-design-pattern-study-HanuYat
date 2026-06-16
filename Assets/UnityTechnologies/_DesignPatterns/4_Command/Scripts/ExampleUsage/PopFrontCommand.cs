using System.Collections.Generic;

public class PopFrontCommand : ICommand
{
    private List<int> intList;
    private int removedValue;
    private bool didRemove;

    public PopFrontCommand(List<int> list)
    {
        intList = list;
    }

    public void Execute()
    {
        if (intList.Count > 0)
        {
            removedValue = intList[0];
            intList.RemoveAt(0);
            didRemove = true;
        }
    }

    public void Undo()
    {
        if (didRemove) intList.Insert(0, removedValue);
    }
}