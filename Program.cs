using System;
using System.Collections;
using System.ComponentModel.Design;

namespace PomodoroNoConsole
{
  class Program
  {

  static void Main(string[] args)
  {
    
        Menu();
 
  }
  static void Menu(){
    Console.WriteLine("=============================");
        Console.WriteLine(" _____   ____  __  __  ____   ");
        Console.WriteLine("|  __ \\ / __ \\|  \\/  ||  __ \\ ");
        Console.WriteLine("| |__) | |  | | \\  / || |  | |");
        Console.WriteLine("|  ___/| |  | | |\\/| || |  | |");
        Console.WriteLine("| |    | |__| | |  | || |__| |");
        Console.WriteLine("|_|     \\____/|_|  |_||_____/");
        Console.WriteLine("=============================");
        Console.WriteLine("ESCOLHA UMA DAS OPÇÕES ABAIXO: ");
        Console.WriteLine("=============================");
        Console.WriteLine("||  1 - POMODORO(25 MINUTOS) || ");
        Console.WriteLine("||  2 - PAUSA(5 MINUTOS)     || ");
        Console.WriteLine("||  3 - SAIR DO PROGRAMA     || ");
        Console.WriteLine("=============================");
        float chosenNumber = float.Parse(Console.ReadLine());

        switch (chosenNumber)
        {
          case 1 : StartPomodoro();
          break;
          case 2 : StartPause();
          break;
          case 3 : System.Environment.Exit(0);
          break;
          default: Console.WriteLine("insira um valor correto");
          break;
        }
  }

  static void StartPomodoro(){
    int currentTime = 0;
    while(currentTime != 1){
        Console.Clear();
        Console.WriteLine("|^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^|");
        Console.WriteLine("|                                                |");
        Console.WriteLine("|         MINUTOS :  " + currentTime+"                           |");
        Console.WriteLine("|                                                |");
        Console.WriteLine("|                                                |");
        Console.WriteLine("|________________________________________________|");
        currentTime++;
        Thread.Sleep(60000);
    }
    Console.ReadKey();
    Menu();
  }

  static void StartPause(){
    int currentTime = 0;
    while(currentTime != 5){
        Console.Clear();
        Console.WriteLine("|^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^|");
        Console.WriteLine("|                                                |");
        Console.WriteLine("|Voce está de pausa a " + currentTime + " Minutos|");
        Console.WriteLine("|                                                |");
        Console.WriteLine("|                                                |");
        Console.WriteLine("|________________________________________________|");
        
        currentTime++;
        Thread.Sleep(60000);
    }
    Console.ReadKey();
    Menu();
  } 


    }

}

