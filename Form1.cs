namespace Tabela_para_Calcular_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Criamos as  variáveis
            double altura, peso, imc;

            // pegar dados digitados por usuário
            altura = Convert.ToDouble(TxtAltura.Text);
            peso = Convert.ToDouble(TxtPeso.Text);

            //Calcular IMC
            imc = peso / (altura * altura);

            //Mostrar o Resultado do Cálculo
            LbResultado.Text = "Resultado do IMC : " + imc;

            if (imc < 18.5)
            {
                LbMensagem.Text = "Mensagem : Você está muito Magro";
                LbMensagem.ForeColor = System.Drawing.Color.BlueViolet;
            }
            if ((imc >= 18.5) && (imc < 24.9))
            {
                LbMensagem.Text = "Mensagem : Você está no peso Ideal";
                LbMensagem.ForeColor = System.Drawing.Color.Green;
            }
            if ((imc >= 25) && (imc < 29.9))
            {
                LbMensagem.Text = "Mensagem : Você está com Sobrepeso";
                LbMensagem.ForeColor = System.Drawing.Color.Brown;
            }
            if ((imc >= 30) && (imc < 34.9))
            {
                LbMensagem.Text = "Mensagem : Você está com Obesidade Grau I";
                LbMensagem.ForeColor = System.Drawing.Color.Blue;
            }
            if ((imc >= 35) && (imc < 39.9))
            {
                LbMensagem.Text = "Mensagem : Você está com Obesidade Grau II";
                LbMensagem.ForeColor = System.Drawing.Color.Red;
            }
            if (imc >= 40)
            {
                LbMensagem.Text = "Mensagem : Você está com Obesidade Grau III";
                LbMensagem.ForeColor = System.Drawing.Color.DarkBlue;
            }
        }
    }
}