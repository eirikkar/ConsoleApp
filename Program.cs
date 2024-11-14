using Spectre.Console;
using Spectre.Console.Cli;

namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        // Install with 'dotnet add package Spectre.Console' and
        // 'dotnet add package Spectre.Console.Cli'
        AnsiConsole.Markup("[underline red]Hello[/] World!");
        // Ask for the user's favorite fruit
        var fruit = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("What's your [green]favorite fruit[/]?")
                .PageSize(11)
                .MoreChoicesText("[grey](Move up and down to reveal more fruits)[/]")
                .AddChoices(
                    [
                        "Apple",
                        "Strawberry",
                        "Blackberry",
                        "Avocado",
                        "Banana",
                        "Blackcurrant",
                        "Blueberry",
                        "Cherry",
                        "Cloudberry",
                        "Cocunut",
                    ]
                )
        );

        // Echo the fruit back to the terminal
        AnsiConsole.WriteLine($"I agree. {fruit} is tasty!");

        // Ask the user to confirm
        var confirmation = AnsiConsole.Prompt(
            new TextPrompt<bool>("Run prompt example?")
                .AddChoice(true)
                .AddChoice(false)
                .DefaultValue(true)
                .WithConverter(choice => choice ? "y" : "n")
        );

        // Echo the confirmation back to the terminal
        Console.WriteLine(confirmation ? "Confirmed" : "Declined");
    }
}
