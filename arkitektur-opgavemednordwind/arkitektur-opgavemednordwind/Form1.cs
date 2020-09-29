using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using arkitektur_opgavemednordwind.Properties;

namespace arkitektur_opgavemednordwind
{
    public partial class Form1 : Form
    {
        private byte[] rowversion;
        private SqlConnection connection;
        private SqlTransaction transaction;
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_select_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(Settings.Default.ConnectionString))
            {
                var cmd = new SqlCommand(" SELECT CustomerID, CompanyName, rowversion " + " FROM Customers " + " WHERE CustomerID = @CustomerID");

                SqlParameter p1 = new SqlParameter("@CustomerID", SqlDbType.NChar, 5);
                p1.Value = text_CustId.Text;

                cmd.Parameters.Add(p1);
                cmd.Connection = conn;

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                rowversion = (byte[]) reader["rowversion"];
                text_custName.Text = (string)reader["CompanyName"];

                reader.Close();
                conn.Close();
            }
        }

        private void Bt_update_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(Settings.Default.ConnectionString))
            {
                var cmd = new SqlCommand(" UPDATE [dbo].[Customers] " + " SET CompanyName = @CompanyName " + " WHERE CustomerID = @CustomerID AND rowversion = @rowversion ");

                SqlParameter p1 = new SqlParameter("@CustomerID", SqlDbType.NChar, 5);
                p1.Value = text_CustId.Text;

                SqlParameter p2 = new SqlParameter("@CustomerID", SqlDbType.NVarChar, 40);
                p2.Value = text_custName.Text;

                SqlParameter p3 = new SqlParameter("@rowversion", SqlDbType.Timestamp);
                p3.Value = rowversion;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Connection = conn;

                conn.Open();
                int antal = cmd.ExecuteNonQuery();
                if(antal>0) //ok ellers
                {
                    MessageBox.Show("Gennemført", "besked", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Fejl - data var blevet opdateret af en anden bruger", "besked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
                conn.Close();
            }
        }

        private void bt_trans_begin_Click(object sender, EventArgs e)
        {
            bt_trans_begin.Enabled = false;
            connection = new SqlConnection(Settings.Default.ConnectionString);
            connection.Open();
            transaction = connection.BeginTransaction(IsolationLevel.RepeatableRead);
        }



        private void bt_trans_select_Click(object sender, EventArgs e)
        {
            bt_trans_select.Enabled = false;

            SqlDataReader reader = null;

            var cmd = new SqlCommand(" SELECT CustomerID, CompanyName, rowversion " + " FROM Customers " + " WHERE CustomerID = @CustomerID");

            SqlParameter p1 = new SqlParameter("@CustomerID", SqlDbType.NChar, 5);
            p1.Value = txt_trans_custid.Text;

            cmd.Parameters.Add(p1);

            cmd.Connection = connection;
            cmd.Transaction = transaction;

            try
            {
                reader = cmd.ExecuteReader();
                reader.Read();
               txt_trans.Text = (string)reader["CompanyName"];
            }
            catch (Exception ee)
            {
                
            }
            finally
            {
                if(reader !=null)
                reader.Close();
            }
        }

        private void bt_trans_update_Click(object sender, EventArgs e)
        {
            bt_trans_update.Enabled = false;

            var cmd = new SqlCommand(" UPDATE [dbo].[Customers] " + " SET CompanyName = @CompanyName " + " WHERE CustomerID = @CustomerID ");

            SqlParameter p1 = new SqlParameter("@CustomerID", SqlDbType.NChar, 5);
            p1.Value = txt_trans_custid.Text;

            SqlParameter p2 = new SqlParameter("@CompanyName", SqlDbType.NVarChar, 40);
            p2.Value = txt_trans.Text;

          

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);

            cmd.Connection = connection;
            cmd.Transaction=transaction;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ee)
            {
                MessageBox.Show("fejl:" + ee.Message, "besked", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void bt_commit_Click(object sender, EventArgs e)
        {
            bt_commit.Enabled = false;

            try
            {
                transaction.Commit();
                MessageBox.Show("Gennemført", "besked", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ee)
            {
                try
                {
                    transaction.Rollback();

                }
                catch (Exception)
                {
                    MessageBox.Show("fejl:" + ee.Message, "besked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {

                connection.Close();
            }
        }

        private void bt_trans_reset_Click(object sender, EventArgs e)
        {
            bt_trans_begin.Enabled = true;
            bt_trans_select.Enabled = true;
            bt_trans_update.Enabled = true;
            bt_commit.Enabled = true;

            try
            {
                connection.Close();

            }
            catch (Exception)
            {

            }
            try
            {
                connection.Dispose();
            }
            catch (Exception)
            {

            }
        }

        
    }
}
