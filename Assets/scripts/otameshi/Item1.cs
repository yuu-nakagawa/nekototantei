using System;
using UnityEngine;

[Serializable]
public class Item1
{
    public enum Type
    {
        nekojarashiA,
        nekojarashiB,
        nekojarashiA1,
    }

    public Type type;       //種類
    public Sprite sprite;  //Slotに表示する画像

    public Item1(Type type, Sprite sprite)
    {
        this.type = type;
        this.sprite = sprite;
    }
}
