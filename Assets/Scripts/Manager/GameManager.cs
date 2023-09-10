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
            Debug.Log($"Animations/{(AnimationSet)Type}");
            Animator tempAnimator = Resources.Load<Animator>($"Animations/{(AnimationSet)Type}.anim");
            if (tempAnimator == null)
            {
                Debug.Log("tempAnimator is null");
            }
            // ¾ÈºÒ·¯¿ÍÁü..
            //PlayerImage.GetComponent<Animator>().runtimeAnimatorController = Resources.Load<Animator>($"Animations/{(AnimationSet)Type}.anim").runtimeAnimatorController;
            
            //PlayerImage.GetComponent<Image>().sprite = Resources.Load<Sprite>($"Resources/Character/PlayerSprite/{(SpriteSet)Type}.png");

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
