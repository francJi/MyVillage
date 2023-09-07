using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class ChangeInfo : MonoBehaviour
{
    //GameManager gameManager;
    public GameObject Deliver;
    public GameObject NameDeliver;
    public GameObject ImageDeliver;
    public GameObject AnimationDeliver;

    public InputField Name;
    public static string NameText;
    public GameObject SelectPanel;
    public GameObject SpriteSelectButton;
    public GameObject SelectedButton;
    public SpriteRenderer SelectedSprite;


    public static int Type = 1;
    public void JoinButtonClick()
    {
        if (Name != null && Name.text.Length > 2 && Name.text.Length < 10)
        {

            NameText = Name.text.ToString();
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            Debug.Log("Need Notifiacation");
        }
    }

    public void CharacterSelectClick()
    {
        SelectPanel.SetActive(true);
    }

    public void GetButttonObject()
    {
        // 클릭한 버튼의 오브젝트를 SpriteSelectButton으로 초기화.
        SelectedButton = EventSystem.current.currentSelectedGameObject;
    }
    public void SpriteSelectButtonClick()
    {
        if (SelectedButton != null)
        {
            SpriteRenderer[] AllSprite = SelectedButton.GetComponentsInChildren<SpriteRenderer>();
            foreach (SpriteRenderer sprite in AllSprite)
            {
                if (sprite.name.Contains("Sprite"))
                {
                    SelectedSprite = sprite;
                }
            }
            SpriteSelectButton.GetComponent<Image>().sprite = SelectedSprite.sprite;

            Button[] childArray = SelectPanel.GetComponentsInChildren<Button>();
            if (SelectedButton != null)
            {
                for (int i = 0; i < childArray.Length; i++)
                {
                    if (childArray[i].name == SelectedButton.GetComponent<Button>().name)
                    {
                        Type = i;
                    }
                }
            }
            //ImageDeliver.GetComponent<SpriteRenderer>().sprite = SelectedSprite.sprite;

            //Animator selectedAnimator = SelectedButton.GetComponent<Animator>();
            //RuntimeAnimatorController animController = selectedAnimator.runtimeAnimatorController;
            //AnimationDeliver.GetComponent<Animator>().runtimeAnimatorController = animController;
            SelectPanel.SetActive(false);
            Debug.Log(Type);
        } 
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        GetButttonObject();
    }
}
