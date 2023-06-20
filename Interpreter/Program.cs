using System;
using System.Collections.Generic;

// Abstract Expression
abstract class Expression
{
    public abstract int Interpret();
}

// Terminal Expression
class NumberExpression : Expression
{
    private int number;

    public NumberExpression(int number)
    {
        this.number = number;
    }

    public override int Interpret()
    {
        return number;
    }
}

// Nonterminal Expression
class AdditionExpression : Expression
{
    private Expression leftExpression;
    private Expression rightExpression;

    public AdditionExpression(Expression leftExpression, Expression rightExpression)
    {
        this.leftExpression = leftExpression;
        this.rightExpression = rightExpression;
    }

    public override int Interpret()
    {
        return leftExpression.Interpret() + rightExpression.Interpret();
    }
}

// Client
class Program
{
    static void Main(string[] args)
    {
        // Xây dựng cây biểu diễn: 1 + 2 + 3
        Expression expression = new AdditionExpression(
            new AdditionExpression(new NumberExpression(1), new NumberExpression(2)),
            new NumberExpression(3)
        );

        // Đánh giá biểu diễn
        int result = expression.Interpret();
        Console.WriteLine("Result: " + result);
    }
}
