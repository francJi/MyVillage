using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    //public Text NameText = ChangeInfo.NameText;
    public float PlayerSpeed;
    public GameObject Player;
    public GameObject PlayerImage;
    public GameObject PlayerName;
    public GameObject NameDeliver;
    public GameObject ImageDeliver;
    public GameObject AnimationDeliver;

    public int Type;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public enum AnimationSet
    {
        KnightWalk,
        PenguinWalk,
        LizardWalk,
    }

    public enum SpriteSet
    {
        knightSprite,
        lizardSprite,
        penguinSprite,
    }
    void Start()
    {
        if (Instance != null)
        {
            PlayerName.GetComponent<Text>().text = ChangeInfo.NameText;
            Type = ChangeInfo.Type;
            Debug.Log(Type);
            if (PlayerImage == null)
            {
                Debug.Log("PlayerImage null");
            }
            Animator tempAnimator = Resources.Load<Animator>($"Animations/{(AnimationSet)Type}.anim");
            if (tempAnimator == null)
            {
                Debug.Log("tempAnimator is null");
            }
            PlayerImage.GetComponent<Animator>().runtimeAnimatorController = Resources.Load<Animator>($"Animations/{(AnimationSet)Type}.anim").runtimeAnimatorController;
            Debug.Log($"Animations/{(AnimationSet)Type}");
            PlayerImage.GetComponent<Image>().sprite = Resources.Load<Sprite>($"Resources/Character/PlayerSprite/{(SpriteSet)Type}.png");
            //Debug.Log("Start");
            //NameDeliver = GameObject.Find("NameDeliver");
            //PlayerName.GetComponent<Text>().text = NameDeliver.GetComponent<Text>().text;

            //ImageDeliver = GameObject.Find("ImageDeliver");
            //PlayerSprite.GetComponent<SpriteRenderer>().sprite = ImageDeliver.GetComponent<SpriteRenderer>().sprite;

            //AnimationDeliver = GameObject.Find("AnimationDeliver");
            //PlayerSprite.GetComponent<Animator>().runtimeAnimatorController = AnimationDeliver.GetComponent<Animator>().runtimeAnimatorController;
            //Destroy(NameDeliver);
        }
        else
        {
            Awake();
        }
    }

    void Update()
    {

    }
}
