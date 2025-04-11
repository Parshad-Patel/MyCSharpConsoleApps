# Console Apps Repository

This repository contains two console applications:

1. **Calculator Program**
2. **Simple Dice Game**

## 1. Calculator Program

A simple calculator that performs basic operations such as addition, subtraction, multiplication, and division. The calculator also allows you to view the history of your operations.

### Features:
- Perform basic arithmetic operations (`+`, `-`, `*`, `/`).
- View a history of performed operations.
- Enter two numbers and choose the operation to perform.
- Option to run multiple operations or exit the program.

### How to Use:
1. Enter two numbers when prompted.
2. Choose the arithmetic operation (`+`, `-`, `*`, `/`).
3. View the result of the operation.
4. Type `o` or `y` to perform another operation, or `h` to see the history of operations.
5. Type `n` to exit the program.

### Example:
Enter the first number: 5 Enter the second number: 3 Enter the operation: + The result is: 8 Do you want to run another operation? (y/n) or see the history (h)

## 2. Simple Dice Game

A two-player dice game where the user plays against the computer. The player chooses between "Even" or "Odd" and rolls a dice. If the dice number matches the choice, the player earns a point. The game continues until one player reaches the winning point limit.

### Features:
- Choose between "Even" or "Odd."
- Roll a dice and earn points based on the choice.
- The game ends when either the player or the computer reaches the winning point limit.
- Option to play multiple rounds.

### How to Use:
1. Enter the winning points limit (1-10).
2. Choose between "Even" or "Odd" (`e` for Even, `o` for Odd).
3. Roll the dice by pressing any key.
4. The first player (user or computer) to reach the winning points limit wins the game.
5. Choose whether to play again or exit.

### Example:
Enter the winning points limit (1-10): 5 Choose either Even or Odd (e/o): e Press any key to roll the dice... The dice rolled: 2 You: 1 | Computer: 0 ...

## Installation

To run these applications, simply clone this repository to your local machine and compile the C# code using Visual Studio or the .NET CLI.

```bash
git clone https://github.com/yourusername/ConsoleAppRepository.git
cd ConsoleAppRepository

Open the project in Visual Studio or use the following command to compile using the .NET CLI:
dotnet build

Then, you can run the individual applications by selecting them in your IDE or running them via the .NET CLI:
dotnet run --project ConsoleApp1
dotnet run --project ConsoleApp_Simple_Dice_Game
```
## License

This project is licensed under the MIT License - see the LICENSE file for details.


