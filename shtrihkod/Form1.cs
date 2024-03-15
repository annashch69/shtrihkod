using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using iTextSharp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace shtrihkod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadProductName();
        }

        private void LoadProductName()
        {
            string connectionString = "Host=localhost;Username=postgres;Password=123456;Database=product";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT Название FROM Товары WHERE ID = 1";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            label6.Text = productName;
                        }
                        else
                        {
                            label6.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery2 = "SELECT Название FROM Товары WHERE ID = 2";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery2, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            label7.Text = productName;
                        }
                        else
                        {
                            label7.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery3 = "SELECT Название FROM Товары WHERE ID = 3";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery3, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            label8.Text = productName;
                        }
                        else
                        {
                            label8.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery4 = "SELECT Название FROM Товары WHERE ID = 4";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery4, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            label9.Text = productName;
                        }
                        else
                        {
                            label9.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery5 = "SELECT Название FROM Товары WHERE ID = 5";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery5, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            label10.Text = productName;
                        }
                        else
                        {
                            label10.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery11 = "SELECT Стоимость FROM Товары WHERE ID = 1";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery11, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Стоимость"].ToString();
                            label11.Text = productName;
                        }
                        else
                        {
                            label11.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery22 = "SELECT Стоимость FROM Товары WHERE ID = 2";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery22, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Стоимость"].ToString();
                            label12.Text = productName;
                        }
                        else
                        {
                            label12.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery33 = "SELECT Стоимость FROM Товары WHERE ID = 3";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery33, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Стоимость"].ToString();
                            label13.Text = productName;
                        }
                        else
                        {
                            label13.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery44 = "SELECT Стоимость FROM Товары WHERE ID = 4";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery44, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Стоимость"].ToString();
                            label14.Text = productName;
                        }
                        else
                        {
                            label14.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery55 = "SELECT Стоимость FROM Товары WHERE ID = 5";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery55, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Стоимость"].ToString();
                            label15.Text = productName;
                        }
                        else
                        {
                            label15.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery1l = "SELECT Артикул FROM Товары WHERE ID = 1";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery1l, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Артикул"].ToString();
                            linkLabel1.Text = productName;
                        }
                        else
                        {
                            linkLabel1.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery2l = "SELECT Артикул FROM Товары WHERE ID = 2";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery2l, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Артикул"].ToString();
                            linkLabel2.Text = productName;
                        }
                        else
                        {
                            linkLabel2.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery3l = "SELECT Артикул FROM Товары WHERE ID = 3";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery3l, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Артикул"].ToString();
                            linkLabel3.Text = productName;
                        }
                        else
                        {
                            linkLabel3.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery4l = "SELECT Артикул FROM Товары WHERE ID = 4";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery4l, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Артикул"].ToString();
                            linkLabel4.Text = productName;
                        }
                        else
                        {
                            linkLabel4.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery5l = "SELECT Артикул FROM Товары WHERE ID = 5";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery5l, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Артикул"].ToString();
                            linkLabel5.Text = productName;
                        }
                        else
                        {
                            linkLabel5.Text = "Товар не найден";
                        }
                    }
                }
            }
        }


        private void RealTimeSearch()
        {
            string searchString = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(searchString))
            {
                string connectionString = "Host=localhost;Username=postgres;Password=123456;Database=product";

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT Артикул, Название, Стоимость FROM Товары WHERE Название ILIKE @searchString";

                    using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@searchString", "%" + searchString + "%");

                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string productName = reader["Название"].ToString();
                                string artikul = reader["Артикул"].ToString();
                                string count = reader["Стоимость"].ToString();
                                label6.Text = productName;
                                label11.Text = count;
                                linkLabel1.Text = artikul;
                            }
                            else
                            {
                                label6.Text = "Товар не найден";
                                label11.Text = "Товар не найден";
                                linkLabel1.Text = "Товар не найден";
                            }
                        }
                    }
                }
            }
        }
        private void LoadProductName2()
        {
            string connectionString = "Host=localhost;Username=postgres;Password=123456;Database=product";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT Название FROM Товары WHERE ID = 6";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            label6.Text = productName;
                        }
                        else
                        {
                            label6.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery2 = "SELECT Название FROM Товары WHERE ID = 7";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery2, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            label7.Text = productName;
                        }
                        else
                        {
                            label7.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery3 = "SELECT Название FROM Товары WHERE ID = 8";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery3, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            label8.Text = productName;
                        }
                        else
                        {
                            label8.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery4 = "SELECT Название FROM Товары WHERE ID = 9";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery4, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            label9.Text = productName;
                        }
                        else
                        {
                            label9.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery5 = "SELECT Название FROM Товары WHERE ID = 10";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery5, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Название"].ToString();
                            label10.Text = productName;
                        }
                        else
                        {
                            label10.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery11 = "SELECT Стоимость FROM Товары WHERE ID = 6";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery11, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Стоимость"].ToString();
                            label11.Text = productName;
                        }
                        else
                        {
                            label11.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery22 = "SELECT Стоимость FROM Товары WHERE ID = 7";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery22, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Стоимость"].ToString();
                            label12.Text = productName;
                        }
                        else
                        {
                            label12.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery33 = "SELECT Стоимость FROM Товары WHERE ID = 8";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery33, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Стоимость"].ToString();
                            label13.Text = productName;
                        }
                        else
                        {
                            label13.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery44 = "SELECT Стоимость FROM Товары WHERE ID = 9";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery44, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Стоимость"].ToString();
                            label14.Text = productName;
                        }
                        else
                        {
                            label14.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery55 = "SELECT Стоимость FROM Товары WHERE ID = 10";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery55, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Стоимость"].ToString();
                            label15.Text = productName;
                        }
                        else
                        {
                            label15.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery1l = "SELECT Артикул FROM Товары WHERE ID = 6";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery1l, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Артикул"].ToString();
                            linkLabel1.Text = productName;
                        }
                        else
                        {
                            linkLabel1.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery2l = "SELECT Артикул FROM Товары WHERE ID = 7";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery2l, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Артикул"].ToString();
                            linkLabel2.Text = productName;
                        }
                        else
                        {
                            linkLabel2.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery3l = "SELECT Артикул FROM Товары WHERE ID = 8";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery3l, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Артикул"].ToString();
                            linkLabel3.Text = productName;
                        }
                        else
                        {
                            linkLabel3.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery4l = "SELECT Артикул FROM Товары WHERE ID = 9";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery4l, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Артикул"].ToString();
                            linkLabel4.Text = productName;
                        }
                        else
                        {
                            linkLabel4.Text = "Товар не найден";
                        }
                    }
                }

                string selectQuery5l = "SELECT Артикул FROM Товары WHERE ID = 10";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery5l, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string productName = reader["Артикул"].ToString();
                            linkLabel5.Text = productName;
                        }
                        else
                        {
                            linkLabel5.Text = "Товар не найден";
                        }
                    }
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadProductName2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadProductName();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            RealTimeSearch();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DrawBarcode(linkLabel1.Text);
        }
        private void DrawBarcode(string code, int resolution = 20) // resolution - пикселей на миллиметр
        {
            int numberCount = 8; // количество цифр
            float height = 25.93f * resolution; // высота штрих кода
            float lineHeight = 22.85f * resolution; // высота штриха
            float leftOffset = 3.63f * resolution; // свободная зона слева
            float rightOffset = 2.31f * resolution; // свободная зона справа
                                                    //штрихи, которые образуют правый и левый ограничивающие знаки,
                                                    //а также центральный ограничивающий знак должны быть удлинены вниз на 1,65мм
            float longLineHeight = lineHeight + 1.65f * resolution;
            float fontHeight = 2.75f * resolution; // высота цифр
            float lineToFontOffset = 0.165f * resolution; // минимальный размер от верхнего края цифр до нижнего края штрихов
            float lineWidthDelta = 0.15f * resolution; // ширина 0.15*{цифра}
            float lineWidthFull = 1.35f * resolution; // ширина белой полоски при 0 или 0.15*9
            float lineOffset = 0.2f * resolution; // между штрихами должно быть расстояние в 0.2мм

            float width = leftOffset + rightOffset + 6 * (lineWidthDelta + lineOffset) + numberCount * (lineWidthFull + lineOffset); // ширина штрих-кода

            Bitmap bitmap = new Bitmap((int)width, (int)height); // создание картинки нужных размеров
            Graphics g = Graphics.FromImage(bitmap); // создание графики

            Font font = new Font("Arial", fontHeight, FontStyle.Regular, GraphicsUnit.Pixel); // создание шрифта

            StringFormat fontFormat = new StringFormat(); // Центрирование текста
            fontFormat.Alignment = StringAlignment.Center;
            fontFormat.LineAlignment = StringAlignment.Center;

            float x = leftOffset; // позиция рисования по x
            for (int i = 0; i < numberCount; i++)
            {
                int number = Convert.ToInt32(code[i].ToString()); // число из кода
                if (number != 0)
                {
                    g.FillRectangle(Brushes.Black, x, 0, number * lineWidthDelta, lineHeight); // рисуем штрих
                }
                RectangleF fontRect = new RectangleF(x, lineHeight + lineToFontOffset, lineWidthFull, fontHeight); // рамки для буквы
                g.DrawString(code[i].ToString(), font, Brushes.Black, fontRect, fontFormat); // рисуем букву
                x += lineWidthFull + lineOffset; // смещаем позицию рисования по x

                if (i == 0 || i == numberCount / 2 || i == numberCount - 1) // если это начало, середина или конец кода рисуем разделители
                {
                    for (int j = 0; j < 2; j++) // рисуем 2 линии разделителя
                    {
                        g.FillRectangle(Brushes.Black, x, 0, lineWidthDelta, longLineHeight); // рисуем длинный штрих
                        x += lineWidthDelta + lineOffset; // смещаем позицию рисования по x
                    }
                }
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // делаем чтобы картинка помещалась в pictureBox
                    pictureBox1.Image = bitmap; // устанавливаем картинку
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DrawBarcode(linkLabel2.Text);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DrawBarcode(linkLabel3.Text);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DrawBarcode(linkLabel4.Text);
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DrawBarcode(linkLabel5.Text);
        }
    }
}

