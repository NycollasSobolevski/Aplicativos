
namespace Classes
{
    public class Animal
    {
        public string Habitat { get; set; }
        public int QtdPaws { get; set; }
        public string Food { get; set; }
        public float Size { get; set; }
    }

    public class Dog : Animal
    {
        public Dog(string color, int age, float furSize, string race)
        {
            this.Habitat = "Terrestre";
            this.QtdPaws = 4;
            this.Food = "Ração";
            this.Size = 50f;
            this.FurColor = color;
            this.Race = race;
            this.FurSize = furSize;
            this.Age = age;
        }
        public string FurColor { get; set; }
        public float FurSize { get; set; }
        public int Age { get; set; }
        public string Race { get; set; }
        public string Latir() => "Au";
        public void Andar(){}
    }

    public class Fish : Animal
    {
        public string  Scale { get; set; }
        public int Flippers { get; set; }
        public void Nadar(){}

    }

    public class Veiculos
    {
        public string Marca {get; set;}
        public string Modelo { get; set; }
        public int Passageiros { get; set; }
        public int QtdRodas { get; set; }
        public string Combustivel { get; set; }
    }

    public class Carro : Veiculos
    {
        public Carro(string Marca, string Modelo, int Passageiros, string Combustivel)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Passageiros = Passageiros;
            this.QtdRodas = 4;
            this.Combustivel = Combustivel;
        }
        public string Tipo { get; set; }
    }

    

};

namespace Empresa
{
    public class Pessoa
    {
        public string Name {get;set;}
        public float idade { get; set; }
    }

    public class Funcionario : Pessoa
    {
        public decimal Salario { get; set; }
        public void Aumento(decimal valorAumentar) => this.Salario = valorAumentar;
    }
    public class Gerente : Funcionario
    {
        public Gerente()
        {
            this.Salario = 5000;
        }
    }
    public class Programmer : Funcionario
    {
        public Programmer()
        {
            this.Salario = 2000;
        }
    }
    public class Diretor : Funcionario
    {
        public Diretor()
        {
            this.Salario = 10000;
        }
    }
    public class Estagiario : Funcionario
    {
        public Estagiario()
        {
            this.Salario = 1000;
        }
    }
}