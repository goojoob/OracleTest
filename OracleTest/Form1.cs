using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OracleTest
{
    public partial class Form1 : Form
    {
        private Database oracleDB;
        private String sqlTest = "select sysdate from dual";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestOracle_Click(object sender, EventArgs e)
        {
            String ip = txtIP.Text;
            String port = txtPort.Text;
            String service = txtService.Text;
            String user = txtUser.Text;
            String pass = txtPass.Text;

            try
            {
                oracleDB = new Database(ip, port, service, user, pass);
                oracleDB.executeSQL(sqlTest);
                lblResultTest.Text = "TEST OK";
            }
            catch (Exception ex)
            {
                lblResultTest.Text = "Error: " + ex;
                MessageBox.Show("Error: " + ex, "Error Oracle Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
