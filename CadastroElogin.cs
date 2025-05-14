using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.ComponentModel.DataAnnotations;

/*
Olá! Espero que você esteja bem.

Para você que abriu o código antes de executá-lo, muito obrigado pela atenção.  
Sei que este projeto é simples e que existem maneiras melhores de otimizar este pequeno sistema de cadastro e autenticação de login.  
Iniciei este código em C# a partir de uma pequena aula introdutória na faculdade, contando também com o apoio de inteligência artificial para compreender melhor o funcionamento de alguns comandos e da biblioteca do C#.

Agradeço muito pela paciência e por dedicar um tempinho da sua vida para executar e ler meu código.  
Muito obrigado!
*/


namespace Autentication
{

    public static class Program
    {

        public static void Main(string[] args)
        {
            String Answer;
            String Email;
            String Senha;

            Console.WriteLine("Seja bem vindo ao sistema!");
            System.Threading.Thread.Sleep(2000);

            Console.Clear();

            bool inicio = true;
            while (inicio)
            {
                Console.WriteLine("Deseja criar um login e senha? S/N");
                Answer = Console.ReadLine();

                if (Answer == "s" || Answer == "S")
                {

                    bool repetir1 = true;

                    while (repetir1)
                    {
                        Console.Clear();
                        Console.WriteLine("Digite um Email valido:");
                        Email = Console.ReadLine();

                        if (!String.IsNullOrEmpty(Email) && Email.Contains("@") && Email.EndsWith(".com"))
                        {
                            for (int rep = 0; rep <= 3; rep++)
                            {
                                Console.Clear();
                                Console.WriteLine($"Verificando{new string('.', rep + 1)}");
                                System.Threading.Thread.Sleep(1000);
                            }
                            Console.Clear();
                            Console.WriteLine("E-mail Aceito");

                            bool repetir2 = true;
                            while (repetir2)
                            {
                                Console.Clear();
                                Console.WriteLine("Digite uma senha valida de no minimo 6 Caracteres ao menos um numero, simbolo e letra maiscula: ");
                                Senha = Console.ReadLine();

                                if (!String.IsNullOrEmpty(Senha) && Senha.Length >= 6 && Senha.Any(char.IsDigit) && Senha.Any(char.IsUpper) && Senha.Any(c => !char.IsLetterOrDigit(c)))
                                {
                                    Console.Clear();
                                    Console.WriteLine("Verificando...");
                                    System.Threading.Thread.Sleep(3000);
                                    Console.Clear();
                                    Console.WriteLine("Senha aceita!");
                                    Console.Clear();
                                    Console.WriteLine("Seu E-mail e senha foram cadastrados com sucesso!");
                                    System.Threading.Thread.Sleep(2000);
                                    Console.Clear();
                                    Console.WriteLine("Obrigado por realizar seu cadastro no Sistema!! <3");

                                    Console.Clear();
                                    Console.WriteLine("Deseja fazer Login? S/N");
                                    Answer = Console.ReadLine();

                                    if (Answer == "s" || Answer == "S")
                                    {
                                        bool login = true;
                                        int tenTativa = 3;
                                        int tenComeco = 0;

                                        while (login)
                                        {
                                            String EmailCad;
                                            String SenhaCad;

                                            Console.Clear();
                                            Console.WriteLine("Digite seu Email cadastado:");
                                            EmailCad = Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("Digite a senha:");
                                            SenhaCad = Console.ReadLine();
                                            Console.Clear();
                                            Console.WriteLine("Verificando.");
                                            System.Threading.Thread.Sleep(1000);
                                            Console.Clear();
                                            Console.WriteLine("Verificando..");
                                            System.Threading.Thread.Sleep(1000);
                                            Console.Clear();
                                            Console.WriteLine("Verificando...");
                                            System.Threading.Thread.Sleep(1000);

                                            if (EmailCad == Email && SenhaCad == Senha)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Email e Senha corretos!");
                                                Console.Clear();
                                                System.Threading.Thread.Sleep(2000);
                                                Console.WriteLine(":) Seja muito Bem Vindo ao Sistema! :)");
                                                login = false;
                                                inicio = false;
                                            }
                                            else
                                            {
                                                tenComeco++;
                                                Console.Clear();
                                                Console.WriteLine("Email ou Senha incorretos!");
                                                System.Threading.Thread.Sleep(2000);
                                                Console.Clear();
                                                Console.WriteLine($"Deseja tentar novamente? S/N (Tentativa {tenComeco} de {tenTativa})");
                                                Answer = Console.ReadLine();

                                                if (Answer == "s" || Answer == "S")
                                                {
                                                    if (tenTativa < tenComeco)
                                                    {
                                                        login = true;
                                                    }
                                                    else if (tenComeco >= tenTativa)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine($"Numero max de tentativas excedido {tenComeco} de {tenTativa} ");
                                                        System.Threading.Thread.Sleep(2000);
                                                        Console.Clear();
                                                        Console.WriteLine("Obrigado por usar o Sistema!!");
                                                        login = false;
                                                        inicio = false;
                                                    }


                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    System.Threading.Thread.Sleep(2000);
                                                    Console.WriteLine("Obrigado por usar o Sistema!!");
                                                    login = false;
                                                    inicio = false;
                                                }
                                            }
                                        }
                                    }
                                    repetir2 = false;
                                    inicio = false;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Senha invalida!");
                                    System.Threading.Thread.Sleep(2000);
                                    Console.Clear();
                                    Console.WriteLine("Deseja tentar novamente? S/N");
                                    Answer = Console.ReadLine();

                                    if (Answer == "s" || Answer == "S")
                                    {
                                        Console.WriteLine("Obrigado por usar o Sistema!!");
                                        repetir2 = false;
                                        inicio = false;
                                    }
                                }
                            }
                            repetir1 = false;
                            inicio = false;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Verificando.");
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            Console.WriteLine("Verificando..");
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            Console.WriteLine("Verificando...");
                            System.Threading.Thread.Sleep(1500);
                            Console.WriteLine("Formato de E-mail invalido.");
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            Console.WriteLine("Deseja tentar novamente? S/N");
                            Answer = Console.ReadLine();

                            if (Answer == "s" || Answer == "S")
                            {
                                Console.WriteLine("Obrigado por usar o Sistema!!");
                                repetir1 = false;
                                inicio = false;
                            }
                        }
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Carregando.");
                    System.Threading.Thread.Sleep(1500);
                    Console.Clear();
                    Console.WriteLine("Carregando..");
                    System.Threading.Thread.Sleep(1500);
                    Console.Clear();
                    Console.WriteLine("Carregando...");
                    System.Threading.Thread.Sleep(1500);
                    Console.Clear();
                    Console.WriteLine("Obrigado por usar o Sistema!!");
                    break;
                }
            }
        }
    }
}
