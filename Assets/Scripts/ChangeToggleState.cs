using UnityEngine;

public class ChangeToggleState : MonoBehaviour
{
    [SerializeField] private JsonReader _jsonReader;
    [SerializeField] private DataFiller _dataFiller;

    private void OnEnable()
    {
        ToggleState.ToggleChanged += ToggleChange;
    }
    private void OnDisable()
    {
        ToggleState.ToggleChanged -= ToggleChange;
    }

    private void ToggleChange(bool isOn, int id)
    {
        _dataFiller.DataArray[id].State = isOn;
        _jsonReader.SaveToFile(_dataFiller.DataArray);
    }
}
