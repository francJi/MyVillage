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
    public GameObject PlayerName;

    public GameObject SelectPanel;
    public GameObject NamePanel;
    public GameObject SpriteSelectButton;
    public GameObject SelectedButton;
    public SpriteRenderer SelectedSprite;

    private void Awake()
    {
        if (UIinstance == null)
        {
            UIinstance = this;
            PlayerName = GameManager.Instance.PlayerName;
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
    }

    public void ChangeNameButtonClick()
    {
        if (Name != null && Name.text.Length > 2 && Name.text.Length < 10)
        {
            //PlayerName.GetComponent<Text>().text = Name.text;
            NamePanel.SetActive(true);
        }
    }

    public void JoinButtonClick()
    {
        if (Name != null && Name.text.Length > 2 && Name.text.Length < 10)
        {
            NamePanel.SetActive(false);
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
        // 클릭한 버튼의 오브젝트를 SpriteSelectButton으로 초기화.
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
        }
    }

}
