[System.Serializable]
public class DataList
{
    public DataStruct[] DataStruct;
}

[System.Serializable]
public struct DataStruct
{
    public string Color;
    public bool State;

    public string Header;
    public string Tag;
    public string Distance;
}
