using System;
using UnityEngine;
using UnityEngine.UI;

public class ToggleState : MonoBehaviour
{
    public static event Action<bool, int> ToggleChanged;
    [SerializeField] private Toggle _toggle;
    [HideInInspector]public int id;

    public void ToggleChange()
    {
        ToggleChanged?.Invoke(_toggle.isOn, id);
    }
}
