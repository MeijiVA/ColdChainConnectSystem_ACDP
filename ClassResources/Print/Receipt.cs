using ColdChainConnectSystem_ACDP.ClassResources;
using ColdChainConnectSystem_ACDP.Materials;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;


public class Receipt
{
    private PrintDocument printDoc = new PrintDocument();
    public void DisplaySalesID(CustomComboBox ccb)
    {
        String query = $"SELECT [salesid] FROM [sales]  GROUP BY [salesid];";
        SqlConnection con = ConnectionClass.Connection();
        using (SqlCommand cmd = new SqlCommand(query, con))
        {
            con.Open();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    ccb.Items.Add(reader[0].ToString());
                }
            }
            con.Close();
        }
    }

    private static List<(int qty, string unit, string description, string sku, decimal unitPrice)> items = new List<(int qty, string unit, string description, string sku, decimal unitPrice)>();

    String soldTo = "";
    decimal grossTotal = 0;
    DateTime date = DateTime.Today;
    String paymentTerm = "";
    String slsid = "";
    String address = "";
    public void GetData(string salesid)
    {

        items.Clear();

        using (SqlConnection con = ConnectionClass.Connection())
        {
            String query = $"SELECT a.[salesid],c.[customerName],a.[salesdate],i.[description],a.[quantity],i.[unitprice],(a.[quantity] * i.[unitprice])AS TOTAL, i.[skucode], a.[SalesDate], c.[PaymentTerm], c.[Address] FROM Sales as a JOIN Inventory AS i ON a.[productid] = i.[numid] JOIN Customer as c ON c.[CustomerID] = a.[CustomerID] WHERE a.[salesid] = '{salesid}' ORDER BY a.[numid] ";

            using (SqlCommand data = new SqlCommand(query, con))
            {
                con.Open();
                using (var reader = data.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (string.IsNullOrEmpty(soldTo))
                        {
                            soldTo = reader[1].ToString();
                            date = Convert.ToDateTime(reader[8].ToString());
                            paymentTerm = reader[9].ToString();
                        }
                        if (string.IsNullOrEmpty(slsid))
                        {
                            slsid = reader[0].ToString();
                        }
                        if (string.IsNullOrEmpty(address))
                        {
                            address = reader[10].ToString();
                        }
                        items.Add((
                            Convert.ToInt32(reader[4]), 
                            "PK",                    
                            reader[3].ToString(),       
                            reader[7].ToString(),       
                            Convert.ToDecimal(reader[5]) 
                        ));
                        grossTotal = grossTotal + Convert.ToDecimal(reader[6].ToString());
                    }
                } 
                con.Close();
            }
        }
    }



    public Receipt()
    {
        printDoc.DocumentName = "Delivery Receipt (ACDP)";
        printDoc.PrintPage += new PrintPageEventHandler(PrintDoc_PrintPage);
    }


    public void ShowPreview()
    {

        try
        {
            using (PrintPreviewDialog previewDialog = new PrintPreviewDialog())
            {
                previewDialog.Document = printDoc;
                previewDialog.Text = "ACDP Delivery Receipt Preview";
                previewDialog.WindowState = FormWindowState.Maximized;
                previewDialog.ShowDialog();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An unexpected error occurred during preview: {ex.Message}", "Preview Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
    {
        Graphics g = e.Graphics;
        System.Drawing.Font fontSmall = new System.Drawing.Font("Arial", 8);
        System.Drawing.Font fontNormal = new System.Drawing.Font("Arial", 9);
        System.Drawing.Font fontBold = new System.Drawing.Font("Arial", 9, FontStyle.Bold);
        float lineSpacing = 14;
        float currentY = 30;
        int pageWidth = e.PageBounds.Width;

        float colX_Start = 50;
        float colX_Qty = 75;
        float colX_Unit = 120;
        float colX_Description = 160;
        float colX_SKU = 450;
        float colX_UPrice = 580;
        float colX_Amount = 750; 

     
        float row1Y = 30;
        float row2Y = row1Y + lineSpacing * 1.5f;
        float row3Y = row2Y + lineSpacing * 2;
        float row4Y = row3Y + lineSpacing;

 
        g.DrawString("ACDP CONSUMER GOODS TRADING", new System.Drawing.Font("Arial", 20, FontStyle.Bold), Brushes.Black, colX_Start, currentY);
        currentY += lineSpacing * 2f;
        g.DrawString("Señiorita St. Saguñin 2000 City of San Fernando (Capital) Pampanga Philippines", fontSmall, Brushes.Black, colX_Start, currentY);
        currentY += lineSpacing * 2;


        float logoAreaWidth = 150; 
        float logoAreaHeight = 50; 
        float receiptBlockX = colX_Amount; 

        using (Image logo = ColdChainConnectSystem_ACDP.Properties.Resources.ACDP_Logo_Print)
        {
            int drawWidth = (int)logoAreaWidth;
            int drawHeight = (int)logoAreaHeight;

            float ratio = Math.Min(logoAreaWidth / logo.Width, logoAreaHeight / logo.Height);
            drawWidth = (int)(logo.Width * ratio);
            drawHeight = (int)(logo.Height * ratio);

            float logoDrawX = receiptBlockX - drawWidth;
            float logoDrawY = row1Y;

            g.DrawImage(logo, logoDrawX, logoDrawY, drawWidth, drawHeight);
        }


      
        float detailX = colX_Amount - 150;
        g.DrawString("DELIVERY RECEIPT", fontBold, Brushes.Black, detailX, currentY - 5);
        currentY += lineSpacing * 2f;
        g.DrawString("No."+slsid.Replace("SLS-","")+"      ", new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Red, detailX + 110, currentY - 5);
        currentY += lineSpacing * 2f;

        g.DrawString("DATE:", fontNormal, Brushes.Black, detailX, currentY);
        g.DrawString(date.ToString("yyyy/MM/dd"), fontNormal, Brushes.Black, detailX + 110, currentY);
        currentY += lineSpacing;
        g.DrawString("TERMS:", fontNormal, Brushes.Black, detailX, currentY);
        g.DrawString(paymentTerm, fontNormal, Brushes.Black, detailX + 110, currentY);
        currentY += lineSpacing * 1.5f;

      
        g.DrawString("SOLD TO:", fontNormal, Brushes.Black, colX_Start, currentY);
        g.DrawString($"{soldTo}", fontBold, Brushes.Black, colX_Start + 80, currentY);
        currentY += lineSpacing;
        g.DrawString("ADDRESS:", fontNormal, Brushes.Black, colX_Start, currentY);
        g.DrawString($"{address}", fontBold, Brushes.Black, colX_Start + 80, currentY);
        currentY += lineSpacing * 1.1f;
      
        g.DrawLine(Pens.Black, colX_Start, currentY + lineSpacing - 5, colX_Amount, currentY + lineSpacing - 5);

        currentY += 20;
        g.DrawString("QTY", fontBold, Brushes.Black, colX_Qty, currentY-10);
        g.DrawString("UNIT", fontBold, Brushes.Black, colX_Unit, currentY-10);
        g.DrawString("DESCRIPTION", fontBold, Brushes.Black, colX_Description, currentY - 10);
        g.DrawString("SKU CODE", fontBold, Brushes.Black, colX_SKU-10, currentY - 10);
        g.DrawString("UNIT PRICE", fontBold, Brushes.Black, colX_UPrice - 10, currentY - 10);
        g.DrawString("AMOUNT", fontBold, Brushes.Black, colX_Amount - 60, currentY - 10);
        g.DrawLine(Pens.Black, colX_Start, currentY + lineSpacing - 5, colX_Amount, currentY + lineSpacing - 5);
        currentY += 10;

    
        decimal grossTotal = 0;

        foreach (var item in items)
        {
            grossTotal += item.unitPrice * item.qty; 

            DrawRightAlignedText(g, item.qty.ToString(), fontNormal, currentY, colX_Unit - 10);
            g.DrawString(item.unit, fontNormal, Brushes.Black, colX_Unit, currentY);
            g.DrawString(item.description, fontNormal, Brushes.Black, colX_Description, currentY);
            g.DrawString(item.sku, fontNormal, Brushes.Black, colX_SKU, currentY);
            DrawRightAlignedText(g, $"₱ {item.unitPrice:N2}", fontNormal, currentY, colX_UPrice + 50);
            DrawRightAlignedText(g, $"₱ {item.qty * item.unitPrice:N2}", fontNormal, currentY, colX_Amount);
            currentY += lineSpacing;
        }

        currentY += lineSpacing * 3; 

        g.DrawLine(Pens.Black, colX_Start, currentY, colX_Amount, currentY);
        currentY += 5;

        decimal discountRate = 0.02m;
        decimal discountAmount = grossTotal * discountRate;
        decimal totalDue = grossTotal - discountAmount; 

        float totalsX_Label = colX_Amount - 200;
        float totalsX_Value = colX_Amount;


        g.DrawString("GROSS", fontNormal, Brushes.Black, totalsX_Label, currentY);
        DrawRightAlignedText(g, $"₱ {grossTotal:N2}", fontNormal, currentY, totalsX_Value);
        currentY += lineSpacing;

        g.DrawString("LESS 2%", fontNormal, Brushes.Black, totalsX_Label, currentY);
        DrawRightAlignedText(g, $"₱ {discountAmount:N2}", fontNormal, currentY, totalsX_Value);
        currentY += lineSpacing;


        g.DrawString("TOTAL AMOUNT DUE", fontBold, Brushes.Black, totalsX_Label - 50, currentY);
        DrawRightAlignedText(g, $"₱ {totalDue:N2}", new System.Drawing.Font(fontBold, FontStyle.Bold), currentY, totalsX_Value);

        currentY += lineSpacing * 2;


        g.DrawString("PREPARED BY:", fontNormal, Brushes.Black, colX_Start, currentY);
        DrawRightAlignedText(g, $"{ConnectionClass.fname} {ConnectionClass.mname.Substring(0,1)}. {ConnectionClass.lname}", new System.Drawing.Font(fontBold, FontStyle.Bold), currentY, totalsX_Value);
        g.DrawString("RECEIVED BY:", fontNormal, Brushes.Black, colX_Amount - 250, currentY);


        e.HasMorePages = false;
    }

//idk how this works lol
    private void DrawRightAlignedText(Graphics g, string text, System.Drawing.Font font, float y, float endX)
    {
        StringFormat sf = new StringFormat();
        sf.Alignment = StringAlignment.Far;
        RectangleF layoutRect = new RectangleF(0, y, endX, font.Height);
        g.DrawString(text, font, Brushes.Black, layoutRect, sf);
    }



    //tinamad ako tanggalin sa button haha
    private void PreviewButton_Click(object sender, EventArgs e)
    {
        try
        {
            this.ShowPreview();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while showing the print preview: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

}