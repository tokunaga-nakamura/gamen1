using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gamen1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("buhinkousei");
            dt.Columns.Add("seq");
            dt.Columns.Add("1");
            dt.Columns.Add("2");
            dt.Columns.Add("3");
            dt.Columns.Add("部品コード");
            dt.Columns.Add("部品名");
            dt.Columns.Add("在庫区分");
            dt.Columns.Add("取引先コード");
            dt.Columns.Add("受注No1");
            dt.Columns.Add("受注No2");
            dt.Columns.Add("数量");

            DataRow dtRow = dt.NewRow();
            dtRow["seq"] = "1";
            dtRow["1"] = "製品";
            dtRow["2"] = "";
            dtRow["3"] = "";
            dtRow["部品コード"] = "01020304050607";
            dtRow["部品名"] = "FW-3216S メイン ";
            dtRow["在庫区分"] = "1";
            dtRow["取引先コード"] = " ";
            dtRow["受注No1"] = " ";
            dtRow["受注No2"] = " ";
            dtRow["数量"] = " ";
            dt.Rows.Add(dtRow);

            dtRow = dt.NewRow(); 
            dtRow["seq"] = "2";
            dtRow["1"] = "";
            dtRow["2"] = "2";
            dtRow["3"] = "";
            dtRow["部品コード"] = "12345678901234 ";
            dtRow["部品名"] = "FT-F3AA024E";
            dtRow["在庫区分"] = "1";
            dtRow["取引先コード"] = " ";
            dtRow["受注No1"] = " ";
            dtRow["受注No2"] = " ";
            dtRow["数量"] = " ";
            dt.Rows.Add(dtRow);

            dtRow = dt.NewRow();
            dtRow["seq"] = "3";
            dtRow["1"] = "";
            dtRow["2"] = "2";
            dtRow["3"] = "";
            dtRow["部品コード"] = "23456789012345 ";
            dtRow["部品名"] = "ALD124-P";
            dtRow["在庫区分"] = "2";
            dtRow["取引先コード"] = "00051";
            dtRow["受注No1"] = "12345";
            dtRow["受注No2"] = "6789";
            dtRow["数量"] = " ";
            dt.Rows.Add(dtRow);

            dtRow = dt.NewRow();
            dtRow["seq"] = "4";
            dtRow["1"] = "";
            dtRow["2"] = "2";
            dtRow["3"] = "";
            dtRow["部品コード"] = "34567890123456";
            dtRow["部品名"] = "HS ASSY";
            dtRow["在庫区分"] = "1";
            dtRow["取引先コード"] = " ";
            dtRow["受注No1"] = " ";
            dtRow["受注No2"] = " ";
            dtRow["数量"] = " ";
            dt.Rows.Add(dtRow);

            dtRow = dt.NewRow();
            dtRow["seq"] = "5";
            dtRow["1"] = "";
            dtRow["2"] = "";
            dtRow["3"] = "3";
            dtRow["部品コード"] = "45678901234567";
            dtRow["部品名"] = "BCR16CM-XXXX#B00";
            dtRow["在庫区分"] = " ";
            dtRow["取引先コード"] = " ";
            dtRow["受注No1"] = " ";
            dtRow["受注No2"] = " ";
            dtRow["数量"] = " ";
            dt.Rows.Add(dtRow);

            dtRow = dt.NewRow();
            dtRow["seq"] = "6";
            dtRow["1"] = "";
            dtRow["2"] = "";
            dtRow["3"] = "3";
            dtRow["部品コード"] = "56789012345678";
            dtRow["部品名"] = "HS220";
            dtRow["在庫区分"] = " ";
            dtRow["取引先コード"] = " ";
            dtRow["受注No1"] = " ";
            dtRow["受注No2"] = " ";
            dtRow["数量"] = " ";
            dt.Rows.Add(dtRow);

            dtRow = dt.NewRow();
            dtRow["seq"] = "7";
            dtRow["1"] = "";
            dtRow["2"] = "";
            dtRow["3"] = "3";
            dtRow["部品コード"] = "67890123456789";
            dtRow["部品名"] = "ビス";
            dtRow["在庫区分"] = " ";
            dtRow["取引先コード"] = " ";
            dtRow["受注No1"] = " ";
            dtRow["受注No2"] = " ";
            dtRow["数量"] = " ";
            dt.Rows.Add(dtRow);

            dtRow = dt.NewRow();
            dtRow["seq"] = "8";
            dtRow["1"] = "";
            dtRow["2"] = "2";
            dtRow["3"] = "";
            dtRow["部品コード"] = "78901234567890";
            dtRow["部品名"] = "EKMG500AABBCCDD";
            dtRow["在庫区分"] = " ";
            dtRow["取引先コード"] = " ";
            dtRow["受注No1"] = " ";
            dtRow["受注No2"] = " ";
            dtRow["数量"] = " ";
            dt.Rows.Add(dtRow);

            dtRow = dt.NewRow();
            dtRow["seq"] = "9";
            dtRow["1"] = "";
            dtRow["2"] = "2";
            dtRow["3"] = "";
            dtRow["部品コード"] = "89012345678901";
            dtRow["部品名"] = "00-0015-00306-01";
            dtRow["在庫区分"] = " ";
            dtRow["取引先コード"] = " ";
            dtRow["受注No1"] = " ";
            dtRow["受注No2"] = " ";
            dtRow["数量"] = " ";
            dt.Rows.Add(dtRow);

            dtRow = dt.NewRow();
            dtRow["seq"] = "10";
            dtRow["1"] = "";
            dtRow["2"] = "2";
            dtRow["3"] = "";
            dtRow["部品コード"] = "90123456789012";
            dtRow["部品名"] = "5289-02A";
            dtRow["在庫区分"] = " ";
            dtRow["取引先コード"] = " ";
            dtRow["受注No1"] = " ";
            dtRow["受注No2"] = " ";
            dtRow["数量"] = " ";
            dt.Rows.Add(dtRow);

            dataGridView1.DataSource = dt;

        }
    }
}
