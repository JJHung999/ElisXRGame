using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

//Source: https://discussions.unity.com/t/how-to-change-text-color-on-hover-in-new-gui/135257/7

[RequireComponent(typeof(Button))]
public class ChildrenButtonChange : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{

  //All of the buttons that use this class
  private static Button current;

  private TextMeshProUGUI[] txt;
  private Image[] images;
  private Button btn;

  protected Color normalColor;
  protected Color disabledColor;
  protected Color pressedColor;
  protected Color highlightedColor;

  void Start()
  {
    txt = GetComponentsInChildren<TextMeshProUGUI>();
    images = GetComponentsInChildren<Image>();
    btn = gameObject.GetComponent<Button>();
    normalColor = btn.colors.normalColor;
    disabledColor = btn.colors.disabledColor;
    pressedColor = btn.colors.pressedColor;
    highlightedColor = btn.colors.highlightedColor;
  }

  private ButtonStatus lastButtonStatus = ButtonStatus.Normal;
  private bool isHighlightDesired = false;
  private bool isPressedDesired = false;

  void LateUpdate()
  {
    ButtonStatus desiredButtonStatus = ButtonStatus.Normal;
    if (ChildrenButtonChange.current == null || ChildrenButtonChange.current != btn)
    {
      isHighlightDesired = false;
      isPressedDesired = false;
    }

    if (!btn.interactable)
      desiredButtonStatus = ButtonStatus.Disabled;
    else
    {
      if (isHighlightDesired)
        desiredButtonStatus = ButtonStatus.Highlighted;
      if (isPressedDesired)
        desiredButtonStatus = ButtonStatus.Pressed;
    }

    if (desiredButtonStatus != this.lastButtonStatus)
    {
      this.lastButtonStatus = desiredButtonStatus;
      switch (this.lastButtonStatus)
      {
        case ButtonStatus.Normal:
          ApplyColor(normalColor);
          break;
        case ButtonStatus.Disabled:
          ApplyColor(disabledColor);
          break;
        case ButtonStatus.Pressed:
          ApplyColor(pressedColor);
          break;
        case ButtonStatus.Highlighted:
          ApplyColor(highlightedColor);
          break;
      }
    }
  }

  public void OnPointerEnter(PointerEventData eventData)
  {
    isHighlightDesired = true;
    ChildrenButtonChange.current = btn;
  }

  public void OnPointerDown(PointerEventData eventData)
  {
    isPressedDesired = true;
    ChildrenButtonChange.current = btn;
  }

  public void OnPointerUp(PointerEventData eventData)
  {
    isPressedDesired = false;
    ChildrenButtonChange.current = null;
  }

  public void OnPointerExit(PointerEventData eventData)
  {
    isHighlightDesired = false;
    current = null;
  }

  public enum ButtonStatus
  {
    Normal,
    Disabled,
    Highlighted,
    Pressed
  }

  private void ApplyColor(Color color)
  {
    foreach (TextMeshProUGUI t in txt) t.color = color;
    foreach (Image i in images) i.color = color;
  }

}