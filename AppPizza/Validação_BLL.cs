using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaLib;

namespace AppPizza
{
    internal class Validação_BLL
    {
        public Propriedades propriedades = new Propriedades();

        public bool ValidateBll(string tex1, string tex2)
        {
            FuncionarioDB pizzaBD = new FuncionarioDB();

            try
            {
                if (tex1.Length > 0 && tex2.Length > 0)
                {
                    return true;
                }
                else
                    Erro.setErro("Campos devem ser Preenchidos");

            }
            catch (Exception e)
            {
                Erro.setErro(e.Message);
            }
            return false;
        }
        public bool ValidateBllCadastro()
        {
            if (propriedades.Nome.Length > 0 && propriedades.Registro.Length > 0 && propriedades.Funcao.Length > 0) return true;
            else Erro.setErro("Campos devem ser Preenchidos");

            return false;
        }
    }
}
