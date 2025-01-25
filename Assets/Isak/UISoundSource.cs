using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UISoundEffects : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler
{

    void Start()
    {

    }

    
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Hover");

    }

    
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Click");
    }
}

