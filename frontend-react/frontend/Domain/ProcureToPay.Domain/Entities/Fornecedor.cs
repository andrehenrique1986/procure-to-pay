using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcureToPay.Domain.Entities
{
    public class Fornecedor
    {
        public int FornecedorId { get; private set; }
        public string FornecedorNome { get; private set; }
        public string? FornecedorNomeFantasia { get; private set; }
        public string FornecedorCpfCnpj {  get; private set; }  
    }
}
