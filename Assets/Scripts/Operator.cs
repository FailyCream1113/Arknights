using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "New Operator", menuName = "Create Manager/New Operator")]
public class Operator : ScriptableObject
{
    [Header("ĳ����")]
    public string _nameEngilsh;
    public string _name;
    public int _star;
    public Sprite _icon;
    [Tooltip("�𰡵�, ����, �����, ��������, ĳ����, �޵�, ������, ����ȸ���Ʈ")]
    public int _position;
    /* ĳ���� ������ 8��
     * 0���� �𰡵�, ����, �����, ��������, ĳ����, �޵�, ������, ����ȸ���Ʈ
     */

    [Space(10f)]

    [Header("�������ͽ�")]
    public int _hp;
    public int _attack;
    public int _defense;
    public int _magicResistance;
    [Tooltip("���� : 18��\n" +
        "�߰� : 25��(���� ����ȸ���Ʈ), 35��(������Ʈ �𰡵�)\n" +
        "���� : 70��\n" +
        "�ſ� ���� : 200��\n")]
    public int _placementTime;
    public int _arrangementCost;
    public int _block;
    [Tooltip("�ſ� ���� : 0.78��\n" +
        "���� : 0.93, 1��\n" +
        "�߰� : 1.05, 1.2�� \n" +
        "�ټ� ���� : 1,25, 1.3, 1.5, 1.6�� | �𰡵�, ����, �����, ����ȸ���Ʈ, ��������, ĳ����, ������\n" +
        "���� : 1.9, 2.3, 2.4 2.7, 2.8, 2.85, 2.9, 3.5�� | ����ȸ���Ʈ, ��������, ĳ����, �޵�, ������")]
    public float _attackSpeed;
    public float _faith;
    public float[] _evasion = new float[2];
    /* �������ͽ�
     * �ִ� HP
     * ���ݷ�
     * ����
     * ���� ����
     * ���ġ �ð�
     * ��ġ �ڽ�Ʈ
     * ���� ���� ��
     * ���� �ӵ�
     * �ŷڵ�
     * ȸ���� | 0 ���� ȸ����, 1 ���� ȸ����
     */

    [Space(10f)]

    [Header("����")]
    public int _level;
    /* ����
     * 2�� : 30
     * 3�� 0�� 40, 1�� 55
     * 4�� 0�� 45, 1�� 60, 2�� 70 
     * 5�� 0�� 50, 1�� 70, 2�� 80
     * 6�� 0�� 50, 1�� 80, 2�� 90
     */
    public int _elite;
    /* ����ȭ
     * ���� 0, 1, 2
     * ����ȭ �������� ��ų ����   ex) ����ȭ ���� 2 => ��ų 3��
     * 2�� Max : 0
     * 3��  Max : 1
     * 4,5�� Max : 2
     */
    [Header("����ɷ�")]
    public int _potential;
    /* ����ɷ�
     * ���� 1, 2, 3, 4, 5
     * ����ɷ� �������� �ö󰡴� ���� �ٸ�
     */
    public string[] _potentialDes = new string[5];

    [Space(10f)]

    [Header("��ų")]
    public int[] _skillStartCost;
    public int[] _skillCost = new int[3];
    public int[] _skillTime = new int[3];
    public string[] _skillName = new string[3];
    [Tooltip("�ڿ� ȸ�� | ���� ȸ��")]
    public bool[] _skillType = new bool[2];
    [Tooltip("�ڵ� �ߵ� | ���� �ߵ�")]
    public bool[] _skillActive = new bool[2];
    [TextArea(3, 5)]
    public string[] _skillDes = new string[3];
    public int _skillRank = 1;
    public int[] _skillAdd = new int[3];
    /* ��ų ��ũ
     * 2�� ����
     * 3�� ��ų 1��
     * 4��, 5�� ��ų 2��
     * 6�� ��ų 3��
     * ���� 1, 2, 3, 4, 5, 6, 7
     * ���� 8, 9, 10�� ���� �÷�����
     * _skillRank + _skillAdd[]
     */

    [Space(10f)]

    [Header("���κз�+")]
    public string _classificationName;
    public int _module;
    public string[] _moduleName;
    [TextArea(3, 5)]
    public string _moduleDes;
    [TextArea(3, 5)]
    public string _characteristicDes;
    public string _talent;
    [TextArea(3, 5)]
    public string _talentDes;
    /* ���κз�+
     * ���κз� �̸�
     * ��� ����, ��� �̸�, ��� ����
     * Ư�� ����
     * ��� �̸�, ����
     */
}