using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ScrollBarState : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Transform _container;
    [SerializeField] private GameObject _scrollBar;
    [SerializeField] private ScrollRect _scrollRect;

    private void Start()
    {
        ScrollState(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        ScrollState(true);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        ScrollState(false);
    }

    private void ScrollState(bool isHover)
    {
        if (isHover)
        {
            if (_container.childCount < 8)
                _scrollRect.vertical = false;
            else
                _scrollRect.vertical = true;
        }
        else _scrollRect.vertical = false;
    }
}
