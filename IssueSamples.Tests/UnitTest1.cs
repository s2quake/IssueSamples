namespace IssueSamples.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var database = new Database();
        Assert.Empty(database.Values);

        var table1 = new Table();
        var table2 = new Table();
        database.Add("table1", table1);
        database.Add("table2", table2);

        Assert.Contains(table1, database.Values);
        Assert.Contains(table2, database.Values);

        database.Remove("table1");
        Assert.Single(database.Values);
        Assert.False(database.Values.Contains(table1));
        Assert.DoesNotContain(table1, database.Values);
        Assert.Contains(table2, database.Values);
    }
}
