using System.Collections.Generic;

public class PushBackCommand : ICommand
{
    private List<int> intList = new List<int>();
    private int numberToAdd;

    public PushBackCommand(List<int> list, int numberToAdd)
    {
        intList = list;
        this.numberToAdd = numberToAdd;
    }

    public void Execute()
    {
        intList.Add(numberToAdd);
    }

    public void Undo()
    {
        if (intList.Count > 0)
        {
            intList.RemoveAt(intList.Count - 1);
        }
    }
}