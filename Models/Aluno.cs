using System.Collections.Generic;

namespace mvc_entity.Models
{
  public partial class Aluno
  {
    #region "Propriedades"
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Matricula { get; set; }

    public string Notas { get; set; }

    #endregion
  }
}
