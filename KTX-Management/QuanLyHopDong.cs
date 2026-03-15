using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace KTX_Management
{
    public partial class QuanLyHopDong : Form
    {
        public QuanLyHopDong()
        {
            InitializeComponent();
            BangTimKiemNangCao.Visible = false;
        }

        private void btnDeleteKeyWords_Click(object sender, EventArgs e)
        {
            // Clear all search inputs and results
            ClearSearchFields();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbtnTImKiemNangCao_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbtnTImKiemNangCao.Checked)
            {
                BangTimKiemNangCao.Visible = true;
            }
            else
            {
                BangTimKiemNangCao.Visible = false;
            }
        }

        private async void btnSearchHD_Click(object sender, EventArgs e)
        {
            // Build query and parameters from current inputs
            var (sql, parameters) = BuildSearchQuery();

            try
            {
                // Open connection asynchronously to avoid blocking UI
                using var conn = new SqlConnection(GetConnectionString());
                using var cmd = new SqlCommand(sql, conn);
                if (parameters.Any())
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                }

                await conn.OpenAsync();
                using var reader = await cmd.ExecuteReaderAsync();

                // Load results into a DataTable and bind to grid
                var table = new DataTable();
                table.Load(reader);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                // Keep user-facing error message
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Get connection string: prefer environment variable then fallback to local default
        private string GetConnectionString()
        {
            return Environment.GetEnvironmentVariable("CONN_STR_QUANLYKTX")
                   ?? "Data Source=.;Initial Catalog=QUANLYKTX;Integrated Security=True;TrustServerCertificate=True";
        }

        // Build query string and parameters from current form inputs.
        // Keeps SQL parameterization to avoid SQL injection and centralizes mapping.
        private (string sql, List<SqlParameter> parameters) BuildSearchQuery()
        {
            var sqlBuilder = new StringBuilder("SELECT * FROM HopDong WHERE 1=1");
            var parameters = new List<SqlParameter>();

            // basic name search
            if (!string.IsNullOrWhiteSpace(TenSVtxb.Text))
            {
                sqlBuilder.Append(" AND TenSV LIKE @tenSV");
                parameters.Add(new SqlParameter("@tenSV", SqlDbType.NVarChar) { Value = "%" + TenSVtxb.Text.Trim() + "%" });
            }

            // advanced search (only when enabled)
            if (rdbtnTImKiemNangCao.Checked)
            {
                if (!string.IsNullOrWhiteSpace(txbMSV.Text))
                {
                    sqlBuilder.Append(" AND MaSV = @msv");
                    parameters.Add(new SqlParameter("@msv", SqlDbType.NVarChar) { Value = txbMSV.Text.Trim() });
                }

                if (!string.IsNullOrWhiteSpace(txbContractNumber.Text))
                {
                    sqlBuilder.Append(" AND MaHopDong = @mahd");
                    parameters.Add(new SqlParameter("@mahd", SqlDbType.NVarChar) { Value = txbContractNumber.Text.Trim() });
                }

                if (!string.IsNullOrWhiteSpace(txbSignedDate.Text))
                {
                    // try to parse date; if fails, treat as string
                    if (DateTime.TryParse(txbSignedDate.Text.Trim(), out var dt))
                    {
                        sqlBuilder.Append(" AND NgayKy = @ngayky");
                        parameters.Add(new SqlParameter("@ngayky", SqlDbType.Date) { Value = dt.Date });
                    }
                    else
                    {
                        sqlBuilder.Append(" AND NgayKy LIKE @ngaykyStr");
                        parameters.Add(new SqlParameter("@ngaykyStr", SqlDbType.NVarChar) { Value = "%" + txbSignedDate.Text.Trim() + "%" });
                    }
                }

                if (!string.IsNullOrWhiteSpace(txbRoomNumber.Text))
                {
                    sqlBuilder.Append(" AND SoPhong = @sophong");
                    parameters.Add(new SqlParameter("@sophong", SqlDbType.NVarChar) { Value = txbRoomNumber.Text.Trim() });
                }

                if (rdbtnCtAvail.Checked)
                {
                    sqlBuilder.Append(" AND TinhTrang = @tinhtrang");
                    parameters.Add(new SqlParameter("@tinhtrang", SqlDbType.NVarChar) { Value = "Vẫn còn" });
                }
                else if (rdbtnCtNotAvail.Checked)
                {
                    sqlBuilder.Append(" AND TinhTrang = @tinhtrang");
                    parameters.Add(new SqlParameter("@tinhtrang", SqlDbType.NVarChar) { Value = "Không còn" });
                }
            }

            return (sqlBuilder.ToString(), parameters);
        }

        // Clear search inputs and results (extracted to reuse from delete handler)
        private void ClearSearchFields()
        {
            // Clear basic search
            TenSVtxb.Text = string.Empty;

            // Clear advanced search fields
            txbMSV.Text = string.Empty;
            txbContractNumber.Text = string.Empty;
            txbSignedDate.Text = string.Empty;
            txbRoomNumber.Text = string.Empty;

            // Reset radio buttons and hide advanced panel
            rdbtnTImKiemNangCao.Checked = false;
            rdbtnCtAvail.Checked = false;
            rdbtnCtNotAvail.Checked = false;
            BangTimKiemNangCao.Visible = false;

            // Clear results grid
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
        }
    }
}
