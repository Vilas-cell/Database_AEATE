using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace Сервер
{
    class Program
    {
        static int port = 8005; // порт для приема входящих запросов
        List<Products> product = new List<Products>();
        List<Client> client = new List<Client>();
        List<Clothes> clothes = new List<Clothes>();
        List<Depot> depot = new List<Depot>();
        List<Food> food = new List<Food>();
        List<Furniture> furniture = new List<Furniture>();
        List<Stationary> stationary = new List<Stationary>();
        List<Technics> technics = new List<Technics>();
        List<User> user = new List<User>();
        List<User_auth> user_auth = new List<User_auth>();

        string connString = "server=localhost;user=root;database=aethe;password=root;";

        public void Data()
        {

          /*  string ZType = "1";
            string Ztable = "Products";
            string Zstroka;
            string sql;
            string Id = " ", Name = " ", Frame = " ", Age = " ", Semester = " ";
          

            var banana = new Products("10", "50", "200", "Банан", "Ниггерия", "1035");


            var products = new List<Products>() { banana };

            string[] strp = new string[10];

            string stp = " ";

            for (int i = 0; i < products.Count; i++)
            {

                strp[i] = products[i].Name;

            }


            for (int i = 0; i < strp.Length; i++)
            {
                if (strp[i] != null)
                {
                    stp += strp[i].ToString();
                }

            }
*/

            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                try
                {
                    Console.WriteLine("Подключение к базе даных");
                    connection.Open();

                    Console.WriteLine("Успешно");

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }

                string sql = "SELECT * FROM product";

                var command = new MySqlCommand(sql, connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        product.Add(new Products(Convert.ToString(reader["ID"]), Convert.ToString(reader["Amount"]),
                        Convert.ToString(reader["Price"]), Convert.ToString(reader["Weight"]), Convert.ToString(reader["Name"]),
                        Convert.ToString(reader["Manufactures"])));

                    }
                }
                /*  switch (ZType)
                  {

                      case "1":
                          sql = "SELECT * FROM" + Ztable;

                          var command = new MySqlCommand(sql, connection);

                          using (var reader = command.ExecuteReader())
                          {
                              while (reader.Read())
                              {
                                  switch (Ztable)
                                  {
                                      case "Product":
                                          product.Add(new Products(Convert.ToString(reader["ID"]), Convert.ToString(reader["Amount"]),
                                          Convert.ToString(reader["Price"]), Convert.ToString(reader["Weight"]), Convert.ToString(reader["Name"]),
                                          Convert.ToString(reader["Manufactures"])));
                                          break;
                                      case "Client":
                                          client.Add(new Client(reader["ID"].ToString(), reader["Adress"].ToString(),
                                          reader["Name"].ToString(), reader["Age"].ToString(), reader["Gender"].ToString(),
                                          reader["Currensy"].ToString(), reader["Phone"].ToString(), reader["Company"].ToString()));
                                          break;
                                  }
                              }
                          }
                          break;

                      case "2":

                          sql = "insert into" + Ztable + "(" + stp + ") values('" + Id + "','" + Name + "','" + Frame + "','" + Age + "','" + Semester + "');";
                          break;
                      case "3":
                          sql = "delete from student.studentinfo where idStudentInfo='" + Id + "';";
                          break;
                  }*/






                // закриваємо конект
                connection.Close();
                // звільнюємо ресурси
                connection.Dispose();
            }

        }

        public void zapros()
        {



        }


        public void Insert_to_Products(string id, string amount, string price, string weight, string name, string manufactures)
        {

            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                try
                {
                    Console.WriteLine("Подключение к базе даных");
                    connection.Open();

                    Console.WriteLine("Успешно");

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }

                string sql = "INSERT INTO 'product' ('ID', 'Amount', 'Price', 'Weight', 'Name', 'Manufactures') VALUES(@id, @amount, @price, @weight, @name, @manufactures)";
                var command = new MySqlCommand(sql, connection);
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                command.Parameters.Add("@amount", MySqlDbType.Int32).Value = amount;
                command.Parameters.Add("@price", MySqlDbType.VarChar).Value = price;
                command.Parameters.Add("@weight", MySqlDbType.VarChar).Value = weight;
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                command.Parameters.Add("@manufactures", MySqlDbType.VarChar).Value = manufactures;

                command.ExecuteNonQuery();
            }

        }


        static void Main(string[] args)
        {
            var prog = new Program();
            //prog.Insert_to_Products();
            prog.Data();
            prog.Socket();



        }

        public void Socket()
        {
            // получаємо адреса для запуску сокета
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
            // створюємо сокет
            Socket listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // зв'язуємо сокет с локальною точкою, по якій будемо при1мати данні
            listenSocket.Bind(ipPoint);
            // начинаем прослуховування
            listenSocket.Listen(10);
            Console.WriteLine("Сервер запущен. Ожидание подключений...");
            while (true)
            {
                Socket handler = listenSocket.Accept();
                // отримуємо повідомлення
                StringBuilder builder = new StringBuilder();
                int bytes = 0; // кількість отриманих байтів
                byte[] data = new byte[256]; // буфер для отримуваних даних 
                                             // буфера для даних що відправляються
                byte[] iddata = new byte[256];
                byte[] amountdata = new byte[256];
                byte[] pricedata = new byte[256];
                byte[] weightdata = new byte[256];
                byte[] namedata = new byte[256];
                byte[] manufacturesdata = new byte[256];
                do
                {
                    Console.WriteLine("Клиент подключен");
                    bytes = handler.Receive(data);
                    builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                }
                while (handler.Available > 0);

                //відправляємо відповідь
                foreach (var item in product)
                    if (!Object.ReferenceEquals(null, item))
                    {
                        //iddata = Encoding.Unicode.GetBytes(item.ID);
                        //handler.Send(iddata);
                        //amountdata = Encoding.Unicode.GetBytes(item.Amount);
                        //handler.Send(amountdata);
                        //pricedata = Encoding.Unicode.GetBytes(item.Price);
                        //handler.Send(pricedata);
                        //weightdata = Encoding.Unicode.GetBytes(item.Weight);
                        //handler.Send(weightdata);
                        //namedata = Encoding.Unicode.GetBytes(item.Name);
                        //handler.Send(namedata);
                        //manufacturesdata = Encoding.Unicode.GetBytes(item.Manufactures);
                        //handler.Send(manufacturesdata);
                        Console.WriteLine(item.ID + " " + item.Amount + " " + item.Price + " " + item.Weight + " " + item.Name + " " + item.Manufactures);
                    }
                //закриваємо сокет
                handler.Shutdown(SocketShutdown.Both);
                handler.Close();
            }
        }

    }
}
