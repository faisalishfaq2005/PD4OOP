using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace problem
{
    internal class Database
    {
        public string Name { get; private set; }
        public List<Table> Tables { get; private set; }

        // Constructor
        public Database(string name)
        {
            Name = name;
            Tables = new List<Table>();
        }

        // Method to create a new table
        public void CreateTable(string tableName, List<string> columnNames)
        {
            // Check if a table with the same name already exists
            if (Tables.Exists(t => t.Name == tableName))
            {
                Console.WriteLine($"Table '{tableName}' already exists in the database.");
            }
            else
            {
                // Create a new table and add it to the database
                Table table = new Table(tableName);
                foreach (string columnName in columnNames)
                {
                    table.AddColumn(columnName);
                }
                Tables.Add(table);
            }
        }

        // Method to drop a table
        public void DropTable(string tableName)
        {
            Table tableToRemove = Tables.Find(t => t.Name == tableName);
            if (tableToRemove != null)
            {
                Tables.Remove(tableToRemove);
                Console.WriteLine($"Table '{tableName}' dropped successfully.");
            }
            else
            {
                Console.WriteLine($"Table '{tableName}' does not exist in the database.");
            }
        }
    }
}
