using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class OperatorManager : MonoBehaviour
{
    public static OperatorManager instance;

    public List<Operator> allOper = new List<Operator>();
    [SerializeField]
    private GameObject[] haveOper;
    [SerializeField]
    private GameObject OperatorParent;
    [SerializeField]
    private GameObject charPrefab;

    [SerializeField]
    private GameObject selectOper;
    [SerializeField]
    private bool isSelect = false;

    //public ScrollRect scrollRect;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        InitOperator();
        InitOrganizationOperator();
        
    }


    void Update()
    {
        UpdateOperator();
    }


    public void InitOperator()
    {
        Operator[] tempoper = Resources.LoadAll<Operator>("HaveCharacter");
        for (int i = 0; i < tempoper.Length; i++)
        {
            allOper.Add(tempoper[i]);
        }
    }

    public  void InitOrganizationOperator()
    {
        for(int i = 0; i < allOper.Count; i++)
        {
            GameObject obj = Instantiate(charPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            obj.transform.parent = OperatorParent.transform;
            Button btn = obj.GetComponent<Button>();
            btn.onClick.AddListener(SelectOperator);
            btn.onClick.AddListener(OnClickOperator);
            Image image = obj.GetComponent<Image>();
            image.sprite = allOper[i]._icon;
            image.name = allOper[i]._name;
            obj.tag = "Operator";
        }

        // 미완 캐릭터 수에 따라 스크롤뷰 콘텐츠 바꾸기
        if(haveOper.Length > 16)
        {
            //-210
            int temp = haveOper.Length % 16;
            if ( temp % 2 != 0)
            {
                RectTransform rt = OperatorParent.GetComponent<RectTransform>();
                if( temp / 2 >= 1)
                {
                    rt.anchoredPosition = new Vector2(-210 * (temp / 2), 0);
                }
                else rt.anchoredPosition = new Vector2(-210, 0);
            }
        }
    }

    public void UpdateOperator()
    {
        GetHaveOper();

        if (UiManager.instance.isLevel)
        {
            Sort.instance.LevelSort();
            for (int i = 0; i < allOper.Count; i++)
            {
                Image image = haveOper[i].GetComponent<Image>();
                image.sprite = allOper[i]._icon;
                image.name = allOper[i]._name;
            }
            UiManager.instance.isLevel = false;
        }
    }

    public void GetHaveOper()
    {
        haveOper = GameObject.FindGameObjectsWithTag("Operator");
    }

    public void SelectOperator()
    {
        foreach (GameObject obj in haveOper)
        {
            for (int i = 0; i < haveOper.Length; i++)
            {
                if (obj.name == haveOper[i].name)
                {
                    selectOper = obj;
                }
            }
        }
    }

    public void OnClickOperator()
    {
        
        Outline outline = selectOper.GetComponent<Outline>();

        if (!isSelect)
        {
            outline.effectColor = Color.blue;
            outline.effectDistance = new Vector2(2, -2);
            isSelect = true;
        }
        else
        {
            if(selectOper == this)
            {
                outline.effectDistance = new Vector2(-2, 2);
                isSelect = false;
            }
            else
            {
                outline.effectDistance = new Vector2(-2, 2);
                isSelect = false;
                OnClickOperator();
            }
        }
    }
}
