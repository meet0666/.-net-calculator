namespace ProfessionalCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtDisplay;

        private System.Windows.Forms.Button btn0, btn1, btn2, btn3, btn4,
        btn5, btn6, btn7, btn8, btn9;

        private System.Windows.Forms.Button btnAdd, btnSub, btnMul, btnDiv,
        btnEqual, btnClear, btnScientific;

        private System.Windows.Forms.Button btnSin, btnCos, btnTan,
        btnSqrt, btnSquare, btnLog, btnPi;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(420, 520);
            this.BackColor = System.Drawing.Color.FromArgb(30,30,30);
            this.Text = "Professional Scientific Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            txtDisplay = new System.Windows.Forms.TextBox();
            txtDisplay.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            txtDisplay.Location = new System.Drawing.Point(20,20);
            txtDisplay.Size = new System.Drawing.Size(360,60);
            txtDisplay.Text="0";
            txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txtDisplay.BackColor = System.Drawing.Color.Black;
            txtDisplay.ForeColor = System.Drawing.Color.White;
            this.Controls.Add(txtDisplay);

            CreateButton(btn7 = new Button(),"7",20,110,number_Click);
            CreateButton(btn8 = new Button(),"8",100,110,number_Click);
            CreateButton(btn9 = new Button(),"9",180,110,number_Click);
            CreateButton(btnDiv = new Button(),"/",260,110,operator_Click);

            CreateButton(btn4 = new Button(),"4",20,190,number_Click);
            CreateButton(btn5 = new Button(),"5",100,190,number_Click);
            CreateButton(btn6 = new Button(),"6",180,190,number_Click);
            CreateButton(btnMul = new Button(),"*",260,190,operator_Click);

            CreateButton(btn1 = new Button(),"1",20,270,number_Click);
            CreateButton(btn2 = new Button(),"2",100,270,number_Click);
            CreateButton(btn3 = new Button(),"3",180,270,number_Click);
            CreateButton(btnSub = new Button(),"-",260,270,operator_Click);

            CreateButton(btnClear = new Button(),"C",20,350,btnClear_Click);
            CreateButton(btn0 = new Button(),"0",100,350,number_Click);
            CreateButton(btnEqual = new Button(),"=",180,350,btnEqual_Click);
            CreateButton(btnAdd = new Button(),"+",260,350,operator_Click);

            btnScientific = new Button();
            btnScientific.Text="Scientific";
            btnScientific.Size=new System.Drawing.Size(360,40);
            btnScientific.Location=new System.Drawing.Point(20,430);
            btnScientific.BackColor=System.Drawing.Color.FromArgb(80,80,80);
            btnScientific.ForeColor=System.Drawing.Color.White;
            btnScientific.FlatStyle=System.Windows.Forms.FlatStyle.Flat;
            btnScientific.Click += btnScientific_Click;
            this.Controls.Add(btnScientific);

            // Scientific Buttons
            CreateSciButton(btnSin = new Button(),"sin",420,110,btnSin_Click);
            CreateSciButton(btnCos = new Button(),"cos",420,190,btnCos_Click);
            CreateSciButton(btnTan = new Button(),"tan",420,270,btnTan_Click);

            CreateSciButton(btnSqrt = new Button(),"√",500,110,btnSqrt_Click);
            CreateSciButton(btnSquare = new Button(),"x²",500,190,btnSquare_Click);
            CreateSciButton(btnLog = new Button(),"log",500,270,btnLog_Click);
            CreateSciButton(btnPi = new Button(),"π",460,350,btnPi_Click);

            this.ResumeLayout(false);
        }

        private void CreateButton(Button btn,string text,int x,int y,System.EventHandler handler)
        {
            btn.Text=text;
            btn.Font=new System.Drawing.Font("Segoe UI",14F,System.Drawing.FontStyle.Bold);
            btn.Size=new System.Drawing.Size(70,70);
            btn.Location=new System.Drawing.Point(x,y);
            btn.BackColor=System.Drawing.Color.FromArgb(60,60,60);
            btn.ForeColor=System.Drawing.Color.White;
            btn.FlatStyle=System.Windows.Forms.FlatStyle.Flat;
            btn.Click+=handler;
            this.Controls.Add(btn);
        }

        private void CreateSciButton(Button btn,string text,int x,int y,System.EventHandler handler)
        {
            btn.Text=text;
            btn.Font=new System.Drawing.Font("Segoe UI",12F,System.Drawing.FontStyle.Bold);
            btn.Size=new System.Drawing.Size(70,70);
            btn.Location=new System.Drawing.Point(x,y);
            btn.BackColor=System.Drawing.Color.FromArgb(90,90,90);
            btn.ForeColor=System.Drawing.Color.White;
            btn.FlatStyle=System.Windows.Forms.FlatStyle.Flat;
            btn.Click+=handler;
            this.Controls.Add(btn);
        }
    }
}