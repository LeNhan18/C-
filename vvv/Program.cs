using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vvv
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            string connectionString = "Server=127.0.0.1;Database=;User ID=your_username;Password=your_password;";

            // Khởi tạo kết nối
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Mở kết nối
                    connection.Open();
                    Console.WriteLine("Kết nối thành công!");

                    // Thực hiện một truy vấn
                    string query = "SELECT * FROM your_table";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine($"ID: {reader["id"]}, Name: {reader["name"]}");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi
                    Console.WriteLine($"Lỗi: {ex.Message}");
                }
                finally
                {
                    // Đóng kết nối
                    connection.Close();
                    Console.WriteLine("Kết nối đã được đóng.");
                }
            }
        }
    }
}
