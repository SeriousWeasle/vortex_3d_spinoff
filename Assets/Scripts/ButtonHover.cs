using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public ButtonTest bt;
    public int diffIdx = 0;
    public void OnPointerEnter(PointerEventData eventData)
    {
        bt.UpdateMenu(diffIdx);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        bt.UpdateMenu(diffIdx);
    }
}
