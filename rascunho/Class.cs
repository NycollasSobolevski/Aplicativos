using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class ContaCorrente
    {
        // // Random nao funcionando
        public ContaCorrente(string corretista, float saldo = 0f)
        {
            Random random = new Random();
            Numero = random.Next(10000, 99999);
            Corretista = corretista;
            Saldo = saldo;
        }

        public int Numero { get; set; }
        public string Corretista  { get; set; }
        public float Saldo { get; set; } = 0f;

            //  Os métodos são os seguintes: alterar nome, depósito e saque; No construtor, o saldo é opcional, 
            // com valor default zero e os demais atributos são obrigatórios.

        public void AlterName(string name) => this.Corretista = name;
        public void Saque(float value) => this.Saldo -= value;
        public void Deposit(float value ) => this.Saldo += value;
    }

// Crie uma classe Retângulo, onde possui lado a e lado b, passados pelo construtor, e com métodos para calcular área, perímetro.

    public class Retangulo
    {
        public float LadoA{get;set;}
        public float LadoB{get;set;}
        public Retangulo(float A, float B){
            this.LadoA = A;
            this.LadoB = B;
        }

        public float Area() => this.LadoA * this.LadoB;
        public float Perimeter() => (this.LadoA * 2) + (this.LadoB * 2);
    }



// Para controlar melhor, seu gestor pediu para criar uma classe de Funcionário, com nome, cpf, 
// salário que são passados em construtor e faltas que são iniciadas com 0, possui também os métodos GetBonificação,
// AumentarSalario, Faltou e GetFaltas

    public class Employee
    {
        private string Name { get; set; }
        private string CPF { get; set; }
        private float Salary { get; set; }
        private int Faltas { get; set; } = 0;

        public Employee(string Name, string CPF, float Salary){
            this.Name = Name;
            this.CPF = CPF;
            this.Salary = Salary;
        }

        public float GetBonificacao() => this.Salary;
        public void AumentarSalary(float value) => this.Salary += value;
        public void Falta() => this.Faltas += 1;
        public int GetFaltas() => this.Faltas;
    }
    
    // public class Calculadora
    // {
    //     public void Sum(float a, float b) => a + b;
    //     public void Sub(float a, float b) => a - b;
    //     public void Mult(float a, float b) => a * b;
    //     public void Div(float a, float b) => a / b;


    //     // public static float Exp(float a)
    //     // {
    //     //     float calc;
    //     //     for (int i = 0; i < a; i++)
    //     //         calc = this * this;
    //     //     return calc;
    //     // }
    // }
}