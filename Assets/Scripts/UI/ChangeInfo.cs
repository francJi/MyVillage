using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeInfo : MonoBehaviour
{
    //GameManager gameManager;
    public GameObject NameDeliver;
    public InputField Name;
    public Text NameText;
    public void JoinButtonClick()
    {
        if (Name != null && Name.text.Length > 2 && Name.text.Length < 10)
        {

            NameDeliver.GetComponent<Text>().text = Name.text;
            DontDestroyOnLoad(NameDeliver);
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            Debug.Log("Need Notifiacation");
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
}
