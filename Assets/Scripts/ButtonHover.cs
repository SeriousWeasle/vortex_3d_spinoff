using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonHover : MonoBehaviour, IPointerEnterHandler
{
    public ButtonTest bt;
    public int diffIdx = 0;
    public void OnPointerEnter(PointerEventData eventData)
    {
        bt.UpdateMenu(diffIdx); //if cursor hovers over this button, set button manager's diff idx
    }
}
