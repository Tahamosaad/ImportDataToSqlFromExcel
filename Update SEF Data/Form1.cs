using System;
using oExcel = Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Reflection;
using System.Globalization;
using System.Threading;
using System.Runtime.InteropServices;
namespace UpdateSEFData
{
    public partial class Form1 : Form
    { 
       public static DatabaseConnection dbc = new DatabaseConnection();
              int i, NoOfCards, GrdRow = 0;
            int CardID = 0, SheetCols = 0;
           
            long SheetRows = 0;
          
            SqlCommand cmd = new SqlCommand("");
            SqlCommand cmd2 = new SqlCommand("");
             List<string> OrderList = new List<string>();
            SortedList<string, string> ColoumName = new SortedList<string, string>(); 
        public Form1()
        {
            InitializeComponent();
      
            txt_Servername.Text = System.Environment.MachineName;
            //txt_DBname.Text = "SS_cards";
            //txtDBPassword.Text = "MSSTSandURV1";

        }
        public void Databaseinit(){
               dbc.ServerName = txt_Servername.Text.ToString();
               dbc.DBName = txt_DBname.Text.ToString();
               dbc.ServerPWD = txtDBPassword.Text.ToString();
               dbc.GlobalConnectionString = "Data Source=" + dbc.ServerName + ";Initial Catalog=" + dbc.DBName + "; user id = sa ; Password =" + dbc.ServerPWD;
              
           }
        private void btnOK_Click(object sender, EventArgs e)
        {
            Databaseinit();
            
             CultureInfo oldCI = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            NoOfCards = 6;// oxlbook.Worksheets.Count;
            var oxlapp = new oExcel.Application();
            oExcel.Workbook oxlbook = oxlapp.Workbooks.Open(Application.StartupPath + "\\NewBackSide.xlsx");
            oExcel.Worksheet oxlsheet;
            //oExcel.Range range;
            //oxlapp.Visible = true;

            SqlTransaction SQLTrans = null; 
            
            try
            {
                SqlConnection con = new SqlConnection(dbc.GlobalConnectionString);
                con.Open();
                SQLTrans = con.BeginTransaction() ;
                Cursor.Current = Cursors.WaitCursor;

                cmd = new SqlCommand("Delete from CardsControls where IsBackSide = 1 ", con, SQLTrans);
                ExecuteSQl(cmd);
                     oxlsheet = (oExcel.Worksheet)oxlbook.Worksheets.get_Item(1);
                    SheetCols = oxlsheet.UsedRange.Columns.Count;
                    SheetRows = oxlsheet.UsedRange.Rows.Count;
                for (i = 1; (i <= NoOfCards); i++)
                {    
                    CardID = i;
                    labStatus.Text = ("Applying Card ( " + (i + (" ) of " + NoOfCards)));
                    Application.DoEvents();
                    for (GrdRow = 2; (GrdRow <= SheetRows); GrdRow++)
                    {
                        ColoumName.Clear();
                        if (GetCardData(oxlsheet))
                        {
                            cmd = new SqlCommand("INSERT INTO CardsControls (CardID, ControlType, PropertyName, ControlName, IsBackSide, PropertyValue, PropertyImage, ControlIndex) Values (" + CardID + ", '" + ColoumName["ControlType"] + "', '" + ColoumName["PropertyName"] + "','" + ColoumName["ControlName"] + "'," + ColoumName["IsBackSide"] + ",'" + ColoumName["PropertyValue"] + "', " + ColoumName["PropertyImage"] + ", " + ColoumName["ControlIndex"] + ")", con, SQLTrans);
                            ExecuteSQl(cmd);
                        }
                           
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString() + "\r\n" + " (Grid Row " + GrdRow + " / Card ID" + CardID + " )");
                goto ExecErr;
            }
           
            if (!string.IsNullOrEmpty( cmd.CommandText)) {
               
                SQLTrans.Commit();
                oxlapp.Visible = true;
                MessageBox.Show("Executed Succefully");
                goto ExecSucess;
            }
            else
            {
                SQLTrans.Rollback();
            }
           
        ExecErr:
           
       ExecSucess: 
            oxlapp.Quit(); 
            labStatus.Text = "";
            Application.DoEvents();
            Cursor.Current = Cursors.Default;  
            //oxlapp = null;
            //oxlbook = null;
            oxlsheet = null;
            //Marshal.ReleaseComObject(oxlsheet);
            Marshal.ReleaseComObject(oxlbook);
            Marshal.ReleaseComObject(oxlapp);
            this.Close();
        
        }
        private bool GetCardData(oExcel.Worksheet oxlsheet)
        {
            byte bs = Convert.ToByte(((oExcel.Range)oxlsheet.Cells[GrdRow, 5]).Value2);
            ColoumName.Add("ControlType", Convert.ToString(((oExcel.Range)oxlsheet.Cells[GrdRow, 2]).Value2));
            ColoumName.Add("PropertyName", Convert.ToString(((oExcel.Range)oxlsheet.Cells[GrdRow, 3]).Value2));
            ColoumName.Add("ControlName", Convert.ToString(((oExcel.Range)oxlsheet.Cells[GrdRow, 4]).Text));
            ColoumName.Add("IsBackSide", bs.ToString());
            ColoumName.Add("PropertyValue",Convert.ToString(((oExcel.Range)oxlsheet.Cells[GrdRow, 6]).Value2));//Issuedate
            ColoumName.Add("PropertyImage", Convert.ToString(((oExcel.Range)oxlsheet.Cells[GrdRow, 7]).Value2));
            ColoumName.Add("ControlIndex", Convert.ToString(((oExcel.Range)oxlsheet.Cells[GrdRow, 8]).Value2));
           return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        public static bool ExecuteSQl(SqlCommand cmd)
        {
            try
            {
                {
                    SqlConnection cn = cmd.Connection;
                    //cn.Open();
                    int RowsAff = cmd.ExecuteNonQuery();
                    //cn.Close();
                    return true;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString() + "\r\n" + cmd.CommandText);
                return false;
            }

        }
        //bool OpenExcelTxt(string FileName, string Txt)
        //{
        //    try
        //    {FileName = FileName.Replace(" ", "_");
        //    FileName = (System.Environment.GetEnvironmentVariable("temp") + ("\\" + FileName));
        //    System.IO.File.WriteAllText(FileName, Txt,UTF8Encoding.Unicode);
        //    System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo("Excel", FileName);
        //    psi.UseShellExecute = true;
        //    System.Diagnostics.Process.Start(psi);
        //    return true;

        //    }
        //    catch (Exception ex)
        //    {MessageBox.Show(ex.Message.ToString());
        //        return false;
        //    }
            
        //}
       
    }
}
