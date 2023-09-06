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
    public GameObject PlayerSprite;
    public GameObject PlayerName;
    public GameObject NameDeliver;
    public GameObject ImageDeliver;
    public GameObject AnimationDeliver;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            Debug.Log("Awake");
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        if (Instance != null && NameDeliver != null)
        {
            Debug.Log("Start");
            NameDeliver = GameObject.Find("NameDeliver");
            NameText.text = NameDeliver.GetComponent<Text>().text;
            ImageDeliver = GameObject.Find("ImageDeliver");
           
            PlayerSprite.GetComponent<SpriteRenderer>().sprite = ImageDeliver.GetComponent<SpriteRenderer>().sprite;
            AnimationDeliver = GameObject.Find("AnimationDeliver");
            PlayerSprite.GetComponent<Animator>().runtimeAnimatorController = AnimationDeliver.GetComponent<Animator>().runtimeAnimatorController;
            Destroy(NameDeliver);
        }
        else
        {
            Awake();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
