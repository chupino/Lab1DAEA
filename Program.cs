using System;
using System.Collections.Generic;

class Program
{
    static List<string> tasks = new List<string>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Gestión de Tareas");
            Console.WriteLine("1. Agregar Tarea");
            Console.WriteLine("2. Listar Tareas");
            Console.WriteLine("3. Eliminar Tarea");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ListTasks();
                    break;
                case "3":
                    RemoveTask();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    break;
            }
        }
    }

    static void AddTask()
    {
        Console.Write("Ingrese la tarea: ");
        string task = Console.ReadLine();
        tasks.Add(task);
        Console.WriteLine("Tarea agregada.\n");
    }

    static void ListTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No hay tareas en la lista.\n");
        }
        else
        {
            Console.WriteLine("Tareas:");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
            Console.WriteLine();
        }
    }

    static void RemoveTask()
    {
        ListTasks();
        if (tasks.Count > 0)
        {
            Console.Write("Ingrese el número de la tarea a eliminar: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
            {
                tasks.RemoveAt(taskNumber - 1);
                Console.WriteLine("Tarea eliminada.\n");
            }
            else
            {
                Console.WriteLine("Número de tarea inválido.\n");
            }
        }
    }
}
