using application.Common;

namespace application_xunit;

public class UnitTest
{
    public readonly ShapeApp _shapeApp;
    public string Output { get; set; } = string.Empty;
    public UnitTest()
    {
        _shapeApp = new ShapeBuilder
            .Options()
            .WithOutputHandler(OutputText)
            .Build();
    }

    public void OutputText(string input)
    {
        Output = input;
    }
}