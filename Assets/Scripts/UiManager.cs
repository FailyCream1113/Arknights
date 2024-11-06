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

    //��â �̵�
    public void OnOrganizationClick()
    {
        SceneManager.LoadScene("OrganizationScene");
    }

    //����â �̵�
    public void OnSelectClick()
    {
        SceneManager.LoadScene("SelectScene");
    }

    //�ڷΰ���
    public void OnBackClick()
    {
        //��â�̸� ����ȭ������
        if (scene.name == "OrganizationScene")
            SceneManager.LoadScene("MainScene");
        //����â�̸� ��â����
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
            //���� �� �پ��� �� ������ �������� ����

        }
        else
        {

        }
    }

}
