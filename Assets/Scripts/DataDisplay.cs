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

    public void DataAssignment(DataStruct data, int id)
    {
        if (ColorUtility.TryParseHtmlString(data.color, out Color newColor))
            _color.color = newColor;

        _state.isOn = data.state;
        _header.text = data.header;
        _tag.text = data.tag;
        _distance.text = data.distance;

        _toggleState.id = id;
    }
}
