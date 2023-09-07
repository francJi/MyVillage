using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager UIinstance;
    public Button SelectButton;
    public Button ChangeNameButton;
    public Button PlayersButton;
    public Button JoinButton;

    public InputField Name;
    //public GameObject PlayerName;

    public GameObject SelectPanel;
    public GameObject NamePanel;
    public GameObject SpriteSelectButton;
    public GameObject SelectedButton;
    public SpriteRenderer SelectedSprite;

    public bool IsUI = false;
    private void Awake()
    {
        if (UIinstance == null)
        {
            UIinstance = this;
            //PlayerName = GameManager.Instance.PlayerName;
        }
        else
        {
            Destroy(gameObject);
        }

    }

    private void Start()
    {
        
    }

    public void SelectButtonClick()
    {
        SelectPanel.SetActive(true);
        IsUI = true;
    }

    public void ChangeNameButtonClick()
    {
        NamePanel.SetActive(true);
        IsUI = true;
    }

    public void JoinButtonClick()
    {
        if (Name != null && Name.text.Length > 2 && Name.text.Length < 10)
        {
            NamePanel.SetActive(false);
            IsUI = false;
        }
        else
        {
            Debug.Log("Need Notifiacation");
        }
    }

    public void PlayersButtonClick() 
    {
    
    }

    public void GetButttonObject()
    {
        // Ŭ���� ��ư�� ������Ʈ�� SpriteSelectButton���� �ʱ�ȭ.
        SelectedButton = EventSystem.current.currentSelectedGameObject;
    }

    private void LateUpdate()
    {
        GetButttonObject();
    }

    public void SpriteSelectButtonClick()
    {
        if (SelectedButton != null)
        {
            SelectPanel.SetActive(false);
            IsUI = false;
        }
    }

}
