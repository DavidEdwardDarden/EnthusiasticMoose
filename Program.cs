using System;

Main();

void Main()
{

    object[] huh = {1,2};

string[] questions = { "Are meese real?", "Are you enthusiastic?", "Do you love C# yet?", "Do you want to know a secret?" };
    string[] trueAnswers = { "Really? It seems very unlikely.", "Yay!", "Good job sucking up to your instructor!", "ME TOO!!!! I love secrets...tell me one!" };
    string[] falseAnswers = { "I  K N E W  I T !!!", "You should try it!", "You will...oh, yes, you will...", "Oh, no...secrets are the best, I love to share them!" };

    //! I need to map the array of True and False answers, as well as the questions into the foreach statement 

    //? single function call, that will do all that, called in the loop

    //* call a function question, get the text data in to new function

    ////1. Do "A"
    //2. Do "B"
    //3. Do "C"
    //4. Do "D"

    for(int i = 0;i <questions.Length; i++){
 
     bool isTrue = MooseAsks(questions[i]);
    if (isTrue)
    {
        MooseSays(trueAnswers[i]);
    }
    else
    {
        MooseSays(falseAnswers[i]);
    }
    }



//             Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
//              Console.WriteLine("--------------------------------------------");
//      Console.WriteLine();

// void CanadaQuestion()
// {
//     bool isTrue = MooseAsks("Is Canada real?");
//     if (isTrue)
//     {
//         MooseSays("Really? It seems very unlikely.");
//     }
//     else
//     {
//         MooseSays("I  K N E W  I T !!!");
//     }
// }

// void EnthusiasticQuestion()
// {
//     bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
//     if (isEnthusiastic)
//     {
//         MooseSays("Yay!");
//     }
//     else
//     {
//         MooseSays("You should try it!");
//     }
// }

// void LoveCSharpQuestion()
// {
//     bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
//     if (doesLoveCSharp)
//     {
//         MooseSays("Good job sucking up to your instructor!");
//     }
//     else
//     {
//         MooseSays("You will...oh, yes, you will...");
//     }
// }

// void SecretQuestion()
// {
//     bool wantsSecret = MooseAsks("Do you want to know a secret?");
//     if (wantsSecret)
//     {
//         MooseSays("ME TOO!!!! I love secrets...tell me one!");
//     }
//     else
//     {
//         MooseSays("Oh, no...secrets are the best, I love to share them!");
//     }
// }

// // Let the moose speak!
// MooseSays("H I, I'M  E N T H U S I A S T I C !");
// MooseSays("I really am enthusiastic");

void MooseSays(string message)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}

bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}

// // bool isTrue = MooseAsks("Is Canada real?");
// // Console.WriteLine(isTrue);

// // Ask some questions
// CanadaQuestion();
// EnthusiasticQuestion();
// LoveCSharpQuestion();
// SecretQuestion();
}