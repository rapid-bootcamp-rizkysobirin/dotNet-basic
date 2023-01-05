using Sample101Linq.DataSource;

public class ProgramMain
{
    public static void Main()
    {
        //buat instansiasi karena gk pake static
        AggregateOperator aggregateOperator= new AggregateOperator();
        aggregateOperator.CountSyntax();

        Console.WriteLine("Nested Count");
        aggregateOperator.CountNested();

        Console.WriteLine("Group Count");
        aggregateOperator.GroupedCount();

        Console.WriteLine("Sum Syntax");
        aggregateOperator.SumSyntax();

        Console.WriteLine("Sum of Projection");
        aggregateOperator.SumProjection();

        Console.WriteLine("Grouped Sum");
        aggregateOperator.SumGrouped();

        Console.WriteLine("Min SYntex");
        aggregateOperator.MinSyntax();

        Console.WriteLine("Min Projection");
        aggregateOperator.MinProjection();

        Console.WriteLine("Min Grouped");
        aggregateOperator.MinGrouped();

        Console.WriteLine("Grouped Sum");
        aggregateOperator.SumGrouped();

        Console.WriteLine("Min Sytax");
        aggregateOperator.MinSyntax();

        Console.WriteLine("Min Projection");
        aggregateOperator.MinProjection();

        Console.WriteLine("Min Grouped");
        aggregateOperator.MinGrouped();

        Console.WriteLine("Min Each Group");
        aggregateOperator.MinEacGroup();

        Console.WriteLine("Max Syntax");
        aggregateOperator.MaxSyntax();

        Console.WriteLine("Max Projection");
        aggregateOperator.MaxProjection();

        Console.WriteLine("Max Grouped");
        aggregateOperator.MaxGrouped();

        Console.WriteLine("Max Each Grouped");
        aggregateOperator.MaxEachGrouped();

        Console.WriteLine("Average Syntax");
        aggregateOperator.AverageSyntax();

        Console.WriteLine("Average Projection");
        aggregateOperator.AverageProjection();

        Console.WriteLine("Average Grouped");
        aggregateOperator.AverageGrouped();

        Console.WriteLine("Aggregate Syntax");
        aggregateOperator.AggregateSyntax();

        Console.WriteLine("Aggregare Seeded");
        aggregateOperator.SeededAggregate();
    }

    #region 101 Linq 
    
    #endregion
}