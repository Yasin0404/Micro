namespace EvOtomasyonu // <-- PROJE İSMİNİ KONTROL ET
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlSideMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCikisYap = new Guna.UI2.WinForms.Guna2Button();
            this.btnAyarlar = new Guna.UI2.WinForms.Guna2Button();
            this.btnPerde = new Guna.UI2.WinForms.Guna2Button();
            this.btnKlima = new Guna.UI2.WinForms.Guna2Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.ctrlClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ctrlMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.mainTabControl = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabKlima = new System.Windows.Forms.TabPage();
            this.pnlKlimaBilgi = new Guna.UI2.WinForms.Guna2Panel();
            this.lblKlimaPortBilgi = new System.Windows.Forms.Label();
            this.lblFanSpeed = new System.Windows.Forms.Label();
            this.lblHomeDesired = new System.Windows.Forms.Label();
            this.lblHomeAmbient = new System.Windows.Forms.Label();
            this.labelBaslik1 = new System.Windows.Forms.Label();
            this.pnlKlimaCard = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSicaklikArttir = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnSicaklikAzalt = new Guna.UI2.WinForms.Guna2CircleButton();
            this.progressTermostat = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.lblDerece = new System.Windows.Forms.Label();
            this.lblKlimaBaslik = new System.Windows.Forms.Label();
            this.tabPerde = new System.Windows.Forms.TabPage();
            this.pnlPerdeBilgi = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPerdePortBilgi = new System.Windows.Forms.Label();
            this.lblLightIntensity = new System.Windows.Forms.Label();
            this.lblCurtainStatus = new System.Windows.Forms.Label();
            this.lblOutdoorPressure = new System.Windows.Forms.Label();
            this.lblOutdoorTemp = new System.Windows.Forms.Label();
            this.labelBaslik2 = new System.Windows.Forms.Label();
            this.pnlPerdeCard = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPerdeYuzde = new System.Windows.Forms.Label();
            this.trackBarPerde = new Guna.UI2.WinForms.Guna2TrackBar();
            this.btnPerdeAyarla = new Guna.UI2.WinForms.Guna2Button();
            this.lblPerdeBaslik = new System.Windows.Forms.Label();
            this.tabAyarlar = new System.Windows.Forms.TabPage();
            this.pnlBaglanti = new Guna.UI2.WinForms.Guna2Panel();
            this.lblBaglantiDurumu = new System.Windows.Forms.Label();
            this.btnBaglantiyiKes = new Guna.UI2.WinForms.Guna2Button();
            this.btnBaglan = new Guna.UI2.WinForms.Guna2Button();
            this.cmbBaud = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbPort = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblAyarlarBaslik = new System.Windows.Forms.Label();
            this.pnlSideMenu.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.tabKlima.SuspendLayout();
            this.pnlKlimaBilgi.SuspendLayout();
            this.pnlKlimaCard.SuspendLayout();
            this.progressTermostat.SuspendLayout();
            this.tabPerde.SuspendLayout();
            this.pnlPerdeBilgi.SuspendLayout();
            this.pnlPerdeCard.SuspendLayout();
            this.tabAyarlar.SuspendLayout();
            this.pnlBaglanti.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(25)))));
            this.pnlSideMenu.Controls.Add(this.btnCikisYap);
            this.pnlSideMenu.Controls.Add(this.btnAyarlar);
            this.pnlSideMenu.Controls.Add(this.btnPerde);
            this.pnlSideMenu.Controls.Add(this.btnKlima);
            this.pnlSideMenu.Controls.Add(this.lblLogo);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(293, 800);
            this.pnlSideMenu.TabIndex = 0;
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.Animated = true;
            this.btnCikisYap.BorderRadius = 10;
            this.btnCikisYap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnCikisYap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCikisYap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnCikisYap.Location = new System.Drawing.Point(29, 714);
            this.btnCikisYap.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(235, 55);
            this.btnCikisYap.TabIndex = 4;
            this.btnCikisYap.Text = "Çıkış Yap";
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.Animated = true;
            this.btnAyarlar.BorderRadius = 10;
            this.btnAyarlar.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAyarlar.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(255)))));
            this.btnAyarlar.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnAyarlar.FillColor = System.Drawing.Color.Transparent;
            this.btnAyarlar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAyarlar.ForeColor = System.Drawing.Color.Gray;
            this.btnAyarlar.Location = new System.Drawing.Point(29, 295);
            this.btnAyarlar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(235, 55);
            this.btnAyarlar.TabIndex = 3;
            this.btnAyarlar.Text = "Ayarlar";
            this.btnAyarlar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnPerde
            // 
            this.btnPerde.Animated = true;
            this.btnPerde.BorderRadius = 10;
            this.btnPerde.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPerde.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(255)))));
            this.btnPerde.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnPerde.FillColor = System.Drawing.Color.Transparent;
            this.btnPerde.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPerde.ForeColor = System.Drawing.Color.Gray;
            this.btnPerde.Location = new System.Drawing.Point(29, 222);
            this.btnPerde.Margin = new System.Windows.Forms.Padding(4);
            this.btnPerde.Name = "btnPerde";
            this.btnPerde.Size = new System.Drawing.Size(235, 55);
            this.btnPerde.TabIndex = 2;
            this.btnPerde.Text = "Perde Kontrol";
            this.btnPerde.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnKlima
            // 
            this.btnKlima.Animated = true;
            this.btnKlima.BorderRadius = 10;
            this.btnKlima.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnKlima.Checked = true;
            this.btnKlima.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(255)))));
            this.btnKlima.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnKlima.FillColor = System.Drawing.Color.Transparent;
            this.btnKlima.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKlima.ForeColor = System.Drawing.Color.Gray;
            this.btnKlima.Location = new System.Drawing.Point(29, 148);
            this.btnKlima.Margin = new System.Windows.Forms.Padding(4);
            this.btnKlima.Name = "btnKlima";
            this.btnKlima.Size = new System.Drawing.Size(235, 55);
            this.btnKlima.TabIndex = 1;
            this.btnKlima.Text = "Klima";
            this.btnKlima.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(33, 49);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(176, 32);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "SMART HOME";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.pnlHeader;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.pnlHeader.Controls.Add(this.ctrlClose);
            this.pnlHeader.Controls.Add(this.ctrlMinimize);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(293, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1107, 49);
            this.pnlHeader.TabIndex = 5;
            // 
            // ctrlClose
            // 
            this.ctrlClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.ctrlClose.FillColor = System.Drawing.Color.Transparent;
            this.ctrlClose.IconColor = System.Drawing.Color.White;
            this.ctrlClose.Location = new System.Drawing.Point(987, 0);
            this.ctrlClose.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlClose.Name = "ctrlClose";
            this.ctrlClose.Size = new System.Drawing.Size(60, 49);
            this.ctrlClose.TabIndex = 2;
            // 
            // ctrlMinimize
            // 
            this.ctrlMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.ctrlMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.ctrlMinimize.FillColor = System.Drawing.Color.Transparent;
            this.ctrlMinimize.IconColor = System.Drawing.Color.White;
            this.ctrlMinimize.Location = new System.Drawing.Point(1047, 0);
            this.ctrlMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlMinimize.Name = "ctrlMinimize";
            this.ctrlMinimize.Size = new System.Drawing.Size(60, 49);
            this.ctrlMinimize.TabIndex = 3;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.mainTabControl.Controls.Add(this.tabKlima);
            this.mainTabControl.Controls.Add(this.tabPerde);
            this.mainTabControl.Controls.Add(this.tabAyarlar);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.ItemSize = new System.Drawing.Size(180, 40);
            this.mainTabControl.Location = new System.Drawing.Point(293, 49);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1107, 751);
            this.mainTabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.mainTabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.mainTabControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.mainTabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.mainTabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.mainTabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.mainTabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.mainTabControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.mainTabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.mainTabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.mainTabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.mainTabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.mainTabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.mainTabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.mainTabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.mainTabControl.TabButtonSize = new System.Drawing.Size(180, 40);
            this.mainTabControl.TabIndex = 0;
            this.mainTabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.mainTabControl.TabMenuVisible = false;
            // 
            // tabKlima
            // 
            this.tabKlima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.tabKlima.Controls.Add(this.pnlKlimaBilgi);
            this.tabKlima.Controls.Add(this.pnlKlimaCard);
            this.tabKlima.Controls.Add(this.lblKlimaBaslik);
            this.tabKlima.Location = new System.Drawing.Point(5, 4);
            this.tabKlima.Margin = new System.Windows.Forms.Padding(4);
            this.tabKlima.Name = "tabKlima";
            this.tabKlima.Padding = new System.Windows.Forms.Padding(4);
            this.tabKlima.Size = new System.Drawing.Size(1098, 743);
            this.tabKlima.TabIndex = 0;
            this.tabKlima.Text = "Klima";
            // 
            // pnlKlimaBilgi
            // 
            this.pnlKlimaBilgi.BackColor = System.Drawing.Color.Transparent;
            this.pnlKlimaBilgi.BorderColor = System.Drawing.Color.Gray;
            this.pnlKlimaBilgi.BorderRadius = 15;
            this.pnlKlimaBilgi.BorderThickness = 1;
            this.pnlKlimaBilgi.Controls.Add(this.lblKlimaPortBilgi);
            this.pnlKlimaBilgi.Controls.Add(this.lblFanSpeed);
            this.pnlKlimaBilgi.Controls.Add(this.lblHomeDesired);
            this.pnlKlimaBilgi.Controls.Add(this.lblHomeAmbient);
            this.pnlKlimaBilgi.Controls.Add(this.labelBaslik1);
            this.pnlKlimaBilgi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.pnlKlimaBilgi.Location = new System.Drawing.Point(600, 98);
            this.pnlKlimaBilgi.Margin = new System.Windows.Forms.Padding(4);
            this.pnlKlimaBilgi.Name = "pnlKlimaBilgi";
            this.pnlKlimaBilgi.Size = new System.Drawing.Size(427, 308);
            this.pnlKlimaBilgi.TabIndex = 2;
            // 
            // lblKlimaPortBilgi
            // 
            this.lblKlimaPortBilgi.AutoSize = true;
            this.lblKlimaPortBilgi.Font = new System.Drawing.Font("Consolas", 9F);
            this.lblKlimaPortBilgi.ForeColor = System.Drawing.Color.Gray;
            this.lblKlimaPortBilgi.Location = new System.Drawing.Point(27, 222);
            this.lblKlimaPortBilgi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKlimaPortBilgi.Name = "lblKlimaPortBilgi";
            this.lblKlimaPortBilgi.Size = new System.Drawing.Size(192, 36);
            this.lblKlimaPortBilgi.TabIndex = 4;
            this.lblKlimaPortBilgi.Text = "Connection Port: --\r\nConnection Baudrate: --";
            // 
            // lblFanSpeed
            // 
            this.lblFanSpeed.AutoSize = true;
            this.lblFanSpeed.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblFanSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.lblFanSpeed.Location = new System.Drawing.Point(27, 160);
            this.lblFanSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFanSpeed.Name = "lblFanSpeed";
            this.lblFanSpeed.Size = new System.Drawing.Size(148, 25);
            this.lblFanSpeed.TabIndex = 3;
            this.lblFanSpeed.Text = "Fan Speed: 0 rps";
            // 
            // lblHomeDesired
            // 
            this.lblHomeDesired.AutoSize = true;
            this.lblHomeDesired.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblHomeDesired.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHomeDesired.Location = new System.Drawing.Point(27, 117);
            this.lblHomeDesired.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHomeDesired.Name = "lblHomeDesired";
            this.lblHomeDesired.Size = new System.Drawing.Size(248, 25);
            this.lblHomeDesired.TabIndex = 2;
            this.lblHomeDesired.Text = "Home Desired Temp: 22.0 °C";
            // 
            // lblHomeAmbient
            // 
            this.lblHomeAmbient.AutoSize = true;
            this.lblHomeAmbient.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblHomeAmbient.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHomeAmbient.Location = new System.Drawing.Point(27, 74);
            this.lblHomeAmbient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHomeAmbient.Name = "lblHomeAmbient";
            this.lblHomeAmbient.Size = new System.Drawing.Size(255, 25);
            this.lblHomeAmbient.TabIndex = 1;
            this.lblHomeAmbient.Text = "Home Ambient Temp: 24.5 °C";
            // 
            // labelBaslik1
            // 
            this.labelBaslik1.AutoSize = true;
            this.labelBaslik1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelBaslik1.ForeColor = System.Drawing.Color.White;
            this.labelBaslik1.Location = new System.Drawing.Point(27, 25);
            this.labelBaslik1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBaslik1.Name = "labelBaslik1";
            this.labelBaslik1.Size = new System.Drawing.Size(189, 28);
            this.labelBaslik1.TabIndex = 0;
            this.labelBaslik1.Text = "SYSTEM MONITOR";
            // 
            // pnlKlimaCard
            // 
            this.pnlKlimaCard.BackColor = System.Drawing.Color.Transparent;
            this.pnlKlimaCard.BorderRadius = 30;
            this.pnlKlimaCard.Controls.Add(this.btnSicaklikArttir);
            this.pnlKlimaCard.Controls.Add(this.btnSicaklikAzalt);
            this.pnlKlimaCard.Controls.Add(this.progressTermostat);
            this.pnlKlimaCard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.pnlKlimaCard.Location = new System.Drawing.Point(40, 98);
            this.pnlKlimaCard.Margin = new System.Windows.Forms.Padding(4);
            this.pnlKlimaCard.Name = "pnlKlimaCard";
            this.pnlKlimaCard.Size = new System.Drawing.Size(533, 517);
            this.pnlKlimaCard.TabIndex = 1;
            // 
            // btnSicaklikArttir
            // 
            this.btnSicaklikArttir.Animated = true;
            this.btnSicaklikArttir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.btnSicaklikArttir.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnSicaklikArttir.ForeColor = System.Drawing.Color.White;
            this.btnSicaklikArttir.Location = new System.Drawing.Point(427, 228);
            this.btnSicaklikArttir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSicaklikArttir.Name = "btnSicaklikArttir";
            this.btnSicaklikArttir.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSicaklikArttir.Size = new System.Drawing.Size(67, 62);
            this.btnSicaklikArttir.TabIndex = 3;
            this.btnSicaklikArttir.Text = "+";
            // 
            // btnSicaklikAzalt
            // 
            this.btnSicaklikAzalt.Animated = true;
            this.btnSicaklikAzalt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.btnSicaklikAzalt.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnSicaklikAzalt.ForeColor = System.Drawing.Color.White;
            this.btnSicaklikAzalt.Location = new System.Drawing.Point(40, 228);
            this.btnSicaklikAzalt.Margin = new System.Windows.Forms.Padding(4);
            this.btnSicaklikAzalt.Name = "btnSicaklikAzalt";
            this.btnSicaklikAzalt.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSicaklikAzalt.Size = new System.Drawing.Size(67, 62);
            this.btnSicaklikAzalt.TabIndex = 2;
            this.btnSicaklikAzalt.Text = "-";
            // 
            // progressTermostat
            // 
            this.progressTermostat.Controls.Add(this.lblDerece);
            this.progressTermostat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.progressTermostat.FillThickness = 12;
            this.progressTermostat.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.progressTermostat.ForeColor = System.Drawing.Color.White;
            this.progressTermostat.Location = new System.Drawing.Point(67, 74);
            this.progressTermostat.Margin = new System.Windows.Forms.Padding(4);
            this.progressTermostat.Minimum = 0;
            this.progressTermostat.Name = "progressTermostat";
            this.progressTermostat.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.progressTermostat.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.progressTermostat.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.progressTermostat.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.progressTermostat.ProgressThickness = 12;
            this.progressTermostat.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.progressTermostat.Size = new System.Drawing.Size(369, 369);
            this.progressTermostat.TabIndex = 0;
            this.progressTermostat.Value = 65;
            // 
            // lblDerece
            // 
            this.lblDerece.AutoSize = true;
            this.lblDerece.BackColor = System.Drawing.Color.Transparent;
            this.lblDerece.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold);
            this.lblDerece.ForeColor = System.Drawing.Color.White;
            this.lblDerece.Location = new System.Drawing.Point(79, 128);
            this.lblDerece.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDerece.Name = "lblDerece";
            this.lblDerece.Size = new System.Drawing.Size(217, 106);
            this.lblDerece.TabIndex = 1;
            this.lblDerece.Text = "22°C";
            // 
            // lblKlimaBaslik
            // 
            this.lblKlimaBaslik.AutoSize = true;
            this.lblKlimaBaslik.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblKlimaBaslik.ForeColor = System.Drawing.Color.White;
            this.lblKlimaBaslik.Location = new System.Drawing.Point(40, 37);
            this.lblKlimaBaslik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKlimaBaslik.Name = "lblKlimaBaslik";
            this.lblKlimaBaslik.Size = new System.Drawing.Size(214, 41);
            this.lblKlimaBaslik.TabIndex = 0;
            this.lblKlimaBaslik.Text = "Oturma Odası";
            // 
            // tabPerde
            // 
            this.tabPerde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.tabPerde.Controls.Add(this.pnlPerdeBilgi);
            this.tabPerde.Controls.Add(this.pnlPerdeCard);
            this.tabPerde.Controls.Add(this.lblPerdeBaslik);
            this.tabPerde.Location = new System.Drawing.Point(5, 4);
            this.tabPerde.Margin = new System.Windows.Forms.Padding(4);
            this.tabPerde.Name = "tabPerde";
            this.tabPerde.Padding = new System.Windows.Forms.Padding(4);
            this.tabPerde.Size = new System.Drawing.Size(1098, 743);
            this.tabPerde.TabIndex = 1;
            this.tabPerde.Text = "Perde";
            // 
            // pnlPerdeBilgi
            // 
            this.pnlPerdeBilgi.BackColor = System.Drawing.Color.Transparent;
            this.pnlPerdeBilgi.BorderColor = System.Drawing.Color.Gray;
            this.pnlPerdeBilgi.BorderRadius = 15;
            this.pnlPerdeBilgi.BorderThickness = 1;
            this.pnlPerdeBilgi.Controls.Add(this.lblPerdePortBilgi);
            this.pnlPerdeBilgi.Controls.Add(this.lblLightIntensity);
            this.pnlPerdeBilgi.Controls.Add(this.lblCurtainStatus);
            this.pnlPerdeBilgi.Controls.Add(this.lblOutdoorPressure);
            this.pnlPerdeBilgi.Controls.Add(this.lblOutdoorTemp);
            this.pnlPerdeBilgi.Controls.Add(this.labelBaslik2);
            this.pnlPerdeBilgi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.pnlPerdeBilgi.Location = new System.Drawing.Point(640, 98);
            this.pnlPerdeBilgi.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPerdeBilgi.Name = "pnlPerdeBilgi";
            this.pnlPerdeBilgi.Size = new System.Drawing.Size(427, 308);
            this.pnlPerdeBilgi.TabIndex = 3;
            // 
            // lblPerdePortBilgi
            // 
            this.lblPerdePortBilgi.AutoSize = true;
            this.lblPerdePortBilgi.Font = new System.Drawing.Font("Consolas", 9F);
            this.lblPerdePortBilgi.ForeColor = System.Drawing.Color.Gray;
            this.lblPerdePortBilgi.Location = new System.Drawing.Point(27, 246);
            this.lblPerdePortBilgi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerdePortBilgi.Name = "lblPerdePortBilgi";
            this.lblPerdePortBilgi.Size = new System.Drawing.Size(192, 36);
            this.lblPerdePortBilgi.TabIndex = 5;
            this.lblPerdePortBilgi.Text = "Connection Port: --\r\nConnection Baudrate: --";
            // 
            // lblLightIntensity
            // 
            this.lblLightIntensity.AutoSize = true;
            this.lblLightIntensity.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblLightIntensity.ForeColor = System.Drawing.Color.Yellow;
            this.lblLightIntensity.Location = new System.Drawing.Point(27, 197);
            this.lblLightIntensity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLightIntensity.Name = "lblLightIntensity";
            this.lblLightIntensity.Size = new System.Drawing.Size(197, 25);
            this.lblLightIntensity.TabIndex = 4;
            this.lblLightIntensity.Text = "Light Intensity: 0.0 Lux";
            // 
            // lblCurtainStatus
            // 
            this.lblCurtainStatus.AutoSize = true;
            this.lblCurtainStatus.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCurtainStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.lblCurtainStatus.Location = new System.Drawing.Point(27, 154);
            this.lblCurtainStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurtainStatus.Name = "lblCurtainStatus";
            this.lblCurtainStatus.Size = new System.Drawing.Size(169, 25);
            this.lblCurtainStatus.TabIndex = 3;
            this.lblCurtainStatus.Text = "Curtain Status: 0 %";
            // 
            // lblOutdoorPressure
            // 
            this.lblOutdoorPressure.AutoSize = true;
            this.lblOutdoorPressure.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblOutdoorPressure.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblOutdoorPressure.Location = new System.Drawing.Point(27, 111);
            this.lblOutdoorPressure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutdoorPressure.Name = "lblOutdoorPressure";
            this.lblOutdoorPressure.Size = new System.Drawing.Size(229, 25);
            this.lblOutdoorPressure.TabIndex = 2;
            this.lblOutdoorPressure.Text = "Outdoor Pressure: 0.0 hPa";
            // 
            // lblOutdoorTemp
            // 
            this.lblOutdoorTemp.AutoSize = true;
            this.lblOutdoorTemp.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblOutdoorTemp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblOutdoorTemp.Location = new System.Drawing.Point(27, 68);
            this.lblOutdoorTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutdoorTemp.Name = "lblOutdoorTemp";
            this.lblOutdoorTemp.Size = new System.Drawing.Size(200, 25);
            this.lblOutdoorTemp.TabIndex = 1;
            this.lblOutdoorTemp.Text = "Outdoor Temp: 20.0 °C";
            // 
            // labelBaslik2
            // 
            this.labelBaslik2.AutoSize = true;
            this.labelBaslik2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelBaslik2.ForeColor = System.Drawing.Color.White;
            this.labelBaslik2.Location = new System.Drawing.Point(27, 25);
            this.labelBaslik2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBaslik2.Name = "labelBaslik2";
            this.labelBaslik2.Size = new System.Drawing.Size(189, 28);
            this.labelBaslik2.TabIndex = 0;
            this.labelBaslik2.Text = "SYSTEM MONITOR";
            // 
            // pnlPerdeCard
            // 
            this.pnlPerdeCard.BackColor = System.Drawing.Color.Transparent;
            this.pnlPerdeCard.BorderRadius = 30;
            this.pnlPerdeCard.Controls.Add(this.lblPerdeYuzde);
            this.pnlPerdeCard.Controls.Add(this.trackBarPerde);
            this.pnlPerdeCard.Controls.Add(this.btnPerdeAyarla);
            this.pnlPerdeCard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.pnlPerdeCard.Location = new System.Drawing.Point(40, 98);
            this.pnlPerdeCard.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPerdeCard.Name = "pnlPerdeCard";
            this.pnlPerdeCard.Size = new System.Drawing.Size(573, 517);
            this.pnlPerdeCard.TabIndex = 2;
            // 
            // lblPerdeYuzde
            // 
            this.lblPerdeYuzde.AutoSize = true;
            this.lblPerdeYuzde.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold);
            this.lblPerdeYuzde.ForeColor = System.Drawing.Color.White;
            this.lblPerdeYuzde.Location = new System.Drawing.Point(173, 62);
            this.lblPerdeYuzde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerdeYuzde.Name = "lblPerdeYuzde";
            this.lblPerdeYuzde.Size = new System.Drawing.Size(206, 106);
            this.lblPerdeYuzde.TabIndex = 2;
            this.lblPerdeYuzde.Text = "65%";
            // 
            // trackBarPerde
            // 
            this.trackBarPerde.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.trackBarPerde.HoverState.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.trackBarPerde.Location = new System.Drawing.Point(53, 222);
            this.trackBarPerde.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarPerde.Name = "trackBarPerde";
            this.trackBarPerde.Size = new System.Drawing.Size(467, 49);
            this.trackBarPerde.TabIndex = 1;
            this.trackBarPerde.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(255)))));
            this.trackBarPerde.Value = 65;
            // 
            // btnPerdeAyarla
            // 
            this.btnPerdeAyarla.BorderRadius = 15;
            this.btnPerdeAyarla.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(255)))));
            this.btnPerdeAyarla.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPerdeAyarla.ForeColor = System.Drawing.Color.White;
            this.btnPerdeAyarla.Location = new System.Drawing.Point(153, 295);
            this.btnPerdeAyarla.Margin = new System.Windows.Forms.Padding(4);
            this.btnPerdeAyarla.Name = "btnPerdeAyarla";
            this.btnPerdeAyarla.Size = new System.Drawing.Size(267, 55);
            this.btnPerdeAyarla.TabIndex = 0;
            this.btnPerdeAyarla.Text = "Enter Desired Curtain";
            // 
            // lblPerdeBaslik
            // 
            this.lblPerdeBaslik.AutoSize = true;
            this.lblPerdeBaslik.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblPerdeBaslik.ForeColor = System.Drawing.Color.White;
            this.lblPerdeBaslik.Location = new System.Drawing.Point(40, 37);
            this.lblPerdeBaslik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerdeBaslik.Name = "lblPerdeBaslik";
            this.lblPerdeBaslik.Size = new System.Drawing.Size(230, 41);
            this.lblPerdeBaslik.TabIndex = 1;
            this.lblPerdeBaslik.Text = "Salon Perdeleri";
            // 
            // tabAyarlar
            // 
            this.tabAyarlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.tabAyarlar.Controls.Add(this.pnlBaglanti);
            this.tabAyarlar.Controls.Add(this.lblAyarlarBaslik);
            this.tabAyarlar.Location = new System.Drawing.Point(5, 4);
            this.tabAyarlar.Margin = new System.Windows.Forms.Padding(4);
            this.tabAyarlar.Name = "tabAyarlar";
            this.tabAyarlar.Size = new System.Drawing.Size(1098, 743);
            this.tabAyarlar.TabIndex = 2;
            this.tabAyarlar.Text = "Ayarlar";
            // 
            // pnlBaglanti
            // 
            this.pnlBaglanti.BackColor = System.Drawing.Color.Transparent;
            this.pnlBaglanti.BorderRadius = 30;
            this.pnlBaglanti.Controls.Add(this.lblBaglantiDurumu);
            this.pnlBaglanti.Controls.Add(this.btnBaglantiyiKes);
            this.pnlBaglanti.Controls.Add(this.btnBaglan);
            this.pnlBaglanti.Controls.Add(this.cmbBaud);
            this.pnlBaglanti.Controls.Add(this.cmbPort);
            this.pnlBaglanti.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.pnlBaglanti.Location = new System.Drawing.Point(247, 98);
            this.pnlBaglanti.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBaglanti.Name = "pnlBaglanti";
            this.pnlBaglanti.Size = new System.Drawing.Size(600, 492);
            this.pnlBaglanti.TabIndex = 3;
            // 
            // lblBaglantiDurumu
            // 
            this.lblBaglantiDurumu.AutoSize = true;
            this.lblBaglantiDurumu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBaglantiDurumu.ForeColor = System.Drawing.Color.IndianRed;
            this.lblBaglantiDurumu.Location = new System.Drawing.Point(240, 49);
            this.lblBaglantiDurumu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaglantiDurumu.Name = "lblBaglantiDurumu";
            this.lblBaglantiDurumu.Size = new System.Drawing.Size(116, 28);
            this.lblBaglantiDurumu.TabIndex = 4;
            this.lblBaglantiDurumu.Text = "Bağlı Değil";
            // 
            // btnBaglantiyiKes
            // 
            this.btnBaglantiyiKes.BorderRadius = 15;
            this.btnBaglantiyiKes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.btnBaglantiyiKes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBaglantiyiKes.ForeColor = System.Drawing.Color.White;
            this.btnBaglantiyiKes.Location = new System.Drawing.Point(67, 345);
            this.btnBaglantiyiKes.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaglantiyiKes.Name = "btnBaglantiyiKes";
            this.btnBaglantiyiKes.Size = new System.Drawing.Size(467, 55);
            this.btnBaglantiyiKes.TabIndex = 3;
            this.btnBaglantiyiKes.Text = "Bağlantıyı Kes";
            // 
            // btnBaglan
            // 
            this.btnBaglan.BorderRadius = 15;
            this.btnBaglan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(255)))));
            this.btnBaglan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBaglan.ForeColor = System.Drawing.Color.White;
            this.btnBaglan.Location = new System.Drawing.Point(67, 271);
            this.btnBaglan.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(467, 55);
            this.btnBaglan.TabIndex = 2;
            this.btnBaglan.Text = "Bağlan";
            // 
            // cmbBaud
            // 
            this.cmbBaud.BackColor = System.Drawing.Color.Transparent;
            this.cmbBaud.BorderRadius = 10;
            this.cmbBaud.BorderThickness = 0;
            this.cmbBaud.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaud.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.cmbBaud.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBaud.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBaud.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbBaud.ForeColor = System.Drawing.Color.White;
            this.cmbBaud.ItemHeight = 30;
            this.cmbBaud.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.cmbBaud.Location = new System.Drawing.Point(67, 185);
            this.cmbBaud.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBaud.Name = "cmbBaud";
            this.cmbBaud.Size = new System.Drawing.Size(465, 36);
            this.cmbBaud.TabIndex = 1;
            // 
            // cmbPort
            // 
            this.cmbPort.BackColor = System.Drawing.Color.Transparent;
            this.cmbPort.BorderRadius = 10;
            this.cmbPort.BorderThickness = 0;
            this.cmbPort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPort.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.cmbPort.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPort.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPort.ForeColor = System.Drawing.Color.White;
            this.cmbPort.ItemHeight = 30;
            this.cmbPort.Location = new System.Drawing.Point(67, 123);
            this.cmbPort.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(465, 36);
            this.cmbPort.TabIndex = 0;
            // 
            // lblAyarlarBaslik
            // 
            this.lblAyarlarBaslik.AutoSize = true;
            this.lblAyarlarBaslik.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblAyarlarBaslik.ForeColor = System.Drawing.Color.White;
            this.lblAyarlarBaslik.Location = new System.Drawing.Point(413, 25);
            this.lblAyarlarBaslik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAyarlarBaslik.Name = "lblAyarlarBaslik";
            this.lblAyarlarBaslik.Size = new System.Drawing.Size(254, 41);
            this.lblAyarlarBaslik.TabIndex = 2;
            this.lblAyarlarBaslik.Text = "Bağlantı Ayarları";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlSideMenu.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.mainTabControl.ResumeLayout(false);
            this.tabKlima.ResumeLayout(false);
            this.tabKlima.PerformLayout();
            this.pnlKlimaBilgi.ResumeLayout(false);
            this.pnlKlimaBilgi.PerformLayout();
            this.pnlKlimaCard.ResumeLayout(false);
            this.progressTermostat.ResumeLayout(false);
            this.progressTermostat.PerformLayout();
            this.tabPerde.ResumeLayout(false);
            this.tabPerde.PerformLayout();
            this.pnlPerdeBilgi.ResumeLayout(false);
            this.pnlPerdeBilgi.PerformLayout();
            this.pnlPerdeCard.ResumeLayout(false);
            this.pnlPerdeCard.PerformLayout();
            this.tabAyarlar.ResumeLayout(false);
            this.tabAyarlar.PerformLayout();
            this.pnlBaglanti.ResumeLayout(false);
            this.pnlBaglanti.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel pnlSideMenu;
        private Guna.UI2.WinForms.Guna2Button btnKlima;
        private System.Windows.Forms.Label lblLogo;
        private Guna.UI2.WinForms.Guna2Button btnAyarlar;
        private Guna.UI2.WinForms.Guna2Button btnPerde;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2TabControl mainTabControl;
        private System.Windows.Forms.TabPage tabKlima;
        private System.Windows.Forms.TabPage tabPerde;
        private System.Windows.Forms.TabPage tabAyarlar;
        private System.Windows.Forms.Label lblKlimaBaslik;
        private Guna.UI2.WinForms.Guna2Panel pnlKlimaCard;
        private Guna.UI2.WinForms.Guna2CircleProgressBar progressTermostat;
        private System.Windows.Forms.Label lblDerece;
        private Guna.UI2.WinForms.Guna2CircleButton btnSicaklikArttir;
        private Guna.UI2.WinForms.Guna2CircleButton btnSicaklikAzalt;
        private Guna.UI2.WinForms.Guna2Panel pnlPerdeCard;
        private System.Windows.Forms.Label lblPerdeBaslik;
        private Guna.UI2.WinForms.Guna2Button btnPerdeAyarla;
        private Guna.UI2.WinForms.Guna2TrackBar trackBarPerde;
        private System.Windows.Forms.Label lblPerdeYuzde;
        private Guna.UI2.WinForms.Guna2Panel pnlBaglanti;
        private System.Windows.Forms.Label lblAyarlarBaslik;
        private Guna.UI2.WinForms.Guna2ComboBox cmbBaud;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPort;
        private Guna.UI2.WinForms.Guna2Button btnBaglantiyiKes;
        private Guna.UI2.WinForms.Guna2Button btnBaglan;
        private System.Windows.Forms.Label lblBaglantiDurumu;
        private Guna.UI2.WinForms.Guna2Button btnCikisYap;
        private Guna.UI2.WinForms.Guna2ControlBox ctrlMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox ctrlClose;

        // YENİ EKLENEN PANELLER VE LABELLAR
        private Guna.UI2.WinForms.Guna2Panel pnlKlimaBilgi;
        private System.Windows.Forms.Label labelBaslik1;
        private System.Windows.Forms.Label lblHomeAmbient;
        private System.Windows.Forms.Label lblHomeDesired;
        private System.Windows.Forms.Label lblFanSpeed;
        private System.Windows.Forms.Label lblKlimaPortBilgi;

        private Guna.UI2.WinForms.Guna2Panel pnlPerdeBilgi;
        private System.Windows.Forms.Label labelBaslik2;
        private System.Windows.Forms.Label lblOutdoorTemp;
        private System.Windows.Forms.Label lblOutdoorPressure;
        private System.Windows.Forms.Label lblCurtainStatus;
        private System.Windows.Forms.Label lblLightIntensity;
        private System.Windows.Forms.Label lblPerdePortBilgi;
    }
}