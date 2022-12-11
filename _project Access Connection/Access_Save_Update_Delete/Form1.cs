using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Access_Save_Update_Delete
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = new
        // OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\csharp\_db\Database_Files\csave.mdb");
        OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\csharp\_db\Database_Files\csave.accdb");
        // ver \Tutorial Conexão Access\connection string

        int checker;
        Bitmap bitmap = null;

        public Form1()
        {
            InitializeComponent();
            // para permitir enter = tab
            this.KeyPreview = true;
        }

        private void cleanTxts()
        {
            txtAddress.Text = "";
            txtFirstname.Text = "";
            txtPostcode.Text = "";
            txtStudentID.Text = "";
            txtSurname.Text = "";
            txtTelephone.Text = "";
        }

        private void dataViewer()
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM csave;";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);
                dataGridView1.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataViewer();
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO csave(StudentID, Firstname, Surname, Address, Postcode, Telephone) values('"
                    + txtStudentID.Text + "', '" + txtFirstname.Text + "', '" + txtSurname.Text + "', '"
                    + txtAddress.Text + "', '" + txtPostcode.Text + "', '" + txtTelephone.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro salvo em Database", "Access Connect", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();
                dataViewer();   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // para permitir enter = tab this.KeyPreview = true; na tab propriedades ou
            // adicionar no construtor do form
            e.Handled = true;
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            dataViewer();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirme que você quer sair", "Access Connect", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE csave SET StudentID='" + txtStudentID.Text 
                    + "' WHERE Firstname='" + txtFirstname.Text 
                    + "' AND Surname='" + txtSurname.Text + "';";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);
                dataGridView1.DataSource = dt;

                conn.Close();
                MessageBox.Show("Registro atualizado com sucesso!", "Access Connect",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataViewer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtStudentID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtFirstname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtSurname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtAddress.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtPostcode.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txtTelephone.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE * FROM csave WHERE StudentID='" + txtStudentID.Text + "';";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);
                dataGridView1.DataSource = dt;

                conn.Close();
                MessageBox.Show("Registro deletado com sucesso!", "Access Connect",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataViewer();
                cleanTxts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dataViewer();
            cleanTxts();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            checker = 0;

            try
            {
                conn.Open();

                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM csave WHERE StudentID='" + txtSearch.Text 
                    + "' OR Firstname='" + txtSearch.Text
                    + "' OR Surname='" + txtSearch.Text + "';";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);

                checker = Convert.ToInt32(dt.Rows.Count.ToString());

                dataGridView1.DataSource = dt;

                conn.Close();

                if (checker == 0)
                {
                    MessageBox.Show("Registro não encontrado.", "Access Connect",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                int height = dataGridView1.Height;
                dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
                bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
                dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                printPreviewDialog1.ShowDialog();
                dataGridView1.Height = height;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawImage(bitmap, 0, 0);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }
    }
}
