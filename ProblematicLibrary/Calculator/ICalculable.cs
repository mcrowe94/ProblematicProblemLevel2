namespace ProblematicLibrary.Calculator
{
    public interface ICalculable
    {
        double Add(int x, int y);
        double Subtract(int x, int y);
        double Multiply(int x, int y);
        double Divide(int x, int y);
    }
}