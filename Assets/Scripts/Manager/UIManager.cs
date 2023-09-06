using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager UIinstance;
    public Button SelectButton;
    public Button ChangeNameButton;
    public Button PlayersButton;

    private void Awake()
    {
        if (UIinstance == null)
        {
            UIinstance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SelectButtonClick()
    {

    }

    public void ChangeNameButtonClick()
    { 
    
    }

    public void PlayersButtonClick() 
    {
    
    }

    void Start()
    {
        
    }


    void Update()
    {
        
    }
}
