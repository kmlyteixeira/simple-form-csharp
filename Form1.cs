using System.Windows.Forms;

namespace simple_form_csharp;

public class Form1 : Form
{
    private Label label1;
    private TextBox textBox1;
    private Button button1;
    private Button button2;

    public Form1()
    {
        InitializeComponent();
    }

    public void InitializeComponent()
    {
        this.label1 = new Label();
        this.textBox1 = new TextBox();
        this.button1 = new Button();
        this.button2 = new Button();

        this.label1.AutoSize = true;
        this.label1.Location = new Point(12, 9);
        this.label1.Name = "label1";
        this.label1.Size = new Size(35, 13);
        this.label1.TabIndex = 0;
        this.label1.Text = "Seu Nome";

        this.textBox1.Location = new Point(12, 25);
        this.textBox1.Name = "Insira Seu Nome Aqui";
        this.textBox1.Size = new Size(200, 20);
        this.textBox1.TabIndex = 1;

        this.button1.Location = new Point(12, 51);
        this.button1.Name = "button1";
        this.button1.Size = new Size(75, 23);
        this.button1.TabIndex = 2;
        this.button1.Text = "Olá";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new EventHandler((sender, e) => MessageBox.Show("Olá, " + this.textBox1.Text));
        
        this.button2.Location = new Point(12, 80);
        this.button2.Name = "button2";
        this.button2.Size = new Size(75, 23);
        this.button2.TabIndex = 3;
        this.button2.Text = "Sair";
        this.button2.UseVisualStyleBackColor = true;
        this.button2.Click += new EventHandler((sender, e) => Application.Exit());

        this.ClientSize = new Size(284, 261);
        this.Controls.Add(this.button2);
        this.Controls.Add(this.button1);
        this.Controls.Add(this.textBox1);
        this.Controls.Add(this.label1);
        this.Name = "Form1";
        this.ResumeLayout(false);
        this.PerformLayout();

        this.ShowDialog();
    }
}
