using System;
using System.Data;
using System.Data.OleDb;

class Program
{
    static string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\dahhw\Documents\Salon.accdb;";

    static void Main()
    {
        using (OleDbConnection connection = new(connectionString))
        {
            connection.Open();

            while (true)
            {
                Console.WriteLine("\n#1 Manage Employees");
                Console.WriteLine("#2 Manage Clients");
                Console.WriteLine("#3 Manage Income");
                Console.WriteLine("#4 Manage Service Records");
                Console.WriteLine("#5 Manage Services");
                Console.WriteLine("#6 Print All Data");
                Console.WriteLine("#7 Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ManageEmployeesMenu(connection);
                        break;
                    case "2":
                        ManageClientsMenu(connection);
                        break;
                    case "3":
                        ManageIncomeMenu(connection);
                        break;
                    case "4":
                        ManageServiceRecordsMenu(connection);
                        break;
                    case "5":
                        ManageServicesMenu(connection);
                        break;
                    case "6":
                        PrintAllData(connection);
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }

    static void ManageEmployeesMenu(OleDbConnection connection)
    {
        Console.WriteLine("\nChoose an employee option:");
        Console.WriteLine("#1 Add Employee");
        Console.WriteLine("#2 Delete Employee");
        Console.WriteLine("#3 Filter Employees");
        Console.WriteLine("#4 Print all employees");
        Console.WriteLine("#5 <--- Back");
        Console.Write("Enter your choice: ");
        string employeeChoice = Console.ReadLine();

        switch (employeeChoice)
        {
            case "1":
                AddEmployee(connection);
                ManageEmployeesMenu(connection);
                break;
            case "2":
                DeleteEmployee(connection);
                ManageEmployeesMenu(connection);
                break;
            case "3":
                FilterEmployees(connection);
                ManageEmployeesMenu(connection);
                break;
            case "4":
                PrintAllEmployees(connection);
                ManageEmployeesMenu(connection);
                break;
            case "5":
                return;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                ManageEmployeesMenu(connection);
                break;
        }
    }

    static void ManageClientsMenu(OleDbConnection connection)
    {
        while (true)
        {
            Console.WriteLine("Choose a client option:");
            Console.WriteLine("#1 Add Client");
            Console.WriteLine("#2 Delete Client");
            Console.WriteLine("#3 Filter Clients");
            Console.WriteLine("#4 Print All Clients");
            Console.WriteLine("#5 <--- Back");
            Console.Write("Enter your choice: ");
            string clientChoice = Console.ReadLine();

            switch (clientChoice)
            {
                case "1":
                    AddClient(connection);
                    break;
                case "2":
                    DeleteClient(connection);
                    break;
                case "3":
                    FilterClients(connection);
                    break;
                case "4":
                    PrintAllClients(connection);
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void ManageIncomeMenu(OleDbConnection connection)
    {
        while (true)
        {
            Console.WriteLine("Choose an income option:");
            Console.WriteLine("#1 Add Income Record");
            Console.WriteLine("#2 Filter Income Records");
            Console.WriteLine("#3 Print All Income Records");
            Console.WriteLine("#4 <--- Back");
            Console.Write("Enter your choice: ");
            string incomeChoice = Console.ReadLine();

            switch (incomeChoice)
            {
                case "1":
                    AddIncome(connection);
                    break;
                case "2":
                    FilterIncome(connection);
                    break;
                case "3":
                    PrintAllIncome(connection);
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void ManageServiceRecordsMenu(OleDbConnection connection)
    {
        Console.WriteLine("\nChoose a service record option:");
        Console.WriteLine("#1 Add Service Record");
        Console.WriteLine("#2 Filter Service Records");
        Console.WriteLine("#3 Print All Service Records");
        Console.WriteLine("#4 <--- Back");
        Console.Write("Enter your choice: ");
        string serviceRecordChoice = Console.ReadLine();

        switch (serviceRecordChoice)
        {
            case "1":
                AddServiceRecord(connection);
                ManageServiceRecordsMenu(connection);
                break;
            case "2":
                FilterServiceRecords(connection);
                ManageServiceRecordsMenu(connection);
                break;
            case "3":
                PrintAllServiceRecords(connection);
                ManageServiceRecordsMenu(connection);
                break;
            case "4":
                return;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                ManageServiceRecordsMenu(connection);
                break;
        }
    }


    static void ManageServicesMenu(OleDbConnection connection)
    {
        Console.WriteLine("\nChoose a service option:");
        Console.WriteLine("#1 Add Service");
        Console.WriteLine("#2 Delete Service");
        Console.WriteLine("#3 Print All Services");
        Console.WriteLine("#4 <--- Back");
        Console.Write("Enter your choice: ");
        string serviceChoice = Console.ReadLine();

        switch (serviceChoice)
        {
            case "1":
                AddService(connection);
                ManageServicesMenu(connection);
                break;
            case "2":
                DeleteService(connection);
                ManageServicesMenu(connection);
                break;
            case "3":
                PrintAllServices(connection);
                ManageServicesMenu(connection);
                break;
            case "4":
                return;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                ManageServicesMenu(connection);
                break;
        }
    }


    static void AddEmployee(OleDbConnection connection)
    {
        // Запрашиваем у пользователя данные о сотруднике
        Console.Write("\nEnter Employee Name: "); // Введите имя сотрудника
        string employeeName = Console.ReadLine();
        Console.Write("Enter Employee Surname: "); // Введите фамилию сотрудника
        string employeeSurname = Console.ReadLine();
        Console.Write("Enter Position: "); // Введите должность
        string position = Console.ReadLine();
        Console.Write("Enter Salary: "); // Введите зарплату
        decimal salary = Convert.ToDecimal(Console.ReadLine());

        // Создаем SQL-запрос для добавления сотрудника в базу данных
        string sqlInsert = "INSERT INTO Employees (EmployeesName, EmployeesSurname, [Position], Salary) " +
                           "VALUES (@EmployeeName, @EmployeeSurname, @Position, @Salary)";

        using (OleDbCommand command = new OleDbCommand(sqlInsert, connection))
        {
            // Добавляем параметры в SQL-запрос из пользовательского ввода
            command.Parameters.AddWithValue("@EmployeeName", employeeName);
            command.Parameters.AddWithValue("@EmployeeSurname", employeeSurname);
            command.Parameters.AddWithValue("@Position", position);
            command.Parameters.AddWithValue("@Salary", salary);

            // Выполняем SQL-запрос и получаем количество затронутых строк
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                // Если сотрудник был успешно добавлен, выводим сообщение об успехе
                Console.WriteLine("Employee added successfully."); // Сотрудник успешно добавлен
            }
            else
            {
                // Если не удалось добавить сотрудника, выводим сообщение об ошибке
                Console.WriteLine("Failed to add employee."); // Не удалось добавить сотрудника
            }
        }

        // Выводим всех сотрудников после добавления нового
        PrintAllEmployees(connection);
    }


    static void DeleteEmployee(OleDbConnection connection)
    {
        // Запрашиваем у пользователя ID сотрудника для удаления
        Console.Write("Enter Employee ID to delete: "); // Введите ID сотрудника для удаления
        string userInput = Console.ReadLine();

        // Проверяем, является ли ввод пользователя действительным числом
        if (!int.TryParse(userInput, out int employeeId))
        {
            // Если ввод недействителен, выводим сообщение об ошибке и выходим из функции
            Console.WriteLine("Invalid input. Please enter a valid Employee ID."); // Недействительный ввод. Пожалуйста, введите действительный ID сотрудника.
            return;
        }

        // Создаем SQL-запрос для удаления сотрудника из базы данных
        string sqlDelete = "DELETE FROM Employees WHERE EmployeesID = @EmployeeId";

        using (OleDbCommand command = new OleDbCommand(sqlDelete, connection))
        {
            // Добавляем параметры в SQL-запрос из пользовательского ввода
            command.Parameters.AddWithValue("@EmployeesId", employeeId);

            try
            {
                // Выполняем SQL-запрос и получаем количество затронутых строк
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                    // Если сотрудник был успешно удален, выводим сообщение об успехе
                    Console.WriteLine("Employee deleted successfully."); // Сотрудник успешно удален.
                else
                    // Если сотрудника не найдено или удаление не удалось, выводим сообщение об ошибке
                    Console.WriteLine("Employee not found or deletion failed."); // Сотрудник не найден или удаление не удалось.
            }
            catch (Exception ex)
            {
                // Если произошла ошибка при выполнении SQL-запроса, выводим сообщение об ошибке
                Console.WriteLine($"An error occurred: {ex.Message}"); // Произошла ошибка: {ex.Message}
            }
        }
    }


    static void FilterEmployees(OleDbConnection connection)
    {
        // Запрашиваем у пользователя поле для фильтрации
        Console.WriteLine("Choose a field to filter by:"); // Выберите поле для фильтрации
        Console.WriteLine("1. Employee Name"); // Имя сотрудника
        Console.WriteLine("2. Employee Surname"); // Фамилия сотрудника
        Console.WriteLine("3. Position"); // Должность
        Console.WriteLine("4. Salary"); // Зарплата
        Console.Write("Enter your choice: "); // Введите ваш выбор
        string filterChoice = Console.ReadLine();

        string field = "";
        switch (filterChoice)
        {
            case "1":
                field = "EmployeesName";
                break;
            case "2":
                field = "EmployeesSurname";
                break;
            case "3":
                field = "Position";
                break;
            case "4":
                field = "Salary";
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again."); // Недействительный выбор. Пожалуйста, попробуйте еще раз.
                return;
        }

        Console.Write("Enter 'asc' for ascending or 'desc' for descending: "); // Введите 'asc' для возрастания или 'desc' для убывания
        string sortOrder = Console.ReadLine().ToLower();

        if (sortOrder != "asc" && sortOrder != "desc")
        {
            Console.WriteLine("Invalid sort order. Please enter 'asc' or 'desc'."); // Недействительный порядок сортировки. Пожалуйста, введите 'asc' или 'desc'.
            return;
        }

        string sqlQuery = $"SELECT EmployeesName, EmployeesSurname, [Position], Salary FROM Employees ORDER BY {field} {sortOrder}";

        using (OleDbCommand command = new OleDbCommand(sqlQuery, connection))
        {
            try
            {
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("+----------------+-----------------+------------------+------------------------+");
                    Console.WriteLine("|   Employee Name      |   Employee Surname  |   Position      |     Salary    |");
                    Console.WriteLine("+----------------+-----------------+------------------+------------------------+");

                    while (reader.Read())
                    {
                        string employeeName = reader["EmployeesName"].ToString();
                        string employeeSurname = reader["EmployeesSurname"].ToString();
                        string position = reader["Position"].ToString();

                        decimal salary = reader.IsDBNull(reader.GetOrdinal("Salary")) ? 0 : reader.GetDecimal(reader.GetOrdinal("Salary"));

                        Console.WriteLine($"| {employeeName,-20} | {employeeSurname,-19} | {position,-15} | {salary,-13:C} |");
                    }

                    Console.WriteLine("+----------------+-----------------+------------------+------------------------+");
                }
            }
            catch (Exception ex)
            {
                // Если произошла ошибка при выполнении SQL-запроса, выводим сообщение об ошибке
                Console.WriteLine($"An error occurred: {ex.Message}"); // Произошла ошибка: {ex.Message}
            }
        }
    }


    static void AddClient(OleDbConnection connection)
    {
        // Запрашиваем у пользователя данные о клиенте
        Console.Write("Enter Client Name: "); // Введите имя клиента
        string clientName = Console.ReadLine();
        Console.Write("Enter Client Surname: "); // Введите фамилию клиента
        string clientSurname = Console.ReadLine();
        Console.Write("Enter Phone Number: "); // Введите номер телефона
        string phoneNumber = Console.ReadLine();
        Console.Write("Enter Address: "); // Введите адрес
        string address = Console.ReadLine();

        // Создаем SQL-запрос для добавления клиента в базу данных
        string sqlInsert = "INSERT INTO Clients (ClientName, ClientSurname, PhoneNumber, Address) " +
                           "VALUES (@ClientName, @ClientSurname, @PhoneNumber, @Address)";

        using (OleDbCommand command = new OleDbCommand(sqlInsert, connection))
        {
            // Добавляем параметры в SQL-запрос из пользовательского ввода
            command.Parameters.AddWithValue("@ClientName", clientName);
            command.Parameters.AddWithValue("@ClientSurname", clientSurname);
            command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
            command.Parameters.AddWithValue("@Address", address);

            try
            {
                // Выполняем SQL-запрос и получаем количество затронутых строк
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                    // Если клиент был успешно добавлен, выводим сообщение об успехе
                    Console.WriteLine("Client added successfully."); // Клиент успешно добавлен.
                else
                    // Если не удалось добавить клиента, выводим сообщение об ошибке
                    Console.WriteLine("Failed to add client."); // Не удалось добавить клиента.
            }
            catch (Exception ex)
            {
                // Если произошла ошибка при выполнении SQL-запроса, выводим сообщение об ошибке
                Console.WriteLine($"An error occurred: {ex.Message}"); // Произошла ошибка: {ex.Message}
            }
        }
    }


    // Метод для удаления клиента из базы данных
    static void DeleteClient(OleDbConnection connection)
    {
        // Запрашиваем у пользователя ID клиента, которого нужно удалить
        Console.Write("Введите ID клиента для удаления: ");
        int clientId = Convert.ToInt32(Console.ReadLine());

        // SQL-запрос для удаления клиента с указанным ID
        string sqlDelete = "DELETE FROM Clients WHERE ClientID = @ClientId";

        // Создаем команду с SQL-запросом и соединением
        using (OleDbCommand command = new OleDbCommand(sqlDelete, connection))
        {
            // Добавляем параметр в команду
            command.Parameters.AddWithValue("@ClientId", clientId);

            // Выполняем команду и получаем количество затронутых строк
            int rowsAffected = command.ExecuteNonQuery();
            // Если количество затронутых строк больше 0, значит, клиент был успешно удален
            if (rowsAffected > 0)
                Console.WriteLine("Клиент успешно удален.");
            // В противном случае выводим сообщение об ошибке
            else
                Console.WriteLine("Клиент не найден или удаление не удалось.");
        }
    }


    // Метод для вывода всех клиентов из базы данных
    static void PrintAllClients(OleDbConnection connection)
    {
        // SQL-запрос для выборки всех клиентов
        string sqlQuery = "SELECT ClientID, ClientName, ClientSurname, PhoneNumber, Address FROM Clients";

        // Создаем команду с SQL-запросом и соединением
        using (OleDbCommand command = new OleDbCommand(sqlQuery, connection))
        // Создаем объект OleDbDataReader для чтения строк результата SQL-запроса
        using (OleDbDataReader reader = command.ExecuteReader())
        {
            // Выводим заголовок таблицы
            Console.WriteLine("+----------+--------------------+---------------------+--------------------+--------------+");
            Console.WriteLine("| ClientID |   Client Name      |   Client Surname    |   Phone Number     |   Address    |");
            Console.WriteLine("+----------+--------------------+---------------------+--------------------+--------------+");

            // Читаем результаты запроса построчно
            while (reader.Read())
            {
                // Получаем данные каждого поля для текущей строки
                int clientId = reader.GetInt32(reader.GetOrdinal("ClientID"));
                string clientName = reader["ClientName"].ToString();
                string clientSurname = reader["ClientSurname"].ToString();
                string phoneNumber = reader["PhoneNumber"].ToString();
                string address = reader["Address"].ToString();

                // Выводим данные текущей строки в формате таблицы
                Console.WriteLine($"| {clientId,-8} | {clientName,-18} | {clientSurname,-19} | {phoneNumber,-18} | {address,-12} |");
            }

            // Выводим конец таблицы
            Console.WriteLine("+----------+--------------------+---------------------+--------------------+--------------+");
        }
    }

    static void PrintAllEmployees(OleDbConnection connection)
    {
        string sqlQuery = "SELECT EmployeesID, EmployeesName, EmployeesSurname, [Position], Salary FROM Employees";
        using (OleDbCommand command = new OleDbCommand(sqlQuery, connection))
        using (OleDbDataReader reader = command.ExecuteReader())
        {
            Console.WriteLine("+-----------------+----------------------+---------------------+-----------------+---------------+");
            Console.WriteLine("|   Employee ID   |   Employee Name      |   Employee Surname  |   Position      |   Salary      |");
            Console.WriteLine("+-----------------+----------------------+---------------------+-----------------+---------------+");

            while (reader.Read())
            {
                int employeeId = reader.GetInt32(reader.GetOrdinal("EmployeesID"));
                string employeeName = reader["EmployeesName"].ToString();
                string employeeSurname = reader["EmployeesSurname"].ToString();
                string position = reader["Position"].ToString();

                decimal salary = reader.IsDBNull(reader.GetOrdinal("Salary")) ? 0 : reader.GetDecimal(reader.GetOrdinal("Salary"));

                Console.WriteLine($"| {employeeId,-15} | {employeeName,-20} | {employeeSurname,-19} | {position,-15} | {salary,-13:C} |");
            }

            Console.WriteLine("+-----------------+----------------------+---------------------+-----------------+---------------+");
        }
    }

    // Метод для вывода информации о всех услугах из базы данных
    static void PrintAllServices(OleDbConnection connection)
    {
        // SQL-запрос для выборки информации о услугах
        string sqlQuery = "SELECT ServiceID, ServiceName, Description, Cost FROM Services";

        // Используем using, чтобы автоматически освободить ресурсы
        using (OleDbCommand command = new OleDbCommand(sqlQuery, connection))
        using (OleDbDataReader reader = command.ExecuteReader())
        {
            Console.WriteLine("+------------+----------------------+---------------------------+----------------+");
            Console.WriteLine("| Service ID |   Service Name       |         Description       |      Cost      |");
            Console.WriteLine("+------------+----------------------+---------------------------+----------------+");

            while (reader.Read())
            {
                // Получение значений из результата запроса
                int serviceId = reader.GetInt32(reader.GetOrdinal("ServiceID"));
                string serviceName = reader["ServiceName"].ToString();
                string description = reader["Description"].ToString();
                decimal cost = reader.GetDecimal(reader.GetOrdinal("Cost"));

                // Форматированный вывод данных о услугах
                Console.WriteLine($"| {serviceId,-10} | {serviceName,-20} | {description,-25} | {cost,-14:C} |");
            }

            Console.WriteLine("+------------+----------------------+---------------------------+----------------+");
        }
    }

    // Метод для фильтрации клиентов по имени или фамилии
    static void FilterClients(OleDbConnection connection)
    {
        // Запрашиваем у пользователя часть имени или фамилии для фильтрации
        Console.Write("Введите часть имени или фамилии клиента для фильтрации: ");
        string filterText = Console.ReadLine();

        // SQL-запрос для выборки клиентов, имя или фамилия которых содержат указанный текст
        string sqlFilter = "SELECT * FROM Clients WHERE ClientName LIKE @FilterText OR ClientSurname LIKE @FilterText";

        // Создаем команду с SQL-запросом и соединением
        using (OleDbCommand command = new OleDbCommand(sqlFilter, connection))
        {
            // Добавляем параметр в команду
            command.Parameters.AddWithValue("@FilterText", "%" + filterText + "%");

            // Создаем объект OleDbDataReader для чтения строк результата SQL-запроса
            using (OleDbDataReader reader = command.ExecuteReader())
            {
                Console.WriteLine("Клиенты:");
                // Читаем результаты запроса построчно
                while (reader.Read())
                {
                    // Выводим данные каждого клиента
                    Console.WriteLine($"ID клиента: {reader["ClientID"]}, Имя: {reader["ClientName"]}, " +
                                      $"Фамилия: {reader["ClientSurname"]}, Телефон: {reader["PhoneNumber"]}, " +
                                      $"Адрес: {reader["Address"]}");
                }
            }
        }
    }


    // Метод для добавления записи о доходе в базу данных
    static void AddIncome(OleDbConnection connection)
    {
        // Запрашиваем у пользователя дату дохода
        Console.Write("Введите дату дохода (гггг-ММ-дд): ");
        DateTime incomeDate;
        // Проверяем, корректно ли введена дата
        if (DateTime.TryParse(Console.ReadLine(), out incomeDate))
        {
            // Запрашиваем у пользователя сумму дохода
            Console.Write("Введите сумму дохода: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            // SQL-запрос для добавления записи о доходе
            string sqlInsert = "INSERT INTO Income (IncomeDate, Amount) VALUES (@IncomeDate, @Amount)";

            // Создаем команду с SQL-запросом и соединением
            using (OleDbCommand command = new OleDbCommand(sqlInsert, connection))
            {
                // Добавляем параметры в команду
                command.Parameters.AddWithValue("@IncomeDate", incomeDate);
                command.Parameters.AddWithValue("@Amount", amount);

                // Выполняем команду и получаем количество затронутых строк
                int rowsAffected = command.ExecuteNonQuery();
                // Если количество затронутых строк больше 0, значит, запись о доходе была успешно добавлена
                if (rowsAffected > 0)
                    Console.WriteLine("Запись о доходе успешно добавлена.");
                // В противном случае выводим сообщение об ошибке
                else
                    Console.WriteLine("Не удалось добавить запись о доходе.");
            }
        }
        else
        {
            // Выводим сообщение об ошибке, если формат даты был некорректным
            Console.WriteLine("Неверный формат даты. Пожалуйста, введите дату в формате гггг-ММ-дд.");
        }
    }


    // Метод для фильтрации записей о доходах по дате
    static void FilterIncome(OleDbConnection connection)
    {
        // Запрашиваем у пользователя начальную дату для фильтрации
        Console.Write("Введите начальную дату (гггг-ММ-дд): ");
        DateTime startDate;
        // Проверяем, корректно ли введена дата
        if (!DateTime.TryParse(Console.ReadLine(), out startDate))
        {
            Console.WriteLine("Неверный формат даты. Пожалуйста, введите дату в формате гггг-ММ-дд.");
            return;
        }

        // Запрашиваем у пользователя конечную дату для фильтрации
        Console.Write("Введите конечную дату (гггг-ММ-дд): ");
        DateTime endDate;
        // Проверяем, корректно ли введена дата
        if (!DateTime.TryParse(Console.ReadLine(), out endDate))
        {
            Console.WriteLine("Неверный формат даты. Пожалуйста, введите дату в формате гггг-ММ-дд.");
            return;
        }

        // SQL-запрос для выборки записей о доходах за указанный период
        string sqlFilter = "SELECT * FROM Income WHERE IncomeDate BETWEEN @StartDate AND @EndDate";

        // Создаем команду с SQL-запросом и соединением
        using (OleDbCommand command = new OleDbCommand(sqlFilter, connection))
        {
            // Добавляем параметры в команду
            command.Parameters.AddWithValue("@StartDate", startDate);
            command.Parameters.AddWithValue("@EndDate", endDate);

            // Создаем объект OleDbDataReader для чтения строк результата SQL-запроса
            using (OleDbDataReader reader = command.ExecuteReader())
            {
                Console.WriteLine("Записи о доходах:");
                // Читаем результаты запроса построчно
                while (reader.Read())
                {
                    // Выводим данные каждой записи о доходе
                    Console.WriteLine($"ID дохода: {reader["IncomeID"]}, Дата: {reader["IncomeDate"]}, " +
                                      $"Сумма: {reader["Amount"]:C}");
                }
            }
        }
    }



    // Метод для добавления записи о предоставленной услуге в базу данных
    static void AddServiceRecord(OleDbConnection connection)
    {
        // Запрашиваем у пользователя дату предоставления услуги
        Console.Write("Введите дату предоставления услуги (дд-ММ-гггг): ");
        if (DateTime.TryParseExact(Console.ReadLine(), "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime serviceDate))
        {
            // Выводим список всех сотрудников
            PrintAllEmployees(connection);
            Console.Write("Введите ID сотрудника: ");
            if (int.TryParse(Console.ReadLine(), out int employeeId))
            {
                // Выводим список всех услуг
                PrintAllServices(connection);
                Console.Write("Введите ID услуги: ");
                if (int.TryParse(Console.ReadLine(), out int serviceId))
                {
                    // Выводим список всех клиентов
                    PrintAllClients(connection);
                    Console.Write("Введите ID клиента: ");
                    if (int.TryParse(Console.ReadLine(), out int clientId))
                    {
                        // Проверяем, существуют ли введенные ID сотрудника, услуги и клиента в соответствующих таблицах
                        if (DoesEmployeeExist(connection, employeeId) &&
                            DoesServiceExist(connection, serviceId) &&
                            DoesClientExist(connection, clientId))
                        {
                            // SQL-запрос для добавления записи о предоставленной услуге
                            string sqlInsert = "INSERT INTO ServiceRecords (ServiceDate, EmployeeID, ServiceID, ClientID) " +
                                               "VALUES (@ServiceDate, @EmployeeID, @ServiceID, @ClientID)";

                            // Создаем команду с SQL-запросом и соединением
                            using (OleDbCommand command = new OleDbCommand(sqlInsert, connection))
                            {
                                // Добавляем параметры в команду
                                command.Parameters.AddWithValue("@ServiceDate", serviceDate);
                                command.Parameters.AddWithValue("@EmployeeID", employeeId);
                                command.Parameters.AddWithValue("@ServiceID", serviceId);
                                command.Parameters.AddWithValue("@ClientID", clientId);

                                // Выполняем команду и получаем количество затронутых строк
                                int rowsAffected = command.ExecuteNonQuery();
                                // Если количество затронутых строк больше 0, значит, запись о предоставленной услуге была успешно добавлена
                                if (rowsAffected > 0)
                                    Console.WriteLine("Запись о предоставленной услуге успешно добавлена.");
                                // В противном случае выводим сообщение об ошибке
                                else
                                    Console.WriteLine("Не удалось добавить запись о предоставленной услуге.");
                            }
                        }
                        else
                        {
                            // Выводим сообщение об ошибке, если один или несколько введенных ID не существуют в соответствующих таблицах
                            Console.WriteLine("Один или несколько введенных ID не существуют в соответствующих таблицах.");
                        }
                    }
                    else
                    {
                        // Выводим сообщение об ошибке, если формат ID клиента был некорректным
                        Console.WriteLine("Неверный ID клиента.");
                    }
                }
                else
                {
                    // Выводим сообщение об ошибке, если формат ID услуги был некорректным
                    Console.WriteLine("Неверный ID услуги.");
                }
            }
            else
            {
                // Выводим сообщение об ошибке, если формат ID сотрудника был некорректным
                Console.WriteLine("Неверный ID сотрудника.");
            }
        }
        else
        {
            // Выводим сообщение об ошибке, если формат даты был некорректным
            Console.WriteLine("Неверный формат даты. Пожалуйста, введите дату в формате дд-ММ-гггг.");
        }
    }


    // Метод для проверки существования сотрудника с указанным ID в таблице Employees
    static bool DoesEmployeeExist(OleDbConnection connection, int employeeId)
    {
        // SQL-запрос для проверки количества сотрудников с указанным ID
        string sqlQuery = "SELECT COUNT(*) FROM Employees WHERE EmployeesID = @EmployeeID";
        using (OleDbCommand command = new OleDbCommand(sqlQuery, connection))
        {
            // Добавляем параметр в команду
            command.Parameters.AddWithValue("@EmployeeID", employeeId);
            // Выполняем команду и получаем количество сотрудников с указанным ID
            int count = Convert.ToInt32(command.ExecuteScalar());
            // Если количество больше 0, значит, сотрудник с указанным ID существует
            return count > 0;
        }
    }

    // Метод для проверки существования услуги с указанным ID в таблице Services
    static bool DoesServiceExist(OleDbConnection connection, int serviceId)
    {
        // SQL-запрос для проверки количества услуг с указанным ID
        string sqlQuery = "SELECT COUNT(*) FROM Services WHERE ServiceID = @ServiceID";
        using (OleDbCommand command = new OleDbCommand(sqlQuery, connection))
        {
            // Добавляем параметр в команду
            command.Parameters.AddWithValue("@ServiceID", serviceId);
            // Выполняем команду и получаем количество услуг с указанным ID
            int count = Convert.ToInt32(command.ExecuteScalar());
            // Если количество больше 0, значит, услуга с указанным ID существует
            return count > 0;
        }
    }

    // Метод для проверки существования клиента с указанным ID в таблице Clients
    static bool DoesClientExist(OleDbConnection connection, int clientId)
    {
        // SQL-запрос для проверки количества клиентов с указанным ID
        string sqlQuery = "SELECT COUNT(*) FROM Clients WHERE ClientID = @ClientID";
        using (OleDbCommand command = new OleDbCommand(sqlQuery, connection))
        {
            // Добавляем параметр в команду
            command.Parameters.AddWithValue("@ClientID", clientId);
            // Выполняем команду и получаем количество клиентов с указанным ID
            int count = Convert.ToInt32(command.ExecuteScalar());
            // Если количество больше 0, значит, клиент с указанным ID существует
            return count > 0;
        }
    }



    // Метод для фильтрации записей о предоставленных услугах по дате
    static void FilterServiceRecords(OleDbConnection connection)
    {
        // Запрашиваем у пользователя начальную дату для фильтрации
        Console.Write("Введите начальную дату (дд-ММ-гггг): ");
        if (!DateTime.TryParseExact(Console.ReadLine(), "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime startDate))
        {
            Console.WriteLine("Неверный формат даты. Пожалуйста, введите дату в формате дд-ММ-гггг.");
            return;
        }

        // Запрашиваем у пользователя конечную дату для фильтрации
        Console.Write("Введите конечную дату (дд-ММ-гггг): ");
        if (!DateTime.TryParseExact(Console.ReadLine(), "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime endDate))
        {
            Console.WriteLine("Неверный формат даты. Пожалуйста, введите дату в формате дд-ММ-гггг.");
            return;
        }

        // SQL-запрос для выборки записей о предоставленных услугах за указанный период
        string sqlFilter = "SELECT sr.ServiceRecordsID, sr.ServiceDate, e.EmployeesName, s.Name AS ServiceName, " +
                           "c.ClientName, c.ClientSurname " +
                           "FROM ServiceRecords sr " +
                           "INNER JOIN Employees e ON sr.EmployeeID = e.ID " +
                           "INNER JOIN Services s ON sr.ServiceID = s.ID " +
                           "INNER JOIN Clients c ON sr.ClientID = c.ClientID " +
                           "WHERE sr.ServiceDate BETWEEN @StartDate AND @EndDate";

        // Создаем команду с SQL-запросом и соединением
        using (OleDbCommand command = new OleDbCommand(sqlFilter, connection))
        {
            // Добавляем параметры в команду
            command.Parameters.AddWithValue("@StartDate", startDate);
            command.Parameters.AddWithValue("@EndDate", endDate);

            // Создаем объект OleDbDataReader для чтения строк результата SQL-запроса
            using (OleDbDataReader reader = command.ExecuteReader())
            {
                Console.WriteLine("Записи о предоставленных услугах:");
                // Читаем результаты запроса построчно
                while (reader.Read())
                {
                    // Выводим данные каждой записи о предоставленной услуге
                    Console.WriteLine($"ID записи: {reader["ServiceRecordsID"]}, Дата: {reader["ServiceDate"]}, " +
                                      $"Сотрудник: {reader["EmployeesName"]}, " +
                                      $"Услуга: {reader["ServiceName"]}, " +
                                      $"Клиент: {reader["ClientName"]} {reader["ClientSurname"]}");
                }
            }
        }
    }


    // Метод для добавления услуги в базу данных
    static void AddService(OleDbConnection connection)
    {
        // Запрашиваем у пользователя название услуги
        Console.Write("Введите название услуги: ");
        string serviceName = Console.ReadLine();
        // Запрашиваем у пользователя описание услуги
        Console.Write("Введите описание: ");
        string description = Console.ReadLine();
        // Запрашиваем у пользователя стоимость услуги
        Console.Write("Введите стоимость: ");
        decimal cost = Convert.ToDecimal(Console.ReadLine());

        // SQL-запрос для добавления услуги
        string sqlInsert = "INSERT INTO Services (ServiceName, Description, Cost) " +
                   "VALUES (@ServiceName, @Description, @Cost)";

        // Создаем команду с SQL-запросом и соединением
        using (OleDbCommand command = new OleDbCommand(sqlInsert, connection))
        {
            // Добавляем параметры в команду
            command.Parameters.AddWithValue("@ServiceName", serviceName);
            command.Parameters.AddWithValue("@Description", description);
            command.Parameters.AddWithValue("@Cost", cost);

            // Выполняем команду и получаем количество затронутых строк
            int rowsAffected = command.ExecuteNonQuery();
            // Если количество затронутых строк больше 0, значит, услуга была успешно добавлена
            if (rowsAffected > 0)
                Console.WriteLine("Услуга успешно добавлена.");
            // В противном случае выводим сообщение об ошибке
            else
                Console.WriteLine("Не удалось добавить услугу.");
        }
    }


    // Статический метод для удаления услуги
    static void DeleteService(OleDbConnection connection)
    {
        // Выводим сообщение, предлагающее ввести ID услуги для удаления
        Console.Write("Введите ID услуги для удаления: ");
        // Считываем ID услуги, введенный пользователем
        int serviceId = Convert.ToInt32(Console.ReadLine());

        // SQL-запрос для удаления услуги с заданным ID
        string sqlDelete = "DELETE FROM Services WHERE ServiceID = @ServiceId";

        // Создаем команду с SQL-запросом и соединением
        using (OleDbCommand command = new OleDbCommand(sqlDelete, connection))
        {
            // Добавляем параметр в команду
            command.Parameters.AddWithValue("@ServiceId", serviceId);

            // Выполняем команду и получаем количество затронутых строк
            int rowsAffected = command.ExecuteNonQuery();
            // Если количество затронутых строк больше 0, выводим сообщение об успешном удалении
            if (rowsAffected > 0)
                Console.WriteLine("Услуга успешно удалена.");
            // В противном случае выводим сообщение о том, что услуга не найдена или удаление не удалось
            else
                Console.WriteLine("Услуга не найдена или удаление не удалось.");
        }
    }


    static void FilterServices(OleDbConnection connection)
    {
        Console.Write("Enter part of the Service Name to filter: ");
        string filterText = Console.ReadLine();

        string sqlFilter = "SELECT * FROM Services WHERE Name LIKE @FilterText";

        using (OleDbCommand command = new OleDbCommand(sqlFilter, connection))
        {
            command.Parameters.AddWithValue("@FilterText", "%" + filterText + "%");

            using (OleDbDataReader reader = command.ExecuteReader())
            {
                Console.WriteLine("Services:");
                while (reader.Read())
                {
                    Console.WriteLine($"Service ID: {reader["ServiceID"]}, Name: {reader["Name"]}, " +
                                      $"Description: {reader["Description"]}, Cost: {reader["Cost"]:C}");
                }
            }
        }
    }

    static void PrintAllIncome(OleDbConnection connection)
    {
        string sqlQuery = "SELECT IncomeDate, Amount FROM Income";
        using (OleDbCommand command = new OleDbCommand(sqlQuery, connection))
        using (OleDbDataReader reader = command.ExecuteReader())
        {
            Console.WriteLine("+-------------------+-----------------------+");
            Console.WriteLine("|   Income Date     |   Amount (Currency)   |");
            Console.WriteLine("+-------------------+-----------------------+");

            while (reader.Read())
            {
                DateTime incomeDate = reader.GetDateTime(reader.GetOrdinal("IncomeDate"));
                decimal amount = reader.GetDecimal(reader.GetOrdinal("Amount"));

                Console.WriteLine($"| {incomeDate.ToString("yyyy-MM-dd"),-17} | {amount,-21:C} |");
            }

            Console.WriteLine("+-------------------+-----------------------+");
        }
    }

    static void FilterMenu(OleDbConnection connection)
    {
        while (true)
        {
            Console.WriteLine("Choose a filter option:");
            Console.WriteLine("#1 Filter Employees");
            Console.WriteLine("#2 Filter Services");
            Console.WriteLine("#3 Filter Clients");
            Console.WriteLine("#4 <--- Back");
            Console.Write("Enter your choice: ");
            string filterChoice = Console.ReadLine();

            switch (filterChoice)
            {
                case "1":
                    FilterEmployees(connection);
                    break;
                case "2":
                    FilterServices(connection);
                    break;
                case "3":
                    FilterClients(connection);
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void PrintAllServiceRecords(OleDbConnection connection)
    {
        string sqlQuery = "SELECT sr.ServiceRecordID, sr.ServiceDate, e.EmployeesName, s.ServiceName, c.ClientName, c.ClientSurname " +
          "FROM ((ServiceRecords sr " +
          "INNER JOIN Employees e ON sr.EmployeeID = e.EmployeesID) " +
          "INNER JOIN Services s ON sr.ServiceID = s.ServiceID) " +
          "INNER JOIN Clients c ON sr.ClientID = c.ClientID";



        using (OleDbCommand command = new OleDbCommand(sqlQuery, connection))
        using (OleDbDataReader reader = command.ExecuteReader())
        {
            Console.WriteLine("+----------------+------------------+-----------------+----------------+----------------+----------------+");
            Console.WriteLine("| ServiceRecordID|   Service Date   |   Employee Name  |   Service Name |   Client Name  |   Client Surname |");
            Console.WriteLine("+----------------+------------------+-----------------+----------------+----------------+----------------+");

            while (reader.Read())
            {
                int serviceRecordId = reader.GetInt32(reader.GetOrdinal("ServiceRecordID"));
                DateTime serviceDate = reader.GetDateTime(reader.GetOrdinal("ServiceDate"));
                string employeeName = reader["EmployeesName"].ToString();
                string serviceName = reader["ServiceName"].ToString();
                string clientName = reader["ClientName"].ToString();
                string clientSurname = reader["ClientSurname"].ToString();

                Console.WriteLine($"| {serviceRecordId,-15} | {serviceDate,-15} | {employeeName,-16} | {serviceName,-15} | {clientName,-15} | {clientSurname,-15} |");
            }

            Console.WriteLine("+----------------+------------------+-----------------+----------------+----------------+----------------+");
        }
    }

    static void PrintAllData(OleDbConnection connection)
    {
        Console.WriteLine("All table content:");
        PrintAllClients(connection);
        PrintAllEmployees(connection);
        PrintAllIncome(connection);
        PrintAllServices(connection);

    }
}
