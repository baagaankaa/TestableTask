using UnityEngine;
using UnityEngine.UI;

public class DataDisplay : MonoBehaviour
{
    [Header("Data Assignment")]
    [SerializeField] private Image _color;
    [SerializeField] private Toggle _state;
    [SerializeField] private Text _header;
    [SerializeField] private Text _tag;
    [SerializeField] private Text _distance;

    [SerializeField] private ToggleState _toggleState;

    public void DataDisplayy(DataStruct data, int id)
    {
        if (ColorUtility.TryParseHtmlString(data.Color, out Color newColor))
            _color.color = newColor;

        _state.isOn = data.State;
        _header.text = data.Header;
        _tag.text = data.Tag;
        _distance.text = data.Distance;

        _toggleState.Id = id;
    }
}
