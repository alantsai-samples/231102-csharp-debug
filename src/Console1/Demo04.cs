public class Demo04
{
    public void Run()
    {
        Process1();

        // try
        // {
        //     Process1();
        // }
        // catch
        // {
        //     Console.WriteLine("An exception has occurred");
        // }

        Console.WriteLine("Exit program");
    }

    static void Process1()
    {
        //WriteMessage();

        // try
        // {
        //     WriteMessage();
        // }
        // catch
        // {
        //     Console.WriteLine("Exception caught in Process1");
        // }

        try
        {
            WriteMessage();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception caught in Process1");
            throw new ApplicationException("出错啦", ex);
        }
    }

    static void WriteMessage()
    {
        double float1 = 3000.0;
        double float2 = 0.0;
        int number1 = 3000;
        int number2 = 0;

        Console.WriteLine(float1 / float2);
        Console.WriteLine(number1 / number2);
    }
}