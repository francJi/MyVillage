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
    public Text NameText;
    public GameObject SelectPanel;
    public GameObject SpriteSelectButton;
    public GameObject SelectedButton;
    public Image SelectedImage;
    public void JoinButtonClick()
    {
        if (Name != null && Name.text.Length > 2 && Name.text.Length < 10)
        {

            NameDeliver.GetComponent<Text>().text = Name.text;
            DontDestroyOnLoad(Deliver);
            //DontDestroyOnLoad(ImageDeliver);
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
            Image[] AllImage = SelectedButton.GetComponentsInChildren<Image>();
            foreach (Image image in AllImage)
            {
                if (image.name.Contains("Sprite"))
                {
                    SelectedImage = image;
                }
            }
            SpriteSelectButton.GetComponent<Image>().sprite = SelectedImage.sprite;
            ImageDeliver.GetComponent<Image>().sprite = SelectedImage.sprite;

            Animator selectedAnimator = SelectedButton.GetComponent<Animator>();
            RuntimeAnimatorController animController = selectedAnimator.runtimeAnimatorController;
            AnimationDeliver.GetComponent<Animator>().runtimeAnimatorController = animController;
            SelectPanel.SetActive(false);
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
