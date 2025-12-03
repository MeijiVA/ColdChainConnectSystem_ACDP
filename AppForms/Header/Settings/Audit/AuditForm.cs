using ColdChainConnectSystem_ACDP.ClassResources;
using ColdChainConnectSystem_ACDP.ClassResources.Display;
using ColdChainConnectSystem_ACDP.ClassResources.Security;
using ColdChainConnectSystem_ACDP.Materials;
using ColdChainConnectSystem_ACDP.Popup;
using ExcelDataReader.Log;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.AppForms.Header.Settings.Audit
{
    public partial class AuditForm : Form
    {
        public AuditForm()
        {
            InitializeComponent();
        }

        String userQuery;
        String actionQuery;
        public void LoadAllLogEntriesIntoDataGridView(string UserQuery = "")
        {
            dgvTable.Rows.Clear();
            // SQL Query to select all data (no WHERE clause)
            string sqlQuery =
                "SELECT [NumID], [User], [Action], [Reference], [ReferenceID], [Description], [ActionDate] " +
                $"FROM [Audit] {userQuery} {actionQuery} ORDER BY [NumID] DESC;";
            try
            {
                using (SqlConnection connection = ConnectionClass.Connection())
                {
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        connection.Open();

                        // 2. Execute the command and get the SqlDataReader
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // 3. Loop through all results and manually populate the DataTable
                            while (reader.Read())
                            {

                                // Non-nullable columns
                                int num = reader.GetInt32(reader.GetOrdinal("NumID"));
                                String action = reader.GetString(reader.GetOrdinal("Action"));
                                String reference = reader.GetString(reader.GetOrdinal("Reference"));

                                // Nullable columns: Must check for DBNull before accessing the value
                                object user = reader.IsDBNull(reader.GetOrdinal("User")) ? DBNull.Value : (object)reader.GetString(reader.GetOrdinal("User"));
                                object refid = reader.IsDBNull(reader.GetOrdinal("ReferenceID")) ? DBNull.Value : (object)reader.GetString(reader.GetOrdinal("ReferenceID"));
                                object desc = reader.IsDBNull(reader.GetOrdinal("Description")) ? DBNull.Value : (object)reader.GetString(reader.GetOrdinal("Description"));
                                object date = reader.IsDBNull(reader.GetOrdinal("ActionDate")) ? DBNull.Value : (object)reader.GetDateTime(reader.GetOrdinal("ActionDate"));

                                dgvTable.Rows.Add(new object[] {num,user,action,reference,refid,desc,Convert.ToDateTime(date).ToString("yyyy-MM-dd")});
                            }
                        }
                    }
                }
                dgvTable.ClearSelection();
            }
            catch (Exception ex)
            {
               new CustomMessageBox($"Data Load Error",$"Database Error: Failed to load log entries.\nDetails: { ex.Message }", MessageBoxButtons.OK).ShowDialog();
            }
        }
        private void AuditForm_Load(object sender, EventArgs e)
        {
            userQuery = "";
            actionQuery = "";
            LoadAllLogEntriesIntoDataGridView();
        }
        private void cbxUser_Load(object sender, EventArgs e)
        {
            AuditLog.AddUsers(cbxUser);

        }

        public void SetWhereQuery()
        {

            switch (cbxUser.Texts)
            {
                case "All":
                    userQuery = "";
                    break;
                case "Filter":
                    userQuery = "";
                    break;
                default:
                    userQuery = "WHERE [User] = '" + cbxUser.Texts.ToString() + "'";
                    break;
            }

            if (userQuery == "")
            {
                switch (cbxAction.Texts)
                {
                    case "All":
                        userQuery = "";
                        break;
                    case "Filter":
                        actionQuery = "";
                        break;
                    default:
                        actionQuery = "WHERE [Action] = '" + cbxAction.Texts.ToString() + "'";
                        break;
                }
            }
            else
            {
                switch (cbxAction.Texts)
                {
                    case "All":
                        actionQuery = "";
                        break;
                    case "Filter":
                        actionQuery = "";
                        break;
                    default:
                        actionQuery = "AND [Action] = '" + cbxAction.SelectedItem.ToString() + "'";
                        break;
                }
            }
        }

        private void cbxAction_Load(object sender, EventArgs e)
        {
            AuditLog.AddAction(cbxAction);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SetWhereQuery();
            LoadAllLogEntriesIntoDataGridView();
        }
    }
}
