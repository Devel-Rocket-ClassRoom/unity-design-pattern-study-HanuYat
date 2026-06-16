using System.Collections.Generic;

public class PushFrontCommand : ICommand
{
    private List<int> intList = new List<int>();
    private int numberToAdd;

    public PushFrontCommand(List<int> list, int numberToAdd)
    {
        intList = list;
        this.numberToAdd = numberToAdd;
    }

    public void Execute()
    {
        intList.Insert(0, numberToAdd);
    }

    public void Undo()
    {
        if (intList.Count > 0)
        {
            intList.RemoveAt(0);
        }
    }
}