using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Record_System.Gateways;
using SQLite;

namespace Record_System
{
    public partial class recordSystem : Form
    {
        public recordSystem()
        {
            InitializeComponent();
        }

        private void recordSystem_Load(object sender, EventArgs e)
        {
            //Call init method.
            Initialise();
        }
        /**
         * Call initial methods required for the program.
         */
        private void Initialise()
        {
            moduleCheck();
        }

        /**
         * Determine which modules are active in order to display their menus. 
         */
        private void moduleCheck()
        {
            try
            {

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void initConnection()
        {
            try
            {
               
            }
            catch (Exception e)
            {
                Library.ErrorHandler(e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Gateways.Gateway gateway = new Gateway();

                SqlConnection conn = gateway.GetConnection();
                conn.Open();
                MessageBox.Show("Connection open!");
                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                throw;
            }
            
        }
    }
}
