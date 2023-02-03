using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace adonet_03_2_2023_2
{
    public partial class Form1 : Form
    {
        private string _connectionString;
        private DataSet _dataSet;
        private SqlDataAdapter _dataAdapter;

        public Form1()
        {
            InitializeComponent();
            _connectionString = ConfigurationManager
                .ConnectionStrings["DefaultConnection"]
                .ConnectionString;
            _dataAdapter = new();   // ����� � ���
            _dataSet = new DataSet();  // � ���
            GetData();
        }
        private void GetData()
        {
            _dataSet = new DataSet();
            var getAllTablesTExt =
                "select * from Goods;" +
                "select * from Supliers;" +
                "select * from Deliveries;";
            var connection = new  SqlConnection(_connectionString);
            _dataAdapter = new SqlDataAdapter(getAllTablesTExt, connection);
            _dataAdapter.TableMappings.Add("Table","Goods");
            _dataAdapter.TableMappings.Add("Table1", "Supliers");
            _dataAdapter.TableMappings.Add("Table2", "Deliveries");
            _dataAdapter.Fill(_dataSet);


        }
        private void btn_fill_Click(object sender, EventArgs e)
        {
            try
            {
                _dataSet= new DataSet();
                // ������� �����������
                var connection = new SqlConnection(_connectionString);
                //����� ������� �� ����� ����
                var commandText = txt_comand.Text;

                //����� �������
                _dataAdapter = new SqlDataAdapter(commandText, connection);

                // �������� ����
                mainGrid.DataSource = null;
                //��������� �������
                _dataAdapter.Fill(_dataSet,"authors");
                //�������� ���� DataSet
                mainGrid.DataSource = _dataSet.Tables["authors"];
                TestConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }
            private void TestConnection()
            {
                var connection = new SqlConnection(_connectionString);
                try
                {
                    connection.Open();
                    MessageBox.Show("����������� �����������");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //Close();
                }
                finally
                {
                    connection.Close();
                }
            }

        private void btn_Upd_Click(object sender, EventArgs e)
        {
            var commandBilder = new SqlCommandBuilder(_dataAdapter);  //������ ����� ������ ��� ���� ��������
            _dataAdapter.Update(_dataSet, "authors");
            //Debug.WriteLine(commandBilder.GetInsertCommand().CommandText);
            //Debug.WriteLine(commandBilder.GetUpdateCommand().CommandText);
            //Debug.WriteLine(commandBilder.GetDeleteCommand().CommandText);
            MessageBox.Show("������ ���������");
        }

        private void btn_allGoods_Click(object sender, EventArgs e)
        {
            mainGrid.DataSource = null;
            mainGrid.DataSource = _dataSet.Tables["Goods"];
        }

        private void btn_AllSupliers_Click(object sender, EventArgs e)
        {
            mainGrid.DataSource = null;
            mainGrid.DataSource = _dataSet.Tables["Supliers"];
        }

        private void btn_allDelivery_Click(object sender, EventArgs e)
        {
            mainGrid.DataSource = null;
            mainGrid.DataSource = _dataSet.Tables["Deliveries"];
        }
    }
}