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

    public GameObject SideBar;

    public void CharacterSelectClick()
    {
        SelectPanel.SetActive(true);
    }

    public void SideBarClose()
    {
        SideBar.SetActive(false);
    }

    public void SideBarOpen()
    {
        SideBar.SetActive(true);
    }

}
