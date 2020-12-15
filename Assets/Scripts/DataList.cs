[System.Serializable]
public class DataList
{
    public DataStruct[] dataStruct;
}

[System.Serializable]
public struct DataStruct
{
    public string color;
    public bool state;

    public string header;
    public string tag;
    public string distance;
}
