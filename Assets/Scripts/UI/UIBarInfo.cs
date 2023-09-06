using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIBarInfo : MonoBehaviour
{
    public GameObject SelectPanel;
    public GameObject SpriteSelectButton;
    public GameObject SelectedButton;
    public SpriteRenderer SelectedSprite;

    public void CharacterSelectClick()
    {
        SelectPanel.SetActive(true);
    }


}
