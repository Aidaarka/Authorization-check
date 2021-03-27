using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1_HKI
{
    struct Rights
    {
        public string UserName;
        public string Right;
    }
    class Checking
    {
        static void Main()
        {
            List<Rights> listOfUsers = new List<Rights>()
            {
                new Rights(){ UserName = "Admin" },
                new Rights(){ UserName = "Guest" },
                new Rights(){ UserName = "User1" },
                new Rights(){ UserName = "User2" }
            };
            Dictionary<Rights, Rights> File1 = new Dictionary<Rights, Rights>()
            {
                {new Rights() {UserName =  "Admin"}, new Rights() {Right = "All of rights" } },
                {new Rights() {UserName =  "Guest"}, new Rights() {Right = "Read" } },
                {new Rights() {UserName =  "User1"}, new Rights() {Right = "Write" } },
                {new Rights() {UserName =  "User2"}, new Rights() {Right = "No rights" } }
            };
            Dictionary<Rights, Rights> File2 = new Dictionary<Rights, Rights>()
            {
                {new Rights() {UserName =  "Admin"}, new Rights() {Right = "All of rights" } },
                {new Rights() {UserName =  "Guest"}, new Rights() {Right = "No rights" } },
                {new Rights() {UserName =  "User1"}, new Rights() {Right = "No rights" } },
                {new Rights() {UserName =  "User2"}, new Rights() {Right = "Read" } }
            };
            Dictionary<Rights, Rights> File3 = new Dictionary<Rights, Rights>()
            {
                {new Rights() {UserName =  "Admin"}, new Rights() {Right = "All of rights" } },
                {new Rights() {UserName =  "Guest"}, new Rights() {Right = "Write" } },
                {new Rights() {UserName =  "User1"}, new Rights() {Right = "No rights" } },
                {new Rights() {UserName =  "User2"}, new Rights() {Right = "Write" } }
            };
            Dictionary<Rights, Rights> File4 = new Dictionary<Rights, Rights>()
            {
                {new Rights() {UserName =  "Admin"}, new Rights() {Right = "All of rights" } },
                {new Rights() {UserName =  "Guest"}, new Rights() {Right = "Write" } },
                {new Rights() {UserName =  "User1"}, new Rights() {Right = "Read" } },
                {new Rights() {UserName =  "User2"}, new Rights() {Right = "Read" } }
            };

            Console.WriteLine("Введите иия пользователя: ");
            string interNameUser = Console.ReadLine();

            //Использование LinQ
            var selectedUsers = from user in listOfUsers
                                where user.UserName == interNameUser
                                select user;

            //Вход в цикл только если пользователь из списка
            foreach (Rights user in selectedUsers)
            {
                Console.WriteLine("Список ваших прав: ");
                foreach (KeyValuePair<Rights, Rights> keyValue in File1)
                {
                    if (interNameUser == keyValue.Key.UserName)
                    {
                        Console.WriteLine($"В File1 доступно {keyValue.Value.Right} ");
                    }
                }
                foreach (KeyValuePair<Rights, Rights> keyValue in File2)
                {
                    if (interNameUser == keyValue.Key.UserName)
                    {
                        Console.WriteLine($"В File2 доступно {keyValue.Value.Right} ");
                    }
                }
                foreach (KeyValuePair<Rights, Rights> keyValue in File3)
                {
                    if (interNameUser == keyValue.Key.UserName)
                    {
                        Console.WriteLine($"В File3 доступно {keyValue.Value.Right} ");
                    }
                }
                foreach (KeyValuePair<Rights, Rights> keyValue in File4)
                {
                    if (interNameUser == keyValue.Key.UserName)
                    {
                        Console.WriteLine($"В File4 доступно {keyValue.Value.Right} ");
                    }
                }

                Console.WriteLine("Введите название файла: ");
                string interFileName = Console.ReadLine();

                Console.WriteLine("Введите действие: ");
                string interAction = Console.ReadLine();

                if (interFileName == "File1")
                {
                    if (interNameUser == "Admin")
                    {
                        Console.WriteLine("Операция успешно выполнена!");
                    }
                    foreach (KeyValuePair<Rights, Rights> keyValue in File1)
                    {
                        if (interNameUser == keyValue.Key.UserName && interAction == keyValue.Value.Right)
                        {
                            Console.WriteLine("Операция успешно выполнена!");
                        }
                    }
                }
                else if (interFileName == "File2")
                {
                    if (interNameUser == "Admin")
                    {
                        Console.WriteLine("Операция успешно выполнена!");
                    }
                    foreach (KeyValuePair<Rights, Rights> keyValue in File2)
                    {
                        if (interNameUser == keyValue.Key.UserName && interAction == keyValue.Value.Right)
                        {
                            Console.WriteLine("Операция успешно выполнена!");
                        }
                    }
                }
                else if (interFileName == "File3")
                {
                    if (interNameUser == "Admin")
                    {
                        Console.WriteLine("Операция успешно выполнена!");
                    }
                    foreach (KeyValuePair<Rights, Rights> keyValue in File3)
                    {
                        if (interNameUser == keyValue.Key.UserName && interAction == keyValue.Value.Right)
                        {
                            Console.WriteLine("Операция успешно выполнена!");
                        }
                    }
                }
                else if (interFileName == "File4")
                {
                    if (interNameUser == "Admin")
                    {
                        Console.WriteLine("Операция успешно выполнена!");
                    }
                    foreach (KeyValuePair<Rights, Rights> keyValue in File4)
                    {
                        if (interNameUser == keyValue.Key.UserName && interAction == keyValue.Value.Right)
                        {
                            Console.WriteLine("Операция успешно выполнена!");
                        }
                    }
                }
            }
        }
    }
}
