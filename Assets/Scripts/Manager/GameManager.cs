using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Text NameText;
    public float PlayerSpeed;
    public GameObject Player;
    public GameObject PlayerName;
    public GameObject NameDeliver;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            NameDeliver = GameObject.Find("NameDeliver");
            NameText.text = NameDeliver.GetComponent<Text>().text;
            Destroy(NameDeliver);
        }
        else
        {
            Destroy(gameObject);
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
