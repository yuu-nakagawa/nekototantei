using System;
using UnityEngine;

[Serializable]
public class Item1
{
    public enum Type
    {
        Cube,
        Ball,
    }

    public Type type;       //種類
    public Sprite sprite;  //Slotに表示する画像
}
