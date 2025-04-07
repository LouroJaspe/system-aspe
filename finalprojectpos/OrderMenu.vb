Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class OrderMenu
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jimen\source\repos\tblProducts.accdb")
    Dim cmd As OleDbCommand
    Dim reader As OleDbDataReader
    Private WithEvents printDoc As New PrintDocument()
    Private printPreview As New PrintPreviewDialog()

    Private Sub OrderMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupDataGridView()
        LoadProducts()
    End Sub

    Sub LoadProducts()
        Try
            con.Open()
            cmd = New OleDbCommand("SELECT * FROM tblProducts", con)
            reader = cmd.ExecuteReader()

            While reader.Read()
                Dim btn As New Button()
                btn.Text = reader("ProductName").ToString() & " - ₱" & reader("Price").ToString()
                btn.Tag = reader("ProductName").ToString() & "," & reader("Price").ToString()
                btn.Width = 150
                btn.Height = 50
                AddHandler btn.Click, AddressOf Product_Click
                FlowLayoutPanel.Controls.Add(btn)
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub SetupDataGridView()
        With dgvordersummary
            .Columns.Clear()
            .Columns.Add("Product", "Product")
            .Columns.Add("Quantity", "Quantity")
            .Columns.Add("Price", "Price")
            .Columns.Add("Total", "Total")
        End With
        dgvordersummary.Visible = True
    End Sub

    Private Sub Product_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim data() As String = btn.Tag.ToString().Split(","c)
        Dim productName As String = data(0)
        Dim price As Decimal = Convert.ToDecimal(data(1))
        Dim quantity As Integer = 1
        Dim totalPrice As Decimal = price * quantity
        dgvordersummary.Rows.Add(productName, quantity, price, totalPrice)
        CalculateTotal()
    End Sub

    Sub CalculateTotal()
        Dim subtotal As Decimal = 0
        If dgvordersummary.Rows.Count > 0 Then
            For Each row As DataGridViewRow In dgvordersummary.Rows
                If row.Cells(3).Value IsNot Nothing Then
                    subtotal += Convert.ToDecimal(row.Cells(3).Value)
                End If
            Next
        End If
        Dim tax As Decimal = subtotal * 0.1
        Dim total As Decimal = subtotal + tax
        txtsubtotal.Text = subtotal.ToString("0.00")
        txttax.Text = tax.ToString("0.00")
        txttotal.Text = total.ToString("0.00")
    End Sub

    Private Sub btncheckout_Click(sender As Object, e As EventArgs) Handles btncheckout.Click
        If dgvordersummary.Rows.Count = 0 Then
            MessageBox.Show("No items in the order.")
            Return
        End If
        If String.IsNullOrWhiteSpace(txttotal.Text) OrElse
       String.IsNullOrWhiteSpace(txttax.Text) OrElse
       String.IsNullOrWhiteSpace(txtamountreceived.Text) OrElse
       String.IsNullOrWhiteSpace(cmbpayment.Text) Then
            MessageBox.Show("Please enter all required fields.")
            Return
        End If
        Dim totalAmount As Decimal
        Dim taxAmount As Decimal
        Dim amountReceived As Decimal
        If Not Decimal.TryParse(txttotal.Text, totalAmount) OrElse
       Not Decimal.TryParse(txttax.Text, taxAmount) OrElse
       Not Decimal.TryParse(txtamountreceived.Text, amountReceived) Then
            MessageBox.Show("Invalid input format.")
            Return
        End If
        Dim changeAmount As Decimal = amountReceived - totalAmount
        If amountReceived < totalAmount Then
            MessageBox.Show("Insufficient amount received.")
            Return
        End If


        txtchange.Text = changeAmount.ToString("0.00")

        Try
            con.Open()
            Dim query As String = "INSERT INTO tblOrders (OrderDate, TotalAmount, TaxAmount, PaymentMethod, AmountReceived, ChangeAmount) " &
                              "VALUES (@OrderDate, @TotalAmount, @TaxAmount, @PaymentMethod, @AmountReceived, @ChangeAmount)"
            cmd = New OleDbCommand(query, con)
            cmd.Parameters.Add("@OrderDate", OleDbType.Date).Value = DateTime.Now
            cmd.Parameters.Add("@TotalAmount", OleDbType.Currency).Value = totalAmount
            cmd.Parameters.Add("@TaxAmount", OleDbType.Currency).Value = taxAmount
            cmd.Parameters.Add("@PaymentMethod", OleDbType.VarChar).Value = cmbpayment.Text
            cmd.Parameters.Add("@AmountReceived", OleDbType.Currency).Value = amountReceived
            cmd.Parameters.Add("@ChangeAmount", OleDbType.Currency).Value = changeAmount
            cmd.ExecuteNonQuery()
            MessageBox.Show("Order saved successfully! Change: ₱" & changeAmount.ToString("0.00"))
        Catch ex As Exception
            MessageBox.Show("Error saving order: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub txtchange_TextChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub btnreceipt_Click(sender As Object, e As EventArgs) Handles btnreceipt.Click
        printPreview.Document = printDoc
        printPreview.ShowDialog()
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        dgvordersummary.Rows.Clear()
        txtsubtotal.Text = "0.00"
        txttax.Text = "0.00"
        txttotal.Text = "0.00"
        txtchange.Text = "0.00"
        txtamountreceived.Clear()
        cmbpayment.SelectedIndex = -1
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

    End Sub
    Private Sub printDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles printDoc.PrintPage
        Dim font As New Font("Arial", 12)
        Dim brush As New SolidBrush(Color.Black)
        Dim startX As Integer = 20
        Dim startY As Integer = 20
        Dim lineHeight As Integer = 25
        Dim yOffset As Integer = startY

        e.Graphics.DrawString("RECEIPT", New Font("Arial", 14, FontStyle.Bold), brush, startX + 50, yOffset)
        yOffset += lineHeight * 2
        e.Graphics.DrawString("--------------------------------", font, brush, startX, yOffset)
        yOffset += lineHeight

        For Each row As DataGridViewRow In dgvordersummary.Rows
            If row.Cells(0).Value IsNot Nothing Then
                Dim product As String = row.Cells("Product").Value.ToString()
                Dim qty As String = row.Cells("Quantity").Value.ToString()
                Dim price As String = row.Cells("Price").Value.ToString()
                Dim total As String = row.Cells("Total").Value.ToString()
                e.Graphics.DrawString(product & " x" & qty & " @ ₱" & price & " = ₱" & total, font, brush, startX, yOffset)
                yOffset += lineHeight
            End If
        Next

        yOffset += lineHeight
        e.Graphics.DrawString("--------------------------------", font, brush, startX, yOffset)
        yOffset += lineHeight
        e.Graphics.DrawString("Subtotal: ₱" & txtsubtotal.Text, font, brush, startX, yOffset)
        yOffset += lineHeight
        e.Graphics.DrawString("Tax (10%): ₱" & txttax.Text, font, brush, startX, yOffset)
        yOffset += lineHeight
        e.Graphics.DrawString("Total: ₱" & txttotal.Text, New Font("Arial", 12, FontStyle.Bold), brush, startX, yOffset)
        yOffset += lineHeight * 2
        e.Graphics.DrawString("Amount Received: ₱" & txtamountreceived.Text, font, brush, startX, yOffset)
        yOffset += lineHeight
        e.Graphics.DrawString("Thank you for your purchase!", New Font("Arial", 12, FontStyle.Italic), brush, startX, yOffset)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = formWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub dgvordersummary_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvordersummary.CellContentClick

    End Sub

    Private Sub FlowLayoutPanel_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel.Paint

    End Sub
End Class
