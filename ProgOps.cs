using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DowningM_FinalProject
{
    class ProgOps
    {
        //connection string to books database
        private const string CONNECT_STRING = @"Server=cstnt.tstc.edu;Database=MadMaxGaming_MD_2353SU21;User Id=mdowningsu212353;password=1841116";
        //build a connection to database
        private static SqlConnection _cntProductsDatabase = new SqlConnection(CONNECT_STRING);
        //add the command object
        private static SqlCommand _sqlProductsCommand;
        //add the data adapter
        private static SqlDataAdapter _daProducts = new SqlDataAdapter();
        private static SqlDataAdapter _daProducts2 = new SqlDataAdapter();
        //add the data table
        private static DataTable _dtProductsTable = new DataTable();
        private static DataTable _dtProductsTable2 = new DataTable();
        private static StringBuilder _errorMessages = new StringBuilder();

        //**************3 different List to store data from Selections in dgvMain
        private static List<string> _productID = new List<string>();
        private static List<string> _name = new List<string>();
        private static List<string> _quantity = new List<string>();
        private static List<string> _pricePerUnit = new List<string>();
        private static List<string> _totalPriceLine = new List<string>();

        //progops getter
        public static DataTable DTProductsTable
        {
            get { return _dtProductsTable; }
        }

        public static DataTable DTProductsTable2
        {
            get { return _dtProductsTable2; }
        }

        //***********Getters and Setters for List for dgvMain     
        public static List<string> ProductID
        {
            get { return _productID; }
            set { _productID = value; }
        }
        public static List<string> Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public static List<string> Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        public static List<string> Price_Per_Unit
        {
            get { return _pricePerUnit; }
            set { _pricePerUnit = value; }
        }
        public static List<string> Total_Price_Per_Line
        {
            get { return _totalPriceLine; }
            set { _totalPriceLine = value; }
        }

        public static void OpenDatabase()
        {
            //method to open database
            try
            {
                //open the connection to phone database
                if(_cntProductsDatabase.State != ConnectionState.Open)
                {
                    _cntProductsDatabase.Open();
                }

                //message stating that connection to database was successful
                MessageBox.Show("Connection to database was successfully opened.", "Database Connection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                if (ex is SqlException)
                {//handles more specific SqlException here.
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        _errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(_errorMessages.ToString(), "Error Open Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message + "Error (PO1)", "Error Open Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void CloseDisposeDatabase()
        {
            //method to close database and dispose of the connection object
            try
            {
                //close connection
                _cntProductsDatabase.Close();
                //message stating that connection to database was successful
                MessageBox.Show("Connection to database was successfully closed.", "Database Connection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                //dispose of the sql objects
                _cntProductsDatabase.Dispose();
                _sqlProductsCommand.Dispose();
                _daProducts.Dispose();
                _dtProductsTable.Dispose();
            }
            catch (SqlException ex)
            {
                if (ex is SqlException)
                {//handles more specific SqlException here.
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        _errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(_errorMessages.ToString(), "Error Close Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message + "Error (PO2)", "Error Close Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void ProductCommand(ComboBox cbMain, DataGridView dvMain)
        {
            //statement for the datagridview
            string sqlStatement = "Select * From Products";
            _sqlProductsCommand = new SqlCommand(sqlStatement, _cntProductsDatabase);
            _daProducts.SelectCommand = _sqlProductsCommand;
            _daProducts.Fill(_dtProductsTable);
            dvMain.DataSource = _dtProductsTable;

            //statement for the combo box
            string sqlStatement2 = "Select Video_QuantityOnHand From Products Where Video_Game_UPC = '" + dvMain.CurrentRow.Cells[0].Value.ToString() + "';";
            _sqlProductsCommand = new SqlCommand(sqlStatement2, _cntProductsDatabase);
            _daProducts2.SelectCommand = _sqlProductsCommand;
            _daProducts2.Fill(_dtProductsTable2);
            for (int i = 0; i <= Convert.ToInt32(_dtProductsTable2.Rows[0]["Video_QuantityOnHand"].ToString()); i++)
            {
                cbMain.Items.Add(i);
            }
        }

        public static void ComboCommand(ComboBox cbMain, DataGridView dvMain)
        {
            cbMain.Items.Clear();
            //statement for the combo box
            string sqlStatement2 = "Select Video_QuantityOnHand From Products Where Video_Game_UPC = '" + dvMain.CurrentRow.Cells[0].Value.ToString() + "';";
            _sqlProductsCommand = new SqlCommand(sqlStatement2, _cntProductsDatabase);
            //resets the data adapter
            _daProducts2 = new SqlDataAdapter();
            _daProducts2.SelectCommand = _sqlProductsCommand;
            //resets the datatable
            _dtProductsTable2 = new DataTable();
            _daProducts2.Fill(_dtProductsTable2);
            for (int i = 0; i <= Convert.ToInt32(_dtProductsTable2.Rows[0]["Video_QuantityOnHand"].ToString()); i++)
            {
                cbMain.Items.Add(i);
            }

        }

        public static void AddToCart(DataGridView dv2)
        {
            //shopping cart
            dv2.ColumnCount = 4;
            //int total = 0;
            // dv2.Columns[0].Name = "ProductID";
            dv2.Columns[0].Name = "Game_Title";
            dv2.Columns[1].Name = "Price_Per_Unit";
            dv2.Columns[2].Name = "Quantity";
            dv2.Columns[3].Name = "Total_Price_Per_Line";

            for (int i = 0; i < Name.Count; i++)
            {
                int rowId = dv2.Rows.Add();
                dv2.Rows[rowId].Cells[0].Value = Name[i].ToString();
                dv2.Rows[rowId].Cells[1].Value = Price_Per_Unit[i].ToString();
                dv2.Rows[rowId].Cells[2].Value = Quantity[i].ToString();
                dv2.Rows[rowId].Cells[3].Value = Total_Price_Per_Line[i].ToString();
            }
        }
        public static void Amount(string qty, DataGridView dv1)
        {
            string sqlStatement = "Update Video_Games SET Video_QuantityOnHand = Video_QuantityOnHand - '" + qty + "' Where Video_Game_UPC = '" + dv1.CurrentRow.Cells[0].Value.ToString() + "';";
            _sqlProductsCommand = new SqlCommand(sqlStatement, _cntProductsDatabase);
            _daProducts.SelectCommand = _sqlProductsCommand;
            _daProducts2.Fill(_dtProductsTable2);

        }
        public static void Totals(DataGridView dv2, Label subtotal, Label tx, Label nt)
        {
            double subTotal = 0;
            double chargeTax = .0825;
            double tax = 0;
            double net = 0;

            for (int i = 0; i < Total_Price_Per_Line.Count(); i++)
            {
                subTotal += Convert.ToDouble(Total_Price_Per_Line[i]);
            }
            tax = subTotal * chargeTax;
            net = subTotal + tax;
            subtotal.Text = subTotal.ToString("C");
            tx.Text = tax.ToString("C");
            nt.Text = net.ToString("C");
        }
        public static void DGVMainClickData(DataGridView dv1, ComboBox cb1)
        {
            //add to cart
            Name.Add(dv1.CurrentRow.Cells[1].Value.ToString());
            Price_Per_Unit.Add(dv1.CurrentRow.Cells[3].Value.ToString());
            Quantity.Add(cb1.SelectedItem.ToString());
            int total = 0;
            total = Convert.ToInt32(dv1.CurrentRow.Cells[3].Value) * Convert.ToInt32(cb1.SelectedItem);
            Total_Price_Per_Line.Add(total.ToString());
        }

        public static void DGVClear(DataGridView dv4)
        {
            Price_Per_Unit.Clear();
            Name.Clear();
            Quantity.Clear();
        }
        public static void Remove(DataGridView dv2)
        {
            string sqlStatement = "Update Video_Games SET Video_QuantityOnHand = Video_QuantityOnHand + '" + dv2.CurrentRow.Cells[2].Value.ToString() + "' Where Video_Title = '" + dv2.CurrentRow.Cells[0].Value.ToString() + "';";
            _sqlProductsCommand = new SqlCommand(sqlStatement, _cntProductsDatabase);
            _daProducts.SelectCommand = _sqlProductsCommand;
            _daProducts2.Fill(_dtProductsTable2);

            Name.Remove(dv2.CurrentRow.Cells[0].Value.ToString());
            Price_Per_Unit.Remove(dv2.CurrentRow.Cells[1].Value.ToString());
            Quantity.Remove(dv2.CurrentRow.Cells[2].Value.ToString());
            Total_Price_Per_Line.Remove(dv2.CurrentRow.Cells[3].Value.ToString());
        }
    }
}

