using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem
{
    internal class table
    {
        public string Name { get; private set; }
        public List<Column> Columns { get; private set; }
        public List<Row> Rows { get; private set; }

        // Constructor
        public Table(string name)
        {
            Name = name;
            Columns = new List<Column>();
            Rows = new List<Row>();
        }

        // Method to add a column to the table
        public void AddColumn(string columnName)
        {
            Columns.Add(new Column(columnName));
        }

        // Method to add a row to the table
        public void AddRow(List<string> values)
        {
            if (values.Count != Columns.Count)
            {
                throw new ArgumentException("Number of values must match the number of columns.");
            }
            Rows.Add(new Row(values));
        }

        // Method to display information about the table
        public void DisplayTableInfo()
        {
            Console.WriteLine($"Table Name: {Name}");
            Console.WriteLine("Columns:");
            foreach (Column column in Columns)
            {
                Console.WriteLine($"- {column.Name}");
            }
            Console.WriteLine("Rows:");
            foreach (Row row in Rows)
            {
                Console.WriteLine("- " + string.Join(", ", row.Values));
            }
        }
    }
}
