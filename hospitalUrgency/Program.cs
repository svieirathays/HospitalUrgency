﻿using System;


namespace hospitalUrgency
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Escolha: ");
            Console.WriteLine("0 - Pacientes ");
            Console.WriteLine("1 - Profissionais");
            //Tranforma strings em INT
            var resposta = Int32.Parse(Console.ReadLine());

            //Switch para seleção de menu
            switch(resposta){
                case 0:
            
                    // Validação de saida do ciclo While
                
                    bool stop = false;
                    Pacientes[] pacientes = new Pacientes[1000];
                    var i = 0;
                    Pacientes paciente;

                    Console.Clear();
                    Console.WriteLine("Cadastro de Paciente ");
                    Console.WriteLine("");


                    //Ciclo para cadastrar vários pacientes de forma dinâmica
                    while (stop == false)
                    {
                        paciente = new Pacientes();

                        if (pacientes[0] != null)
                        {
                            paciente.Id = pacientes[i - 1].Id + 1;
                        }
                        else
                        {
                            paciente.Id = 0;
                        }

                        Console.WriteLine("Insira o nome do Paciente:");
                        paciente.Nome = Console.ReadLine();

                        Console.WriteLine("Insira o Morada do Paciente:");
                        paciente.Morada = Console.ReadLine();

                        Console.WriteLine("Insira o Código Postal do Paciente:");
                        bool g = false;
                        while (g == false)
                        {


                            try
                            {
                                paciente.CP = Int32.Parse(Console.ReadLine());
                                g = true;

                            }
                            catch (FormatException)
                            {
                                Console.WriteLine($"Este campo só aceita números");
                                g = false;
                            }
                        }

                        Console.WriteLine("Insira o NIF do Paciente:");
                        g = false;
                        while (g == false)
                        {
                            try
                            {
                                paciente.NIF = Int32.Parse(Console.ReadLine());
                                g = true;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine($"Este campo só aceita números");
                                g = false;
                            }

                        }

                        Console.WriteLine("Insira o Telefone do Paciente:");
                        g = false;
                        while (g == false)
                        {
                            try
                            {
                                paciente.Telefone = Int32.Parse(Console.ReadLine());
                                g = true;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine($"Este campo só aceita números");
                                g = false;
                            }

                        }

                        Console.WriteLine("Quer Adicionar mais Clientes? (Y/N)");
                        var stopString = Console.ReadLine();

                        if (stopString == "N" || stopString == "n") stop = true;

                        pacientes[i] = paciente;

                        Console.WriteLine("YouR ID: " + pacientes[i].Id);
                        Console.WriteLine("You typed: " + pacientes[i].Nome);
                        Console.WriteLine("");
                        i++;

                    }
                    if (pacientes != null)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            Console.WriteLine(pacientes[j].Id + " / " + pacientes[j].Nome + " / " + pacientes[j].Morada + " / " + pacientes[j].CP + " / " + pacientes[j].NIF);
                        }
                    }

                    break;

                case 1:
                    Console.WriteLine("Penso, logo existo");

                    break;
                    
            }
            
        }
    }
}
