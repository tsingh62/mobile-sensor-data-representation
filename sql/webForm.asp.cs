using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;


namespace webgraphs
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataSet ds = new DataSet();
        // private MySqlConnection connection;
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        private static DataTable GetData1(string query)
        {

            string con = "server=localhost;user id=root;password=welcome;database=sensor_data";

            // DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand(query);
            MySqlConnection connection = new MySqlConnection(con);
            connection.Open();
            MySqlDataAdapter returnVal = new MySqlDataAdapter();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            //  MySqlDataReader dr;
            returnVal.SelectCommand = cmd;
            DataTable dt = new DataTable("CharacterInfo");
            returnVal.Fill(dt);
            return dt;
        }
        private static DataTable GetData2(string query1)
        {

            string con = "server=localhost;user id=root;password=welcome;database=sensor_data";

            // DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand(query1);
            MySqlConnection connection = new MySqlConnection(con);
            connection.Open();
            MySqlDataAdapter returnVal = new MySqlDataAdapter();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
       
                 //  MySqlDataReader dr;
            returnVal.SelectCommand = cmd;
            DataTable dt = new DataTable("CharacterInfo");
            returnVal.Fill(dt);
            return dt;
        }
        private static DataTable GetData3(string query3)
        {

            string con = "server=localhost;user id=root;password=welcome;database=sensor_data";

            // DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand(query3);
            MySqlConnection connection = new MySqlConnection(con);
            connection.Open();
            MySqlDataAdapter returnVal = new MySqlDataAdapter();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            //  MySqlDataReader dr;
            returnVal.SelectCommand = cmd;
            DataTable dt = new DataTable("CharacterInfo");
            returnVal.Fill(dt);
            return dt;
        }
        protected void btn_Click(object sender, EventArgs e)
        {
            // Chart1.Visible = ddlCountries.SelectedValue != "";
            string query = string.Format("select time,x_acc,y_acc,z_acc from accelerometer_data");
            DataTable dt = GetData1(query);
            string[] x = new string[dt.Rows.Count];
            float[] y = new float[dt.Rows.Count];
            float[] z = new float[dt.Rows.Count];
            float[] t = new float[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                x[i] = dt.Rows[i][0].ToString();
                y[i] = Convert.ToInt32(dt.Rows[i][1]);
                z[i] = Convert.ToInt32(dt.Rows[i][2]);
                t[i] = Convert.ToInt32(dt.Rows[i][3]); 
            }
            Chart1.Series[0].Points.DataBindXY(x, y);
            Chart1.Series[0].ChartType = SeriesChartType.Line;
            Chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
            Chart1.Legends[0].Enabled = true;

            Chart1.Series[1].Points.DataBindXY(x, z);
            Chart1.Series[1].ChartType = SeriesChartType.Line;
            Chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
            Chart1.Legends[0].Enabled = true;

            Chart1.Series[2].Points.DataBindXY(x, t);
            Chart1.Series[2].ChartType = SeriesChartType.Line;
            Chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
            Chart1.Legends[0].Enabled = true;

            string query1 = string.Format("select time,x_mag,y_mag,z_mag from mag_data");
            DataTable dt1 = GetData2(query1);
            string[] x1 = new string[dt1.Rows.Count];
            float[] y1 = new float[dt1.Rows.Count];
            float[] z1 = new float[dt1.Rows.Count];
            float[] t1 = new float[dt1.Rows.Count];
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                x1[i] = dt1.Rows[i][0].ToString();
                y1[i] = Convert.ToInt32(dt1.Rows[i][1]);
                z1[i] = Convert.ToInt32(dt1.Rows[i][2]);
                t1[i] = Convert.ToInt32(dt1.Rows[i][3]);
            }
            Chart2.Series[0].Points.DataBindXY(x1, y1);
            Chart2.Series[0].ChartType = SeriesChartType.Line;
            Chart2.ChartAreas["ChartArea2"].Area3DStyle.Enable3D = true;
            Chart2.Legends[0].Enabled = true;

            Chart2.Series[1].Points.DataBindXY(x1, z1);
            Chart2.Series[1].ChartType = SeriesChartType.Line;
            Chart2.ChartAreas["ChartArea2"].Area3DStyle.Enable3D = true;
            Chart2.Legends[0].Enabled = true;

            Chart2.Series[2].Points.DataBindXY(x1, t1);
            Chart2.Series[2].ChartType = SeriesChartType.Line;
            Chart2.ChartAreas["ChartArea2"].Area3DStyle.Enable3D = true;
            Chart2.Legends[0].Enabled = true;

            // Chart1.Visible = ddlCountries.SelectedValue != "";
            string query3 = string.Format("select time, light_record from web_health");
            DataTable dt3 = GetData3(query3);
            string[] x3 = new string[dt3.Rows.Count];
            float[] y3 = new float[dt3.Rows.Count];
            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                x3[i] = dt3.Rows[i][0].ToString();
                y3[i] = Convert.ToInt32(dt3.Rows[i][1]);

            }
            Chart3.Series[0].Points.DataBindXY(x3, y3);
            Chart3.Series[0].ChartType = SeriesChartType.Line;
            Chart3.ChartAreas["ChartArea3"].Area3DStyle.Enable3D = true;
            Chart3.Legends[0].Enabled = true;

        

        }
    }
}
