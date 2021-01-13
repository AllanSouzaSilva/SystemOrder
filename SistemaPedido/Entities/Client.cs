using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaPedido.Entities
{
    class Client
    {
        public string NameCli { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
       
        public Client() { }

        public Client(string nameCli, DateTime birthDate, string email)
        {
            NameCli = nameCli;
            BirthDate = birthDate;
            Email = email;
            
        }
        public override string ToString()
        {
            return "Client: "
                    + NameCli
                    +"Birth date"
                    +BirthDate
                    + " - "
                    + Email;

        }

    }
}
