using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace practice_4_
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string xmlFilePath = "users.xml";
            XmlDocument xmlDoc = new XmlDocument();
            doc.Load(xmlFilePath);
            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Просмотреть всех пользователей");
                Console.WriteLine("2. Добавить нового пользователя");
                Console.WriteLine("3. Выход");
                string choice = Console.ReadLine();
                Console.Clear();
                switch (choice)
                {
                    case "1":
                        DisplayUsers(doc);
                        break;
                            case "2":
                        AddUser(doc);
                        doc.Save(xmlFilePath);
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Неверный ввод. Попробуйте ещё раз.");
                        break;
                }
            }
        }
        static void DisplayUsers(XmlDocument doc)
        {
            foreach (XmlNode userNode in doc.SelectNodes("//user"))
            {
                string name = userNode.SelectSingleNode("name").InnerText;
                string age = userNode.SelectSingleNode("age").InnerText;
                Console.WriteLine($"Имя:{name},Возраст:{age}");
            }
        }
        static void AddUser(XmlDocument doc)
        {
            XmlNode root = doc.DocumentElement;
            Console.Write("Введите имя пользователя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите возраст пользователя:");
            string age = Console.ReadLine();
            XmlElement user = doc.CreateElement("user");
            XmlElement nameElement = doc.CreateElement("name");
            nameElement.InnerText = name;
            XmlElement ageElement = doc.CreateElement("age");
            ageElement.InnerText = age;
            user.AppendChild(user);
            Console.WriteLine("Пользователь успешно добавлен!");
        }
    }
}

        
             
        

         

