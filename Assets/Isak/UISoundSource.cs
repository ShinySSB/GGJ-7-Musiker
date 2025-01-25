using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UISoundEffects : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler
{
    public MainMenuController MMC;
    void Start()
    {
        MMC = GameObject.Find("MainMenuController").GetComponent<MainMenuController>();
    }

    
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Hover");
        MMC.hoverSound();
    }

    
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Click");
        MMC.clickSound();
    }
}

