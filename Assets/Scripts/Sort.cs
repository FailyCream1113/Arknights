using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Sort : MonoBehaviour
{
    public static Sort instance;
    public bool isDesc = true;          //��������

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
            //���������� �������� ��-1 ���ֱ�
        }
        else
        {
            OperatorManager.instance.allOper.Sort(delegate (Operator a, Operator b) { return a._level.CompareTo(b._level); });
        }
    }

}
