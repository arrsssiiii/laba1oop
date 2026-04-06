using System;
using System.Collections.Generic;

public class NodeUnit
{
    public int Data { get; set; }
    public List<NodeUnit> InnerNodes { get; set; }

    public NodeUnit(int value)
    {
        Data = value;
        InnerNodes = new List<NodeUnit>();
    }

    public void Attach(NodeUnit element)
    {
        InnerNodes.Add(element);
    }

    public void ShowNested()
    {
        foreach (NodeUnit item in InnerNodes)
        {
            Console.WriteLine(item.Data);
            item.ShowNested();
        }
    }
}