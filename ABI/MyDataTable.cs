using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABI
{
    public class MyDataTable
    {
        DataTable table;

        DataColumn column;
        DataRow row;
        public MyDataTable()
        {
            table = new DataTable("ClientTable");
        }

        private void MakeClientTable()
        {
            column = new DataColumn();
            column.DataType = typeof(System.Int32);
            column.ColumnName = "id Client";
            column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = "Raison Social";
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = "Type";
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = "Activite";
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = "Nature";
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(System.Int32);
            column.ColumnName = "Effectif";
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(System.Decimal);
            column.ColumnName = "CA";
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = "Ville";
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = "Téléphone";
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(System.String);
            column.ColumnName = "Commentaire";
            column.ReadOnly = false;
            column.Unique = false;
            column.AutoIncrement = false;
            table.Columns.Add(column);

        }

        public void addRow(Client client)
        {
            
        }

    }
    
}
