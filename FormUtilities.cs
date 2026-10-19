using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VehicleRentalSystem
{
    internal static class FormUtilities
    {
        public static SqlParameter P(string parameterName, object value)
        {
            return new SqlParameter(parameterName, value ?? DBNull.Value);
        }

        public static void Bind(DataGridView grid, DataTable table)
        {
            grid.AutoGenerateColumns = true;
            grid.DataSource = table;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.ReadOnly = true;
        }

        public static string Cell(DataGridView grid, string columnName)
        {
            if (grid.CurrentRow == null || !grid.Columns.Contains(columnName))
            {
                return "";
            }

            object value = grid.CurrentRow.Cells[columnName].Value;
            if (value == null || value == DBNull.Value)
            {
                return "";
            }

            return Convert.ToString(value);
        }

        public static void Error(Exception exception)
        {
            MessageBox.Show(
                exception.Message,
                "Vehicle Rental System",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        public static bool Confirm(string message)
        {
            DialogResult answer = MessageBox.Show(
                message,
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return answer == DialogResult.Yes;
        }
    }
}
