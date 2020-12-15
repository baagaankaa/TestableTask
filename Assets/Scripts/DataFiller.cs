using UnityEngine;

public class DataFiller : MonoBehaviour
{
    [SerializeField] private Transform _container;
    [SerializeField] private GameObject _boxData;

    public DataStruct[] DataArray;

    public void FillContainer()
    {
        for (int i = 0; i < _container.childCount; i++)
            Destroy(_container.GetChild(i).gameObject);        

        try
        {
            for (int i = 0; i < DataArray.Length; i++)
            {

                var data = Instantiate(_boxData.gameObject, _container);
                data.GetComponent<DataDisplay>().DataDisplayy(DataArray[i], i);
            }
        }
        catch (System.Exception)
        {
            Debug.Log("File is Empty");
        }
    }
}
