using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "New Operator", menuName = "Create Manager/New Operator")]
public class Operator : ScriptableObject
{
    [Header("캐릭터")]
    public string _nameEngilsh;
    public string _name;
    public int _star;
    public Sprite _icon;
    [Tooltip("뱅가드, 가드, 디펜더, 스나이퍼, 캐스터, 메딕, 서포터, 스페셜리스트")]
    public int _position;
    /* 캐릭터 포지션 8개
     * 0부터 뱅가드, 가드, 디펜더, 스나이퍼, 캐스터, 메딕, 서포터, 스페셜리스트
     */

    [Space(10f)]

    [Header("스테이터스")]
    public int _hp;
    public int _attack;
    public int _defense;
    public int _magicResistance;
    [Tooltip("빠름 : 18초\n" +
        "중간 : 25초(상인 스페셜리스트), 35초(에이전트 뱅가드)\n" +
        "느림 : 70초\n" +
        "매우 느림 : 200초\n")]
    public int _placementTime;
    public int _arrangementCost;
    public int _block;
    [Tooltip("매우 빠름 : 0.78초\n" +
        "빠름 : 0.93, 1초\n" +
        "중간 : 1.05, 1.2초 \n" +
        "다소 느림 : 1,25, 1.3, 1.5, 1.6초 | 뱅가드, 가드, 디펜더, 스페셜리스트, 스나이퍼, 캐스터, 서포터\n" +
        "느림 : 1.9, 2.3, 2.4 2.7, 2.8, 2.85, 2.9, 3.5초 | 스페셜리스트, 스나이퍼, 캐스터, 메딕, 서포터")]
    public float _attackSpeed;
    public float _faith;
    public float[] _evasion = new float[2];
    /* 스테이터스
     * 최대 HP
     * 공격력
     * 방어력
     * 마법 저항
     * 재비치 시간
     * 배치 코스트
     * 저지 가능 수
     * 공격 속도
     * 신뢰도
     * 회피율 | 0 물리 회피율, 1 마법 회피율
     */

    [Space(10f)]

    [Header("정보")]
    public int _level;
    /* 레벨
     * 2★ : 30
     * 3★ 0정 40, 1정 55
     * 4★ 0정 45, 1정 60, 2정 70 
     * 5★ 0정 50, 1정 70, 2정 80
     * 6★ 0정 50, 1정 80, 2정 90
     */
    public int _elite;
    /* 정예화
     * 레벨 0, 1, 2
     * 정예화 레벨마다 스킬 열림   ex) 정예화 레벨 2 => 스킬 3개
     * 2성 Max : 0
     * 3성  Max : 1
     * 4,5성 Max : 2
     */
    [Header("잠재능력")]
    public int _potential;
    /* 잠재능력
     * 레벨 1, 2, 3, 4, 5
     * 잠재능력 레벨마다 올라가는 스펙 다름
     */
    public string[] _potentialDes = new string[5];

    [Space(10f)]

    [Header("스킬")]
    public int[] _skillStartCost;
    public int[] _skillCost = new int[3];
    public int[] _skillTime = new int[3];
    public string[] _skillName = new string[3];
    [Tooltip("자연 회복 | 공격 회복")]
    public bool[] _skillType = new bool[2];
    [Tooltip("자동 발동 | 수동 발동")]
    public bool[] _skillActive = new bool[2];
    [TextArea(3, 5)]
    public string[] _skillDes = new string[3];
    public int _skillRank = 1;
    public int[] _skillAdd = new int[3];
    /* 스킬 랭크
     * 2★ 없음
     * 3★ 스킬 1개
     * 4★, 5★ 스킬 2개
     * 6★ 스킬 3개
     * 레벨 1, 2, 3, 4, 5, 6, 7
     * 레벨 8, 9, 10은 각자 올려야함
     * _skillRank + _skillAdd[]
     */

    [Space(10f)]

    [Header("세부분류+")]
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
    /* 세부분류+
     * 세부분류 이름
     * 모듈 개수, 모듈 이름, 모듈 설명
     * 특성 설명
     * 재능 이름, 설명
     */
}