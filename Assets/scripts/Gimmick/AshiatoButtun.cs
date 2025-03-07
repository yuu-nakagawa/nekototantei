﻿using System;
using UnityEngine;

public class AshiatoButtun : MonoBehaviour
{
    //正解
    public int[] answer = { 1, 0, 2, 0, 3, 0 };
    //public Image[] answer = {};

    //入力配列
    public static int[] nyuuryoku = new int[0];
    
    public void Ithibyou()
    {
        GameObject.Find("kohimekaButtunPanel").SetActive(false);
        GameObject.Find("Panel4").transform.Find("kohimeka_akiPanel").gameObject.SetActive(true);
    }
    //入力
    public void OnClick(int position)
    {
        //配列を1増やす
        Array.Resize(ref nyuuryoku, nyuuryoku.Length + 1);
        nyuuryoku[nyuuryoku.Length - 1] = position;

        if (nyuuryoku.Length == 6)
        {
            //正解したらkohimekaButtunPanelを非表示
            //kohimeka_akiPanelを表示する
            if (Answer() == true)
            {
                //GameObject.Find("kohimekaButtunPanel").SetActive(false);
                //GameObject.Find("Panel4").transform.Find("kohimeka_akiPanel").gameObject.SetActive(true);
                Invoke("Ithibyou", 1.0f);
                //Invoke("Nibyou", 1.0f);
            }
            else
            {
                //配列を空にする
                Array.Resize(ref nyuuryoku, 0 );
            }
        }
    }
    //正解と入力が一致するか確認する
    bool Answer()
    {
        for (int i = 0; i < answer.Length; i++)
        {
            if (answer[i] != nyuuryoku[i])
            {
                return false;
            }
        }
        return true;
    }


}

