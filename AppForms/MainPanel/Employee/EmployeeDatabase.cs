using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory;
using ColdChainConnectSystem_ACDP.ClassResources;
using ColdChainConnectSystem_ACDP.ClassResources.Connection;
using ColdChainConnectSystem_ACDP.ClassResources.CustomControls;
using ColdChainConnectSystem_ACDP.ClassResources.Display;
using ColdChainConnectSystem_ACDP.ClassResources.Instances;
using ColdChainConnectSystem_ACDP.Popup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ColdChainConnectSystem_ACDP.ClassResources.Connection.SqlInjectionPrevention;

namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Employee
{
    public partial class EmployeeDatabase : Form
    {
        private int currentPageIndex = 1;
        public int totalPages = 0;

        public EmployeeDatabase()
        {
            InitializeComponent();
            CustomizeSearchBar();
            this.DoubleBuffered = true;
        }

        private void EmployeeDatabase_Load(object sender, EventArgs e)
        {
            CurrentFormClass.form = "empdbform";
            SelectedFilterClass.SelectedFilter = "";
            dgvEmployee.Rows.Clear();
            totalPages = EmployeeClass.LoadEmployeeDatabase(dgvEmployee, lblMaxPage, lblPageNum, currentPageIndex);

            // subscribe to real-time search
            SearchBar.SearchTextChanged += SearchBar_SearchTextChanged;
            // checkbox header
            if (dgvEmployee.Columns["rowCbox"] != null)
            {
                dgvEmployee.Columns["rowCbox"].HeaderCell = new CheckBoxHeaderCell();
            }
        }

        private void SearchBar_SearchTextChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if ((SearchBar.txtSearch.Text.Equals("Search Term") || SearchBar.txtSearch.Text.Equals("")) &&
                (currentPageIndex < totalPages) || (SelectedFilterClass.SelectedFilter.Equals("") && (currentPageIndex < totalPages)))
            {
                dgvEmployee.Rows.Clear();
                lblPageNum.Text = (currentPageIndex += 1).ToString();
                totalPages = EmployeeClass.LoadEmployeeDatabase(dgvEmployee, lblMaxPage, lblPageNum, currentPageIndex);
            }
            else if ((currentPageIndex < totalPages))
            {
                dgvEmployee.Rows.Clear();
                lblPageNum.Text = (currentPageIndex += 1).ToString();
                string sanitizedSearch = SanitizeLikeInput(SearchBar.searchTXT);

                string query;
                if (!string.IsNullOrWhiteSpace(SelectedFilterClass.SelectedFilter))
                {
                    query = "WHERE " + SelectedFilterClass.SelectedFilter + " LIKE '%" + sanitizedSearch + "%' ";
                }
                else
                {
                    query = $"WHERE [empid] LIKE '%{sanitizedSearch}%' OR [username] LIKE '%{sanitizedSearch}%' OR [firstname] LIKE '%{sanitizedSearch}%' OR [lastname] LIKE '%{sanitizedSearch}%' OR [position] LIKE '%{sanitizedSearch}%' OR [status] LIKE '%{sanitizedSearch}%'";
                }

                totalPages = EmployeeClass.LoadEmployeeDatabase(dgvEmployee, lblMaxPage, lblPageNum, currentPageIndex, query);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if ((SearchBar.txtSearch.Text.Equals("Search Term") || SearchBar.txtSearch.Text.Equals("")) &&
                (currentPageIndex > 1) || (SelectedFilterClass.SelectedFilter.Equals("") && (currentPageIndex > 1)))
            {
                dgvEmployee.Rows.Clear();
                lblPageNum.Text = (currentPageIndex -= 1).ToString();
                totalPages = EmployeeClass.LoadEmployeeDatabase(dgvEmployee, lblMaxPage, lblPageNum, currentPageIndex);
            }
            else if (currentPageIndex > 1)
            {
                dgvEmployee.Rows.Clear();
                lblPageNum.Text = (currentPageIndex -= 1).ToString();
                string sanitizedSearch = SanitizeLikeInput(SearchBar.searchTXT);

                string query;
                if (!string.IsNullOrWhiteSpace(SelectedFilterClass.SelectedFilter))
                {
                    query = "WHERE " + SelectedFilterClass.SelectedFilter + " LIKE '%" + sanitizedSearch + "%' ";
                }
                else
                {
                    query = $"WHERE [empid] LIKE '%{sanitizedSearch}%' OR [username] LIKE '%{sanitizedSearch}%' OR [firstname] LIKE '%{sanitizedSearch}%' OR [lastname] LIKE '%{sanitizedSearch}%' OR [position] LIKE '%{sanitizedSearch}%' OR [status] LIKE '%{sanitizedSearch}%'";
                }

                totalPages = EmployeeClass.LoadEmployeeDatabase(dgvEmployee, lblMaxPage, lblPageNum, currentPageIndex, query);
            }
        }

        public void UpdateTable()
        {
            try
            {
                if (SearchBar.txtSearch.Text.Equals("Search Term") || SearchBar.txtSearch.Text.Equals(""))
                {
                    lblPageNum.Text = "1";
                    currentPageIndex = 1;
                    dgvEmployee.Rows.Clear();
                    totalPages = EmployeeClass.LoadEmployeeDatabase(dgvEmployee, lblMaxPage, lblPageNum, currentPageIndex);
                }
                else
                {
                    lblPageNum.Text = "1";
                    currentPageIndex = 1;
                    dgvEmployee.Rows.Clear();
                    string sanitizedSearch = SanitizeLikeInput(SearchBar.searchTXT);

                    string query;
                    if (string.IsNullOrWhiteSpace(SelectedFilterClass.SelectedFilter))
                    {
                        query = $"WHERE [empid] LIKE '%{sanitizedSearch}%' OR [username] LIKE '%{sanitizedSearch}%' OR [firstname] LIKE '%{sanitizedSearch}%' OR [lastname] LIKE '%{sanitizedSearch}%' OR [position] LIKE '%{sanitizedSearch}%' OR [status] LIKE '%{sanitizedSearch}%'";
                    }
                    else
                    {
                        query = "WHERE " + SelectedFilterClass.SelectedFilter + " LIKE '%" + sanitizedSearch + "%' ";
                    }

                    totalPages = EmployeeClass.LoadEmployeeDatabase(dgvEmployee, lblMaxPage, lblPageNum, currentPageIndex, query);
                }
            }
            catch (Exception ex)
            {
                new CustomMessageBox("Error", ex.Message, MessageBoxButtons.OK).ShowDialog();
            }
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // header checkbox handling
            if (e.RowIndex == -1 && e.ColumnIndex == 0)
            {
                bool allChecked = true;
                foreach (DataGridViewRow row in dgvEmployee.Rows)
                {
                    if (row.Cells[0].Value == null || !(bool)row.Cells[0].Value)
                    {
                        allChecked = false;
                        break;
                    }
                }

                foreach (DataGridViewRow row in dgvEmployee.Rows)
                {
                    row.Cells[0].Value = !allChecked;
                }
                dgvEmployee.RefreshEdit();
                return;
            }

            if (e.RowIndex < 0) return;

            if (dgvEmployee.Columns[e.ColumnIndex].Name == "unarchiveCol")
            {
                string empId = Convert.ToString(dgvEmployee.Rows[e.RowIndex].Cells["empid"].FormattedValue);
                string status = Convert.ToString(dgvEmployee.Rows[e.RowIndex].Cells["status"].FormattedValue);

                if (!string.Equals(status, "Archived", StringComparison.OrdinalIgnoreCase))
                {
                    return;
                }

                if (new CustomMessageBox("Unarchive Employee",
                        $"Are you sure you want to unarchive employee {empId}?",
                        MessageBoxButtons.OKCancel).ShowDialog() == DialogResult.OK)
                {
                    bool success = EmployeeClass.UnarchiveEmployee(empId);
                    if (success)
                    {
                        new CustomMessageBox("Success", "Employee unarchived successfully!", MessageBoxButtons.OK).ShowDialog();
                        UpdateTable();
                        // also refresh main employee list if open
                        if (EmployeeInstance.i != null)
                        {
                            EmployeeInstance.i.LoadAllEmployees();
                        }
                    }
                }
            }
        }

        private void dgvEmployee_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvEmployee.Columns[e.ColumnIndex].Name == "status" && e.RowIndex >= 0)
            {
                if (dgvEmployee.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    string status = dgvEmployee.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToLower();
                    if (status == "active")
                    {
                        e.CellStyle.BackColor = Color.FromArgb(200, 255, 200);
                        e.CellStyle.ForeColor = Color.FromArgb(107, 188, 59);
                    }
                    else if (status == "inactive")
                    {
                        e.CellStyle.BackColor = Color.FromArgb(255, 255, 200);
                        e.CellStyle.ForeColor = Color.FromArgb(255, 27, 20);
                    }
                    else if (status == "archived")
                    {
                        e.CellStyle.BackColor = Color.FromArgb(220, 220, 220);
                        e.CellStyle.ForeColor = Color.FromArgb(115, 115, 115);
                    }
                }
            }
        }
        private void CustomizeSearchBar()
        {
          
            SearchBar.btnAddItem.Visible = false;
            SearchBar.btnExport.Visible = false;
            SearchBar.btnImport.Visible = false;
        }

    
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
          
            if (dgvEmployee.Columns[e.ColumnIndex].Name == "Status")
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();
                    if (status.Equals("Inactive", StringComparison.OrdinalIgnoreCase))
                    {
                        e.CellStyle.ForeColor = Color.Red;
                        e.CellStyle.SelectionForeColor = Color.Red;
                    }
                    else if (status.Equals("Active", StringComparison.OrdinalIgnoreCase))
                    {
                        e.CellStyle.ForeColor = Color.Green; // Optional: Make Active green
                    }
                }
            }
        }
        private void dgvEmployee_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
        
            e.ThrowException = false;
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmployee.Columns[e.ColumnIndex].Name == "btnUnarchive" && e.RowIndex >= 0)
            {
                List<string> idsToUnarchive = new List<string>();
                foreach (DataGridViewRow row in dgvEmployee.Rows)
                {

                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        idsToUnarchive.Add(row.Cells[1].Value.ToString());
                    }
                }

                if (idsToUnarchive.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to unarchive these employees?", "Unarchive Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {


                        // Refresh the grid
                        EmployeeInstance.i.LoadAllEmployees();
                    }
                }
                else
                {
                    MessageBox.Show("Please select employees to unarchive.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}


