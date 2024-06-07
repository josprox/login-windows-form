using System;
using System.Data.SQLite;

namespace idusers
{
    public class SQLiteConf
    {
        private string connectionString;
        public string tipo_conexion { get; }

        public SQLiteConf()
        {
            // Definimos la conexión
            connectionString = "Data Source=MyDatabase.db";
            tipo_conexion = "Data Source=MyDatabase.db";
            // Inicializar la base de datos y crear las tablas si no existen
            InicializarDb();
        }

        private void InicializarDb()
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Creamos las tablas
                    string createUsersTable = @"CREATE TABLE IF NOT EXISTS Usuarios(
                                                id INTEGER PRIMARY KEY AUTOINCREMENT,
                                                Nombre TEXT NOT NULL,
                                                Contra TEXT NOT NULL)";
                    string createSalariesTable = @"CREATE TABLE IF NOT EXISTS Salarios(
                                                   id INTEGER PRIMARY KEY AUTOINCREMENT,
                                                   id_user INTEGER NOT NULL,
                                                   Salario REAL,
                                                   Salario_por_hora REAL,
                                                   Horas_extras REAL,
                                                   Comisiones REAL,
                                                   FOREIGN KEY(id_user) REFERENCES Usuarios(id))";

                    using (var command = new SQLiteCommand(createUsersTable, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    using (var command = new SQLiteCommand(createSalariesTable, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    Console.WriteLine("Base de datos iniciada y tablas creadas.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al inicializar la base de datos: " + ex.Message);
            }
        }

        public void CrearUsuario(string name, string password)
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string insertUserQuery = @"INSERT INTO Usuarios (Nombre, Contra) VALUES (@Name, @Password)";
                    using (var command = new SQLiteCommand(insertUserQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Password", password);
                        command.ExecuteNonQuery();
                    }

                    Console.WriteLine("Usuario creado.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al crear el usuario: " + ex.Message);
            }
        }

        public void RegistrarSalario(string userName, double salary, double hourlyRate, double extraHours, double commissions)
        {
            int userId = BuscarIdUsuario(userName);
            if (userId == -1)
            {
                Console.WriteLine("Usuario no encontrado.");
                return;
            }

            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string insertSalaryQuery = @"INSERT INTO Salarios (id_user, Salario, Salario_por_hora, Horas_extras, Comisiones)
                                                 VALUES (@UserId, @Salary, @HourlyRate, @ExtraHours, @Commissions)";
                    using (var command = new SQLiteCommand(insertSalaryQuery, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);
                        command.Parameters.AddWithValue("@Salary", salary);
                        command.Parameters.AddWithValue("@HourlyRate", hourlyRate);
                        command.Parameters.AddWithValue("@ExtraHours", extraHours);
                        command.Parameters.AddWithValue("@Commissions", commissions);
                        command.ExecuteNonQuery();
                    }

                    Console.WriteLine("Salario registrado correctamente.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al registrar el salario: " + ex.Message);
            }
        }

        private int BuscarIdUsuario(string name)
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string getUserIdQuery = @"SELECT id FROM Usuarios WHERE Nombre = @Name";
                    using (var command = new SQLiteCommand(getUserIdQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);

                        var result = command.ExecuteScalar();
                        if (result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar el ID del usuario: " + ex.Message);
            }

            return -1; // Usuario no encontrado
        }
    }
}
