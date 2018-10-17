using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

public class Form1 : Form
{
    //TextBox textBox1 = new TextBox();
    //TextBox textBox2 = new TextBox();
    //TextBox textBox3 = new TextBox();
    //TextBox textBox4 = new TextBox();
    public Form1()
    {
        this.AutoScaleBaseSize = new Size(6, 14);
        this.ClientSize = new Size(400, 300);
        this.Paint += new PaintEventHandler(this.Form1_Paint);
    }
    static void Main()
    {
        Application.Run(new Form1());
    }
    private void Form1_Paint(object sender, PaintEventArgs e)
    {
        graphics = e.Graphics;
        drawCayleyTree(10, 200, 310, 100, -Math.PI / 2);
    }

    private Graphics graphics;
    readonly double th1 = 30 * Math.PI / 180;
    readonly double th2 = 20 * Math.PI / 180;
    readonly double per1 = 0.6;
    private TextBox textBox1;
    private TextBox textBox2;
    private TextBox textBox3;
    private TextBox textBox4;
    private Button button1;
    readonly double per2 = 0.7;

    void drawCayleyTree(int n,
            double x0, double y0, double leng, double th)
    {
        if (n == 0) return;

        int k = 2;
        double x1 = x0 + leng * Math.Cos(th);
        double x2 = x0 + leng * k * Math.Cos(th);
        double y1 = y0 + leng * Math.Sin(th);
        double y2 = y0 + leng * k * Math.Sin(th);

        drawLine(x0, y0, x1, y1);
        drawLine(x0, y0, x2, y2);

        drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
        drawCayleyTree(n - 1, x2, y2, per2 * leng, th - th2);
    }
    void drawLine(double x0, double y0, double x1, double y1)
    {
        graphics.DrawLine(
            Pens.Blue,
            (int)x0, (int)y0, (int)x1, (int)y1);
    }

    private void InitializeComponent()
    {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(651, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 35);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "请输入角度1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(651, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 35);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "请输入角度2";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(651, 153);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(157, 35);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "请输入长度1";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(651, 194);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(157, 35);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "请输入长度2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(651, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "生成树";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(841, 704);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

}

