using UnityEngine;
using UnityEngine.EventSystems;

public class ArrowAnimation : MonoBehaviour, IPointerEnterHandler, IPointerDownHandler, IPointerExitHandler
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _animator.SetBool("IsHover", true);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        _animator.SetBool("IsClick", true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _animator.SetBool("IsHover", false);
    }
}
