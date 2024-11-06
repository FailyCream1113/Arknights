using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Sort : MonoBehaviour
{
    public static Sort instance;
    public bool isDesc = true;          //내림차순

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

    }

    public void LevelSort()
    {
        if (isDesc)
        {
            OperatorManager.instance.allOper.Sort(delegate (Operator a, Operator b) { return a._level.CompareTo(b._level) * -1; });
            //내림차순은 마지막에 ×-1 해주기
        }
        else
        {
            OperatorManager.instance.allOper.Sort(delegate (Operator a, Operator b) { return a._level.CompareTo(b._level); });
        }
    }

}
