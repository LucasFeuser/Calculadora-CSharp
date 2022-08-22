                    using System;

                    namespace Calculadora
                    {
                    class Program
                    {
                    static void Main(string[] args)
                    {
                    Menu();
                    }

                    static void Soma()
                    {
                    Console.Clear(); //Clear Terminal;
                    Console.WriteLine("Primeiro valor:"); //Msg first value;
                    float v1 = float.Parse(Console.ReadLine()); //Input user value, and transforma Readline using parse, because default Readline set a string input;
                    Console.WriteLine("Segundo valor:");
                    float v2 = float.Parse(Console.ReadLine());

                    Console.WriteLine("");

                    float resultado = v1 + v2;

                    // Console.WriteLine("O resultado da soma é " + resultado); 
                        Console.WriteLine($"O resultado da soma é {resultado}"); //init a string $ to print result inside a "", this is call intelpol strings;  
                    // Console.WriteLine($"O resultado da soma é {v1 + v2}");
                    // Console.WriteLine("O resultado da soma é " + ( v1 + v2 ));
                    Console.ReadKey(); //using to dont close window
                    Menu();
                    }

                    static void Subtracao()
                    {
                    Console.Clear();

                    Console.WriteLine("Primeiro valor:");
                    float v1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Segundo valor:");
                    float v2 = float.Parse(Console.ReadLine());

                    Console.WriteLine("");

                    float resultado = v1 - v2;
                    Console.WriteLine($"O resultado da subtração é {resultado}");
                    Console.ReadKey(); //using to dont close window
                    Menu();
                    }

                    static void Divisao()
                    {
                    Console.Clear();

                    Console.WriteLine("Primeiro valor:");
                    float v1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Segundo valor:");
                    float v2 = float.Parse(Console.ReadLine());

                    Console.WriteLine("");

                    float resultado = v1 / v2;
                    Console.WriteLine($"o resultado da divisão é {resultado}");
                    Console.ReadKey();
                    Menu();
                    }

                    static void Multicacao()
                    {
                    Console.Clear();

                    Console.WriteLine("First value:");
                    float v1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Second value:");
                    float v2 = float.Parse(Console.ReadLine());

                    Console.WriteLine("");  

                    float resultado = v1 * v2;
                    Console.WriteLine($"The result of your multiplication is {v1 * v2}");
                    Console.ReadKey();
                    Menu();
                    }

                    static void Menu()
                    {
                    Console.Clear();

                    Console.WriteLine("Qual operação deseja fazer:");
                    Console.WriteLine(" 1 - Soma");
                    Console.WriteLine(" 2 - Subtração");
                    Console.WriteLine(" 3 - Divisão");
                    Console.WriteLine(" 4 - Multiplicação");
                    Console.WriteLine(" 5 - Sair Programa");

                    Console.WriteLine(" - - - - - - - - - - - - - - - ");
                    Console.WriteLine(" Selecione uma opção: ");

                    short res = short.Parse(Console.ReadLine());

                    // if (res == 1)
                    // {
                    //     Soma();
                    // }

                        switch (res)
                        {
                        case 1: Soma();break;
                        case 2: Subtracao();break;
                        case 3: Divisao(); break;
                        case 4: Multicacao(); break;
                        case 5: System.Environment.Exit(0); break;
                        default: Menu(); break;
                        }
                    {
                        
                    }

                    }
                    }
                    }
