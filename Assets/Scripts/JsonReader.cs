using System;
using System.IO;
using UnityEngine;


public class JsonReader : MonoBehaviour
{
    private DataFiller _dataFiller;
    [SerializeField] private string _fileName;
    private string _path;

    private void Awake()
    {
        _dataFiller = GetComponent<DataFiller>();

        _path = Path.Combine(Application.streamingAssetsPath, _fileName);            
        LoadFromFile();
    }

    private void LoadFromFile()
    {
        if (!File.Exists(_path))
        {
            Debug.Log("File Not Found!");
            return;
        }

        try
        {
            string json = File.ReadAllText(_path);

            DataList dataList = JsonUtility.FromJson<DataList>(json);
            _dataFiller.DataArray = dataList.DataStruct;
        }
        catch (Exception e)
        {
            Debug.Log(e.Message);
        }

        _dataFiller.FillContainer();
    }

    public void SaveToFile(DataStruct[] array)
    {
        try
        {
            string json = "{\n \t \"DataStruct\":[\n";
            for (int i = 0; i < array.Length; i++)
            {
                json += JsonUtility.ToJson(array[i], true);
                if (i < array.Length - 1)
                    json += ",\n";
            }

            json += "\n]\n}";
            File.WriteAllText(_path, json);
        }
        catch (Exception e)
        {
            Debug.Log(e.Message);
        }
    }

    public void UpdateData()
    {
        SaveToFile(_dataFiller.DataArray);
        LoadFromFile();
    }
}
