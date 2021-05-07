using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObj : MonoBehaviour
{
    [SerializeField] Item1.Type itemType;
    Item1 item;
    //[SerializeField] Item1 item;
    //クリックしたら消す

    private void Start()
    {
        //itemTypeに応じてitemを生成する
        item = ItemGenerater.instance.Spawn(itemType);
    }
    public void OnClickObj()
    {
        ItemBox1.instance.SetItem(item);
        gameObject.SetActive(false);
    }

    public void OnClickNekojarashiA()
    {
        //ItemBox1.instance.SetItem(item);
        
        gameObject.SetActive(false);
    }
}
