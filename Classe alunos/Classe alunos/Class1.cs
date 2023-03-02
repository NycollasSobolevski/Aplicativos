using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_alunos
{
    public class Aluno
    {
        public string Nome { get; private set; }
        public string CPF{ get; private set; }
        public string Nascimento { get; private set; }
        public int Faltas { get; private set; }
        public float Nota1 { get; private set; }
        public float Nota2 { get; private set; }
        public bool Recuperação { get; set; } = false;
        
        public Aluno(string nome, string cpf, string nascimento)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.Nascimento = nascimento;
        }

        public void SetNota(int nota, float valor)
        {
            if (nota == 1)
                this.Nota1 = valor;
            else if (nota == 2)
                this.Nota2 = valor;
        }

        public bool FoiAprovado() => (((this.Nota1 + this.Nota2) / 2) >= 70);

    }
    public class Carro
    {
        public Carro(string marca, string modelo, string ano)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
        }

        private string Marca { get;  set; }
        private string Modelo { get;  set; }
        private string Ano { get;  set; }
        public float VelAtual { get; private set; }


        public void Acelerar(float velocidade) => VelAtual += velocidade;
        public void Frear(float frenagem) => VelAtual -= frenagem;
        public void ExibirDados() => Console.WriteLine(" Marca: "+this.Marca + " Modelo: "+this.Modelo + " Ano: "+this.Ano + " Velocidade Atual: "+this.VelAtual);
        
    }
    public class ContaCorrente
    {
        // Random nao funcionando
        Random random = new Random();
        public ContaCorrente(string corretista)
        {
            Corretista = corretista;
        }

        private int Numero { get; set; } = random.Next(10000, 99999);
        private string Corretista  { get; set; }
        private float Saldo { get; set; } = 0f;

    }
}
