<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrderMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrderMenu))
        Me.FlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.burger = New System.Windows.Forms.Button()
        Me.sandwich = New System.Windows.Forms.Button()
        Me.fries = New System.Windows.Forms.Button()
        Me.pizza = New System.Windows.Forms.Button()
        Me.sushi = New System.Windows.Forms.Button()
        Me.donut = New System.Windows.Forms.Button()
        Me.cake = New System.Windows.Forms.Button()
        Me.bread = New System.Windows.Forms.Button()
        Me.noodles = New System.Windows.Forms.Button()
        Me.pasta = New System.Windows.Forms.Button()
        Me.tempura = New System.Windows.Forms.Button()
        Me.sashimi = New System.Windows.Forms.Button()
        Me.chicken = New System.Windows.Forms.Button()
        Me.steak = New System.Windows.Forms.Button()
        Me.fish = New System.Windows.Forms.Button()
        Me.omelete = New System.Windows.Forms.Button()
        Me.salad = New System.Windows.Forms.Button()
        Me.boiledegg = New System.Windows.Forms.Button()
        Me.macarons = New System.Windows.Forms.Button()
        Me.fruitsalad = New System.Windows.Forms.Button()
        Me.icecream = New System.Windows.Forms.Button()
        Me.sundae = New System.Windows.Forms.Button()
        Me.chocolate = New System.Windows.Forms.Button()
        Me.coffee = New System.Windows.Forms.Button()
        Me.cola = New System.Windows.Forms.Button()
        Me.lemon = New System.Windows.Forms.Button()
        Me.orange = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvordersummary = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.txttax = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbpayment = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtamountreceived = New System.Windows.Forms.TextBox()
        Me.btncheckout = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnreceipt = New System.Windows.Forms.Button()
        Me.Button35 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.txtchange = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel.SuspendLayout()
        CType(Me.dgvordersummary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel
        '
        Me.FlowLayoutPanel.Controls.Add(Me.burger)
        Me.FlowLayoutPanel.Controls.Add(Me.sandwich)
        Me.FlowLayoutPanel.Controls.Add(Me.fries)
        Me.FlowLayoutPanel.Controls.Add(Me.pizza)
        Me.FlowLayoutPanel.Controls.Add(Me.sushi)
        Me.FlowLayoutPanel.Controls.Add(Me.donut)
        Me.FlowLayoutPanel.Controls.Add(Me.cake)
        Me.FlowLayoutPanel.Controls.Add(Me.bread)
        Me.FlowLayoutPanel.Controls.Add(Me.noodles)
        Me.FlowLayoutPanel.Controls.Add(Me.pasta)
        Me.FlowLayoutPanel.Controls.Add(Me.tempura)
        Me.FlowLayoutPanel.Controls.Add(Me.sashimi)
        Me.FlowLayoutPanel.Controls.Add(Me.chicken)
        Me.FlowLayoutPanel.Controls.Add(Me.steak)
        Me.FlowLayoutPanel.Controls.Add(Me.fish)
        Me.FlowLayoutPanel.Controls.Add(Me.omelete)
        Me.FlowLayoutPanel.Controls.Add(Me.salad)
        Me.FlowLayoutPanel.Controls.Add(Me.boiledegg)
        Me.FlowLayoutPanel.Controls.Add(Me.macarons)
        Me.FlowLayoutPanel.Controls.Add(Me.fruitsalad)
        Me.FlowLayoutPanel.Controls.Add(Me.icecream)
        Me.FlowLayoutPanel.Controls.Add(Me.sundae)
        Me.FlowLayoutPanel.Controls.Add(Me.chocolate)
        Me.FlowLayoutPanel.Controls.Add(Me.coffee)
        Me.FlowLayoutPanel.Controls.Add(Me.cola)
        Me.FlowLayoutPanel.Controls.Add(Me.lemon)
        Me.FlowLayoutPanel.Controls.Add(Me.orange)
        Me.FlowLayoutPanel.Location = New System.Drawing.Point(2, 2)
        Me.FlowLayoutPanel.Name = "FlowLayoutPanel"
        Me.FlowLayoutPanel.Size = New System.Drawing.Size(688, 624)
        Me.FlowLayoutPanel.TabIndex = 4
        '
        'burger
        '
        Me.burger.BackgroundImage = Global.finalprojectpos.My.Resources.Resources.images__1_
        Me.burger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.burger.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.burger.ForeColor = System.Drawing.Color.Black
        Me.burger.Location = New System.Drawing.Point(3, 3)
        Me.burger.Name = "burger"
        Me.burger.Size = New System.Drawing.Size(70, 60)
        Me.burger.TabIndex = 1
        Me.burger.Text = "BURGER"
        Me.burger.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.burger.UseVisualStyleBackColor = True
        '
        'sandwich
        '
        Me.sandwich.BackgroundImage = Global.finalprojectpos.My.Resources.Resources.download__2_
        Me.sandwich.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.sandwich.Font = New System.Drawing.Font("Mongolian Baiti", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sandwich.ForeColor = System.Drawing.Color.Black
        Me.sandwich.Location = New System.Drawing.Point(79, 3)
        Me.sandwich.Name = "sandwich"
        Me.sandwich.Size = New System.Drawing.Size(70, 60)
        Me.sandwich.TabIndex = 6
        Me.sandwich.Text = "SANDWICH"
        Me.sandwich.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.sandwich.UseVisualStyleBackColor = True
        '
        'fries
        '
        Me.fries.BackgroundImage = Global.finalprojectpos.My.Resources.Resources.download
        Me.fries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.fries.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fries.ForeColor = System.Drawing.Color.Black
        Me.fries.Location = New System.Drawing.Point(155, 3)
        Me.fries.Name = "fries"
        Me.fries.Size = New System.Drawing.Size(70, 60)
        Me.fries.TabIndex = 2
        Me.fries.Text = "FRIES"
        Me.fries.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.fries.UseVisualStyleBackColor = True
        '
        'pizza
        '
        Me.pizza.BackgroundImage = Global.finalprojectpos.My.Resources.Resources.download1
        Me.pizza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pizza.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pizza.ForeColor = System.Drawing.Color.Black
        Me.pizza.Location = New System.Drawing.Point(231, 3)
        Me.pizza.Name = "pizza"
        Me.pizza.Size = New System.Drawing.Size(70, 60)
        Me.pizza.TabIndex = 3
        Me.pizza.Text = "PIZZA"
        Me.pizza.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.pizza.UseVisualStyleBackColor = True
        '
        'sushi
        '
        Me.sushi.BackgroundImage = Global.finalprojectpos.My.Resources.Resources.images__4_
        Me.sushi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.sushi.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sushi.ForeColor = System.Drawing.Color.Black
        Me.sushi.Location = New System.Drawing.Point(307, 3)
        Me.sushi.Name = "sushi"
        Me.sushi.Size = New System.Drawing.Size(70, 60)
        Me.sushi.TabIndex = 12
        Me.sushi.Text = "SUSHI"
        Me.sushi.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.sushi.UseVisualStyleBackColor = True
        '
        'donut
        '
        Me.donut.BackgroundImage = Global.finalprojectpos.My.Resources.Resources.images__2_
        Me.donut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.donut.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.donut.ForeColor = System.Drawing.Color.Black
        Me.donut.Location = New System.Drawing.Point(383, 3)
        Me.donut.Name = "donut"
        Me.donut.Size = New System.Drawing.Size(70, 60)
        Me.donut.TabIndex = 7
        Me.donut.Text = "DONUT"
        Me.donut.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.donut.UseVisualStyleBackColor = True
        '
        'cake
        '
        Me.cake.BackgroundImage = Global.finalprojectpos.My.Resources.Resources.images__3_
        Me.cake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cake.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cake.ForeColor = System.Drawing.Color.Black
        Me.cake.Location = New System.Drawing.Point(459, 3)
        Me.cake.Name = "cake"
        Me.cake.Size = New System.Drawing.Size(70, 60)
        Me.cake.TabIndex = 8
        Me.cake.Text = "CAKE"
        Me.cake.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cake.UseVisualStyleBackColor = True
        '
        'bread
        '
        Me.bread.BackgroundImage = Global.finalprojectpos.My.Resources.Resources.download__10_
        Me.bread.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bread.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bread.ForeColor = System.Drawing.Color.Black
        Me.bread.Location = New System.Drawing.Point(535, 3)
        Me.bread.Name = "bread"
        Me.bread.Size = New System.Drawing.Size(70, 60)
        Me.bread.TabIndex = 24
        Me.bread.Text = "BREAD"
        Me.bread.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bread.UseVisualStyleBackColor = True
        '
        'noodles
        '
        Me.noodles.BackgroundImage = Global.finalprojectpos.My.Resources.Resources.download__2_1
        Me.noodles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.noodles.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noodles.ForeColor = System.Drawing.Color.Black
        Me.noodles.Location = New System.Drawing.Point(611, 3)
        Me.noodles.Name = "noodles"
        Me.noodles.Size = New System.Drawing.Size(70, 60)
        Me.noodles.TabIndex = 9
        Me.noodles.Text = "NOODLES"
        Me.noodles.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.noodles.UseVisualStyleBackColor = True
        '
        'pasta
        '
        Me.pasta.BackgroundImage = Global.finalprojectpos.My.Resources.Resources.download__3_
        Me.pasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pasta.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pasta.ForeColor = System.Drawing.Color.Black
        Me.pasta.Location = New System.Drawing.Point(3, 69)
        Me.pasta.Name = "pasta"
        Me.pasta.Size = New System.Drawing.Size(70, 60)
        Me.pasta.TabIndex = 10
        Me.pasta.Text = "PASTA"
        Me.pasta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.pasta.UseVisualStyleBackColor = True
        '
        'tempura
        '
        Me.tempura.BackgroundImage = Global.finalprojectpos.My.Resources.Resources.download__4_
        Me.tempura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tempura.Font = New System.Drawing.Font("Mongolian Baiti", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tempura.ForeColor = System.Drawing.Color.Black
        Me.tempura.Location = New System.Drawing.Point(79, 69)
        Me.tempura.Name = "tempura"
        Me.tempura.Size = New System.Drawing.Size(70, 60)
        Me.tempura.TabIndex = 11
        Me.tempura.Text = "TEMPURA"
        Me.tempura.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tempura.UseVisualStyleBackColor = True
        '
        'sashimi
        '
        Me.sashimi.BackgroundImage = Global.finalprojectpos.My.Resources.Resources.download__4_1
        Me.sashimi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.sashimi.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sashimi.ForeColor = System.Drawing.Color.Black
        Me.sashimi.Location = New System.Drawing.Point(155, 69)
        Me.sashimi.Name = "sashimi"
        Me.sashimi.Size = New System.Drawing.Size(70, 60)
        Me.sashimi.TabIndex = 15
        Me.sashimi.Text = "SASHIMI"
        Me.sashimi.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.sashimi.UseVisualStyleBackColor = True
        '
        'chicken
        '
        Me.chicken.BackgroundImage = Global.finalprojectpos.My.Resources.Resources.download__1_1
        Me.chicken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.chicken.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chicken.ForeColor = System.Drawing.Color.Black
        Me.chicken.Location = New System.Drawing.Point(231, 69)
        Me.chicken.Name = "chicken"
        Me.chicken.Size = New System.Drawing.Size(70, 60)
        Me.chicken.TabIndex = 5
        Me.chicken.Text = "CHICKEN"
        Me.chicken.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.chicken.UseVisualStyleBackColor = True
        '
        'steak
        '
        Me.steak.BackgroundImage = Global.finalprojectpos.My.Resources.Resources.download__12_
        Me.steak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.steak.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.steak.ForeColor = System.Drawing.Color.Black
        Me.steak.Location = New System.Drawing.Point(307, 69)
        Me.steak.Name = "steak"
        Me.steak.Size = New System.Drawing.Size(70, 60)
        Me.steak.TabIndex = 14
        Me.steak.Text = "STEAK"
        Me.steak.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.steak.UseVisualStyleBackColor = True
        '
        'fish
        '
        Me.fish.BackgroundImage = Global.finalprojectpos.My.Resources.Resources.download__5_1
        Me.fish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.fish.Font = New System.Drawing.Font("Mongolian Baiti", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fish.ForeColor = System.Drawing.Color.Black
        Me.fish.Location = New System.Drawing.Point(383, 69)
        Me.fish.Name = "fish"
        Me.fish.Size = New System.Drawing.Size(70, 60)
        Me.fish.TabIndex = 16
        Me.fish.Text = "FRIED FISH"
        Me.fish.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.fish.UseVisualStyleBackColor = True
        '
        'omelete
        '
        Me.omelete.BackgroundImage = Global.finalprojectpos.My.Resources.Resources.download__13_
        Me.omelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.omelete.Font = New System.Drawing.Font("Mongolian Baiti", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.omelete.ForeColor = System.Drawing.Color.Black
        Me.omelete.Location = New System.Drawing.Point(459, 69)
        Me.omelete.Name = "omelete"
        Me.omelete.Size = New System.Drawing.Size(70, 60)
        Me.omelete.TabIndex = 17
        Me.omelete.Text = "OMELETE"
        Me.omelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.omelete.UseVisualStyleBackColor = True
        '
        'salad
        '
        Me.salad.BackgroundImage = Global.finalprojectpos.My.Resources.Resources.download__11_
        Me.salad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.salad.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salad.ForeColor = System.Drawing.Color.Black
        Me.salad.Location = New System.Drawing.Point(535, 69)
        Me.salad.Name = "salad"
        Me.salad.Size = New System.Drawing.Size(70, 60)
        Me.salad.TabIndex = 13
        Me.salad.Text = "SALAD"
        Me.salad.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.salad.UseVisualStyleBackColor = True
        '
        'boiledegg
        '
        Me.boiledegg.BackgroundImage = Global.finalprojectpos.My.Resources.Resources.download__14_
        Me.boiledegg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.boiledegg.Font = New System.Drawing.Font("Mongolian Baiti", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boiledegg.ForeColor = System.Drawing.Color.Black
        Me.boiledegg.Location = New System.Drawing.Point(611, 69)
        Me.boiledegg.Name = "boiledegg"
        Me.boiledegg.Size = New System.Drawing.Size(70, 60)
        Me.boiledegg.TabIndex = 18
        Me.boiledegg.Text = "BOILED EGG"
        Me.boiledegg.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.boiledegg.UseVisualStyleBackColor = True
        '
        'macarons
        '
        Me.macarons.BackgroundImage = Global.finalprojectpos.My.Resources.Resources.download__15_
        Me.macarons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.macarons.Font = New System.Drawing.Font("Mongolian Baiti", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.macarons.ForeColor = System.Drawing.Color.Black
        Me.macarons.Location = New System.Drawing.Point(3, 135)
        Me.macarons.Name = "macarons"
        Me.macarons.Size = New System.Drawing.Size(70, 60)
        Me.macarons.TabIndex = 19
        Me.macarons.Text = "MACARONS"
        Me.macarons.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.macarons.UseVisualStyleBackColor = True
        '
        'fruitsalad
        '
        Me.fruitsalad.BackgroundImage = Global.finalprojectpos.My.Resources.Resources.download__18_
        Me.fruitsalad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.fruitsalad.Font = New System.Drawing.Font("Mongolian Baiti", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fruitsalad.ForeColor = System.Drawing.Color.Black
        Me.fruitsalad.Location = New System.Drawing.Point(79, 135)
        Me.fruitsalad.Name = "fruitsalad"
        Me.fruitsalad.Size = New System.Drawing.Size(70, 60)
        Me.fruitsalad.TabIndex = 20
        Me.fruitsalad.Text = "FRUIT SALAD"
        Me.fruitsalad.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.fruitsalad.UseVisualStyleBackColor = True
        '
        'icecream
        '
        Me.icecream.BackgroundImage = Global.finalprojectpos.My.Resources.Resources.download__6_1
        Me.icecream.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.icecream.Font = New System.Drawing.Font("Mongolian Baiti", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.icecream.ForeColor = System.Drawing.Color.Black
        Me.icecream.Location = New System.Drawing.Point(155, 135)
        Me.icecream.Name = "icecream"
        Me.icecream.Size = New System.Drawing.Size(70, 60)
        Me.icecream.TabIndex = 21
        Me.icecream.Text = "ICE CREAM"
        Me.icecream.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.icecream.UseVisualStyleBackColor = True
        '
        'sundae
        '
        Me.sundae.BackgroundImage = Global.finalprojectpos.My.Resources.Resources.download__16_
        Me.sundae.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.sundae.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sundae.ForeColor = System.Drawing.Color.Black
        Me.sundae.Location = New System.Drawing.Point(231, 135)
        Me.sundae.Name = "sundae"
        Me.sundae.Size = New System.Drawing.Size(70, 60)
        Me.sundae.TabIndex = 22
        Me.sundae.Text = "SUNDAE"
        Me.sundae.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.sundae.UseVisualStyleBackColor = True
        '
        'chocolate
        '
        Me.chocolate.BackgroundImage = Global.finalprojectpos.My.Resources.Resources.download__17_
        Me.chocolate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.chocolate.Font = New System.Drawing.Font("Mongolian Baiti", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chocolate.ForeColor = System.Drawing.Color.Black
        Me.chocolate.Location = New System.Drawing.Point(307, 135)
        Me.chocolate.Name = "chocolate"
        Me.chocolate.Size = New System.Drawing.Size(70, 60)
        Me.chocolate.TabIndex = 23
        Me.chocolate.Text = "CHOCOLATE"
        Me.chocolate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.chocolate.UseVisualStyleBackColor = True
        '
        'coffee
        '
        Me.coffee.BackgroundImage = Global.finalprojectpos.My.Resources.Resources.download__9_
        Me.coffee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.coffee.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coffee.ForeColor = System.Drawing.Color.Black
        Me.coffee.Location = New System.Drawing.Point(383, 135)
        Me.coffee.Name = "coffee"
        Me.coffee.Size = New System.Drawing.Size(70, 60)
        Me.coffee.TabIndex = 25
        Me.coffee.Text = "COFFEE"
        Me.coffee.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.coffee.UseVisualStyleBackColor = True
        '
        'cola
        '
        Me.cola.BackgroundImage = Global.finalprojectpos.My.Resources.Resources.download__1_
        Me.cola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cola.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cola.ForeColor = System.Drawing.Color.Black
        Me.cola.Location = New System.Drawing.Point(459, 135)
        Me.cola.Name = "cola"
        Me.cola.Size = New System.Drawing.Size(70, 60)
        Me.cola.TabIndex = 4
        Me.cola.Text = "COLA"
        Me.cola.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cola.UseVisualStyleBackColor = True
        '
        'lemon
        '
        Me.lemon.BackgroundImage = Global.finalprojectpos.My.Resources.Resources.download__5_
        Me.lemon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.lemon.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lemon.ForeColor = System.Drawing.Color.Black
        Me.lemon.Location = New System.Drawing.Point(535, 135)
        Me.lemon.Name = "lemon"
        Me.lemon.Size = New System.Drawing.Size(70, 60)
        Me.lemon.TabIndex = 26
        Me.lemon.Text = "LEMON"
        Me.lemon.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.lemon.UseVisualStyleBackColor = True
        '
        'orange
        '
        Me.orange.BackgroundImage = Global.finalprojectpos.My.Resources.Resources.download__6_
        Me.orange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.orange.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orange.ForeColor = System.Drawing.Color.Black
        Me.orange.Location = New System.Drawing.Point(611, 135)
        Me.orange.Name = "orange"
        Me.orange.Size = New System.Drawing.Size(70, 60)
        Me.orange.TabIndex = 27
        Me.orange.Text = "ORANGE"
        Me.orange.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.orange.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Algerian", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(747, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 32)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "TASTY TAP MENU"
        '
        'dgvordersummary
        '
        Me.dgvordersummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvordersummary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgvordersummary.Location = New System.Drawing.Point(642, 247)
        Me.dgvordersummary.Name = "dgvordersummary"
        Me.dgvordersummary.Size = New System.Drawing.Size(446, 134)
        Me.dgvordersummary.TabIndex = 7
        '
        'Column1
        '
        Me.Column1.HeaderText = "Product Name"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Quantity"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Price"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Total Price"
        Me.Column4.Name = "Column4"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(693, 390)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Subtotal:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(693, 415)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Tax:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(693, 442)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Total:"
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Location = New System.Drawing.Point(762, 386)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(76, 20)
        Me.txtsubtotal.TabIndex = 11
        '
        'txttax
        '
        Me.txttax.Location = New System.Drawing.Point(762, 411)
        Me.txttax.Name = "txttax"
        Me.txttax.Size = New System.Drawing.Size(76, 20)
        Me.txttax.TabIndex = 12
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(762, 437)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(76, 20)
        Me.txttotal.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(846, 390)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Payment Method:"
        '
        'cmbpayment
        '
        Me.cmbpayment.FormattingEnabled = True
        Me.cmbpayment.Items.AddRange(New Object() {"Cash", "Card", "Account"})
        Me.cmbpayment.Location = New System.Drawing.Point(971, 385)
        Me.cmbpayment.Name = "cmbpayment"
        Me.cmbpayment.Size = New System.Drawing.Size(76, 21)
        Me.cmbpayment.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(846, 415)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 16)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Amount Received:"
        '
        'txtamountreceived
        '
        Me.txtamountreceived.Location = New System.Drawing.Point(971, 416)
        Me.txtamountreceived.Name = "txtamountreceived"
        Me.txtamountreceived.Size = New System.Drawing.Size(76, 20)
        Me.txtamountreceived.TabIndex = 18
        '
        'btncheckout
        '
        Me.btncheckout.FlatAppearance.BorderSize = 0
        Me.btncheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncheckout.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncheckout.Location = New System.Drawing.Point(720, 496)
        Me.btncheckout.Name = "btncheckout"
        Me.btncheckout.Size = New System.Drawing.Size(95, 40)
        Me.btncheckout.TabIndex = 20
        Me.btncheckout.Text = "Checkout"
        Me.btncheckout.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.FlatAppearance.BorderSize = 0
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclear.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(832, 496)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(95, 40)
        Me.btnclear.TabIndex = 21
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnreceipt
        '
        Me.btnreceipt.FlatAppearance.BorderSize = 0
        Me.btnreceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreceipt.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreceipt.Location = New System.Drawing.Point(942, 496)
        Me.btnreceipt.Name = "btnreceipt"
        Me.btnreceipt.Size = New System.Drawing.Size(103, 40)
        Me.btnreceipt.TabIndex = 22
        Me.btnreceipt.Text = "Receipt"
        Me.btnreceipt.UseVisualStyleBackColor = True
        '
        'Button35
        '
        Me.Button35.FlatAppearance.BorderSize = 0
        Me.Button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button35.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button35.Location = New System.Drawing.Point(764, 562)
        Me.Button35.Name = "Button35"
        Me.Button35.Size = New System.Drawing.Size(236, 40)
        Me.Button35.TabIndex = 23
        Me.Button35.Text = "Return to Menu"
        Me.Button35.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Algerian", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(751, 212)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(246, 32)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "ORDER SUMMARY"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.finalprojectpos.My.Resources.Resources.Black_Orange_Circle_Burger_Food_Logo__removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(740, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(261, 169)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'txtchange
        '
        Me.txtchange.Location = New System.Drawing.Point(971, 445)
        Me.txtchange.Name = "txtchange"
        Me.txtchange.Size = New System.Drawing.Size(76, 20)
        Me.txtchange.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(908, 447)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 16)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Change:"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1004, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 27)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "-"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1070, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(34, 27)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "x"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1037, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(34, 27)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "◻"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'OrderMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(1104, 628)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtchange)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button35)
        Me.Controls.Add(Me.btnreceipt)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btncheckout)
        Me.Controls.Add(Me.txtamountreceived)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbpayment)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txttax)
        Me.Controls.Add(Me.txtsubtotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvordersummary)
        Me.Controls.Add(Me.FlowLayoutPanel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "OrderMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LEMON"
        Me.FlowLayoutPanel.ResumeLayout(False)
        CType(Me.dgvordersummary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvordersummary As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents txttax As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbpayment As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtamountreceived As TextBox
    Friend WithEvents btncheckout As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btnreceipt As Button
    Friend WithEvents Button35 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents burger As Button
    Friend WithEvents sandwich As Button
    Friend WithEvents fries As Button
    Friend WithEvents pizza As Button
    Friend WithEvents sushi As Button
    Friend WithEvents donut As Button
    Friend WithEvents cake As Button
    Friend WithEvents bread As Button
    Friend WithEvents noodles As Button
    Friend WithEvents pasta As Button
    Friend WithEvents tempura As Button
    Friend WithEvents sashimi As Button
    Friend WithEvents chicken As Button
    Friend WithEvents steak As Button
    Friend WithEvents fish As Button
    Friend WithEvents omelete As Button
    Friend WithEvents salad As Button
    Friend WithEvents boiledegg As Button
    Friend WithEvents macarons As Button
    Friend WithEvents fruitsalad As Button
    Friend WithEvents icecream As Button
    Friend WithEvents sundae As Button
    Friend WithEvents chocolate As Button
    Friend WithEvents coffee As Button
    Friend WithEvents cola As Button
    Friend WithEvents lemon As Button
    Friend WithEvents orange As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents txtchange As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
End Class
