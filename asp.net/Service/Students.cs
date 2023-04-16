
namespace TrybeApp.Services
{
    public class StudentService
    {
        // Método responsável pela validação
        protected bool ValidateNewStudent(string studentName)
        {
            if (studentName.Trim().Length == 0) { //Caso o nome de estudante venha vazio
              return false // Será considerado inválido
            }
            return true; // Caso contrário, retornaremos que é válido.
        }

        // Método que será chamado ao tentar criar uma nova pessoa estudante:
        public bool CreateStudent(Student studentToCreate)
        {
            // Validação de Estudante:
            if (ValidateNewStudent(studentToCreate.Name))
            {
                //Caso a validação dê certo, poderemos aqui conectar com a model para fazer a inserção no nosso banco.
            }
            else
            {
              // Caso contrário, podemos retornar que era inválido e não foi inserido no banco.
            }
        }
    }
}