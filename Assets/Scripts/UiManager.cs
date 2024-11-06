using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UiManager : MonoBehaviour
{

    public static UiManager instance;
    private Scene scene;
    public bool isQuickOrganizstion = true;

    [SerializeField]
    private Image quickOrchestration;
    [SerializeField]
    private Image deletingOrchestration;

    public bool isLevel = true;


    void Start()
    {
        if(instance == null)
        {
            instance = this;
            //DontDestroyOnLoad(this.gameObject);
        }
        else { Destroy(this.gameObject); }
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //편성창 이동
    public void OnOrganizationClick()
    {
        SceneManager.LoadScene("OrganizationScene");
    }

    //선택창 이동
    public void OnSelectClick()
    {
        SceneManager.LoadScene("SelectScene");
    }

    //뒤로가기
    public void OnBackClick()
    {
        //편성창이면 메인화면으로
        if (scene.name == "OrganizationScene")
            SceneManager.LoadScene("MainScene");
        //선택창이면 편성창으로
        if (scene.name == "SelectScene")
            SceneManager.LoadScene("OrganizationScene");
    }

    public void OnCogWheelClick()
    {
        
    }
    public void OnNotificationClick()
    {

    }
    public void OnMailClick()
    {

    }
    public void OnCalenderClick()
    {
        
    }

    public void OnQuickClick()
    {
        if(isQuickOrganizstion)
        {
            SceneManager.LoadScene("SelectScene");
        }
        else
        {
            isQuickOrganizstion = true;
        }
    }

    public void OnDeleteOrganizationClick()
    {
        if(isQuickOrganizstion)
        {
            isQuickOrganizstion = false;
            //quickOrchestration.Interactable = false;
            //빠른 편성 줄어들고 편성 삭제가 왼쪽으로 나옴

        }
        else
        {

        }
    }

}
