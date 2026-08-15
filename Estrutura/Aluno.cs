
namespace Estrutura
{
    internal struct Aluno
    {
        // membros da struct
        //Campos
        public string nome;
        public int cpf;
        public double altura;


        //Sobrecarga
        public Aluno(string nome, int cpf) : this()
        {
            this.nome = nome;
            this.cpf = cpf;
        }


        //Construtor
        public Aluno(string nome, int cpf, double altura)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.altura = altura;
        }


        //Metodos

        public double Idade(int idade)
        {
            return idade / 3.5;
        }

        


    }
}
