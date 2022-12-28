using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class List
{
    public List<string> list;
}

[System.Serializable]
public class InsideList
{
    public List<List> list;
}