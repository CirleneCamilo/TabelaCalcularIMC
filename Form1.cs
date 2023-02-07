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
            //Criamos as  vari�veis
            double altura, peso, imc;

            // pegar dados digitados por usu�rio
            altura = Convert.ToDouble(TxtAltura.Text);
            peso = Convert.ToDouble(TxtPeso.Text);

            //Calcular IMC
            imc = peso / (altura * altura);

            //Mostrar o Resultado do C�lculo
            LbResultado.Text = "Resultado do IMC : " + imc;

            if (imc < 18.5)
            {
                LbMensagem.Text = "Mensagem : Voc� est� muito Magro";
                LbMensagem.ForeColor = System.Drawing.Color.BlueViolet;
            }
            if ((imc >= 18.5) && (imc < 24.9))
            {
                LbMensagem.Text = "Mensagem : Voc� est� no peso Ideal";
                LbMensagem.ForeColor = System.Drawing.Color.Green;
            }
            if ((imc >= 25) && (imc < 29.9))
            {
                LbMensagem.Text = "Mensagem : Voc� est� com Sobrepeso";
                LbMensagem.ForeColor = System.Drawing.Color.Brown;
            }
            if ((imc >= 30) && (imc < 34.9))
            {
                LbMensagem.Text = "Mensagem : Voc� est� com Obesidade Grau I";
                LbMensagem.ForeColor = System.Drawing.Color.Blue;
            }
            if ((imc >= 35) && (imc < 39.9))
            {
                LbMensagem.Text = "Mensagem : Voc� est� com Obesidade Grau II";
                LbMensagem.ForeColor = System.Drawing.Color.Red;
            }
            if (imc >= 40)
            {
                LbMensagem.Text = "Mensagem : Voc� est� com Obesidade Grau III";
                LbMensagem.ForeColor = System.Drawing.Color.DarkBlue;
            }
        }
    }
}