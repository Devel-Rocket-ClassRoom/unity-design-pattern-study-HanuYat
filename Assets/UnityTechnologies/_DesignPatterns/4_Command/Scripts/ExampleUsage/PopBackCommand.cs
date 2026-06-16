using System.Collections.Generic;

public class PopBackCommand : ICommand
{
    private List<int> intList;
    private int removedValue;
    private bool didRemove;

    public PopBackCommand(List<int> list)
    {
        intList = list;
    }

    public void Execute()
    {
        if (intList.Count > 0)
        {
            removedValue = intList[intList.Count - 1];
            intList.RemoveAt(intList.Count - 1);
            didRemove = true;
        }
    }

    public void Undo()
    {
        if (didRemove) intList.Add(removedValue);
    }
}