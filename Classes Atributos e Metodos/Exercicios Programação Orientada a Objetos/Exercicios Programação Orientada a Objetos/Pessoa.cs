
namespace Exercicios_Programação_Orientada_a_Objetos {
    internal class Person{
        public string name = null;
        public int age= 0;
        public double wage = 0.00;

        public string Older(Person firstPerson, Person secondPerson) {
            if (firstPerson.age > secondPerson.age) {
                return ($"Pessoa mais velha: {firstPerson.name}");
            }
            else {
                return ($"Pessoa mais velha: {secondPerson.name}");
            }
        }
    }
}
