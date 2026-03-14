using System;
using System.Data.SqlClient;

namespace QuanLyKTX
{
    public class StudentService
    {
        // SMELL: Tên biến không theo chuẩn camelCase, chứa số vô nghĩa
        private string string1 = "connection_string_here";

        public void ProcessStudent(string studentId)
        {
            // VULNERABILITY: SQL Injection cực kỳ nguy hiểm (Cộng chuỗi trực tiếp)
            string query = "SELECT * FROM Students WHERE Id = '" + studentId + "'";

            try
            {
                // BUG: Sử dụng đối tượng mà không khởi tạo (Potential NullReference)
                SqlConnection conn = null;
                conn.Open();

                // SMELL: Khai báo biến mà không bao giờ dùng đến
                int temporaryValue = 100;

                Console.WriteLine("Executing: " + query);
            }
            catch (Exception ex)
            {
                // SMELL: Nuốt chửng ngoại lệ (Empty catch block) - Cực kỳ độc hại khi debug
            }
        }

        // SMELL: Hàm quá đơn giản hoặc vô dụng (Dead code)
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}