namespace AmbuBolt.Models;

public class DirectionsData
{
    public string[] destination_addresses { get; set; }
    public string[] origin_addresses { get; set; }
    public DirectionsRow[] rows { get; set; }
    public string status { get; set; }
}

public class DirectionsRow
{
    public DirectionsElement[] elements { get; set; }
}

public class DirectionsElement
{
    public DirectionsDistance distance { get; set; }
    public DirectionsDuration duration { get; set; }
    public string status { get; set; }
}

public class DirectionsDistance
{
    public string text { get; set; }
    public int value { get; set; }
}

public class DirectionsDuration
{
    public string text { get; set; }
    public int value { get; set; }
}